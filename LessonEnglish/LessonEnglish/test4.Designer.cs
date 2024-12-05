namespace LessonEnglish
{
    partial class test4
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
            this.question = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(9, 20);
            this.question.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.question.Multiline = true;
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.question.Size = new System.Drawing.Size(302, 105);
            this.question.TabIndex = 12;
            this.question.Text = "Вопрос";
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Return.Location = new System.Drawing.Point(186, 266);
            this.Return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(112, 57);
            this.Return.TabIndex = 11;
            this.Return.Text = "Вернуться";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // nextQuestion
            // 
            this.nextQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextQuestion.Location = new System.Drawing.Point(28, 266);
            this.nextQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(112, 57);
            this.nextQuestion.TabIndex = 10;
            this.nextQuestion.Text = "Следующий вопрос";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButton3.Location = new System.Drawing.Point(50, 182);
            this.RadioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(96, 22);
            this.RadioButton3.TabIndex = 9;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Вариант3";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButton2.Location = new System.Drawing.Point(50, 155);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(96, 22);
            this.RadioButton2.TabIndex = 8;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Вариант2";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButton1.Location = new System.Drawing.Point(50, 128);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(96, 22);
            this.RadioButton1.TabIndex = 7;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Вариант1";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // test4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 368);
            this.Controls.Add(this.question);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.RadioButton3);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "test4";
            this.Text = "Тест №4";
            this.Load += new System.EventHandler(this.test4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
    }
}