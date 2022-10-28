namespace ConversaoDeTemperatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbValor = new System.Windows.Forms.TextBox();
            this.rdbCelsiusSaida = new System.Windows.Forms.RadioButton();
            this.rdbKelvinSaida = new System.Windows.Forms.RadioButton();
            this.rdbFahrenheightSaida = new System.Windows.Forms.RadioButton();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.rdbCelsiusEntrada = new System.Windows.Forms.RadioButton();
            this.rdbFahrenheightEntrada = new System.Windows.Forms.RadioButton();
            this.rdbkelvinEntrada = new System.Windows.Forms.RadioButton();
            this.txtbResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbSaida.SuspendLayout();
            this.gbEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbValor
            // 
            this.txtbValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbValor.Location = new System.Drawing.Point(138, 12);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(281, 29);
            this.txtbValor.TabIndex = 0;
            this.txtbValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbValor.TextChanged += new System.EventHandler(this.txtbValor_TextChanged);
            // 
            // rdbCelsiusSaida
            // 
            this.rdbCelsiusSaida.AutoSize = true;
            this.rdbCelsiusSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbCelsiusSaida.Location = new System.Drawing.Point(66, 15);
            this.rdbCelsiusSaida.Name = "rdbCelsiusSaida";
            this.rdbCelsiusSaida.Size = new System.Drawing.Size(77, 25);
            this.rdbCelsiusSaida.TabIndex = 0;
            this.rdbCelsiusSaida.TabStop = true;
            this.rdbCelsiusSaida.Text = "Celsius";
            this.rdbCelsiusSaida.UseVisualStyleBackColor = true;
            // 
            // rdbKelvinSaida
            // 
            this.rdbKelvinSaida.AutoSize = true;
            this.rdbKelvinSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbKelvinSaida.Location = new System.Drawing.Point(66, 40);
            this.rdbKelvinSaida.Name = "rdbKelvinSaida";
            this.rdbKelvinSaida.Size = new System.Drawing.Size(70, 25);
            this.rdbKelvinSaida.TabIndex = 1;
            this.rdbKelvinSaida.TabStop = true;
            this.rdbKelvinSaida.Text = "Kelvin";
            this.rdbKelvinSaida.UseVisualStyleBackColor = true;
            // 
            // rdbFahrenheightSaida
            // 
            this.rdbFahrenheightSaida.AutoSize = true;
            this.rdbFahrenheightSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFahrenheightSaida.Location = new System.Drawing.Point(66, 65);
            this.rdbFahrenheightSaida.Name = "rdbFahrenheightSaida";
            this.rdbFahrenheightSaida.Size = new System.Drawing.Size(101, 25);
            this.rdbFahrenheightSaida.TabIndex = 2;
            this.rdbFahrenheightSaida.TabStop = true;
            this.rdbFahrenheightSaida.Text = "Fahrenheit";
            this.rdbFahrenheightSaida.UseVisualStyleBackColor = true;
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.rdbCelsiusSaida);
            this.gbSaida.Controls.Add(this.rdbFahrenheightSaida);
            this.gbSaida.Controls.Add(this.rdbKelvinSaida);
            this.gbSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbSaida.Location = new System.Drawing.Point(263, 47);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(200, 100);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saída";
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rdbCelsiusEntrada);
            this.gbEntrada.Controls.Add(this.rdbFahrenheightEntrada);
            this.gbEntrada.Controls.Add(this.rdbkelvinEntrada);
            this.gbEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbEntrada.Location = new System.Drawing.Point(30, 47);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(200, 100);
            this.gbEntrada.TabIndex = 1;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // rdbCelsiusEntrada
            // 
            this.rdbCelsiusEntrada.AutoSize = true;
            this.rdbCelsiusEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbCelsiusEntrada.Location = new System.Drawing.Point(66, 15);
            this.rdbCelsiusEntrada.Name = "rdbCelsiusEntrada";
            this.rdbCelsiusEntrada.Size = new System.Drawing.Size(77, 25);
            this.rdbCelsiusEntrada.TabIndex = 0;
            this.rdbCelsiusEntrada.TabStop = true;
            this.rdbCelsiusEntrada.Text = "Celsius";
            this.rdbCelsiusEntrada.UseVisualStyleBackColor = true;
            // 
            // rdbFahrenheightEntrada
            // 
            this.rdbFahrenheightEntrada.AutoSize = true;
            this.rdbFahrenheightEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbFahrenheightEntrada.Location = new System.Drawing.Point(66, 65);
            this.rdbFahrenheightEntrada.Name = "rdbFahrenheightEntrada";
            this.rdbFahrenheightEntrada.Size = new System.Drawing.Size(101, 25);
            this.rdbFahrenheightEntrada.TabIndex = 2;
            this.rdbFahrenheightEntrada.TabStop = true;
            this.rdbFahrenheightEntrada.Text = "Fahrenheit";
            this.rdbFahrenheightEntrada.UseVisualStyleBackColor = true;
            // 
            // rdbkelvinEntrada
            // 
            this.rdbkelvinEntrada.AutoSize = true;
            this.rdbkelvinEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbkelvinEntrada.Location = new System.Drawing.Point(66, 40);
            this.rdbkelvinEntrada.Name = "rdbkelvinEntrada";
            this.rdbkelvinEntrada.Size = new System.Drawing.Size(70, 25);
            this.rdbkelvinEntrada.TabIndex = 1;
            this.rdbkelvinEntrada.TabStop = true;
            this.rdbkelvinEntrada.Text = "Kelvin";
            this.rdbkelvinEntrada.UseVisualStyleBackColor = true;
            // 
            // txtbResultado
            // 
            this.txtbResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbResultado.Location = new System.Drawing.Point(138, 167);
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.Size = new System.Drawing.Size(281, 29);
            this.txtbResultado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.Location = new System.Drawing.Point(107, 216);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(107, 44);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(236, 216);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 44);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 282);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtbResultado);
            this.Controls.Add(this.gbEntrada);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSaida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtbValor;
        private RadioButton rdbCelsiusSaida;
        private RadioButton rdbKelvinSaida;
        private RadioButton rdbFahrenheightSaida;
        private GroupBox gbSaida;
        private GroupBox gbEntrada;
        private RadioButton rdbCelsiusEntrada;
        private RadioButton rdbFahrenheightEntrada;
        private RadioButton rdbkelvinEntrada;
        private TextBox txtbResultado;
        private Label label2;
        private Button btnConverter;
        private Button btnLimpar;
    }
}