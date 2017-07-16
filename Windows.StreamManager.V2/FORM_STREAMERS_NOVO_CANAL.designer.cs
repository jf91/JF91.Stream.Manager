namespace Windows.StreamManager
{
    partial class FORM_STREAMERS_NOVO_CANAL
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
            this.TEXTBOX_URL_RMTP = new System.Windows.Forms.TextBox();
            this.LABEL_URL_RMTP = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.TREEVIEW_STREAMERS = new System.Windows.Forms.TreeView();
            this.TEXTBOX_CASTER_RMTP = new System.Windows.Forms.TextBox();
            this.LABEL_CASTER_RMTP = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
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
            this.BUTTON_GUARDAR.Enabled = false;
            this.BUTTON_GUARDAR.Name = "BUTTON_GUARDAR";
            this.BUTTON_GUARDAR.Size = new System.Drawing.Size(61, 20);
            this.BUTTON_GUARDAR.Text = "Guardar";
            this.BUTTON_GUARDAR.Click += new System.EventHandler(this.BUTTON_GUARDAR_Click);
            // 
            // TEXTBOX_URL_RMTP
            // 
            this.TEXTBOX_URL_RMTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_URL_RMTP.Location = new System.Drawing.Point(148, 96);
            this.TEXTBOX_URL_RMTP.Name = "TEXTBOX_URL_RMTP";
            this.TEXTBOX_URL_RMTP.Size = new System.Drawing.Size(140, 13);
            this.TEXTBOX_URL_RMTP.TabIndex = 13;
            this.TEXTBOX_URL_RMTP.TextChanged += new System.EventHandler(this.TEXTBOX_URL_RMTP_TextChanged);
            // 
            // LABEL_URL_RMTP
            // 
            this.LABEL_URL_RMTP.AutoSize = true;
            this.LABEL_URL_RMTP.Location = new System.Drawing.Point(145, 80);
            this.LABEL_URL_RMTP.Name = "LABEL_URL_RMTP";
            this.LABEL_URL_RMTP.Size = new System.Drawing.Size(78, 13);
            this.LABEL_URL_RMTP.TabIndex = 12;
            this.LABEL_URL_RMTP.Text = "URL de RMTP";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(148, 52);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(140, 13);
            this.TEXTBOX_NOME.TabIndex = 15;
            this.TEXTBOX_NOME.TextChanged += new System.EventHandler(this.TEXTBOX_NOME_TextChanged);
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(145, 36);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 14;
            this.LABEL_NOME.Text = "Nome";
            // 
            // TREEVIEW_STREAMERS
            // 
            this.TREEVIEW_STREAMERS.FullRowSelect = true;
            this.TREEVIEW_STREAMERS.HideSelection = false;
            this.TREEVIEW_STREAMERS.Location = new System.Drawing.Point(12, 27);
            this.TREEVIEW_STREAMERS.Name = "TREEVIEW_STREAMERS";
            this.TREEVIEW_STREAMERS.Size = new System.Drawing.Size(127, 151);
            this.TREEVIEW_STREAMERS.TabIndex = 16;
            // 
            // TEXTBOX_CASTER_RMTP
            // 
            this.TEXTBOX_CASTER_RMTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_CASTER_RMTP.Location = new System.Drawing.Point(148, 141);
            this.TEXTBOX_CASTER_RMTP.Name = "TEXTBOX_CASTER_RMTP";
            this.TEXTBOX_CASTER_RMTP.Size = new System.Drawing.Size(140, 13);
            this.TEXTBOX_CASTER_RMTP.TabIndex = 18;
            // 
            // LABEL_CASTER_RMTP
            // 
            this.LABEL_CASTER_RMTP.AutoSize = true;
            this.LABEL_CASTER_RMTP.Location = new System.Drawing.Point(145, 125);
            this.LABEL_CASTER_RMTP.Name = "LABEL_CASTER_RMTP";
            this.LABEL_CASTER_RMTP.Size = new System.Drawing.Size(71, 13);
            this.LABEL_CASTER_RMTP.TabIndex = 17;
            this.LABEL_CASTER_RMTP.Text = "Caster RMTP";
            // 
            // FORM_STREAMERS_NOVO_CANAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 190);
            this.Controls.Add(this.TEXTBOX_CASTER_RMTP);
            this.Controls.Add(this.LABEL_CASTER_RMTP);
            this.Controls.Add(this.TREEVIEW_STREAMERS);
            this.Controls.Add(this.TEXTBOX_NOME);
            this.Controls.Add(this.LABEL_NOME);
            this.Controls.Add(this.TEXTBOX_URL_RMTP);
            this.Controls.Add(this.LABEL_URL_RMTP);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_STREAMERS_NOVO_CANAL";
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
        private System.Windows.Forms.ToolStripMenuItem BUTTON_GUARDAR;
        private System.Windows.Forms.TextBox TEXTBOX_URL_RMTP;
        private System.Windows.Forms.Label LABEL_URL_RMTP;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.TreeView TREEVIEW_STREAMERS;
        private System.Windows.Forms.TextBox TEXTBOX_CASTER_RMTP;
        private System.Windows.Forms.Label LABEL_CASTER_RMTP;
    }
}