namespace exam2
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
            this.Funt = new System.Windows.Forms.RadioButton();
            this.Pud = new System.Windows.Forms.RadioButton();
            this.Unc = new System.Windows.Forms.RadioButton();
            this.Drhm = new System.Windows.Forms.RadioButton();
            this.Gran = new System.Windows.Forms.RadioButton();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mass_Text = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Funt
            // 
            this.Funt.AutoSize = true;
            this.Funt.Location = new System.Drawing.Point(212, 60);
            this.Funt.Name = "Funt";
            this.Funt.Size = new System.Drawing.Size(52, 17);
            this.Funt.TabIndex = 5;
            this.Funt.TabStop = true;
            this.Funt.Text = "Фунт";
            this.Funt.UseVisualStyleBackColor = true;
            // 
            // Pud
            // 
            this.Pud.AutoSize = true;
            this.Pud.Location = new System.Drawing.Point(317, 63);
            this.Pud.Name = "Pud";
            this.Pud.Size = new System.Drawing.Size(44, 17);
            this.Pud.TabIndex = 6;
            this.Pud.TabStop = true;
            this.Pud.Text = "Пуд";
            this.Pud.UseVisualStyleBackColor = true;
            // 
            // Unc
            // 
            this.Unc.AutoSize = true;
            this.Unc.Location = new System.Drawing.Point(212, 103);
            this.Unc.Name = "Unc";
            this.Unc.Size = new System.Drawing.Size(57, 17);
            this.Unc.TabIndex = 7;
            this.Unc.TabStop = true;
            this.Unc.Text = "Унция";
            this.Unc.UseVisualStyleBackColor = true;
            // 
            // Drhm
            // 
            this.Drhm.AutoSize = true;
            this.Drhm.Location = new System.Drawing.Point(317, 103);
            this.Drhm.Name = "Drhm";
            this.Drhm.Size = new System.Drawing.Size(65, 17);
            this.Drhm.TabIndex = 8;
            this.Drhm.TabStop = true;
            this.Drhm.Text = "Драхма";
            this.Drhm.UseVisualStyleBackColor = true;
            // 
            // Gran
            // 
            this.Gran.AutoSize = true;
            this.Gran.Location = new System.Drawing.Point(212, 148);
            this.Gran.Name = "Gran";
            this.Gran.Size = new System.Drawing.Size(49, 17);
            this.Gran.TabIndex = 9;
            this.Gran.TabStop = true;
            this.Gran.Text = "Гран";
            this.Gran.UseVisualStyleBackColor = true;
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(54, 50);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(100, 20);
            this.tBox1.TabIndex = 10;
            this.tBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox1_KeyPress);
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(54, 118);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(100, 20);
            this.tBox2.TabIndex = 11;
            this.tBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBox2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выберите единицу измерения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введите массу в граммах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Из грамм в ";
            // 
            // mass_Text
            // 
            this.mass_Text.AutoSize = true;
            this.mass_Text.Location = new System.Drawing.Point(98, 91);
            this.mass_Text.Name = "mass_Text";
            this.mass_Text.Size = new System.Drawing.Size(0, 13);
            this.mass_Text.TabIndex = 15;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(69, 257);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(250, 31);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "Перевести";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 300);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.mass_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox2);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.Gran);
            this.Controls.Add(this.Drhm);
            this.Controls.Add(this.Unc);
            this.Controls.Add(this.Pud);
            this.Controls.Add(this.Funt);
            this.Name = "Form1";
            this.Text = "Перевод массы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Funt;
        private System.Windows.Forms.RadioButton Pud;
        private System.Windows.Forms.RadioButton Unc;
        private System.Windows.Forms.RadioButton Drhm;
        private System.Windows.Forms.RadioButton Gran;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mass_Text;
        private System.Windows.Forms.Button btn1;
    }
}

