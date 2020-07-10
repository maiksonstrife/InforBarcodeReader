namespace InforBarcodeReader
{
    partial class SettingsApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsApp));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filialPathButtonM = new MetroFramework.Controls.MetroButton();
            this.filialNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filialPathTextBox = new System.Windows.Forms.TextBox();
            this.FiliaisGridView = new System.Windows.Forms.DataGridView();
            this.SaveSettingsButtonM = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.UpdateButton = new MetroFramework.Controls.MetroButton();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PastaFilial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletarConfig = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiliaisGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.filialPathButtonM);
            this.groupBox2.Controls.Add(this.filialNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.filialPathTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 94);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1- Filial";
            // 
            // filialPathButtonM
            // 
            this.filialPathButtonM.Location = new System.Drawing.Point(267, 61);
            this.filialPathButtonM.Name = "filialPathButtonM";
            this.filialPathButtonM.Size = new System.Drawing.Size(78, 20);
            this.filialPathButtonM.Style = MetroFramework.MetroColorStyle.Black;
            this.filialPathButtonM.TabIndex = 37;
            this.filialPathButtonM.Text = "Browse";
            this.filialPathButtonM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.filialPathButtonM.Click += new System.EventHandler(this.filialPathButtonM_Click);
            // 
            // filialNameTextBox
            // 
            this.filialNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.filialNameTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filialNameTextBox.Location = new System.Drawing.Point(53, 28);
            this.filialNameTextBox.Name = "filialNameTextBox";
            this.filialNameTextBox.Size = new System.Drawing.Size(208, 20);
            this.filialNameTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // filialPathTextBox
            // 
            this.filialPathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.filialPathTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filialPathTextBox.Location = new System.Drawing.Point(53, 61);
            this.filialPathTextBox.Name = "filialPathTextBox";
            this.filialPathTextBox.Size = new System.Drawing.Size(208, 20);
            this.filialPathTextBox.TabIndex = 17;
            // 
            // FiliaisGridView
            // 
            this.FiliaisGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.FiliaisGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FiliaisGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FiliaisGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FiliaisGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FiliaisGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FiliaisGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FiliaisGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filial,
            this.PastaFilial,
            this.DeletarConfig});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FiliaisGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FiliaisGridView.EnableHeadersVisualStyles = false;
            this.FiliaisGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FiliaisGridView.Location = new System.Drawing.Point(12, 212);
            this.FiliaisGridView.Name = "FiliaisGridView";
            this.FiliaisGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FiliaisGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FiliaisGridView.Size = new System.Drawing.Size(772, 200);
            this.FiliaisGridView.TabIndex = 35;
            this.FiliaisGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FiliaisGridView_CellClick);
            this.FiliaisGridView.DoubleClick += new System.EventHandler(this.FiliaisGridView_DoubleClick);
            // 
            // SaveSettingsButtonM
            // 
            this.SaveSettingsButtonM.Location = new System.Drawing.Point(706, 418);
            this.SaveSettingsButtonM.Name = "SaveSettingsButtonM";
            this.SaveSettingsButtonM.Size = new System.Drawing.Size(78, 20);
            this.SaveSettingsButtonM.TabIndex = 39;
            this.SaveSettingsButtonM.Text = "Salvar";
            this.SaveSettingsButtonM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SaveSettingsButtonM.Click += new System.EventHandler(this.SaveSettingsButtonM_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(12, 184);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "Filiais Salvas";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 418);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(116, 20);
            this.UpdateButton.TabIndex = 42;
            this.UpdateButton.Text = "Atualizar";
            this.UpdateButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Filial
            // 
            this.Filial.Frozen = true;
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            this.Filial.Width = 150;
            // 
            // PastaFilial
            // 
            this.PastaFilial.Frozen = true;
            this.PastaFilial.HeaderText = "PastaFilial";
            this.PastaFilial.MinimumWidth = 40;
            this.PastaFilial.Name = "PastaFilial";
            this.PastaFilial.ReadOnly = true;
            this.PastaFilial.Width = 530;
            // 
            // DeletarConfig
            // 
            this.DeletarConfig.HeaderText = "Deletar";
            this.DeletarConfig.Name = "DeletarConfig";
            this.DeletarConfig.Text = "Delete";
            this.DeletarConfig.UseColumnTextForButtonValue = true;
            this.DeletarConfig.Width = 50;
            // 
            // SettingsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SaveSettingsButtonM);
            this.Controls.Add(this.FiliaisGridView);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsApp";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FiliaisGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox filialNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filialPathTextBox;
        private System.Windows.Forms.DataGridView FiliaisGridView;
        private MetroFramework.Controls.MetroButton filialPathButtonM;
        private MetroFramework.Controls.MetroButton SaveSettingsButtonM;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton UpdateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filial;
        private System.Windows.Forms.DataGridViewTextBoxColumn PastaFilial;
        private System.Windows.Forms.DataGridViewButtonColumn DeletarConfig;
    }
}