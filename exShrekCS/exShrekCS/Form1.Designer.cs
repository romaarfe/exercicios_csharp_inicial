namespace exShrekCS
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblConcelho = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.chkEscalao = new System.Windows.Forms.CheckBox();
            this.chkSocio = new System.Windows.Forms.CheckBox();
            this.chkAgravamento = new System.Windows.Forms.CheckBox();
            this.cbxConcelho = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pbxShrek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShrek)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(48, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 56);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CÁLCULO DO VALOR DA AVENÇA";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(90, 116);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 22);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "NOME";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(90, 156);
            this.lblNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(180, 22);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "ANO DO NASCIMENTO";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(90, 196);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(110, 22);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "VALOR BASE";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(90, 414);
            this.lblPergunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(200, 22);
            this.lblPergunta.TabIndex = 4;
            this.lblPergunta.Text = "Reside no distrito?";
            // 
            // lblConcelho
            // 
            this.lblConcelho.AutoSize = true;
            this.lblConcelho.Location = new System.Drawing.Point(90, 462);
            this.lblConcelho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConcelho.Name = "lblConcelho";
            this.lblConcelho.Size = new System.Drawing.Size(90, 22);
            this.lblConcelho.TabIndex = 5;
            this.lblConcelho.Text = "CONCELHO";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(302, 108);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 30);
            this.txtNome.TabIndex = 6;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(302, 148);
            this.txtNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(164, 30);
            this.txtNascimento.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(302, 188);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(164, 30);
            this.txtValor.TabIndex = 8;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(302, 524);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 30);
            this.txtResultado.TabIndex = 9;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Location = new System.Drawing.Point(302, 410);
            this.rdbSim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(58, 26);
            this.rdbSim.TabIndex = 10;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(363, 410);
            this.rdbNao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(58, 26);
            this.rdbNao.TabIndex = 11;
            this.rdbNao.TabStop = true;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // chkEscalao
            // 
            this.chkEscalao.AutoSize = true;
            this.chkEscalao.Location = new System.Drawing.Point(94, 272);
            this.chkEscalao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEscalao.Name = "chkEscalao";
            this.chkEscalao.Size = new System.Drawing.Size(289, 26);
            this.chkEscalao.TabIndex = 12;
            this.chkEscalao.Text = "Desconto de escalão? (10%)";
            this.chkEscalao.UseVisualStyleBackColor = true;
            // 
            // chkSocio
            // 
            this.chkSocio.AutoSize = true;
            this.chkSocio.Location = new System.Drawing.Point(94, 308);
            this.chkSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSocio.Name = "chkSocio";
            this.chkSocio.Size = new System.Drawing.Size(259, 26);
            this.chkSocio.TabIndex = 13;
            this.chkSocio.Text = "Desconto de sócio? (5%)";
            this.chkSocio.UseVisualStyleBackColor = true;
            // 
            // chkAgravamento
            // 
            this.chkAgravamento.AutoSize = true;
            this.chkAgravamento.Location = new System.Drawing.Point(94, 344);
            this.chkAgravamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAgravamento.Name = "chkAgravamento";
            this.chkAgravamento.Size = new System.Drawing.Size(249, 26);
            this.chkAgravamento.TabIndex = 14;
            this.chkAgravamento.Text = "Tem agravamento? (12€)";
            this.chkAgravamento.UseVisualStyleBackColor = true;
            // 
            // cbxConcelho
            // 
            this.cbxConcelho.FormattingEnabled = true;
            this.cbxConcelho.Items.AddRange(new object[] {
            "Amares",
            "Braga",
            "Guimarães"});
            this.cbxConcelho.Location = new System.Drawing.Point(266, 462);
            this.cbxConcelho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxConcelho.Name = "cbxConcelho";
            this.cbxConcelho.Size = new System.Drawing.Size(200, 30);
            this.cbxConcelho.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(94, 524);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 30);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pbxShrek
            // 
            this.pbxShrek.Location = new System.Drawing.Point(514, 108);
            this.pbxShrek.Name = "pbxShrek";
            this.pbxShrek.Size = new System.Drawing.Size(269, 262);
            this.pbxShrek.TabIndex = 17;
            this.pbxShrek.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 609);
            this.Controls.Add(this.pbxShrek);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxConcelho);
            this.Controls.Add(this.chkAgravamento);
            this.Controls.Add(this.chkSocio);
            this.Controls.Add(this.chkEscalao);
            this.Controls.Add(this.rdbNao);
            this.Controls.Add(this.rdbSim);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblConcelho);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxShrek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblConcelho;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.CheckBox chkEscalao;
        private System.Windows.Forms.CheckBox chkSocio;
        private System.Windows.Forms.CheckBox chkAgravamento;
        private System.Windows.Forms.ComboBox cbxConcelho;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pbxShrek;
    }
}

