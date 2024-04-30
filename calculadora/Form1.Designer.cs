namespace calculadora
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
            txtResultado = new TextBox();
            btnQuatro = new Button();
            btnUm = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnLimpar = new Button();
            lblOperacao = new Label();
            btnPorcentagem = new Button();
            btnRaiz = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.Black;
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.White;
            txtResultado.Location = new Point(120, 45);
            txtResultado.Margin = new Padding(4, 3, 4, 3);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(199, 49);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.FromArgb(51, 51, 51);
            btnQuatro.FlatAppearance.BorderSize = 0;
            btnQuatro.FlatStyle = FlatStyle.Flat;
            btnQuatro.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnQuatro.ForeColor = Color.White;
            btnQuatro.Location = new Point(14, 235);
            btnQuatro.Margin = new Padding(4, 3, 4, 3);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(70, 56);
            btnQuatro.TabIndex = 1;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.FromArgb(51, 51, 51);
            btnUm.FlatAppearance.BorderSize = 0;
            btnUm.FlatStyle = FlatStyle.Flat;
            btnUm.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnUm.ForeColor = Color.White;
            btnUm.Location = new Point(14, 297);
            btnUm.Margin = new Padding(4, 3, 4, 3);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(70, 56);
            btnUm.TabIndex = 2;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.FromArgb(51, 51, 51);
            btnCinco.FlatAppearance.BorderSize = 0;
            btnCinco.FlatStyle = FlatStyle.Flat;
            btnCinco.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnCinco.ForeColor = Color.White;
            btnCinco.Location = new Point(92, 235);
            btnCinco.Margin = new Padding(4, 3, 4, 3);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(70, 56);
            btnCinco.TabIndex = 3;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.FromArgb(51, 51, 51);
            btnSeis.FlatAppearance.BorderSize = 0;
            btnSeis.FlatStyle = FlatStyle.Flat;
            btnSeis.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnSeis.ForeColor = Color.White;
            btnSeis.Location = new Point(170, 235);
            btnSeis.Margin = new Padding(4, 3, 4, 3);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(70, 56);
            btnSeis.TabIndex = 4;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.FromArgb(51, 51, 51);
            btnDois.FlatAppearance.BorderSize = 0;
            btnDois.FlatStyle = FlatStyle.Flat;
            btnDois.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnDois.ForeColor = Color.White;
            btnDois.Location = new Point(92, 297);
            btnDois.Margin = new Padding(4, 3, 4, 3);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(70, 56);
            btnDois.TabIndex = 5;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.FromArgb(51, 51, 51);
            btnTres.FlatAppearance.BorderSize = 0;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnTres.ForeColor = Color.White;
            btnTres.Location = new Point(170, 297);
            btnTres.Margin = new Padding(4, 3, 4, 3);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(70, 56);
            btnTres.TabIndex = 6;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.FromArgb(51, 51, 51);
            btnNove.FlatAppearance.BorderSize = 0;
            btnNove.FlatStyle = FlatStyle.Flat;
            btnNove.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnNove.ForeColor = Color.White;
            btnNove.Location = new Point(170, 174);
            btnNove.Margin = new Padding(4, 3, 4, 3);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(70, 56);
            btnNove.TabIndex = 7;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.FromArgb(51, 51, 51);
            btnOito.FlatAppearance.BorderSize = 0;
            btnOito.FlatStyle = FlatStyle.Flat;
            btnOito.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnOito.ForeColor = Color.White;
            btnOito.Location = new Point(92, 174);
            btnOito.Margin = new Padding(4, 3, 4, 3);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(70, 56);
            btnOito.TabIndex = 8;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.FromArgb(51, 51, 51);
            btnSete.FlatAppearance.BorderSize = 0;
            btnSete.FlatStyle = FlatStyle.Flat;
            btnSete.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnSete.ForeColor = Color.White;
            btnSete.Location = new Point(14, 174);
            btnSete.Margin = new Padding(4, 3, 4, 3);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(70, 56);
            btnSete.TabIndex = 9;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(51, 51, 51);
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnZero.ForeColor = Color.White;
            btnZero.Location = new Point(14, 360);
            btnZero.Margin = new Padding(4, 3, 4, 3);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(148, 56);
            btnZero.TabIndex = 10;
            btnZero.Text = "    0";
            btnZero.TextAlign = ContentAlignment.MiddleLeft;
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(51, 51, 51);
            btnVirgula.FlatAppearance.BorderSize = 0;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnVirgula.ForeColor = Color.White;
            btnVirgula.Location = new Point(170, 359);
            btnVirgula.Margin = new Padding(4, 3, 4, 3);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(70, 56);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.FromArgb(254, 149, 5);
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(248, 359);
            btnIgual.Margin = new Padding(4, 3, 4, 3);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(70, 56);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackColor = Color.FromArgb(254, 149, 5);
            btnAdicao.FlatAppearance.BorderSize = 0;
            btnAdicao.FlatStyle = FlatStyle.Flat;
            btnAdicao.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnAdicao.ForeColor = Color.White;
            btnAdicao.Location = new Point(248, 297);
            btnAdicao.Margin = new Padding(4, 3, 4, 3);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(70, 56);
            btnAdicao.TabIndex = 13;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = false;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.FromArgb(254, 149, 5);
            btnSubtracao.FlatAppearance.BorderSize = 0;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnSubtracao.ForeColor = Color.White;
            btnSubtracao.Location = new Point(248, 236);
            btnSubtracao.Margin = new Padding(4, 3, 4, 3);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(70, 56);
            btnSubtracao.TabIndex = 14;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.FromArgb(254, 149, 5);
            btnMultiplicacao.FlatAppearance.BorderSize = 0;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = Color.White;
            btnMultiplicacao.Location = new Point(248, 174);
            btnMultiplicacao.Margin = new Padding(4, 3, 4, 3);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(70, 56);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.FromArgb(254, 149, 5);
            btnDivisao.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnDivisao.FlatAppearance.BorderSize = 0;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnDivisao.ForeColor = Color.White;
            btnDivisao.Location = new Point(248, 112);
            btnDivisao.Margin = new Padding(4, 3, 4, 3);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(70, 56);
            btnDivisao.TabIndex = 16;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(165, 165, 165);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnLimpar.ForeColor = Color.Black;
            btnLimpar.Location = new Point(13, 112);
            btnLimpar.Margin = new Padding(4, 3, 4, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(71, 56);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Font = new Font("Montserrat", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperacao.ForeColor = Color.White;
            lblOperacao.Location = new Point(13, 45);
            lblOperacao.Margin = new Padding(4, 0, 4, 0);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 55);
            lblOperacao.TabIndex = 18;
            // 
            // btnPorcentagem
            // 
            btnPorcentagem.BackColor = Color.FromArgb(165, 165, 165);
            btnPorcentagem.FlatAppearance.BorderSize = 0;
            btnPorcentagem.FlatStyle = FlatStyle.Flat;
            btnPorcentagem.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnPorcentagem.ForeColor = Color.Black;
            btnPorcentagem.Location = new Point(169, 112);
            btnPorcentagem.Margin = new Padding(4, 3, 4, 3);
            btnPorcentagem.Name = "btnPorcentagem";
            btnPorcentagem.Size = new Size(70, 56);
            btnPorcentagem.TabIndex = 20;
            btnPorcentagem.Text = "%";
            btnPorcentagem.UseVisualStyleBackColor = false;
            btnPorcentagem.Click += btnPorcentagem_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.FromArgb(165, 165, 165);
            btnRaiz.FlatAppearance.BorderSize = 0;
            btnRaiz.FlatStyle = FlatStyle.Flat;
            btnRaiz.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            btnRaiz.ForeColor = Color.Black;
            btnRaiz.Location = new Point(92, 112);
            btnRaiz.Margin = new Padding(4, 3, 4, 3);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(71, 56);
            btnRaiz.TabIndex = 21;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(332, 435);
            Controls.Add(btnRaiz);
            Controls.Add(btnPorcentagem);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnSete);
            Controls.Add(btnOito);
            Controls.Add(btnNove);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnUm);
            Controls.Add(btnQuatro);
            Controls.Add(txtResultado);
            Font = new Font("Montserrat", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnQuatro;
        private Button btnUm;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnDois;
        private Button btnTres;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnLimpar;
        private Label lblOperacao;
        private Button btnPorcentagem;
        private Button btnRaiz;
    }
}
