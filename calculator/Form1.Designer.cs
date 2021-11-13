namespace calculator
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.del1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.del2 = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.button_Sum = new System.Windows.Forms.Button();
            this.button_Subtrac = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num1.Location = new System.Drawing.Point(129, 105);
            this.num1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num1.Multiline = true;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(55, 46);
            this.num1.TabIndex = 0;
            // 
            // del1
            // 
            this.del1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del1.Location = new System.Drawing.Point(129, 157);
            this.del1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del1.Multiline = true;
            this.del1.Name = "del1";
            this.del1.Size = new System.Drawing.Size(55, 51);
            this.del1.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num2.Location = new System.Drawing.Point(255, 105);
            this.num2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num2.Multiline = true;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(55, 46);
            this.num2.TabIndex = 3;
            // 
            // del2
            // 
            this.del2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del2.Location = new System.Drawing.Point(255, 157);
            this.del2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del2.Multiline = true;
            this.del2.Name = "del2";
            this.del2.Size = new System.Drawing.Size(55, 51);
            this.del2.TabIndex = 2;
            // 
            // sign
            // 
            this.sign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.sign.Location = new System.Drawing.Point(212, 134);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(0, 34);
            this.sign.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(336, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(380, 128);
            this.answer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(304, 39);
            this.answer.TabIndex = 6;
            // 
            // button_Sum
            // 
            this.button_Sum.BackColor = System.Drawing.Color.Yellow;
            this.button_Sum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Sum.Location = new System.Drawing.Point(168, 246);
            this.button_Sum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Sum.Name = "button_Sum";
            this.button_Sum.Size = new System.Drawing.Size(44, 39);
            this.button_Sum.TabIndex = 7;
            this.button_Sum.Text = "+";
            this.button_Sum.UseVisualStyleBackColor = false;
            this.button_Sum.Click += new System.EventHandler(this.button_Sum_Click);
            // 
            // button_Subtrac
            // 
            this.button_Subtrac.BackColor = System.Drawing.Color.Yellow;
            this.button_Subtrac.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Subtrac.Location = new System.Drawing.Point(239, 246);
            this.button_Subtrac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Subtrac.Name = "button_Subtrac";
            this.button_Subtrac.Size = new System.Drawing.Size(44, 39);
            this.button_Subtrac.TabIndex = 8;
            this.button_Subtrac.Text = "-";
            this.button_Subtrac.UseVisualStyleBackColor = false;
            this.button_Subtrac.Click += new System.EventHandler(this.button_Subtrac_Click);
            // 
            // button_Multiply
            // 
            this.button_Multiply.BackColor = System.Drawing.Color.Yellow;
            this.button_Multiply.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Multiply.Location = new System.Drawing.Point(312, 246);
            this.button_Multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(44, 39);
            this.button_Multiply.TabIndex = 9;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = false;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.BackColor = System.Drawing.Color.Yellow;
            this.button_Divide.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Divide.Location = new System.Drawing.Point(389, 246);
            this.button_Divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(44, 39);
            this.button_Divide.TabIndex = 10;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = false;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_Result
            // 
            this.button_Result.BackColor = System.Drawing.Color.Yellow;
            this.button_Result.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Result.Location = new System.Drawing.Point(255, 308);
            this.button_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(112, 46);
            this.button_Result.TabIndex = 11;
            this.button_Result.Text = "=";
            this.button_Result.UseVisualStyleBackColor = false;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(804, 448);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Subtrac);
            this.Controls.Add(this.button_Sum);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.del2);
            this.Controls.Add(this.del1);
            this.Controls.Add(this.num1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox del1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox del2;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button button_Sum;
        private System.Windows.Forms.Button button_Subtrac;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Result;
    }
}

