namespace lab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbHrn1 = new System.Windows.Forms.TextBox();
            this.tbCop1 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblAddResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resHrn = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.tbCop2 = new System.Windows.Forms.TextBox();
            this.tbHrn2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFrac2 = new System.Windows.Forms.TextBox();
            this.tbFrac1 = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFull2 = new System.Windows.Forms.TextBox();
            this.tbFull1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDiv2 = new System.Windows.Forms.Button();
            this.btnMul2 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSum2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbHrn1
            // 
            this.tbHrn1.Location = new System.Drawing.Point(47, 37);
            this.tbHrn1.Name = "tbHrn1";
            this.tbHrn1.Size = new System.Drawing.Size(122, 22);
            this.tbHrn1.TabIndex = 0;
            this.tbHrn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHrn1_KeyPress);
            // 
            // tbCop1
            // 
            this.tbCop1.Location = new System.Drawing.Point(202, 37);
            this.tbCop1.Name = "tbCop1";
            this.tbCop1.Size = new System.Drawing.Size(122, 22);
            this.tbCop1.TabIndex = 1;
            this.tbCop1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCop1_KeyPress);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(425, 56);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(43, 38);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // lblAddResult
            // 
            this.lblAddResult.AutoSize = true;
            this.lblAddResult.Location = new System.Drawing.Point(44, 18);
            this.lblAddResult.Name = "lblAddResult";
            this.lblAddResult.Size = new System.Drawing.Size(49, 16);
            this.lblAddResult.TabIndex = 5;
            this.lblAddResult.Text = "Гривні";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Гривні";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат:";
            // 
            // resHrn
            // 
            this.resHrn.AutoSize = true;
            this.resHrn.Location = new System.Drawing.Point(126, 130);
            this.resHrn.Name = "resHrn";
            this.resHrn.Size = new System.Drawing.Size(0, 16);
            this.resHrn.TabIndex = 9;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(474, 56);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(43, 38);
            this.btnSub.TabIndex = 10;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(523, 56);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(43, 38);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(572, 56);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(43, 38);
            this.btnDiv.TabIndex = 12;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // tbCop2
            // 
            this.tbCop2.Location = new System.Drawing.Point(203, 86);
            this.tbCop2.Name = "tbCop2";
            this.tbCop2.Size = new System.Drawing.Size(122, 22);
            this.tbCop2.TabIndex = 14;
            this.tbCop2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCop2_KeyPress);
            // 
            // tbHrn2
            // 
            this.tbHrn2.Location = new System.Drawing.Point(48, 86);
            this.tbHrn2.Name = "tbHrn2";
            this.tbHrn2.Size = new System.Drawing.Size(122, 22);
            this.tbHrn2.TabIndex = 13;
            this.tbHrn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHrn2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Дробові";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Дробові";
            // 
            // tbFrac2
            // 
            this.tbFrac2.Location = new System.Drawing.Point(202, 308);
            this.tbFrac2.Name = "tbFrac2";
            this.tbFrac2.Size = new System.Drawing.Size(122, 22);
            this.tbFrac2.TabIndex = 24;
            this.tbFrac2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrac2_KeyPress);
            // 
            // tbFrac1
            // 
            this.tbFrac1.Location = new System.Drawing.Point(47, 308);
            this.tbFrac1.Name = "tbFrac1";
            this.tbFrac1.Size = new System.Drawing.Size(122, 22);
            this.tbFrac1.TabIndex = 23;
            this.tbFrac1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrac1_KeyPress);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(126, 352);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 16);
            this.lblRes.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Цілі зі знаком";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Цілі зі знаком";
            // 
            // tbFull2
            // 
            this.tbFull2.Location = new System.Drawing.Point(201, 259);
            this.tbFull2.Name = "tbFull2";
            this.tbFull2.Size = new System.Drawing.Size(122, 22);
            this.tbFull2.TabIndex = 18;
            this.tbFull2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFull2_KeyPress);
            // 
            // tbFull1
            // 
            this.tbFull1.Location = new System.Drawing.Point(46, 259);
            this.tbFull1.Name = "tbFull1";
            this.tbFull1.Size = new System.Drawing.Size(122, 22);
            this.tbFull1.TabIndex = 17;
            this.tbFull1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFull1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Копійки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Копійки";
            // 
            // btnDiv2
            // 
            this.btnDiv2.Location = new System.Drawing.Point(572, 278);
            this.btnDiv2.Name = "btnDiv2";
            this.btnDiv2.Size = new System.Drawing.Size(43, 38);
            this.btnDiv2.TabIndex = 32;
            this.btnDiv2.Text = "/";
            this.btnDiv2.UseVisualStyleBackColor = true;
            this.btnDiv2.Click += new System.EventHandler(this.btnDiv2_Click);
            // 
            // btnMul2
            // 
            this.btnMul2.Location = new System.Drawing.Point(523, 278);
            this.btnMul2.Name = "btnMul2";
            this.btnMul2.Size = new System.Drawing.Size(43, 38);
            this.btnMul2.TabIndex = 31;
            this.btnMul2.Text = "*";
            this.btnMul2.UseVisualStyleBackColor = true;
            this.btnMul2.Click += new System.EventHandler(this.btnMul2_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Location = new System.Drawing.Point(474, 278);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(43, 38);
            this.btnSub2.TabIndex = 30;
            this.btnSub2.Text = "-";
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnSum2
            // 
            this.btnSum2.Location = new System.Drawing.Point(425, 278);
            this.btnSum2.Name = "btnSum2";
            this.btnSum2.Size = new System.Drawing.Size(43, 38);
            this.btnSum2.TabIndex = 29;
            this.btnSum2.Text = "+";
            this.btnSum2.UseVisualStyleBackColor = true;
            this.btnSum2.Click += new System.EventHandler(this.btnSum2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Результат:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "Приклад: 2/5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDiv2);
            this.Controls.Add(this.btnMul2);
            this.Controls.Add(this.btnSub2);
            this.Controls.Add(this.btnSum2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbFrac2);
            this.Controls.Add(this.tbFrac1);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbFull2);
            this.Controls.Add(this.tbFull1);
            this.Controls.Add(this.tbCop2);
            this.Controls.Add(this.tbHrn2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.resHrn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddResult);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.tbCop1);
            this.Controls.Add(this.tbHrn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHrn1;
        private System.Windows.Forms.TextBox tbCop1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblAddResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resHrn;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.TextBox tbCop2;
        private System.Windows.Forms.TextBox tbHrn2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFrac2;
        private System.Windows.Forms.TextBox tbFrac1;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFull2;
        private System.Windows.Forms.TextBox tbFull1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDiv2;
        private System.Windows.Forms.Button btnMul2;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnSum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}

