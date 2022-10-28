namespace CadastrodeClientes
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.btnPessoaJuridica = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnPessoaFisica = new System.Windows.Forms.Panel();
            this.txtbInfoPF = new System.Windows.Forms.TextBox();
            this.txtbCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbEndPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNomePF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPessoaJuridica = new System.Windows.Forms.Panel();
            this.txtbInfoPJ = new System.Windows.Forms.TextBox();
            this.txtbie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbcnpj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbEndPJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbNomePJ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnPessoaFisica.SuspendLayout();
            this.pnPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPessoaFisica.Image = global::CadastrodeClientes.Properties.Resources.fisico;
            this.btnPessoaFisica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoaFisica.Location = new System.Drawing.Point(61, 10);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(108, 54);
            this.btnPessoaFisica.TabIndex = 0;
            this.btnPessoaFisica.Text = "Pessoa Física";
            this.btnPessoaFisica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPessoaFisica.UseVisualStyleBackColor = true;
            this.btnPessoaFisica.Click += new System.EventHandler(this.btnPessoaFisica_Click);
            // 
            // btnPessoaJuridica
            // 
            this.btnPessoaJuridica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPessoaJuridica.Image = global::CadastrodeClientes.Properties.Resources.juridico;
            this.btnPessoaJuridica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoaJuridica.Location = new System.Drawing.Point(217, 10);
            this.btnPessoaJuridica.Name = "btnPessoaJuridica";
            this.btnPessoaJuridica.Size = new System.Drawing.Size(108, 54);
            this.btnPessoaJuridica.TabIndex = 1;
            this.btnPessoaJuridica.Text = "Pessoa Jurídica";
            this.btnPessoaJuridica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnPessoaJuridica.Click += new System.EventHandler(this.btnPessoaJuridica_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Image = global::CadastrodeClientes.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(373, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 54);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnPessoaFisica
            // 
            this.pnPessoaFisica.Controls.Add(this.txtbInfoPF);
            this.pnPessoaFisica.Controls.Add(this.txtbCPF);
            this.pnPessoaFisica.Controls.Add(this.label4);
            this.pnPessoaFisica.Controls.Add(this.txtbRG);
            this.pnPessoaFisica.Controls.Add(this.label3);
            this.pnPessoaFisica.Controls.Add(this.txtbEndPF);
            this.pnPessoaFisica.Controls.Add(this.label2);
            this.pnPessoaFisica.Controls.Add(this.txtbNomePF);
            this.pnPessoaFisica.Controls.Add(this.label1);
            this.pnPessoaFisica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnPessoaFisica.Location = new System.Drawing.Point(40, 88);
            this.pnPessoaFisica.Name = "pnPessoaFisica";
            this.pnPessoaFisica.Size = new System.Drawing.Size(467, 337);
            this.pnPessoaFisica.TabIndex = 2;
            this.pnPessoaFisica.Visible = false;
            // 
            // txtbInfoPF
            // 
            this.txtbInfoPF.Location = new System.Drawing.Point(12, 118);
            this.txtbInfoPF.Multiline = true;
            this.txtbInfoPF.Name = "txtbInfoPF";
            this.txtbInfoPF.Size = new System.Drawing.Size(429, 216);
            this.txtbInfoPF.TabIndex = 2;
            // 
            // txtbCPF
            // 
            this.txtbCPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbCPF.Location = new System.Drawing.Point(288, 75);
            this.txtbCPF.Name = "txtbCPF";
            this.txtbCPF.Size = new System.Drawing.Size(153, 25);
            this.txtbCPF.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(240, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF:";
            // 
            // txtbRG
            // 
            this.txtbRG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbRG.Location = new System.Drawing.Point(96, 77);
            this.txtbRG.Name = "txtbRG";
            this.txtbRG.Size = new System.Drawing.Size(138, 25);
            this.txtbRG.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "RG:";
            // 
            // txtbEndPF
            // 
            this.txtbEndPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbEndPF.Location = new System.Drawing.Point(96, 46);
            this.txtbEndPF.Name = "txtbEndPF";
            this.txtbEndPF.Size = new System.Drawing.Size(345, 25);
            this.txtbEndPF.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Endereço:";
            // 
            // txtbNomePF
            // 
            this.txtbNomePF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbNomePF.Location = new System.Drawing.Point(96, 15);
            this.txtbNomePF.Name = "txtbNomePF";
            this.txtbNomePF.Size = new System.Drawing.Size(345, 25);
            this.txtbNomePF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // pnPessoaJuridica
            // 
            this.pnPessoaJuridica.Controls.Add(this.txtbInfoPJ);
            this.pnPessoaJuridica.Controls.Add(this.txtbie);
            this.pnPessoaJuridica.Controls.Add(this.label5);
            this.pnPessoaJuridica.Controls.Add(this.txtbcnpj);
            this.pnPessoaJuridica.Controls.Add(this.label6);
            this.pnPessoaJuridica.Controls.Add(this.txtbEndPJ);
            this.pnPessoaJuridica.Controls.Add(this.label7);
            this.pnPessoaJuridica.Controls.Add(this.txtbNomePJ);
            this.pnPessoaJuridica.Controls.Add(this.label8);
            this.pnPessoaJuridica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnPessoaJuridica.Location = new System.Drawing.Point(40, 88);
            this.pnPessoaJuridica.Name = "pnPessoaJuridica";
            this.pnPessoaJuridica.Size = new System.Drawing.Size(467, 337);
            this.pnPessoaJuridica.TabIndex = 2;
            this.pnPessoaJuridica.Visible = false;
            // 
            // txtbInfoPJ
            // 
            this.txtbInfoPJ.Location = new System.Drawing.Point(12, 118);
            this.txtbInfoPJ.Multiline = true;
            this.txtbInfoPJ.Name = "txtbInfoPJ";
            this.txtbInfoPJ.Size = new System.Drawing.Size(429, 216);
            this.txtbInfoPJ.TabIndex = 2;
            // 
            // txtbie
            // 
            this.txtbie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbie.Location = new System.Drawing.Point(288, 75);
            this.txtbie.Name = "txtbie";
            this.txtbie.Size = new System.Drawing.Size(153, 25);
            this.txtbie.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(254, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "IE:";
            // 
            // txtbcnpj
            // 
            this.txtbcnpj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbcnpj.Location = new System.Drawing.Point(96, 77);
            this.txtbcnpj.Name = "txtbcnpj";
            this.txtbcnpj.Size = new System.Drawing.Size(138, 25);
            this.txtbcnpj.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "CNPJ:";
            // 
            // txtbEndPJ
            // 
            this.txtbEndPJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbEndPJ.Location = new System.Drawing.Point(96, 46);
            this.txtbEndPJ.Name = "txtbEndPJ";
            this.txtbEndPJ.Size = new System.Drawing.Size(345, 25);
            this.txtbEndPJ.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Endereço:";
            // 
            // txtbNomePJ
            // 
            this.txtbNomePJ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbNomePJ.Location = new System.Drawing.Point(96, 15);
            this.txtbNomePJ.Name = "txtbNomePJ";
            this.txtbNomePJ.Size = new System.Drawing.Size(345, 25);
            this.txtbNomePJ.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.pnPessoaJuridica);
            this.Controls.Add(this.pnPessoaFisica);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPessoaJuridica);
            this.Controls.Add(this.btnPessoaFisica);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnPessoaFisica.ResumeLayout(false);
            this.pnPessoaFisica.PerformLayout();
            this.pnPessoaJuridica.ResumeLayout(false);
            this.pnPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPessoaFisica;
        private Button btnPessoaJuridica;
        private Button btnSalvar;
        private Panel pnPessoaFisica;
        private TextBox txtbCPF;
        private Label label4;
        private TextBox txtbRG;
        private Label label3;
        private TextBox txtbEndPF;
        private Label label2;
        private TextBox txtbNomePF;
        private Label label1;
        private TextBox txtbInfoPF;
        private Panel pnPessoaJuridica;
        private TextBox txtbInfoPJ;
        private TextBox txtbie;
        private Label label5;
        private TextBox txtbcnpj;
        private Label label6;
        private TextBox txtbEndPJ;
        private Label label7;
        private TextBox txtbNomePJ;
        private Label label8;
    }
}