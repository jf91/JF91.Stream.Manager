namespace Windows.StreamManager
{
    partial class FORM_LOGIN
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
            this.COMBOBOX_PROJECTOS = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BUTTON_FECHAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_GERIR_PROJECTOS = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_ENTRAR = new System.Windows.Forms.Button();
            this.BUTTON_LIGACOES = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMBOBOX_PROJECTOS
            // 
            this.COMBOBOX_PROJECTOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOBOX_PROJECTOS.FormattingEnabled = true;
            this.COMBOBOX_PROJECTOS.Location = new System.Drawing.Point(12, 39);
            this.COMBOBOX_PROJECTOS.Name = "COMBOBOX_PROJECTOS";
            this.COMBOBOX_PROJECTOS.Size = new System.Drawing.Size(246, 21);
            this.COMBOBOX_PROJECTOS.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_FECHAR,
            this.BUTTON_LIGACOES,
            this.BUTTON_GERIR_PROJECTOS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BUTTON_FECHAR
            // 
            this.BUTTON_FECHAR.Name = "BUTTON_FECHAR";
            this.BUTTON_FECHAR.Size = new System.Drawing.Size(54, 20);
            this.BUTTON_FECHAR.Text = "Fechar";
            this.BUTTON_FECHAR.Click += new System.EventHandler(this.BUTTON_FECHAR_Click);
            // 
            // BUTTON_GERIR_PROJECTOS
            // 
            this.BUTTON_GERIR_PROJECTOS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_GERIR_PROJECTOS.Name = "BUTTON_GERIR_PROJECTOS";
            this.BUTTON_GERIR_PROJECTOS.Size = new System.Drawing.Size(96, 20);
            this.BUTTON_GERIR_PROJECTOS.Text = "Gerir Projectos";
            this.BUTTON_GERIR_PROJECTOS.Click += new System.EventHandler(this.BUTTON_GERIR_PROJECTOS_Click);
            // 
            // BUTTON_ENTRAR
            // 
            this.BUTTON_ENTRAR.Location = new System.Drawing.Point(12, 66);
            this.BUTTON_ENTRAR.Name = "BUTTON_ENTRAR";
            this.BUTTON_ENTRAR.Size = new System.Drawing.Size(246, 23);
            this.BUTTON_ENTRAR.TabIndex = 3;
            this.BUTTON_ENTRAR.Text = "Entrar";
            this.BUTTON_ENTRAR.UseVisualStyleBackColor = true;
            this.BUTTON_ENTRAR.Click += new System.EventHandler(this.BUTTON_ENTRAR_Click);
            // 
            // BUTTON_LIGACOES
            // 
            this.BUTTON_LIGACOES.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_LIGACOES.Name = "BUTTON_LIGACOES";
            this.BUTTON_LIGACOES.Size = new System.Drawing.Size(65, 20);
            this.BUTTON_LIGACOES.Text = "Ligações";
            this.BUTTON_LIGACOES.Click += new System.EventHandler(this.BUTTON_LIGACOES_Click);
            // 
            // FORM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 108);
            this.Controls.Add(this.BUTTON_ENTRAR);
            this.Controls.Add(this.COMBOBOX_PROJECTOS);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream Manager Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_LOGIN_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COMBOBOX_PROJECTOS;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_GERIR_PROJECTOS;
        private System.Windows.Forms.Button BUTTON_ENTRAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_LIGACOES;
    }
}