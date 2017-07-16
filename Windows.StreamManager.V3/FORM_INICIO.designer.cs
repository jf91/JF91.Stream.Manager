namespace Windows.StreamManager
{
    partial class FORM_INICIO
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
            this.BUTTON_CANAIS = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_STREAMERS = new System.Windows.Forms.ToolStripMenuItem();
            this.SPLICONTAINER_INICIO = new System.Windows.Forms.SplitContainer();
            this.COMBOBOX_CANAIS = new System.Windows.Forms.ComboBox();
            this.LABEL_LIGAR_EM = new System.Windows.Forms.Label();
            this.BUTTON_LIGAR = new System.Windows.Forms.Button();
            this.TREEVIEW_STREAMERS = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPLICONTAINER_INICIO)).BeginInit();
            this.SPLICONTAINER_INICIO.Panel1.SuspendLayout();
            this.SPLICONTAINER_INICIO.Panel2.SuspendLayout();
            this.SPLICONTAINER_INICIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_FECHAR,
            this.BUTTON_CANAIS,
            this.BUTTON_STREAMERS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(274, 24);
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
            // BUTTON_CANAIS
            // 
            this.BUTTON_CANAIS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_CANAIS.Name = "BUTTON_CANAIS";
            this.BUTTON_CANAIS.Size = new System.Drawing.Size(54, 20);
            this.BUTTON_CANAIS.Text = "Canais";
            this.BUTTON_CANAIS.Click += new System.EventHandler(this.BUTTON_CANAIS_Click);
            // 
            // BUTTON_STREAMERS
            // 
            this.BUTTON_STREAMERS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_STREAMERS.Name = "BUTTON_STREAMERS";
            this.BUTTON_STREAMERS.Size = new System.Drawing.Size(71, 20);
            this.BUTTON_STREAMERS.Text = "Streamers";
            this.BUTTON_STREAMERS.Click += new System.EventHandler(this.BUTTON_STREAMERS_Click);
            // 
            // SPLICONTAINER_INICIO
            // 
            this.SPLICONTAINER_INICIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPLICONTAINER_INICIO.Location = new System.Drawing.Point(0, 24);
            this.SPLICONTAINER_INICIO.Name = "SPLICONTAINER_INICIO";
            this.SPLICONTAINER_INICIO.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SPLICONTAINER_INICIO.Panel1
            // 
            this.SPLICONTAINER_INICIO.Panel1.Controls.Add(this.COMBOBOX_CANAIS);
            this.SPLICONTAINER_INICIO.Panel1.Controls.Add(this.LABEL_LIGAR_EM);
            this.SPLICONTAINER_INICIO.Panel1.Controls.Add(this.BUTTON_LIGAR);
            // 
            // SPLICONTAINER_INICIO.Panel2
            // 
            this.SPLICONTAINER_INICIO.Panel2.Controls.Add(this.TREEVIEW_STREAMERS);
            this.SPLICONTAINER_INICIO.Size = new System.Drawing.Size(274, 327);
            this.SPLICONTAINER_INICIO.SplitterDistance = 39;
            this.SPLICONTAINER_INICIO.TabIndex = 1;
            // 
            // COMBOBOX_CANAIS
            // 
            this.COMBOBOX_CANAIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBOBOX_CANAIS.FormattingEnabled = true;
            this.COMBOBOX_CANAIS.Location = new System.Drawing.Point(72, 9);
            this.COMBOBOX_CANAIS.Name = "COMBOBOX_CANAIS";
            this.COMBOBOX_CANAIS.Size = new System.Drawing.Size(122, 21);
            this.COMBOBOX_CANAIS.TabIndex = 2;
            // 
            // LABEL_LIGAR_EM
            // 
            this.LABEL_LIGAR_EM.AutoSize = true;
            this.LABEL_LIGAR_EM.Location = new System.Drawing.Point(8, 13);
            this.LABEL_LIGAR_EM.Name = "LABEL_LIGAR_EM";
            this.LABEL_LIGAR_EM.Size = new System.Drawing.Size(61, 13);
            this.LABEL_LIGAR_EM.TabIndex = 1;
            this.LABEL_LIGAR_EM.Text = "LIGAR EM:";
            // 
            // BUTTON_LIGAR
            // 
            this.BUTTON_LIGAR.Location = new System.Drawing.Point(203, 8);
            this.BUTTON_LIGAR.Name = "BUTTON_LIGAR";
            this.BUTTON_LIGAR.Size = new System.Drawing.Size(60, 23);
            this.BUTTON_LIGAR.TabIndex = 0;
            this.BUTTON_LIGAR.Text = "Ligar";
            this.BUTTON_LIGAR.UseVisualStyleBackColor = true;
            this.BUTTON_LIGAR.Click += new System.EventHandler(this.BUTTON_LIGAR_Click);
            // 
            // TREEVIEW_STREAMERS
            // 
            this.TREEVIEW_STREAMERS.BackColor = System.Drawing.SystemColors.Control;
            this.TREEVIEW_STREAMERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TREEVIEW_STREAMERS.HideSelection = false;
            this.TREEVIEW_STREAMERS.Location = new System.Drawing.Point(0, 0);
            this.TREEVIEW_STREAMERS.Name = "TREEVIEW_STREAMERS";
            this.TREEVIEW_STREAMERS.Size = new System.Drawing.Size(274, 284);
            this.TREEVIEW_STREAMERS.TabIndex = 0;
            // 
            // FORM_INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 351);
            this.Controls.Add(this.SPLICONTAINER_INICIO);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FORM_INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_INICIO_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SPLICONTAINER_INICIO.Panel1.ResumeLayout(false);
            this.SPLICONTAINER_INICIO.Panel1.PerformLayout();
            this.SPLICONTAINER_INICIO.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPLICONTAINER_INICIO)).EndInit();
            this.SPLICONTAINER_INICIO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_CANAIS;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_STREAMERS;
        private System.Windows.Forms.SplitContainer SPLICONTAINER_INICIO;
        private System.Windows.Forms.ComboBox COMBOBOX_CANAIS;
        private System.Windows.Forms.Label LABEL_LIGAR_EM;
        private System.Windows.Forms.Button BUTTON_LIGAR;
        private System.Windows.Forms.TreeView TREEVIEW_STREAMERS;
    }
}

