using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InforBarcodeReader
{

    public partial class SettingsApp : MetroFramework.Forms.MetroForm
    {
        UserSetting m_setting;
        int index;
        List<string> changeRowList = new List<string>();

        public SettingsApp()
        {
            InitializeComponent();
            listFiliais();
        }

        private void filialPathButtonM_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                string folder = diag.SelectedPath;
                filialPathTextBox.Text = folder;
            }
        }

        private void SaveSettingsButtonM_Click(object sender, EventArgs e)
        {
            #region //Checa se os campos estão vazios
            bool check = checkIfIsEmpty();
            if (check == true)
            {
                return;
            }
            #endregion
            try
            {
                Load_AppSettings();
                string settings = filialNameTextBox.Text + ";" + filialPathTextBox.Text;
                m_setting.BarcodeFiliaisSettings.Add(settings);
                m_setting.Save();
                createDirectory(filialPathTextBox.Text);
                this.Close();
                SettingsApp main = new SettingsApp();
                main.Show();
                listFiliais();
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = checkIfIsEmpty();
                if (check == true)
                {
                    return;
                }

                Load_AppSettings();
                string settings = filialNameTextBox.Text + ";" + filialPathTextBox.Text;
                m_setting.BarcodeFiliaisSettings[index] = settings;
                m_setting.Save();
                createDirectory(filialPathTextBox.Text);
                this.Close();
                SettingsApp main = new SettingsApp();
                main.Show();
                listFiliais();
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        private void FiliaisGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                index = FiliaisGridView.SelectedRows[0].Index;
                int columnIndex = 0;

                foreach (DataGridViewColumn column in FiliaisGridView.Columns)
                {
                    string readingRow = FiliaisGridView.Rows[index].Cells[columnIndex].Value.ToString();
                    changeRowList.Add(readingRow);
                    columnIndex++;
                }

                filialNameTextBox.Text = changeRowList[0];
                filialPathTextBox.Text = changeRowList[1];
                changeRowList.Clear();
                UpdateButton.Visible = true;
                UpdateButton.Text = "Atualizar " + filialNameTextBox.Text;
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        private void FiliaisGridView_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            try
            {
                if (e.ColumnIndex == FiliaisGridView.Columns["DeletarConfig"].Index && e.RowIndex >= 0) 
                {
                    if (MessageBox.Show("Deletar a Filial?", "Atenção!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        m_setting.BarcodeFiliaisSettings.RemoveAt(e.RowIndex);
                        m_setting.Save();
                        this.Close();
                        SettingsApp main = new SettingsApp();
                        main.Show();
                        listFiliais();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

        public bool checkIfIsEmpty()
        {
            if (String.IsNullOrEmpty(filialNameTextBox.Text))
            {
                MessageBox.Show("Insira 1-filial NOME para Continuar");
                return true;
            }
            else if (String.IsNullOrEmpty(filialPathTextBox.Text))
            {
                MessageBox.Show("Insira 1-Filial PASTA para Continuar");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void createDirectory(string filialPath)
        {
            #region //Carregando UserSetting
            UserSetting userSettingN = new UserSetting();
            try
            {
                userSettingN = UserSetting.Load();
                if (userSettingN == null)
                    userSettingN = new UserSetting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            #endregion

            string signPath = filialPath + "\\0 - Leitor";
            createDiretoryHelper(signPath);

            string watermarkPath = filialPath + "\\1 - Estampar";
            createDiretoryHelper(watermarkPath);

            string cantReadPath = filialPath + "\\Barcode Error";
            createDiretoryHelper(cantReadPath);
        }

        private void createDiretoryHelper(string path)
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

        public void listFiliais()
        {
            Load_AppSettings();
            try
            {
                foreach (string filial in m_setting.BarcodeFiliaisSettings)
                {
                    filial.Trim('"');

                    //pega Caminhos dentro do path e cria novos diretorios
                    char[] separator = { ';' };
                    String[] values = filial.Split(separator);
                    FiliaisGridView.Rows.Add(values[0], values[1]);
                }
            }
            catch(Exception ex)
            {
                ErrorLogging.ErrorLog(ex);
            }
        }

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
            }
        }
    }
}
