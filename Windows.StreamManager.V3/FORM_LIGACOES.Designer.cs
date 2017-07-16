namespace Windows.StreamManager.V3
{
    partial class FORM_LIGACOES
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BUTTON_FECHAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_GUARDAR = new System.Windows.Forms.ToolStripMenuItem();
            this.LABEL_ENDERECO = new System.Windows.Forms.Label();
            this.LABEL_PORTA = new System.Windows.Forms.Label();
            this.LABEL_BD = new System.Windows.Forms.Label();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.LABEL_PASSWORD = new System.Windows.Forms.Label();
            this.TEXTBOX_ENDERECO = new System.Windows.Forms.TextBox();
            this.TEXTBOX_PORTA = new System.Windows.Forms.TextBox();
            this.TEXTBOX_BD = new System.Windows.Forms.TextBox();
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.TEXTBOX_PASSWORD = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_FECHAR,
            this.BUTTON_GUARDAR});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BUTTON_FECHAR
            // 
            this.BUTTON_FECHAR.Name = "BUTTON_FECHAR";
            this.BUTTON_FECHAR.Size = new System.Drawing.Size(54, 20);
            this.BUTTON_FECHAR.Text = "Fechar";
            this.BUTTON_FECHAR.Click += new System.EventHandler(this.BUTTON_FECHAR_Click);
            // 
            // BUTTON_GUARDAR
            // 
            this.BUTTON_GUARDAR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_GUARDAR.Name = "BUTTON_GUARDAR";
            this.BUTTON_GUARDAR.Size = new System.Drawing.Size(61, 20);
            this.BUTTON_GUARDAR.Text = "Guardar";
            this.BUTTON_GUARDAR.Click += new System.EventHandler(this.BUTTON_GUARDAR_Click);
            // 
            // LABEL_ENDERECO
            // 
            this.LABEL_ENDERECO.AutoSize = true;
            this.LABEL_ENDERECO.Location = new System.Drawing.Point(36, 36);
            this.LABEL_ENDERECO.Name = "LABEL_ENDERECO";
            this.LABEL_ENDERECO.Size = new System.Drawing.Size(56, 13);
            this.LABEL_ENDERECO.TabIndex = 1;
            this.LABEL_ENDERECO.Text = "Endereço:";
            // 
            // LABEL_PORTA
            // 
            this.LABEL_PORTA.AutoSize = true;
            this.LABEL_PORTA.Location = new System.Drawing.Point(57, 62);
            this.LABEL_PORTA.Name = "LABEL_PORTA";
            this.LABEL_PORTA.Size = new System.Drawing.Size(35, 13);
            this.LABEL_PORTA.TabIndex = 2;
            this.LABEL_PORTA.Text = "Porta:";
            // 
            // LABEL_BD
            // 
            this.LABEL_BD.AutoSize = true;
            this.LABEL_BD.Location = new System.Drawing.Point(9, 88);
            this.LABEL_BD.Name = "LABEL_BD";
            this.LABEL_BD.Size = new System.Drawing.Size(83, 13);
            this.LABEL_BD.TabIndex = 3;
            this.LABEL_BD.Text = "Base de Dados:";
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(34, 114);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(58, 13);
            this.LABEL_USERNAME.TabIndex = 4;
            this.LABEL_USERNAME.Text = "Username;";
            // 
            // LABEL_PASSWORD
            // 
            this.LABEL_PASSWORD.AutoSize = true;
            this.LABEL_PASSWORD.Location = new System.Drawing.Point(36, 140);
            this.LABEL_PASSWORD.Name = "LABEL_PASSWORD";
            this.LABEL_PASSWORD.Size = new System.Drawing.Size(56, 13);
            this.LABEL_PASSWORD.TabIndex = 5;
            this.LABEL_PASSWORD.Text = "Password:";
            // 
            // TEXTBOX_ENDERECO
            // 
            this.TEXTBOX_ENDERECO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_ENDERECO.Location = new System.Drawing.Point(98, 32);
            this.TEXTBOX_ENDERECO.Name = "TEXTBOX_ENDERECO";
            this.TEXTBOX_ENDERECO.Size = new System.Drawing.Size(168, 20);
            this.TEXTBOX_ENDERECO.TabIndex = 6;
            // 
            // TEXTBOX_PORTA
            // 
            this.TEXTBOX_PORTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PORTA.Location = new System.Drawing.Point(98, 58);
            this.TEXTBOX_PORTA.Name = "TEXTBOX_PORTA";
            this.TEXTBOX_PORTA.Size = new System.Drawing.Size(168, 20);
            this.TEXTBOX_PORTA.TabIndex = 7;
            // 
            // TEXTBOX_BD
            // 
            this.TEXTBOX_BD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_BD.Location = new System.Drawing.Point(98, 84);
            this.TEXTBOX_BD.Name = "TEXTBOX_BD";
            this.TEXTBOX_BD.Size = new System.Drawing.Size(168, 20);
            this.TEXTBOX_BD.TabIndex = 8;
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(98, 110);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(168, 20);
            this.TEXTBOX_USERNAME.TabIndex = 9;
            // 
            // TEXTBOX_PASSWORD
            // 
            this.TEXTBOX_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PASSWORD.Location = new System.Drawing.Point(98, 136);
            this.TEXTBOX_PASSWORD.Name = "TEXTBOX_PASSWORD";
            this.TEXTBOX_PASSWORD.Size = new System.Drawing.Size(168, 20);
            this.TEXTBOX_PASSWORD.TabIndex = 10;
            // 
            // FORM_LIGACOES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 166);
            this.Controls.Add(this.TEXTBOX_PASSWORD);
            this.Controls.Add(this.TEXTBOX_USERNAME);
            this.Controls.Add(this.TEXTBOX_BD);
            this.Controls.Add(this.TEXTBOX_PORTA);
            this.Controls.Add(this.TEXTBOX_ENDERECO);
            this.Controls.Add(this.LABEL_PASSWORD);
            this.Controls.Add(this.LABEL_USERNAME);
            this.Controls.Add(this.LABEL_BD);
            this.Controls.Add(this.LABEL_PORTA);
            this.Controls.Add(this.LABEL_ENDERECO);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_LIGACOES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stream Manager: Ligações";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_GUARDAR;
        private System.Windows.Forms.Label LABEL_ENDERECO;
        private System.Windows.Forms.Label LABEL_PORTA;
        private System.Windows.Forms.Label LABEL_BD;
        private System.Windows.Forms.Label LABEL_USERNAME;
        private System.Windows.Forms.Label LABEL_PASSWORD;
        private System.Windows.Forms.TextBox TEXTBOX_ENDERECO;
        private System.Windows.Forms.TextBox TEXTBOX_PORTA;
        private System.Windows.Forms.TextBox TEXTBOX_BD;
        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.TextBox TEXTBOX_PASSWORD;
    }
}