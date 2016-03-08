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
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(33, 281);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(44, 40);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(95, 281);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(44, 40);
            this.n2.TabIndex = 0;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(156, 281);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(44, 40);
            this.n3.TabIndex = 0;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // btCE
            // 
            this.btCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(33, 108);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(44, 40);
            this.btCE.TabIndex = 0;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // botaoC
            // 
            this.botaoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoC.Location = new System.Drawing.Point(95, 108);
            this.botaoC.Name = "botaoC";
            this.botaoC.Size = new System.Drawing.Size(44, 40);
            this.botaoC.TabIndex = 0;
            this.botaoC.Text = "C";
            this.botaoC.UseVisualStyleBackColor = true;
            this.botaoC.Click += new System.EventHandler(this.botaoC_Click);
            // 
            // Porcentage
            // 
            this.Porcentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcentage.Location = new System.Drawing.Point(156, 108);
            this.Porcentage.Name = "Porcentage";
            this.Porcentage.Size = new System.Drawing.Size(44, 40);
            this.Porcentage.TabIndex = 0;
            this.Porcentage.Text = "%";
            this.Porcentage.UseVisualStyleBackColor = true;
            this.Porcentage.Click += new System.EventHandler(this.Porcentage_Click);
            // 
            // Divisao
            // 
            this.Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisao.Location = new System.Drawing.Point(218, 108);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(44, 40);
            this.Divisao.TabIndex = 0;
            this.Divisao.Text = "÷";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(33, 224);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(44, 40);
            this.n4.TabIndex = 0;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(95, 224);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(44, 40);
            this.n5.TabIndex = 0;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(156, 224);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(44, 40);
            this.n6.TabIndex = 0;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // Menos
            // 
            this.Menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menos.Location = new System.Drawing.Point(218, 224);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(44, 40);
            this.Menos.TabIndex = 0;
            this.Menos.Text = "-";
            this.Menos.UseVisualStyleBackColor = true;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(33, 165);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(44, 40);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(95, 165);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(44, 40);
            this.b8.TabIndex = 0;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(156, 165);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(44, 40);
            this.b9.TabIndex = 0;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // Vezes
            // 
            this.Vezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vezes.Location = new System.Drawing.Point(218, 165);
            this.Vezes.Name = "Vezes";
            this.Vezes.Size = new System.Drawing.Size(44, 40);
            this.Vezes.TabIndex = 0;
            this.Vezes.Text = "x";
            this.Vezes.UseVisualStyleBackColor = true;
            this.Vezes.Click += new System.EventHandler(this.Vezes_Click);
            // 
            // ponto
            // 
            this.ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ponto.Location = new System.Drawing.Point(33, 338);
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
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(95, 338);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(44, 40);
            this.b0.TabIndex = 0;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // igual
            // 
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(218, 281);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(44, 97);
            this.igual.TabIndex = 0;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // bSoma
            // 
            this.bSoma.AutoSize = true;
            this.bSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSoma.Location = new System.Drawing.Point(277, 281);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
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
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.Location = new System.Drawing.Point(277, 109);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(44, 40);
            this.raiz.TabIndex = 2;
            this.raiz.Text = "√¯";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // expo
            // 
            this.expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expo.Location = new System.Drawing.Point(277, 166);
            this.expo.Name = "expo";
            this.expo.Size = new System.Drawing.Size(44, 40);
            this.expo.TabIndex = 2;
            this.expo.Text = "x^y";
            this.expo.UseVisualStyleBackColor = true;
            this.expo.Click += new System.EventHandler(this.expo_Click);
            // 
            // b00
            // 
            this.b00.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b00.Location = new System.Drawing.Point(156, 338);
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
            this.label2.Location = new System.Drawing.Point(235, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "By Nathan Vieira";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b00);
            this.Controls.Add(this.expo);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.Vezes);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.bSoma);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.Porcentage);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.botaoC);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Calculadora !";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

