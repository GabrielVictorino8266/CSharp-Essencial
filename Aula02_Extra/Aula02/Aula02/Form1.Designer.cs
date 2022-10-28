namespace Aula02
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkB_PessoaFisica = new System.Windows.Forms.CheckBox();
            this.chkB_PessoaJuridica = new System.Windows.Forms.CheckBox();
            this.pnlPessoaFisica = new System.Windows.Forms.Panel();
            this.lblNomePfisica = new System.Windows.Forms.Label();
            this.txtbNomePessoaFisica = new System.Windows.Forms.TextBox();
            this.txtbCpfPessoaFisica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbCnpjPessoaJuridica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNomePessoaJuridica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPessoaFisica.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkB_PessoaFisica
            // 
            this.chkB_PessoaFisica.AutoSize = true;
            this.chkB_PessoaFisica.Location = new System.Drawing.Point(65, 189);
            this.chkB_PessoaFisica.Name = "chkB_PessoaFisica";
            this.chkB_PessoaFisica.Size = new System.Drawing.Size(94, 19);
            this.chkB_PessoaFisica.TabIndex = 0;
            this.chkB_PessoaFisica.Text = "Pessoa Física";
            this.chkB_PessoaFisica.UseVisualStyleBackColor = true;
            // 
            // chkB_PessoaJuridica
            // 
            this.chkB_PessoaJuridica.AutoSize = true;
            this.chkB_PessoaJuridica.Location = new System.Drawing.Point(65, 227);
            this.chkB_PessoaJuridica.Name = "chkB_PessoaJuridica";
            this.chkB_PessoaJuridica.Size = new System.Drawing.Size(105, 19);
            this.chkB_PessoaJuridica.TabIndex = 1;
            this.chkB_PessoaJuridica.Text = "Pessoa Jurídica";
            this.chkB_PessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // pnlPessoaFisica
            // 
            this.pnlPessoaFisica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPessoaFisica.Controls.Add(this.txtbCpfPessoaFisica);
            this.pnlPessoaFisica.Controls.Add(this.label2);
            this.pnlPessoaFisica.Controls.Add(this.txtbNomePessoaFisica);
            this.pnlPessoaFisica.Controls.Add(this.lblNomePfisica);
            this.pnlPessoaFisica.Location = new System.Drawing.Point(339, 84);
            this.pnlPessoaFisica.Name = "pnlPessoaFisica";
            this.pnlPessoaFisica.Size = new System.Drawing.Size(323, 124);
            this.pnlPessoaFisica.TabIndex = 2;
            // 
            // lblNomePfisica
            // 
            this.lblNomePfisica.AutoSize = true;
            this.lblNomePfisica.Location = new System.Drawing.Point(38, 33);
            this.lblNomePfisica.Name = "lblNomePfisica";
            this.lblNomePfisica.Size = new System.Drawing.Size(43, 15);
            this.lblNomePfisica.TabIndex = 0;
            this.lblNomePfisica.Text = "Nome:";
            // 
            // txtbNomePessoaFisica
            // 
            this.txtbNomePessoaFisica.Location = new System.Drawing.Point(113, 30);
            this.txtbNomePessoaFisica.Name = "txtbNomePessoaFisica";
            this.txtbNomePessoaFisica.Size = new System.Drawing.Size(175, 23);
            this.txtbNomePessoaFisica.TabIndex = 1;
            // 
            // txtbCpfPessoaFisica
            // 
            this.txtbCpfPessoaFisica.Location = new System.Drawing.Point(113, 69);
            this.txtbCpfPessoaFisica.Name = "txtbCpfPessoaFisica";
            this.txtbCpfPessoaFisica.Size = new System.Drawing.Size(175, 23);
            this.txtbCpfPessoaFisica.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtbCnpjPessoaJuridica);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbNomePessoaJuridica);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(339, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 124);
            this.panel1.TabIndex = 4;
            // 
            // txtbCnpjPessoaJuridica
            // 
            this.txtbCnpjPessoaJuridica.Location = new System.Drawing.Point(113, 69);
            this.txtbCnpjPessoaJuridica.Name = "txtbCnpjPessoaJuridica";
            this.txtbCnpjPessoaJuridica.Size = new System.Drawing.Size(175, 23);
            this.txtbCnpjPessoaJuridica.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNPJ:";
            // 
            // txtbNomePessoaJuridica
            // 
            this.txtbNomePessoaJuridica.Location = new System.Drawing.Point(113, 30);
            this.txtbNomePessoaJuridica.Name = "txtbNomePessoaJuridica";
            this.txtbNomePessoaJuridica.Size = new System.Drawing.Size(175, 23);
            this.txtbNomePessoaJuridica.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPessoaFisica);
            this.Controls.Add(this.chkB_PessoaJuridica);
            this.Controls.Add(this.chkB_PessoaFisica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades do Checkbox";
            this.pnlPessoaFisica.ResumeLayout(false);
            this.pnlPessoaFisica.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkB_PessoaFisica;
        private CheckBox chkB_PessoaJuridica;
        private Panel pnlPessoaFisica;
        private TextBox txtbCpfPessoaFisica;
        private Label label2;
        private TextBox txtbNomePessoaFisica;
        private Label lblNomePfisica;
        private Panel panel1;
        private TextBox txtbCnpjPessoaJuridica;
        private Label label3;
        private TextBox txtbNomePessoaJuridica;
        private Label label4;
    }
}