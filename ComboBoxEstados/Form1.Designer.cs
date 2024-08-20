namespace ComboBoxEstados
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTodos = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblALL = new System.Windows.Forms.Label();
            this.lblSUL = new System.Windows.Forms.Label();
            this.lblSUD = new System.Windows.Forms.Label();
            this.lblCO = new System.Windows.Forms.Label();
            this.lblNORD = new System.Windows.Forms.Label();
            this.lblNORTE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Todos os estados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Região Norte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Região Nordeste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Região Centro-Oeste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Região Sudeste:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Região Sul:";
            // 
            // comboTodos
            // 
            this.comboTodos.FormattingEnabled = true;
            this.comboTodos.Items.AddRange(new object[] {
            "MT",
            "GO",
            "MS",
            "SP",
            "PR",
            "RJ",
            "RS",
            "SC",
            "ES",
            "MG",
            "BA",
            "MA",
            "PI",
            "CE",
            "PE",
            "RN",
            "RR",
            "RO",
            "SE",
            "AL",
            "PB",
            "TO",
            "PA",
            "AP",
            "AM",
            "AC"});
            this.comboTodos.Location = new System.Drawing.Point(315, 93);
            this.comboTodos.Name = "comboTodos";
            this.comboTodos.Size = new System.Drawing.Size(198, 21);
            this.comboTodos.TabIndex = 1;
            this.comboTodos.SelectedIndexChanged += new System.EventHandler(this.comboTodos_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(315, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(315, 242);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(198, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(315, 293);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(198, 21);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(315, 140);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(198, 21);
            this.comboBox5.TabIndex = 5;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(315, 345);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(198, 21);
            this.comboBox6.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(530, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(530, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(530, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(530, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(530, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 38);
            this.button5.TabIndex = 11;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(530, 129);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 38);
            this.button6.TabIndex = 12;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // lblALL
            // 
            this.lblALL.AutoSize = true;
            this.lblALL.Font = new System.Drawing.Font("Roboto Bk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALL.Location = new System.Drawing.Point(585, 87);
            this.lblALL.Name = "lblALL";
            this.lblALL.Size = new System.Drawing.Size(27, 29);
            this.lblALL.TabIndex = 13;
            this.lblALL.Text = "0";
            this.lblALL.Click += new System.EventHandler(this.lblALL_Click);
            // 
            // lblSUL
            // 
            this.lblSUL.AutoSize = true;
            this.lblSUL.Font = new System.Drawing.Font("Roboto Bk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUL.Location = new System.Drawing.Point(585, 336);
            this.lblSUL.Name = "lblSUL";
            this.lblSUL.Size = new System.Drawing.Size(27, 29);
            this.lblSUL.TabIndex = 14;
            this.lblSUL.Text = "0";
            this.lblSUL.Click += new System.EventHandler(this.lblSUL_Click);
            // 
            // lblSUD
            // 
            this.lblSUD.AutoSize = true;
            this.lblSUD.Font = new System.Drawing.Font("Roboto Bk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSUD.Location = new System.Drawing.Point(585, 284);
            this.lblSUD.Name = "lblSUD";
            this.lblSUD.Size = new System.Drawing.Size(27, 29);
            this.lblSUD.TabIndex = 15;
            this.lblSUD.Text = "0";
            this.lblSUD.Click += new System.EventHandler(this.lblSUD_Click);
            // 
            // lblCO
            // 
            this.lblCO.AutoSize = true;
            this.lblCO.Font = new System.Drawing.Font("Roboto Bk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCO.Location = new System.Drawing.Point(585, 233);
            this.lblCO.Name = "lblCO";
            this.lblCO.Size = new System.Drawing.Size(27, 29);
            this.lblCO.TabIndex = 16;
            this.lblCO.Text = "0";
            this.lblCO.Click += new System.EventHandler(this.lblCO_Click);
            // 
            // lblNORD
            // 
            this.lblNORD.AutoSize = true;
            this.lblNORD.Font = new System.Drawing.Font("Roboto Bk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNORD.Location = new System.Drawing.Point(585, 183);
            this.lblNORD.Name = "lblNORD";
            this.lblNORD.Size = new System.Drawing.Size(27, 29);
            this.lblNORD.TabIndex = 17;
            this.lblNORD.Text = "0";
            this.lblNORD.Click += new System.EventHandler(this.lblNORD_Click);
            // 
            // lblNORTE
            // 
            this.lblNORTE.AutoSize = true;
            this.lblNORTE.Font = new System.Drawing.Font("Roboto Bk", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNORTE.Location = new System.Drawing.Point(585, 134);
            this.lblNORTE.Name = "lblNORTE";
            this.lblNORTE.Size = new System.Drawing.Size(27, 29);
            this.lblNORTE.TabIndex = 18;
            this.lblNORTE.Text = "0";
            this.lblNORTE.Click += new System.EventHandler(this.lblNORTE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNORTE);
            this.Controls.Add(this.lblNORD);
            this.Controls.Add(this.lblCO);
            this.Controls.Add(this.lblSUD);
            this.Controls.Add(this.lblSUL);
            this.Controls.Add(this.lblALL);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboTodos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTodos;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblALL;
        private System.Windows.Forms.Label lblSUL;
        private System.Windows.Forms.Label lblSUD;
        private System.Windows.Forms.Label lblCO;
        private System.Windows.Forms.Label lblNORD;
        private System.Windows.Forms.Label lblNORTE;
    }
}

