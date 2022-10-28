namespace ProjetoCalculoMedia
{
    partial class frmCalculoMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoMedia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.cmbNota1 = new System.Windows.Forms.ComboBox();
            this.cmbNota2 = new System.Windows.Forms.ComboBox();
            this.cmbNotaTrabalho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbQtdeAulas = new System.Windows.Forms.TextBox();
            this.txtbQtdeFaltas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbMediaFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbAproveitamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numNotaCorte = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbRecuperacao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoCalculoMedia.Properties.Resources.mediaAluno;
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nota 01";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(219, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 02";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(353, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota Trabalho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTrabalho.Location = new System.Drawing.Point(368, 201);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.PlaceholderText = "Insira a nota";
            this.txtTrabalho.Size = new System.Drawing.Size(100, 21);
            this.txtTrabalho.TabIndex = 4;
            this.txtTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNota2.Location = new System.Drawing.Point(208, 201);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.PlaceholderText = "Insira a nota";
            this.txtNota2.Size = new System.Drawing.Size(100, 21);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNota1.Location = new System.Drawing.Point(48, 201);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.PlaceholderText = "Insira a nota";
            this.txtNota1.Size = new System.Drawing.Size(100, 21);
            this.txtNota1.TabIndex = 0;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbNota1
            // 
            this.cmbNota1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNota1.FormattingEnabled = true;
            this.cmbNota1.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cmbNota1.Location = new System.Drawing.Point(48, 237);
            this.cmbNota1.Name = "cmbNota1";
            this.cmbNota1.Size = new System.Drawing.Size(100, 23);
            this.cmbNota1.TabIndex = 1;
            // 
            // cmbNota2
            // 
            this.cmbNota2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNota2.FormattingEnabled = true;
            this.cmbNota2.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cmbNota2.Location = new System.Drawing.Point(208, 237);
            this.cmbNota2.Name = "cmbNota2";
            this.cmbNota2.Size = new System.Drawing.Size(100, 23);
            this.cmbNota2.TabIndex = 3;
            // 
            // cmbNotaTrabalho
            // 
            this.cmbNotaTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotaTrabalho.FormattingEnabled = true;
            this.cmbNotaTrabalho.Items.AddRange(new object[] {
            "0,2",
            "0,3",
            "0,5"});
            this.cmbNotaTrabalho.Location = new System.Drawing.Point(368, 237);
            this.cmbNotaTrabalho.Name = "cmbNotaTrabalho";
            this.cmbNotaTrabalho.Size = new System.Drawing.Size(100, 23);
            this.cmbNotaTrabalho.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Qtde Aulas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbQtdeAulas
            // 
            this.txtbQtdeAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbQtdeAulas.Location = new System.Drawing.Point(158, 296);
            this.txtbQtdeAulas.Name = "txtbQtdeAulas";
            this.txtbQtdeAulas.Size = new System.Drawing.Size(100, 21);
            this.txtbQtdeAulas.TabIndex = 6;
            this.txtbQtdeAulas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbQtdeFaltas
            // 
            this.txtbQtdeFaltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbQtdeFaltas.Location = new System.Drawing.Point(159, 338);
            this.txtbQtdeFaltas.Name = "txtbQtdeFaltas";
            this.txtbQtdeFaltas.Size = new System.Drawing.Size(100, 21);
            this.txtbQtdeFaltas.TabIndex = 7;
            this.txtbQtdeFaltas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Qtde Faltas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbMediaFinal
            // 
            this.txtbMediaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbMediaFinal.Location = new System.Drawing.Point(97, 413);
            this.txtbMediaFinal.Name = "txtbMediaFinal";
            this.txtbMediaFinal.Size = new System.Drawing.Size(100, 21);
            this.txtbMediaFinal.TabIndex = 13;
            this.txtbMediaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(91, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Média Final";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbAproveitamento
            // 
            this.txtbAproveitamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbAproveitamento.Location = new System.Drawing.Point(288, 413);
            this.txtbAproveitamento.Name = "txtbAproveitamento";
            this.txtbAproveitamento.Size = new System.Drawing.Size(100, 21);
            this.txtbAproveitamento.TabIndex = 11;
            this.txtbAproveitamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbAproveitamento.TextChanged += new System.EventHandler(this.txtbAproveitamento_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(265, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Aproveitamento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Image = global::ProjetoCalculoMedia.Properties.Resources.calc;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(74, 449);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(151, 72);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Image = global::ProjetoCalculoMedia.Properties.Resources.accessories_system_cleaner1;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(265, 449);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(151, 72);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(353, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nota de Corte";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // numNotaCorte
            // 
            this.numNotaCorte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numNotaCorte.Location = new System.Drawing.Point(353, 330);
            this.numNotaCorte.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNotaCorte.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numNotaCorte.Name = "numNotaCorte";
            this.numNotaCorte.Size = new System.Drawing.Size(120, 29);
            this.numNotaCorte.TabIndex = 8;
            this.numNotaCorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numNotaCorte.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSituacao);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(497, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 136);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // lblSituacao
            // 
            this.lblSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacao.Location = new System.Drawing.Point(50, 64);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(88, 25);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação";
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbRecuperacao);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.Location = new System.Drawing.Point(497, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 136);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recuperação";
            // 
            // txtbRecuperacao
            // 
            this.txtbRecuperacao.Location = new System.Drawing.Point(25, 58);
            this.txtbRecuperacao.Name = "txtbRecuperacao";
            this.txtbRecuperacao.Size = new System.Drawing.Size(143, 29);
            this.txtbRecuperacao.TabIndex = 0;
            this.txtbRecuperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCalculoMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numNotaCorte);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbNotaTrabalho);
            this.Controls.Add(this.cmbNota2);
            this.Controls.Add(this.cmbNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbAproveitamento);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.txtbMediaFinal);
            this.Controls.Add(this.txtbQtdeFaltas);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtbQtdeAulas);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculoMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo Média";
            this.Load += new System.EventHandler(this.frmCalculoMedia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotaCorte)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTrabalho;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private ComboBox cmbNota1;
        private ComboBox cmbNota2;
        private ComboBox cmbNotaTrabalho;
        private Label label4;
        private TextBox txtbQtdeAulas;
        private TextBox txtbQtdeFaltas;
        private Label label5;
        private TextBox txtbMediaFinal;
        private Label label6;
        private TextBox txtbAproveitamento;
        private Label label7;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label label8;
        private NumericUpDown numNotaCorte;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtbRecuperacao;
        private Label lblSituacao;
    }
}