namespace Windows.StreamManager
{
    partial class FORM_CANAIS_CRIAR
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
            this.BUTTON_CRIAR = new System.Windows.Forms.ToolStripMenuItem();
            this.TEXTBOX_FLASH_ID = new System.Windows.Forms.TextBox();
            this.LABEL_FLASH_ID = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_FECHAR,
            this.BUTTON_CRIAR});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(208, 24);
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
            // BUTTON_CRIAR
            // 
            this.BUTTON_CRIAR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_CRIAR.Name = "BUTTON_CRIAR";
            this.BUTTON_CRIAR.Size = new System.Drawing.Size(44, 20);
            this.BUTTON_CRIAR.Text = "Criar";
            this.BUTTON_CRIAR.Click += new System.EventHandler(this.BUTTON_CRIAR_Click);
            // 
            // TEXTBOX_FLASH_ID
            // 
            this.TEXTBOX_FLASH_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_FLASH_ID.Location = new System.Drawing.Point(24, 94);
            this.TEXTBOX_FLASH_ID.Name = "TEXTBOX_FLASH_ID";
            this.TEXTBOX_FLASH_ID.Size = new System.Drawing.Size(163, 13);
            this.TEXTBOX_FLASH_ID.TabIndex = 9;
            // 
            // LABEL_FLASH_ID
            // 
            this.LABEL_FLASH_ID.AutoSize = true;
            this.LABEL_FLASH_ID.Location = new System.Drawing.Point(12, 78);
            this.LABEL_FLASH_ID.Name = "LABEL_FLASH_ID";
            this.LABEL_FLASH_ID.Size = new System.Drawing.Size(46, 13);
            this.LABEL_FLASH_ID.TabIndex = 8;
            this.LABEL_FLASH_ID.Text = "Flash ID";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(24, 51);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(163, 13);
            this.TEXTBOX_NOME.TabIndex = 7;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(12, 35);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 6;
            this.LABEL_NOME.Text = "Nome";
            // 
            // FORM_CANAIS_CRIAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 127);
            this.Controls.Add(this.TEXTBOX_FLASH_ID);
            this.Controls.Add(this.LABEL_FLASH_ID);
            this.Controls.Add(this.TEXTBOX_NOME);
            this.Controls.Add(this.LABEL_NOME);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_CANAIS_CRIAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stream Manager: Novo Canal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_CRIAR;
        private System.Windows.Forms.TextBox TEXTBOX_FLASH_ID;
        private System.Windows.Forms.Label LABEL_FLASH_ID;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
    }
}