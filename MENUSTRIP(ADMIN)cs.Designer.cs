﻿namespace Programa_De_Evento__Antônio_
{
    partial class MENUSTRIP_ADMIN_
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaInicio_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "-Nome Do Programa-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarEventosToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // gerenciarEventosToolStripMenuItem
            // 
            this.gerenciarEventosToolStripMenuItem.Name = "gerenciarEventosToolStripMenuItem";
            this.gerenciarEventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerenciarEventosToolStripMenuItem.Text = "Gerenciar Eventos";
            this.gerenciarEventosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEventosToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.clientesUsuáriosToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ajudaToolStripMenuItem.Text = "Cadastros";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // clientesUsuáriosToolStripMenuItem
            // 
            this.clientesUsuáriosToolStripMenuItem.Name = "clientesUsuáriosToolStripMenuItem";
            this.clientesUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesUsuáriosToolStripMenuItem.Text = "Clientes/Usuários";
            this.clientesUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.clientesUsuáriosToolStripMenuItem_Click);
            // 
            // TelaInicio_button
            // 
            this.TelaInicio_button.BackColor = System.Drawing.Color.Tan;
            this.TelaInicio_button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelaInicio_button.ForeColor = System.Drawing.Color.Transparent;
            this.TelaInicio_button.Location = new System.Drawing.Point(249, 346);
            this.TelaInicio_button.Name = "TelaInicio_button";
            this.TelaInicio_button.Size = new System.Drawing.Size(100, 34);
            this.TelaInicio_button.TabIndex = 10;
            this.TelaInicio_button.Text = "-Tela Inicial-";
            this.TelaInicio_button.UseVisualStyleBackColor = false;
            this.TelaInicio_button.Click += new System.EventHandler(this.TelaInicio_button_Click);
            // 
            // MENUSTRIP_ADMIN_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(600, 392);
            this.Controls.Add(this.TelaInicio_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MENUSTRIP_ADMIN_";
            this.Text = "Menu Principal (A)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesUsuáriosToolStripMenuItem;
        private System.Windows.Forms.Button TelaInicio_button;
    }
}