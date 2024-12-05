namespace LessonEnglish
{
    partial class MainPage
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
            this.theory = new System.Windows.Forms.Button();
            this.greeting = new System.Windows.Forms.Label();
            this.Practice = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // theory
            // 
            this.theory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theory.Location = new System.Drawing.Point(56, 81);
            this.theory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theory.Name = "theory";
            this.theory.Size = new System.Drawing.Size(225, 57);
            this.theory.TabIndex = 0;
            this.theory.Text = "Теория";
            this.theory.UseVisualStyleBackColor = true;
            this.theory.Click += new System.EventHandler(this.theory_Click);
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(9, 15);
            this.greeting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(290, 26);
            this.greeting.TabIndex = 1;
            this.greeting.Text = "Добро пожаловать, ученик";
            // 
            // Practice
            // 
            this.Practice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practice.Location = new System.Drawing.Point(56, 162);
            this.Practice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Practice.Name = "Practice";
            this.Practice.Size = new System.Drawing.Size(225, 57);
            this.Practice.TabIndex = 2;
            this.Practice.Text = "Практика";
            this.Practice.UseVisualStyleBackColor = true;
            this.Practice.Click += new System.EventHandler(this.Practice_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(56, 244);
            this.result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(225, 57);
            this.result.TabIndex = 3;
            this.result.Text = "Статистика";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 368);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Practice);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.theory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainPage";
            this.Text = "Выбор действия";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button theory;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button Practice;
        private System.Windows.Forms.Button result;
    }
}