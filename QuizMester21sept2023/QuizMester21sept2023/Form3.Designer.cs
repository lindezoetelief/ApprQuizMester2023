namespace QuizMester21sept2023
{
    partial class Form3
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayText
            // 
            this.lblPlayText.AutoSize = true;
            this.lblPlayText.BackColor = System.Drawing.Color.Ivory;
            this.lblPlayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayText.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPlayText.Location = new System.Drawing.Point(334, 46);
            this.lblPlayText.Name = "lblPlayText";
            this.lblPlayText.Size = new System.Drawing.Size(114, 54);
            this.lblPlayText.TabIndex = 6;
            this.lblPlayText.Text = "Play";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuestion.Location = new System.Drawing.Point(201, 137);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(391, 43);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Question is displayed here";
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerA.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerA.Location = new System.Drawing.Point(140, 231);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerA.TabIndex = 8;
            this.btnAnswerA.Text = "Answer A";
            this.btnAnswerA.UseVisualStyleBackColor = false;
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerB.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerB.Location = new System.Drawing.Point(140, 296);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerB.TabIndex = 9;
            this.btnAnswerB.Text = "Answer B";
            this.btnAnswerB.UseVisualStyleBackColor = false;
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerC.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerC.Location = new System.Drawing.Point(432, 231);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerC.TabIndex = 10;
            this.btnAnswerC.Text = "Answer C";
            this.btnAnswerC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnswerC.UseVisualStyleBackColor = false;
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerD.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerD.Location = new System.Drawing.Point(432, 296);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerD.TabIndex = 11;
            this.btnAnswerD.Text = "Answer D";
            this.btnAnswerD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnswerD.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblPlayText);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayText;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
    }
}