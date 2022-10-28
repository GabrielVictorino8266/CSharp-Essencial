namespace ControleFrota
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
            this.btnCarros = new System.Windows.Forms.Button();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbEixo = new System.Windows.Forms.TextBox();
            this.lblEixo = new System.Windows.Forms.Label();
            this.txtbKm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbPlaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCaminhao = new System.Windows.Forms.PictureBox();
            this.pbCarro = new System.Windows.Forms.PictureBox();
            this.txtbCaminhao = new System.Windows.Forms.TextBox();
            this.txtbCarros = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarros
            // 
            this.btnCarros.Image = global::ControleFrota.Properties.Resources.carIcon;
            this.btnCarros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarros.Location = new System.Drawing.Point(249, 12);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(107, 41);
            this.btnCarros.TabIndex = 0;
            this.btnCarros.Text = "Carros";
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.Image = global::ControleFrota.Properties.Resources.truckIcon;
            this.btnCaminhao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaminhao.Location = new System.Drawing.Point(382, 12);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(107, 41);
            this.btnCaminhao.TabIndex = 1;
            this.btnCaminhao.Text = "Caminhões";
            this.btnCaminhao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaminhao.UseVisualStyleBackColor = true;
            this.btnCaminhao.Click += new System.EventHandler(this.btnCaminhao_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::ControleFrota.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(510, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 41);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbEixo);
            this.panel1.Controls.Add(this.lblEixo);
            this.panel1.Controls.Add(this.txtbKm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbPlaca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbModelo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbCaminhao);
            this.panel1.Controls.Add(this.pbCarro);
            this.panel1.Controls.Add(this.txtbCaminhao);
            this.panel1.Controls.Add(this.txtbCarros);
            this.panel1.Location = new System.Drawing.Point(45, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 491);
            this.panel1.TabIndex = 1;
            // 
            // txtbEixo
            // 
            this.txtbEixo.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbEixo.Location = new System.Drawing.Point(296, 80);
            this.txtbEixo.Name = "txtbEixo";
            this.txtbEixo.PlaceholderText = "Qtde. de Eixos.";
            this.txtbEixo.Size = new System.Drawing.Size(107, 26);
            this.txtbEixo.TabIndex = 7;
            this.txtbEixo.Visible = false;
            // 
            // lblEixo
            // 
            this.lblEixo.AutoSize = true;
            this.lblEixo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEixo.Location = new System.Drawing.Point(242, 84);
            this.lblEixo.Name = "lblEixo";
            this.lblEixo.Size = new System.Drawing.Size(51, 21);
            this.lblEixo.TabIndex = 6;
            this.lblEixo.Text = "Eixos:";
            this.lblEixo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEixo.Visible = false;
            // 
            // txtbKm
            // 
            this.txtbKm.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbKm.Location = new System.Drawing.Point(128, 80);
            this.txtbKm.Name = "txtbKm";
            this.txtbKm.PlaceholderText = "Qtde. Km.";
            this.txtbKm.Size = new System.Drawing.Size(107, 26);
            this.txtbKm.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(68, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "KM:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbPlaca
            // 
            this.txtbPlaca.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbPlaca.Location = new System.Drawing.Point(128, 43);
            this.txtbPlaca.Name = "txtbPlaca";
            this.txtbPlaca.PlaceholderText = "Digite a placa do veículo.";
            this.txtbPlaca.Size = new System.Drawing.Size(420, 26);
            this.txtbPlaca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbModelo
            // 
            this.txtbModelo.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbModelo.Location = new System.Drawing.Point(128, 6);
            this.txtbModelo.Name = "txtbModelo";
            this.txtbModelo.PlaceholderText = "Digite o Modelo do veículo.";
            this.txtbModelo.Size = new System.Drawing.Size(420, 26);
            this.txtbModelo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCaminhao
            // 
            this.pbCaminhao.Image = global::ControleFrota.Properties.Resources.truck24;
            this.pbCaminhao.Location = new System.Drawing.Point(389, 155);
            this.pbCaminhao.Name = "pbCaminhao";
            this.pbCaminhao.Size = new System.Drawing.Size(105, 56);
            this.pbCaminhao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaminhao.TabIndex = 1;
            this.pbCaminhao.TabStop = false;
            // 
            // pbCarro
            // 
            this.pbCarro.Image = ((System.Drawing.Image)(resources.GetObject("pbCarro.Image")));
            this.pbCarro.Location = new System.Drawing.Point(28, 155);
            this.pbCarro.Name = "pbCarro";
            this.pbCarro.Size = new System.Drawing.Size(105, 56);
            this.pbCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarro.TabIndex = 1;
            this.pbCarro.TabStop = false;
            // 
            // txtbCaminhao
            // 
            this.txtbCaminhao.BackColor = System.Drawing.SystemColors.Info;
            this.txtbCaminhao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbCaminhao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCaminhao.Location = new System.Drawing.Point(389, 212);
            this.txtbCaminhao.Multiline = true;
            this.txtbCaminhao.Name = "txtbCaminhao";
            this.txtbCaminhao.PlaceholderText = "Caminhões da Frota";
            this.txtbCaminhao.ReadOnly = true;
            this.txtbCaminhao.Size = new System.Drawing.Size(340, 276);
            this.txtbCaminhao.TabIndex = 9;
            // 
            // txtbCarros
            // 
            this.txtbCarros.BackColor = System.Drawing.SystemColors.Info;
            this.txtbCarros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbCarros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbCarros.Location = new System.Drawing.Point(28, 212);
            this.txtbCarros.Multiline = true;
            this.txtbCarros.Name = "txtbCarros";
            this.txtbCarros.PlaceholderText = "Carros da Frota";
            this.txtbCarros.ReadOnly = true;
            this.txtbCarros.Size = new System.Drawing.Size(340, 276);
            this.txtbCarros.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaminhao);
            this.Controls.Add(this.btnCarros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaminhao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCarros;
        private Button btnCaminhao;
        private Button btnSalvar;
        private Panel panel1;
        private TextBox txtbEixo;
        private Label lblEixo;
        private TextBox txtbKm;
        private Label label3;
        private TextBox txtbPlaca;
        private Label label2;
        private TextBox txtbModelo;
        private Label label1;
        private PictureBox pbCaminhao;
        private PictureBox pbCarro;
        private TextBox txtbCaminhao;
        private TextBox txtbCarros;
    }
}