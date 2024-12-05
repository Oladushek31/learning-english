namespace LessonEnglish
{
    partial class Statistics
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
            this.StatisticsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StatisticsDGV
            // 
            this.StatisticsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticsDGV.Location = new System.Drawing.Point(28, 27);
            this.StatisticsDGV.Name = "StatisticsDGV";
            this.StatisticsDGV.RowHeadersWidth = 51;
            this.StatisticsDGV.RowTemplate.Height = 24;
            this.StatisticsDGV.Size = new System.Drawing.Size(377, 395);
            this.StatisticsDGV.TabIndex = 0;
            this.StatisticsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatisticsDGV_CellContentClick);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.StatisticsDGV);
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StatisticsDGV;
    }
}