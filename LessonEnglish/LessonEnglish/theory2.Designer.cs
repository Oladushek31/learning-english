namespace LessonEnglish
{
    partial class theory2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theory2));
            this.TestButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.theoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestButton
            // 
            this.TestButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestButton.Location = new System.Drawing.Point(176, 300);
            this.TestButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(140, 51);
            this.TestButton.TabIndex = 8;
            this.TestButton.Text = "Перейти к тесту";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(9, 300);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(140, 51);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // theoryTextBox
            // 
            this.theoryTextBox.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theoryTextBox.Location = new System.Drawing.Point(9, 16);
            this.theoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.theoryTextBox.Multiline = true;
            this.theoryTextBox.Name = "theoryTextBox";
            this.theoryTextBox.ReadOnly = true;
            this.theoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.theoryTextBox.Size = new System.Drawing.Size(307, 261);
            this.theoryTextBox.TabIndex = 6;
            this.theoryTextBox.Text = resources.GetString("theoryTextBox.Text");
            // 
            // theory2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(324, 368);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.theoryTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "theory2";
            this.Text = "Лекция №2";
            this.Load += new System.EventHandler(this.theory2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox theoryTextBox;
    }
}