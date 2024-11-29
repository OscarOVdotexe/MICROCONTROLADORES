namespace Calculadora
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
            Button btndiv;
            txtResult = new TextBox();
            btnporcentaje = new Button();
            clear = new Button();
            btnclear = new Button();
            btncleardigit = new Button();
            btnraiz = new Button();
            btnpot = new Button();
            btninversa = new Button();
            btnmult = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnmas = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnmenos = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnrespuesta = new Button();
            btnpunto = new Button();
            btncero = new Button();
            btnsign = new Button();
            btndiv = new Button();
            SuspendLayout();
            // 
            // btndiv
            // 
            btndiv.Location = new Point(225, 144);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(52, 48);
            btndiv.TabIndex = 8;
            btndiv.Tag = " ÷";
            btndiv.Text = " ÷";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += clickOperador;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.GrayText;
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = SystemColors.Menu;
            txtResult.Location = new Point(12, 12);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(276, 60);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnporcentaje
            // 
            btnporcentaje.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnporcentaje.Location = new Point(21, 78);
            btnporcentaje.Name = "btnporcentaje";
            btnporcentaje.Size = new Size(52, 48);
            btnporcentaje.TabIndex = 1;
            btnporcentaje.Text = "%";
            btnporcentaje.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            clear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear.Location = new Point(90, 78);
            clear.Name = "clear";
            clear.Size = new Size(52, 48);
            clear.TabIndex = 2;
            clear.Text = "CE";
            clear.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclear.Location = new Point(158, 78);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(52, 48);
            btnclear.TabIndex = 3;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btncleardigit
            // 
            btncleardigit.Location = new Point(225, 78);
            btncleardigit.Name = "btncleardigit";
            btncleardigit.Size = new Size(52, 48);
            btncleardigit.TabIndex = 4;
            btncleardigit.Text = "<-x-";
            btncleardigit.UseVisualStyleBackColor = true;
            // 
            // btnraiz
            // 
            btnraiz.Location = new Point(158, 144);
            btnraiz.Name = "btnraiz";
            btnraiz.Size = new Size(52, 48);
            btnraiz.TabIndex = 7;
            btnraiz.Tag = "√";
            btnraiz.Text = "√";
            btnraiz.UseVisualStyleBackColor = true;
            btnraiz.Click += clickOperador;
            // 
            // btnpot
            // 
            btnpot.Location = new Point(90, 144);
            btnpot.Name = "btnpot";
            btnpot.Size = new Size(52, 48);
            btnpot.TabIndex = 6;
            btnpot.Tag = "x^2";
            btnpot.Text = "x^2";
            btnpot.UseVisualStyleBackColor = true;
            btnpot.Click += clickOperador;
            // 
            // btninversa
            // 
            btninversa.Location = new Point(21, 144);
            btninversa.Name = "btninversa";
            btninversa.Size = new Size(52, 48);
            btninversa.TabIndex = 5;
            btninversa.Tag = "1/x";
            btninversa.Text = "1/x";
            btninversa.UseVisualStyleBackColor = true;
            btninversa.Click += clickOperador;
            // 
            // btnmult
            // 
            btnmult.Location = new Point(225, 198);
            btnmult.Name = "btnmult";
            btnmult.Size = new Size(52, 48);
            btnmult.TabIndex = 12;
            btnmult.Tag = "X";
            btnmult.Text = " X";
            btnmult.UseVisualStyleBackColor = true;
            btnmult.Click += clickOperador;
            // 
            // btn7
            // 
            btn7.Location = new Point(158, 198);
            btn7.Name = "btn7";
            btn7.Size = new Size(52, 48);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += add_number;
            // 
            // btn8
            // 
            btn8.Location = new Point(90, 198);
            btn8.Name = "btn8";
            btn8.Size = new Size(52, 48);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += add_number;
            // 
            // btn9
            // 
            btn9.Location = new Point(21, 198);
            btn9.Name = "btn9";
            btn9.Size = new Size(52, 48);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += add_number;
            // 
            // btnmas
            // 
            btnmas.Location = new Point(225, 252);
            btnmas.Name = "btnmas";
            btnmas.Size = new Size(52, 48);
            btnmas.TabIndex = 16;
            btnmas.Tag = "+";
            btnmas.Text = "+";
            btnmas.UseVisualStyleBackColor = true;
            btnmas.Click += clickOperador;
            // 
            // btn4
            // 
            btn4.Location = new Point(158, 252);
            btn4.Name = "btn4";
            btn4.Size = new Size(52, 48);
            btn4.TabIndex = 15;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += add_number;
            // 
            // btn5
            // 
            btn5.Location = new Point(90, 252);
            btn5.Name = "btn5";
            btn5.Size = new Size(52, 48);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += add_number;
            // 
            // btn6
            // 
            btn6.Location = new Point(21, 252);
            btn6.Name = "btn6";
            btn6.Size = new Size(52, 48);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += add_number;
            // 
            // btnmenos
            // 
            btnmenos.Location = new Point(225, 306);
            btnmenos.Name = "btnmenos";
            btnmenos.Size = new Size(52, 48);
            btnmenos.TabIndex = 20;
            btnmenos.Tag = "-";
            btnmenos.Text = "-";
            btnmenos.UseVisualStyleBackColor = true;
            btnmenos.Click += clickOperador;
            // 
            // btn1
            // 
            btn1.Location = new Point(158, 306);
            btn1.Name = "btn1";
            btn1.Size = new Size(52, 48);
            btn1.TabIndex = 19;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += add_number;
            // 
            // btn2
            // 
            btn2.Location = new Point(90, 306);
            btn2.Name = "btn2";
            btn2.Size = new Size(52, 48);
            btn2.TabIndex = 18;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += add_number;
            // 
            // btn3
            // 
            btn3.Location = new Point(21, 306);
            btn3.Name = "btn3";
            btn3.Size = new Size(52, 48);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += add_number;
            // 
            // btnrespuesta
            // 
            btnrespuesta.ForeColor = SystemColors.ActiveCaptionText;
            btnrespuesta.Location = new Point(225, 366);
            btnrespuesta.Name = "btnrespuesta";
            btnrespuesta.Size = new Size(52, 48);
            btnrespuesta.TabIndex = 24;
            btnrespuesta.Tag = "=";
            btnrespuesta.Text = "=";
            btnrespuesta.UseVisualStyleBackColor = true;
            btnrespuesta.Click += btnrespuesta_Click;
            // 
            // btnpunto
            // 
            btnpunto.Location = new Point(158, 366);
            btnpunto.Name = "btnpunto";
            btnpunto.Size = new Size(52, 48);
            btnpunto.TabIndex = 23;
            btnpunto.Text = ".";
            btnpunto.UseVisualStyleBackColor = true;
            // 
            // btncero
            // 
            btncero.Location = new Point(90, 366);
            btncero.Name = "btncero";
            btncero.Size = new Size(52, 48);
            btncero.TabIndex = 22;
            btncero.Text = "0";
            btncero.UseVisualStyleBackColor = true;
            // 
            // btnsign
            // 
            btnsign.Location = new Point(21, 366);
            btnsign.Name = "btnsign";
            btnsign.Size = new Size(52, 48);
            btnsign.TabIndex = 21;
            btnsign.Text = "+/-";
            btnsign.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(300, 426);
            Controls.Add(btnrespuesta);
            Controls.Add(btnpunto);
            Controls.Add(btncero);
            Controls.Add(btnsign);
            Controls.Add(btnmenos);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnmas);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnmult);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btndiv);
            Controls.Add(btnraiz);
            Controls.Add(btnpot);
            Controls.Add(btninversa);
            Controls.Add(btncleardigit);
            Controls.Add(btnclear);
            Controls.Add(clear);
            Controls.Add(btnporcentaje);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnporcentaje;
        private Button clear;
        private Button btnclear;
        private Button btncleardigit;
        private Button btndiv;
        private Button btnraiz;
        private Button btnpot;
        private Button btninversa;
        private Button btnmult;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnmas;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnmenos;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnrespuesta;
        private Button btnpunto;
        private Button btncero;
        private Button btnsign;
    }
}
