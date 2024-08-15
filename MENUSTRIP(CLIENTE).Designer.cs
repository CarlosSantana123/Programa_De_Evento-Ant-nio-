namespace Programa_De_Evento__Antônio_
{
    partial class MENUSTRIP_CLIENTE_
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.criarEventoNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarEventoNovoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEventoNovoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // criarEventoNovoToolStripMenuItem
            // 
            this.criarEventoNovoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarEventoNovoToolStripMenuItem1,
            this.consultarEventosToolStripMenuItem});
            this.criarEventoNovoToolStripMenuItem.Name = "criarEventoNovoToolStripMenuItem";
            this.criarEventoNovoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.criarEventoNovoToolStripMenuItem.Text = "Eventos";
            this.criarEventoNovoToolStripMenuItem.Click += new System.EventHandler(this.criarEventoNovoToolStripMenuItem_Click);
            // 
            // criarEventoNovoToolStripMenuItem1
            // 
            this.criarEventoNovoToolStripMenuItem1.Name = "criarEventoNovoToolStripMenuItem1";
            this.criarEventoNovoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.criarEventoNovoToolStripMenuItem1.Text = "Criar Evento Novo";
            this.criarEventoNovoToolStripMenuItem1.Click += new System.EventHandler(this.criarEventoNovoToolStripMenuItem1_Click);
            // 
            // consultarEventosToolStripMenuItem
            // 
            this.consultarEventosToolStripMenuItem.Name = "consultarEventosToolStripMenuItem";
            this.consultarEventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarEventosToolStripMenuItem.Text = "Consultar Eventos";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "-Nome do Programa-";
            // 
            // MENUSTRIP_CLIENTE_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(628, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MENUSTRIP_CLIENTE_";
            this.Text = "Menu Principal (C)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criarEventoNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarEventoNovoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}