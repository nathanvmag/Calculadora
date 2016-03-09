namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.botaoC = new System.Windows.Forms.Button();
            this.Porcentage = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.Menos = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.Vezes = new System.Windows.Forms.Button();
            this.ponto = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.bSoma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.raiz = new System.Windows.Forms.Button();
            this.expo = new System.Windows.Forms.Button();
            this.b00 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.Color.White;
            this.n1.Image = ((System.Drawing.Image)(resources.GetObject("n1.Image")));
            this.n1.Location = new System.Drawing.Point(6, 179);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(44, 40);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.Color.White;
            this.n2.Image = ((System.Drawing.Image)(resources.GetObject("n2.Image")));
            this.n2.Location = new System.Drawing.Point(68, 179);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(44, 40);
            this.n2.TabIndex = 0;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.ForeColor = System.Drawing.Color.White;
            this.n3.Image = ((System.Drawing.Image)(resources.GetObject("n3.Image")));
            this.n3.Location = new System.Drawing.Point(129, 179);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(44, 40);
            this.n3.TabIndex = 0;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // btCE
            // 
            this.btCE.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.ForeColor = System.Drawing.Color.White;
            this.btCE.Image = ((System.Drawing.Image)(resources.GetObject("btCE.Image")));
            this.btCE.Location = new System.Drawing.Point(7, 6);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(44, 40);
            this.btCE.TabIndex = 0;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // botaoC
            // 
            this.botaoC.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoC.ForeColor = System.Drawing.Color.White;
            this.botaoC.Image = ((System.Drawing.Image)(resources.GetObject("botaoC.Image")));
            this.botaoC.Location = new System.Drawing.Point(68, 6);
            this.botaoC.Name = "botaoC";
            this.botaoC.Size = new System.Drawing.Size(44, 40);
            this.botaoC.TabIndex = 0;
            this.botaoC.Text = "C";
            this.botaoC.UseVisualStyleBackColor = true;
            this.botaoC.Click += new System.EventHandler(this.botaoC_Click);
            // 
            // Porcentage
            // 
            this.Porcentage.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcentage.ForeColor = System.Drawing.Color.White;
            this.Porcentage.Image = ((System.Drawing.Image)(resources.GetObject("Porcentage.Image")));
            this.Porcentage.Location = new System.Drawing.Point(129, 6);
            this.Porcentage.Name = "Porcentage";
            this.Porcentage.Size = new System.Drawing.Size(44, 40);
            this.Porcentage.TabIndex = 0;
            this.Porcentage.Text = "%";
            this.Porcentage.UseVisualStyleBackColor = true;
            this.Porcentage.Click += new System.EventHandler(this.Porcentage_Click);
            // 
            // Divisao
            // 
            this.Divisao.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisao.ForeColor = System.Drawing.Color.White;
            this.Divisao.Image = ((System.Drawing.Image)(resources.GetObject("Divisao.Image")));
            this.Divisao.Location = new System.Drawing.Point(191, 6);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(44, 40);
            this.Divisao.TabIndex = 0;
            this.Divisao.Text = "÷";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.ForeColor = System.Drawing.Color.White;
            this.n4.Image = ((System.Drawing.Image)(resources.GetObject("n4.Image")));
            this.n4.Location = new System.Drawing.Point(6, 122);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(44, 40);
            this.n4.TabIndex = 0;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.ForeColor = System.Drawing.Color.White;
            this.n5.Image = ((System.Drawing.Image)(resources.GetObject("n5.Image")));
            this.n5.Location = new System.Drawing.Point(68, 122);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(44, 40);
            this.n5.TabIndex = 0;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.ForeColor = System.Drawing.Color.White;
            this.n6.Image = ((System.Drawing.Image)(resources.GetObject("n6.Image")));
            this.n6.Location = new System.Drawing.Point(129, 122);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(44, 40);
            this.n6.TabIndex = 0;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // Menos
            // 
            this.Menos.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menos.ForeColor = System.Drawing.Color.White;
            this.Menos.Image = ((System.Drawing.Image)(resources.GetObject("Menos.Image")));
            this.Menos.Location = new System.Drawing.Point(191, 122);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(44, 40);
            this.Menos.TabIndex = 0;
            this.Menos.Text = "-";
            this.Menos.UseVisualStyleBackColor = true;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.ForeColor = System.Drawing.Color.White;
            this.b7.Image = ((System.Drawing.Image)(resources.GetObject("b7.Image")));
            this.b7.Location = new System.Drawing.Point(6, 63);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(44, 40);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.ForeColor = System.Drawing.Color.White;
            this.b8.Image = ((System.Drawing.Image)(resources.GetObject("b8.Image")));
            this.b8.Location = new System.Drawing.Point(68, 63);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(44, 40);
            this.b8.TabIndex = 0;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.ForeColor = System.Drawing.Color.White;
            this.b9.Image = ((System.Drawing.Image)(resources.GetObject("b9.Image")));
            this.b9.Location = new System.Drawing.Point(129, 63);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(44, 40);
            this.b9.TabIndex = 0;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // Vezes
            // 
            this.Vezes.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vezes.ForeColor = System.Drawing.Color.White;
            this.Vezes.Image = ((System.Drawing.Image)(resources.GetObject("Vezes.Image")));
            this.Vezes.Location = new System.Drawing.Point(191, 63);
            this.Vezes.Name = "Vezes";
            this.Vezes.Size = new System.Drawing.Size(44, 40);
            this.Vezes.TabIndex = 0;
            this.Vezes.Text = "x";
            this.Vezes.UseVisualStyleBackColor = true;
            this.Vezes.Click += new System.EventHandler(this.Vezes_Click);
            // 
            // ponto
            // 
            this.ponto.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto.ForeColor = System.Drawing.Color.White;
            this.ponto.Image = ((System.Drawing.Image)(resources.GetObject("ponto.Image")));
            this.ponto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ponto.Location = new System.Drawing.Point(6, 236);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(44, 40);
            this.ponto.TabIndex = 0;
            this.ponto.Text = ".";
            this.ponto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ponto.UseVisualStyleBackColor = true;
            this.ponto.Click += new System.EventHandler(this.ponto_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.ForeColor = System.Drawing.Color.White;
            this.b0.Image = ((System.Drawing.Image)(resources.GetObject("b0.Image")));
            this.b0.Location = new System.Drawing.Point(68, 236);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(44, 40);
            this.b0.TabIndex = 0;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Image = ((System.Drawing.Image)(resources.GetObject("igual.Image")));
            this.igual.Location = new System.Drawing.Point(191, 179);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(44, 97);
            this.igual.TabIndex = 0;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // bSoma
            // 
            this.bSoma.Font = new System.Drawing.Font("Digital-7", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSoma.Image = ((System.Drawing.Image)(resources.GetObject("bSoma.Image")));
            this.bSoma.Location = new System.Drawing.Point(250, 179);
            this.bSoma.Name = "bSoma";
            this.bSoma.Size = new System.Drawing.Size(44, 97);
            this.bSoma.TabIndex = 0;
            this.bSoma.Text = "+";
            this.bSoma.UseVisualStyleBackColor = true;
            this.bSoma.Click += new System.EventHandler(this.bSoma_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Digital-7 Mono", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 43);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.ForeColor = System.Drawing.Color.White;
            this.raiz.Image = ((System.Drawing.Image)(resources.GetObject("raiz.Image")));
            this.raiz.Location = new System.Drawing.Point(250, 7);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(44, 40);
            this.raiz.TabIndex = 2;
            this.raiz.Text = "√¯";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // expo
            // 
            this.expo.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expo.ForeColor = System.Drawing.Color.White;
            this.expo.Image = ((System.Drawing.Image)(resources.GetObject("expo.Image")));
            this.expo.Location = new System.Drawing.Point(250, 64);
            this.expo.Name = "expo";
            this.expo.Size = new System.Drawing.Size(44, 40);
            this.expo.TabIndex = 2;
            this.expo.Text = "x^y";
            this.expo.UseVisualStyleBackColor = true;
            this.expo.Click += new System.EventHandler(this.expo_Click);
            // 
            // b00
            // 
            this.b00.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b00.ForeColor = System.Drawing.Color.White;
            this.b00.Image = ((System.Drawing.Image)(resources.GetObject("b00.Image")));
            this.b00.Location = new System.Drawing.Point(129, 236);
            this.b00.Name = "b00";
            this.b00.Size = new System.Drawing.Size(44, 40);
            this.b00.TabIndex = 3;
            this.b00.Text = "00";
            this.b00.UseVisualStyleBackColor = true;
            this.b00.Click += new System.EventHandler(this.b00_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Digital-7", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "By Nathan Vieira";
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("Digital-7", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.Image = ((System.Drawing.Image)(resources.GetObject("Log.Image")));
            this.Log.Location = new System.Drawing.Point(250, 122);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(44, 40);
            this.Log.TabIndex = 5;
            this.Log.Text = "log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(319, 310);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btCE);
            this.tabPage1.Controls.Add(this.Log);
            this.tabPage1.Controls.Add(this.n1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ponto);
            this.tabPage1.Controls.Add(this.b00);
            this.tabPage1.Controls.Add(this.n2);
            this.tabPage1.Controls.Add(this.expo);
            this.tabPage1.Controls.Add(this.b0);
            this.tabPage1.Controls.Add(this.raiz);
            this.tabPage1.Controls.Add(this.b7);
            this.tabPage1.Controls.Add(this.n4);
            this.tabPage1.Controls.Add(this.Menos);
            this.tabPage1.Controls.Add(this.botaoC);
            this.tabPage1.Controls.Add(this.Vezes);
            this.tabPage1.Controls.Add(this.b8);
            this.tabPage1.Controls.Add(this.Divisao);
            this.tabPage1.Controls.Add(this.n5);
            this.tabPage1.Controls.Add(this.bSoma);
            this.tabPage1.Controls.Add(this.n3);
            this.tabPage1.Controls.Add(this.n6);
            this.tabPage1.Controls.Add(this.igual);
            this.tabPage1.Controls.Add(this.b9);
            this.tabPage1.Controls.Add(this.Porcentage);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(311, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calculadora";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(311, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Regra de 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Está para ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Assim como :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Está para :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "O valor :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("DS-Digital", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(32, 172);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 49);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(198, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 49);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Font = new System.Drawing.Font("Digital-7 Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 49);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 395);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora !";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button botaoC;
        private System.Windows.Forms.Button Porcentage;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button Menos;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button Vezes;
        private System.Windows.Forms.Button ponto;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button bSoma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button expo;
        private System.Windows.Forms.Button b00;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

