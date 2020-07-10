using System;
using System.IO;
using System.Windows.Forms;

namespace InforBarcodeReader
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        private void mainFunctionBarcode()
        {
            #region //Carregando UserSetting
            UserSetting userSetting = new UserSetting();
            try
            {
                userSetting = UserSetting.Load();
                if (userSetting == null)
                    userSetting = new UserSetting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            #endregion

            try
            {
                foreach (string filial in userSetting.BarcodeFiliaisSettings)
                {
                    filial.Trim('"');
                    char[] separator = { ';' };
                    String[] values = filial.Split(separator);
                    string filialName = values[0];
                    string path = values[1];

                    string signPath = path + "\\0 - Leitor";
                    createDiretory(signPath);

                    string watermarkPath = path + "\\1 - Estampar";
                    createDiretory(watermarkPath);

                    string cantReadPath = path + "\\Barcode Error";
                    createDiretory(cantReadPath);

                    debug($"Iniciado ... {filialName}");
                    debug("Checando Arquivos ...");

                    string[] barcodeFiles = Directory.GetFiles(signPath);

                    int index = 0;
                    foreach (string file in barcodeFiles)
                    {
                        string filename = Path.GetFileName(file);
                        BarcodeReader reader = new BarcodeReader();
                        reader.readBarcode(file, watermarkPath, cantReadPath, 0);
                        File.Delete(file);
                        index++;
                        debug($"Aquivo...{index} Lido");
                    }
                    debug("Filial Terminada");
                }

                if (checkBox1.Checked)
                {
                    System.Threading.Thread.Sleep(4000);
                    timeLeft = 15;
                }
            }
            catch(Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        public void createDiretory(string path)
        {
            try
            {
                if (Directory.Exists(path) == false)
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch(Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }

        }

        private void debug(string txt)
        {
            DebugBox.AppendText(txt + System.Environment.NewLine);
        }

        private void debugSameLine(string txt)
        {
            DebugBox.ResetText();
            DebugBox.AppendText(txt+ " ");
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                debugSameLine( $"{timeLeft}");
            }
            else
            {
                mainFunctionBarcode();
            }
        }

        private void ReadBarcodeButtonM_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                debug("Timer Habilitado, próximo scan em 15 segundos...");
                timeLeft = 15;
                countdownTimer.Start();
            }
            else
            {
                mainFunctionBarcode();
            }
        }

        private void SettingsButtonM_Click(object sender, EventArgs e)
        {
            SettingsApp configform = new SettingsApp();
            configform.ShowDialog();
        }
    }
}
