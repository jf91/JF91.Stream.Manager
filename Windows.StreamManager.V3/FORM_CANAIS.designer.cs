namespace Windows.StreamManager
{
    partial class FORM_CANAIS
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
            this.BUTTON_APAGAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_GUARDAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_CRIAR_NOVO = new System.Windows.Forms.ToolStripMenuItem();
            this.LISTVIEW_CHANNELS = new System.Windows.Forms.ListView();
            this.HEADER_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HEADER_FLASHID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LABEL_NOME = new System.Windows.Forms.Label();
            this.TEXTBOX_NOME = new System.Windows.Forms.TextBox();
            this.TEXTBOX_FLASH_ID = new System.Windows.Forms.TextBox();
            this.LABEL_FLASH_ID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_FECHAR,
            this.BUTTON_APAGAR,
            this.BUTTON_GUARDAR,
            this.BUTTON_CRIAR_NOVO});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
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
            // BUTTON_APAGAR
            // 
            this.BUTTON_APAGAR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_APAGAR.Enabled = false;
            this.BUTTON_APAGAR.Name = "BUTTON_APAGAR";
            this.BUTTON_APAGAR.Size = new System.Drawing.Size(57, 20);
            this.BUTTON_APAGAR.Text = "Apagar";
            this.BUTTON_APAGAR.Click += new System.EventHandler(this.BUTTON_APAGAR_Click);
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
            // BUTTON_CRIAR_NOVO
            // 
            this.BUTTON_CRIAR_NOVO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_CRIAR_NOVO.Name = "BUTTON_CRIAR_NOVO";
            this.BUTTON_CRIAR_NOVO.Size = new System.Drawing.Size(76, 20);
            this.BUTTON_CRIAR_NOVO.Text = "Criar Novo";
            this.BUTTON_CRIAR_NOVO.Click += new System.EventHandler(this.BUTTON_CRIAR_NOVO_Click);
            // 
            // LISTVIEW_CHANNELS
            // 
            this.LISTVIEW_CHANNELS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HEADER_NOME,
            this.HEADER_FLASHID});
            this.LISTVIEW_CHANNELS.FullRowSelect = true;
            this.LISTVIEW_CHANNELS.HideSelection = false;
            this.LISTVIEW_CHANNELS.Location = new System.Drawing.Point(12, 37);
            this.LISTVIEW_CHANNELS.Name = "LISTVIEW_CHANNELS";
            this.LISTVIEW_CHANNELS.Size = new System.Drawing.Size(164, 185);
            this.LISTVIEW_CHANNELS.TabIndex = 1;
            this.LISTVIEW_CHANNELS.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_CHANNELS.View = System.Windows.Forms.View.Details;
            this.LISTVIEW_CHANNELS.SelectedIndexChanged += new System.EventHandler(this.LISTVIEW_CHANNELS_SelectedIndexChanged);
            // 
            // HEADER_NOME
            // 
            this.HEADER_NOME.Text = "Nome";
            this.HEADER_NOME.Width = 80;
            // 
            // HEADER_FLASHID
            // 
            this.HEADER_FLASHID.Text = "Flash ID";
            this.HEADER_FLASHID.Width = 80;
            // 
            // LABEL_NOME
            // 
            this.LABEL_NOME.AutoSize = true;
            this.LABEL_NOME.Location = new System.Drawing.Point(182, 37);
            this.LABEL_NOME.Name = "LABEL_NOME";
            this.LABEL_NOME.Size = new System.Drawing.Size(35, 13);
            this.LABEL_NOME.TabIndex = 2;
            this.LABEL_NOME.Text = "Nome";
            // 
            // TEXTBOX_NOME
            // 
            this.TEXTBOX_NOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_NOME.Location = new System.Drawing.Point(194, 53);
            this.TEXTBOX_NOME.Name = "TEXTBOX_NOME";
            this.TEXTBOX_NOME.Size = new System.Drawing.Size(163, 13);
            this.TEXTBOX_NOME.TabIndex = 3;
            this.TEXTBOX_NOME.TextChanged += new System.EventHandler(this.TEXTBOX_NOME_TextChanged);
            // 
            // TEXTBOX_FLASH_ID
            // 
            this.TEXTBOX_FLASH_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_FLASH_ID.Location = new System.Drawing.Point(194, 96);
            this.TEXTBOX_FLASH_ID.Name = "TEXTBOX_FLASH_ID";
            this.TEXTBOX_FLASH_ID.Size = new System.Drawing.Size(163, 13);
            this.TEXTBOX_FLASH_ID.TabIndex = 5;
            this.TEXTBOX_FLASH_ID.TextChanged += new System.EventHandler(this.TEXTBOX_FLASH_ID_TextChanged);
            // 
            // LABEL_FLASH_ID
            // 
            this.LABEL_FLASH_ID.AutoSize = true;
            this.LABEL_FLASH_ID.Location = new System.Drawing.Point(182, 80);
            this.LABEL_FLASH_ID.Name = "LABEL_FLASH_ID";
            this.LABEL_FLASH_ID.Size = new System.Drawing.Size(46, 13);
            this.LABEL_FLASH_ID.TabIndex = 4;
            this.LABEL_FLASH_ID.Text = "Flash ID";
            // 
            // FORM_CANAIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 233);
            this.Controls.Add(this.TEXTBOX_FLASH_ID);
            this.Controls.Add(this.LABEL_FLASH_ID);
            this.Controls.Add(this.TEXTBOX_NOME);
            this.Controls.Add(this.LABEL_NOME);
            this.Controls.Add(this.LISTVIEW_CHANNELS);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_CANAIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stream Manager: Canais";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_APAGAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_GUARDAR;
        private System.Windows.Forms.ListView LISTVIEW_CHANNELS;
        private System.Windows.Forms.ColumnHeader HEADER_NOME;
        private System.Windows.Forms.ColumnHeader HEADER_FLASHID;
        private System.Windows.Forms.Label LABEL_NOME;
        private System.Windows.Forms.TextBox TEXTBOX_NOME;
        private System.Windows.Forms.TextBox TEXTBOX_FLASH_ID;
        private System.Windows.Forms.Label LABEL_FLASH_ID;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_CRIAR_NOVO;
    }
}