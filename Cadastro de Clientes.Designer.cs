﻿namespace Programa_De_Evento__Antônio_
{
    partial class Cadastro_de_Clientes
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
            this.criar_btn = new System.Windows.Forms.Button();
            this.cnpjj = new System.Windows.Forms.MaskedTextBox();
            this.cnpj = new System.Windows.Forms.Label();
            this.DNN = new System.Windows.Forms.MaskedTextBox();
            this.telee = new System.Windows.Forms.MaskedTextBox();
            this.tele = new System.Windows.Forms.Label();
            this.DN = new System.Windows.Forms.Label();
            this.repree = new System.Windows.Forms.TextBox();
            this.repre = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.noome = new System.Windows.Forms.TextBox();
            this.senha_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // criar_btn
            // 
            this.criar_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar_btn.Location = new System.Drawing.Point(237, 320);
            this.criar_btn.Name = "criar_btn";
            this.criar_btn.Size = new System.Drawing.Size(126, 51);
            this.criar_btn.TabIndex = 137;
            this.criar_btn.Text = "Criar";
            this.criar_btn.UseVisualStyleBackColor = true;
            this.criar_btn.Click += new System.EventHandler(this.entrar_button_Click);
            // 
            // cnpjj
            // 
            this.cnpjj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnpjj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpjj.Location = new System.Drawing.Point(367, 135);
            this.cnpjj.Name = "cnpjj";
            this.cnpjj.Size = new System.Drawing.Size(206, 27);
            this.cnpjj.TabIndex = 136;
            this.cnpjj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mskcnpjj_MaskInputRejected);
            // 
            // cnpj
            // 
            this.cnpj.AutoSize = true;
            this.cnpj.BackColor = System.Drawing.Color.Transparent;
            this.cnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj.Location = new System.Drawing.Point(361, 111);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(93, 21);
            this.cnpj.TabIndex = 135;
            this.cnpj.Text = "CNPJ/CPF:";
            // 
            // DNN
            // 
            this.DNN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DNN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNN.Location = new System.Drawing.Point(367, 68);
            this.DNN.Mask = "(99) 0000-0000";
            this.DNN.Name = "DNN";
            this.DNN.Size = new System.Drawing.Size(182, 27);
            this.DNN.TabIndex = 134;
            this.DNN.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DNN_MaskInputRejected);
            // 
            // telee
            // 
            this.telee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telee.Location = new System.Drawing.Point(156, 201);
            this.telee.Mask = "00/00/0000";
            this.telee.Name = "telee";
            this.telee.Size = new System.Drawing.Size(102, 27);
            this.telee.TabIndex = 132;
            this.telee.ValidatingType = typeof(System.DateTime);
            // 
            // tele
            // 
            this.tele.AutoSize = true;
            this.tele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele.Location = new System.Drawing.Point(361, 44);
            this.tele.Name = "tele";
            this.tele.Size = new System.Drawing.Size(80, 21);
            this.tele.TabIndex = 131;
            this.tele.Text = "Telefone:";
            // 
            // DN
            // 
            this.DN.AutoSize = true;
            this.DN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DN.Location = new System.Drawing.Point(42, 186);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(108, 42);
            this.DN.TabIndex = 129;
            this.DN.Text = "Data de \r\nNascimento:";
            // 
            // repree
            // 
            this.repree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repree.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repree.Location = new System.Drawing.Point(46, 135);
            this.repree.Name = "repree";
            this.repree.Size = new System.Drawing.Size(210, 29);
            this.repree.TabIndex = 128;
            this.repree.TextChanged += new System.EventHandler(this.repree_TextChanged);
            // 
            // repre
            // 
            this.repre.AutoSize = true;
            this.repre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repre.Location = new System.Drawing.Point(40, 111);
            this.repre.Name = "repre";
            this.repre.Size = new System.Drawing.Size(131, 21);
            this.repre.TabIndex = 127;
            this.repre.Text = "Representante:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(42, 44);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(120, 21);
            this.nome.TabIndex = 126;
            this.nome.Text = "Nome/Usuário";
            // 
            // noome
            // 
            this.noome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noome.Location = new System.Drawing.Point(47, 68);
            this.noome.Name = "noome";
            this.noome.Size = new System.Drawing.Size(211, 29);
            this.noome.TabIndex = 125;
            // 
            // senha_txtbox
            // 
            this.senha_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senha_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_txtbox.Location = new System.Drawing.Point(367, 201);
            this.senha_txtbox.Name = "senha_txtbox";
            this.senha_txtbox.Size = new System.Drawing.Size(206, 27);
            this.senha_txtbox.TabIndex = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 139;
            this.label1.Text = "Senha";
            // 
            // Cadastro_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(599, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senha_txtbox);
            this.Controls.Add(this.criar_btn);
            this.Controls.Add(this.cnpjj);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.DNN);
            this.Controls.Add(this.telee);
            this.Controls.Add(this.tele);
            this.Controls.Add(this.DN);
            this.Controls.Add(this.repree);
            this.Controls.Add(this.repre);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.noome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_de_Clientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Cadastro_de_Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button criar_btn;
        private System.Windows.Forms.MaskedTextBox cnpjj;
        private System.Windows.Forms.Label cnpj;
        private System.Windows.Forms.MaskedTextBox DNN;
        private System.Windows.Forms.MaskedTextBox telee;
        private System.Windows.Forms.Label tele;
        private System.Windows.Forms.Label DN;
        private System.Windows.Forms.TextBox repree;
        private System.Windows.Forms.Label repre;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox noome;
        private System.Windows.Forms.MaskedTextBox senha_txtbox;
        private System.Windows.Forms.Label label1;
    }
}