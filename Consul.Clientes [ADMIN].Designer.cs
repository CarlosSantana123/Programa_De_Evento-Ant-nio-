namespace Programa_De_Evento__Antônio_
{
    partial class Consul
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
            this.criar_ADMIN_button = new System.Windows.Forms.Button();
            this.cnpj_ADMIN_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.cnpj = new System.Windows.Forms.Label();
            this.telefone_ADMIN_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.cpf_ADMIN_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.data_ADMIN_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.tele = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.DN = new System.Windows.Forms.Label();
            this.representante_ADMIN_txtbox = new System.Windows.Forms.TextBox();
            this.repre = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.nome_ADMIN_txtbox = new System.Windows.Forms.TextBox();
            this.editar_ADMIN_button = new System.Windows.Forms.Button();
            this.deletar_ADMIN_button = new System.Windows.Forms.Button();
            this.consultar_ADMIN_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criar_ADMIN_button
            // 
            this.criar_ADMIN_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criar_ADMIN_button.Location = new System.Drawing.Point(45, 289);
            this.criar_ADMIN_button.Name = "criar_ADMIN_button";
            this.criar_ADMIN_button.Size = new System.Drawing.Size(126, 51);
            this.criar_ADMIN_button.TabIndex = 150;
            this.criar_ADMIN_button.Text = "Criar";
            this.criar_ADMIN_button.UseVisualStyleBackColor = true;
            // 
            // cnpj_ADMIN_txtbox
            // 
            this.cnpj_ADMIN_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnpj_ADMIN_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj_ADMIN_txtbox.Location = new System.Drawing.Point(368, 203);
            this.cnpj_ADMIN_txtbox.Mask = "99,999,999/0009-99";
            this.cnpj_ADMIN_txtbox.Name = "cnpj_ADMIN_txtbox";
            this.cnpj_ADMIN_txtbox.Size = new System.Drawing.Size(182, 27);
            this.cnpj_ADMIN_txtbox.TabIndex = 149;
            // 
            // cnpj
            // 
            this.cnpj.AutoSize = true;
            this.cnpj.BackColor = System.Drawing.Color.Transparent;
            this.cnpj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpj.Location = new System.Drawing.Point(362, 179);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(56, 21);
            this.cnpj.TabIndex = 148;
            this.cnpj.Text = "CNPJ:";
            // 
            // telefone_ADMIN_txtbox
            // 
            this.telefone_ADMIN_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefone_ADMIN_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone_ADMIN_txtbox.Location = new System.Drawing.Point(368, 43);
            this.telefone_ADMIN_txtbox.Mask = "(99) 0000-0000";
            this.telefone_ADMIN_txtbox.Name = "telefone_ADMIN_txtbox";
            this.telefone_ADMIN_txtbox.Size = new System.Drawing.Size(182, 27);
            this.telefone_ADMIN_txtbox.TabIndex = 147;
            // 
            // cpf_ADMIN_txtbox
            // 
            this.cpf_ADMIN_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpf_ADMIN_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf_ADMIN_txtbox.Location = new System.Drawing.Point(368, 110);
            this.cpf_ADMIN_txtbox.Mask = "999,999,999-99";
            this.cpf_ADMIN_txtbox.Name = "cpf_ADMIN_txtbox";
            this.cpf_ADMIN_txtbox.Size = new System.Drawing.Size(182, 27);
            this.cpf_ADMIN_txtbox.TabIndex = 146;
            // 
            // data_ADMIN_txtbox
            // 
            this.data_ADMIN_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_ADMIN_txtbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_ADMIN_txtbox.Location = new System.Drawing.Point(47, 203);
            this.data_ADMIN_txtbox.Mask = "00/00/0000";
            this.data_ADMIN_txtbox.Name = "data_ADMIN_txtbox";
            this.data_ADMIN_txtbox.Size = new System.Drawing.Size(102, 27);
            this.data_ADMIN_txtbox.TabIndex = 145;
            this.data_ADMIN_txtbox.ValidatingType = typeof(System.DateTime);
            // 
            // tele
            // 
            this.tele.AutoSize = true;
            this.tele.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tele.Location = new System.Drawing.Point(362, 19);
            this.tele.Name = "tele";
            this.tele.Size = new System.Drawing.Size(80, 21);
            this.tele.TabIndex = 144;
            this.tele.Text = "Telefone:";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(362, 86);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(44, 21);
            this.CPF.TabIndex = 143;
            this.CPF.Text = "CPF:";
            // 
            // DN
            // 
            this.DN.AutoSize = true;
            this.DN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DN.Location = new System.Drawing.Point(41, 152);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(108, 42);
            this.DN.TabIndex = 142;
            this.DN.Text = "Data de \r\nNascimento:";
            // 
            // representante_ADMIN_txtbox
            // 
            this.representante_ADMIN_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.representante_ADMIN_txtbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.representante_ADMIN_txtbox.Location = new System.Drawing.Point(47, 110);
            this.representante_ADMIN_txtbox.Name = "representante_ADMIN_txtbox";
            this.representante_ADMIN_txtbox.Size = new System.Drawing.Size(210, 29);
            this.representante_ADMIN_txtbox.TabIndex = 141;
            // 
            // repre
            // 
            this.repre.AutoSize = true;
            this.repre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repre.Location = new System.Drawing.Point(41, 86);
            this.repre.Name = "repre";
            this.repre.Size = new System.Drawing.Size(131, 21);
            this.repre.TabIndex = 140;
            this.repre.Text = "Representante:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(41, 19);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(61, 21);
            this.nome.TabIndex = 139;
            this.nome.Text = "Nome:";
            // 
            // nome_ADMIN_txtbox
            // 
            this.nome_ADMIN_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nome_ADMIN_txtbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_ADMIN_txtbox.Location = new System.Drawing.Point(46, 43);
            this.nome_ADMIN_txtbox.Name = "nome_ADMIN_txtbox";
            this.nome_ADMIN_txtbox.Size = new System.Drawing.Size(211, 29);
            this.nome_ADMIN_txtbox.TabIndex = 138;
            // 
            // editar_ADMIN_button
            // 
            this.editar_ADMIN_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar_ADMIN_button.Location = new System.Drawing.Point(424, 289);
            this.editar_ADMIN_button.Name = "editar_ADMIN_button";
            this.editar_ADMIN_button.Size = new System.Drawing.Size(126, 51);
            this.editar_ADMIN_button.TabIndex = 151;
            this.editar_ADMIN_button.Text = "Editar";
            this.editar_ADMIN_button.UseVisualStyleBackColor = true;
            // 
            // deletar_ADMIN_button
            // 
            this.deletar_ADMIN_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar_ADMIN_button.Location = new System.Drawing.Point(45, 375);
            this.deletar_ADMIN_button.Name = "deletar_ADMIN_button";
            this.deletar_ADMIN_button.Size = new System.Drawing.Size(126, 51);
            this.deletar_ADMIN_button.TabIndex = 152;
            this.deletar_ADMIN_button.Text = "Deletar";
            this.deletar_ADMIN_button.UseVisualStyleBackColor = true;
            // 
            // consultar_ADMIN_button
            // 
            this.consultar_ADMIN_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar_ADMIN_button.Location = new System.Drawing.Point(424, 375);
            this.consultar_ADMIN_button.Name = "consultar_ADMIN_button";
            this.consultar_ADMIN_button.Size = new System.Drawing.Size(126, 51);
            this.consultar_ADMIN_button.TabIndex = 153;
            this.consultar_ADMIN_button.Text = "Consultar";
            this.consultar_ADMIN_button.UseVisualStyleBackColor = true;
            // 
            // Consul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(595, 443);
            this.Controls.Add(this.consultar_ADMIN_button);
            this.Controls.Add(this.deletar_ADMIN_button);
            this.Controls.Add(this.editar_ADMIN_button);
            this.Controls.Add(this.criar_ADMIN_button);
            this.Controls.Add(this.cnpj_ADMIN_txtbox);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.telefone_ADMIN_txtbox);
            this.Controls.Add(this.cpf_ADMIN_txtbox);
            this.Controls.Add(this.data_ADMIN_txtbox);
            this.Controls.Add(this.tele);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.DN);
            this.Controls.Add(this.representante_ADMIN_txtbox);
            this.Controls.Add(this.repre);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.nome_ADMIN_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consul";
            this.Text = "Consulta de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button criar_ADMIN_button;
        private System.Windows.Forms.MaskedTextBox cnpj_ADMIN_txtbox;
        private System.Windows.Forms.Label cnpj;
        private System.Windows.Forms.MaskedTextBox telefone_ADMIN_txtbox;
        private System.Windows.Forms.MaskedTextBox cpf_ADMIN_txtbox;
        private System.Windows.Forms.MaskedTextBox data_ADMIN_txtbox;
        private System.Windows.Forms.Label tele;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label DN;
        private System.Windows.Forms.TextBox representante_ADMIN_txtbox;
        private System.Windows.Forms.Label repre;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.TextBox nome_ADMIN_txtbox;
        private System.Windows.Forms.Button editar_ADMIN_button;
        private System.Windows.Forms.Button deletar_ADMIN_button;
        private System.Windows.Forms.Button consultar_ADMIN_button;
    }
}