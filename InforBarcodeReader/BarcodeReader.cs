using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ZXing;
using ImageMagick;
using System.Drawing;

namespace InforBarcodeReader
{
    class BarcodeReader
    {
        UserSetting m_setting;
        string fname = "";
        string m_code;
        BarcodeFormat m_found_format;
        bool barcode_found;

        public void readBarcode(string filePath, string saidaPath, string errorPath, int barcodePage)
        {
            Load_AppSettings();
            try
            {
                fname = filePath.Substring(filePath.LastIndexOf('\\') + 1);

                //MagickRead converte pdf em jpg
                MagickReadSettings settings = new MagickReadSettings()
                {
                    Density = new Density(300, 300) //dpi do jpeg que será salvo
                };
                MagickImageCollection magick = new MagickImageCollection();

                magick.Read(filePath, settings);
                magick[barcodePage].Write("temp.jpg");    //salva pagina com barcode na pasta temporaria

                Bitmap page_img = new Bitmap(FromFile("temp.jpg")); //salva jpg na variavel page_img

                Wait_for(40); //Pede pro windows dar uma leve pausa, caso pc esteja lento, isso ajuda

                barcode_found = false;

                if (TryReadCode(page_img, 0) == true) //Método que lê o barcode, mando jpg pra ele ler
                {
                    try
                    {

                        //MAIK NOTE: Renomeia e move arquivo
                        string novoNome = "//" + m_code + ".pdf";
                        novoNome = StringFormater.RemoverCaracteresEspeciais(novoNome);
                        string destFile = System.IO.Path.Combine(saidaPath, novoNome);
                        System.IO.File.Copy(filePath, destFile, true);
                    }
                    catch (Exception ex)
                    {
                        ErrorLogging.ErrorLog(ex);
                        return;
                    }

                    Wait_for(40);
                }
                else //E se não detectar barcode
                {
                    try
                    {
                        String date = (DateTime.Now.ToString("yyyy-MM-dd:HH:mm:ss"));

                        Wait_for(40);
                        string novoNome = "Nao_Detectado_Barcode_" + date.Replace(":", "_") + ".pdf";
                        string destFile = errorPath + "\\" + novoNome;
                        System.IO.File.Copy(filePath, destFile, true);

                        barcode_found = false;
                        Wait_for(40);
                    }
                    catch (Exception ex)
                    {
                        ErrorLogging.ErrorLog(ex);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        //método contador para fazer o app pausar
        public void Wait_for(int milisec)
        {
            DateTime tm = DateTime.Now;
            while (DateTime.Now.Subtract(tm).Milliseconds < milisec)
            {
                Application.DoEvents();
            }
        }

        //Método de leitura de Barcode
        private bool TryReadCode(Bitmap img, int depth)
        {

            if (barcode_found)
                return true;

            List<BarcodeFormat> codeformats = new List<BarcodeFormat>();
            codeformats.Add(BarcodeFormat.QR_CODE);
            codeformats.Add(BarcodeFormat.CODE_128);

            //Parametros de configuração da API ZXing
            ZXing.BarcodeReader reader = new ZXing.BarcodeReader
            {
                AutoRotate = true,
                TryInverted = true,


                Options = {
                PossibleFormats = codeformats,
                TryHarder = true,
                ReturnCodabarStartEnd = true,
                PureBarcode = false,
                }
            };
            Result res = reader.Decode(img);

            if (res != null)
            {
                barcode_found = true;
                m_code = res.Text;
                m_found_format = res.BarcodeFormat;
                return true;
            }

            return false;
        }

        //Método de carregar configuração
        public void Load_AppSettings()
        {
            try
            {
                m_setting = UserSetting.Load();
                if (m_setting == null)
                    m_setting = new UserSetting();
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
                return;
            }
        }

        //Método que lê arquivo e retorna na variavel img
        public static System.Drawing.Image FromFile(string path)
        {
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            var img = System.Drawing.Image.FromStream(ms);
            return img;
        }
    }
}
