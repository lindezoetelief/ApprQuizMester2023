namespace QuizMester21sept2023
{
    partial class Form4
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
            this.lblPlayText = new System.Windows.Forms.Label();
            this.rtbxHighscores = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPlayText
            // 
            this.lblPlayText.AutoSize = true;
            this.lblPlayText.BackColor = System.Drawing.Color.Ivory;
            this.lblPlayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayText.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayText.Location = new System.Drawing.Point(266, 56);
            this.lblPlayText.Name = "lblPlayText";
            this.lblPlayText.Size = new System.Drawing.Size(259, 54);
            this.lblPlayText.TabIndex = 7;
            this.lblPlayText.Text = "Highscores";
            // 
            // rtbxHighscores
            // 
            this.rtbxHighscores.Location = new System.Drawing.Point(99, 148);
            this.rtbxHighscores.Name = "rtbxHighscores";
            this.rtbxHighscores.Size = new System.Drawing.Size(570, 230);
            this.rtbxHighscores.TabIndex = 15;
            this.rtbxHighscores.Text = "";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbxHighscores);
            this.Controls.Add(this.lblPlayText);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayText;
        private System.Windows.Forms.RichTextBox rtbxHighscores;
    }
}