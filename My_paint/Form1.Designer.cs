namespace My_paint
{
    partial class Paint
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
            this.panel = new System.Windows.Forms.Panel();
            this.But_cir = new System.Windows.Forms.Button();
            this.But_rec = new System.Windows.Forms.Button();
            this.button_van = new System.Windows.Forms.Button();
            this.button_van_p = new System.Windows.Forms.Button();
            this.button_van_y = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_train = new System.Windows.Forms.Button();
            this.count_van = new System.Windows.Forms.TextBox();
            this.button_move = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.GhostWhite;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1107, 662);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // But_cir
            // 
            this.But_cir.BackColor = System.Drawing.Color.Yellow;
            this.But_cir.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But_cir.Location = new System.Drawing.Point(1129, 12);
            this.But_cir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.But_cir.Name = "But_cir";
            this.But_cir.Size = new System.Drawing.Size(165, 46);
            this.But_cir.TabIndex = 1;
            this.But_cir.Text = "Круг";
            this.But_cir.UseVisualStyleBackColor = false;
            this.But_cir.Click += new System.EventHandler(this.But_cir_Click);
            // 
            // But_rec
            // 
            this.But_rec.BackColor = System.Drawing.Color.Yellow;
            this.But_rec.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But_rec.Location = new System.Drawing.Point(1125, 79);
            this.But_rec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.But_rec.Name = "But_rec";
            this.But_rec.Size = new System.Drawing.Size(175, 46);
            this.But_rec.TabIndex = 2;
            this.But_rec.Text = "Прямоугольник";
            this.But_rec.UseVisualStyleBackColor = false;
            this.But_rec.Click += new System.EventHandler(this.But_rec_Click);
            // 
            // button_van
            // 
            this.button_van.BackColor = System.Drawing.Color.Yellow;
            this.button_van.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_van.Location = new System.Drawing.Point(1129, 149);
            this.button_van.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_van.Name = "button_van";
            this.button_van.Size = new System.Drawing.Size(165, 46);
            this.button_van.TabIndex = 3;
            this.button_van.Text = "Вагончик";
            this.button_van.UseVisualStyleBackColor = false;
            this.button_van.Click += new System.EventHandler(this.button_van_Click);
            // 
            // button_van_p
            // 
            this.button_van_p.BackColor = System.Drawing.Color.Yellow;
            this.button_van_p.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_van_p.Location = new System.Drawing.Point(1129, 220);
            this.button_van_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_van_p.Name = "button_van_p";
            this.button_van_p.Size = new System.Drawing.Size(165, 60);
            this.button_van_p.TabIndex = 4;
            this.button_van_p.Text = "Вагончик с песком";
            this.button_van_p.UseVisualStyleBackColor = false;
            this.button_van_p.Click += new System.EventHandler(this.button_van_p_Click);
            // 
            // button_van_y
            // 
            this.button_van_y.BackColor = System.Drawing.Color.Yellow;
            this.button_van_y.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_van_y.Location = new System.Drawing.Point(1129, 307);
            this.button_van_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_van_y.Name = "button_van_y";
            this.button_van_y.Size = new System.Drawing.Size(165, 58);
            this.button_van_y.TabIndex = 5;
            this.button_van_y.Text = "Вагончик с углём ";
            this.button_van_y.UseVisualStyleBackColor = false;
            this.button_van_y.Click += new System.EventHandler(this.button_van_y_Click);
            // 
            // button_clean
            // 
            this.button_clean.BackColor = System.Drawing.Color.Yellow;
            this.button_clean.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clean.Location = new System.Drawing.Point(1137, 631);
            this.button_clean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(157, 43);
            this.button_clean.TabIndex = 6;
            this.button_clean.Text = "Очистить";
            this.button_clean.UseVisualStyleBackColor = false;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_train
            // 
            this.button_train.BackColor = System.Drawing.Color.Yellow;
            this.button_train.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_train.Location = new System.Drawing.Point(1129, 430);
            this.button_train.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_train.Name = "button_train";
            this.button_train.Size = new System.Drawing.Size(165, 46);
            this.button_train.TabIndex = 7;
            this.button_train.Text = "Поезд";
            this.button_train.UseVisualStyleBackColor = false;
            this.button_train.Click += new System.EventHandler(this.button_train_Click);
            // 
            // count_van
            // 
            this.count_van.Location = new System.Drawing.Point(1156, 399);
            this.count_van.Margin = new System.Windows.Forms.Padding(4);
            this.count_van.Name = "count_van";
            this.count_van.Size = new System.Drawing.Size(111, 22);
            this.count_van.TabIndex = 8;
            // 
            // button_move
            // 
            this.button_move.BackColor = System.Drawing.Color.Yellow;
            this.button_move.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_move.Location = new System.Drawing.Point(1129, 513);
            this.button_move.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_move.Name = "button_move";
            this.button_move.Size = new System.Drawing.Size(165, 46);
            this.button_move.TabIndex = 9;
            this.button_move.Text = "Переместить";
            this.button_move.UseVisualStyleBackColor = false;
            this.button_move.Click += new System.EventHandler(this.button_move_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1306, 685);
            this.Controls.Add(this.button_move);
            this.Controls.Add(this.count_van);
            this.Controls.Add(this.button_train);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_van_y);
            this.Controls.Add(this.button_van_p);
            this.Controls.Add(this.button_van);
            this.Controls.Add(this.But_rec);
            this.Controls.Add(this.But_cir);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Paint";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button But_cir;
        private System.Windows.Forms.Button But_rec;
        private System.Windows.Forms.Button button_van;
        private System.Windows.Forms.Button button_van_p;
        private System.Windows.Forms.Button button_van_y;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_train;
        private System.Windows.Forms.TextBox count_van;
        private System.Windows.Forms.Button button_move;
    }
}

