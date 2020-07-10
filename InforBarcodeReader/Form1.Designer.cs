namespace InforBarcodeReader
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.DebugBox = new MetroFramework.Controls.MetroTextBox();
            this.ReadBarcodeButtonM = new MetroFramework.Controls.MetroButton();
            this.SettingsButtonM = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(189, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Habilitar Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // DebugBox
            // 
            this.DebugBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugBox.CustomBackground = true;
            this.DebugBox.CustomForeColor = true;
            this.DebugBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DebugBox.Location = new System.Drawing.Point(23, 99);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(760, 328);
            this.DebugBox.TabIndex = 31;
            this.DebugBox.UseStyleColors = true;
            // 
            // ReadBarcodeButtonM
            // 
            this.ReadBarcodeButtonM.Location = new System.Drawing.Point(23, 74);
            this.ReadBarcodeButtonM.Name = "ReadBarcodeButtonM";
            this.ReadBarcodeButtonM.Size = new System.Drawing.Size(136, 20);
            this.ReadBarcodeButtonM.Style = MetroFramework.MetroColorStyle.Black;
            this.ReadBarcodeButtonM.TabIndex = 38;
            this.ReadBarcodeButtonM.Text = "Iniciar";
            this.ReadBarcodeButtonM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ReadBarcodeButtonM.Click += new System.EventHandler(this.ReadBarcodeButtonM_Click);
            // 
            // SettingsButtonM
            // 
            this.SettingsButtonM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButtonM.Location = new System.Drawing.Point(647, 73);
            this.SettingsButtonM.Name = "SettingsButtonM";
            this.SettingsButtonM.Size = new System.Drawing.Size(136, 20);
            this.SettingsButtonM.Style = MetroFramework.MetroColorStyle.Black;
            this.SettingsButtonM.TabIndex = 39;
            this.SettingsButtonM.Text = "Settings";
            this.SettingsButtonM.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SettingsButtonM.Click += new System.EventHandler(this.SettingsButtonM_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButtonM);
            this.Controls.Add(this.ReadBarcodeButtonM);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 250);
            this.Name = "Form1";
            this.Text = "InforBarcodeReader";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer countdownTimer;
        private MetroFramework.Controls.MetroTextBox DebugBox;
        private MetroFramework.Controls.MetroButton ReadBarcodeButtonM;
        private MetroFramework.Controls.MetroButton SettingsButtonM;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

