namespace ControleFuncionarios
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
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNomeTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.txtbInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbNome
            // 
            this.txtbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbNome.Location = new System.Drawing.Point(122, 55);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.PlaceholderText = "Digite o nome do funcionário";
            this.txtbNome.Size = new System.Drawing.Size(254, 29);
            this.txtbNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(442, 55);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 91);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNomeTxt
            // 
            this.lblNomeTxt.AutoSize = true;
            this.lblNomeTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomeTxt.Location = new System.Drawing.Point(38, 55);
            this.lblNomeTxt.Name = "lblNomeTxt";
            this.lblNomeTxt.Size = new System.Drawing.Size(67, 25);
            this.lblNomeTxt.TabIndex = 2;
            this.lblNomeTxt.Text = "Nome:";
            this.lblNomeTxt.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cargo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbSalario
            // 
            this.txtbSalario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbSalario.Location = new System.Drawing.Point(122, 125);
            this.txtbSalario.Name = "txtbSalario";
            this.txtbSalario.PlaceholderText = "digite o salário do funcionário";
            this.txtbSalario.Size = new System.Drawing.Size(254, 29);
            this.txtbSalario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Assistente Administrativo",
            "Assistente de Designer"});
            this.cmbCargo.Location = new System.Drawing.Point(122, 88);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(254, 33);
            this.cmbCargo.TabIndex = 1;
            // 
            // txtbInfo
            // 
            this.txtbInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbInfo.Location = new System.Drawing.Point(38, 185);
            this.txtbInfo.Multiline = true;
            this.txtbInfo.Name = "txtbInfo";
            this.txtbInfo.ReadOnly = true;
            this.txtbInfo.Size = new System.Drawing.Size(493, 228);
            this.txtbInfo.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbInfo);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomeTxt);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtbSalario);
            this.Controls.Add(this.txtbNome);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Funcionários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtbNome;
        private Button btnSalvar;
        private Label lblNomeTxt;
        private Label label1;
        private TextBox txtbSalario;
        private Label label2;
        private ComboBox cmbCargo;
        private TextBox txtbInfo;
    }
}