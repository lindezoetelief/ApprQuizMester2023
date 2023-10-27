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
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblScoreIndicator = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.tmrTimeLeft = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuestion.Location = new System.Drawing.Point(201, 137);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(377, 41);
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
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
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
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
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
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
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
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Location = new System.Drawing.Point(66, 57);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(14, 16);
            this.lblCurrentScore.TabIndex = 12;
            this.lblCurrentScore.Text = "0";
            // 
            // lblScoreIndicator
            // 
            this.lblScoreIndicator.AutoSize = true;
            this.lblScoreIndicator.Location = new System.Drawing.Point(33, 84);
            this.lblScoreIndicator.Name = "lblScoreIndicator";
            this.lblScoreIndicator.Size = new System.Drawing.Size(58, 16);
            this.lblScoreIndicator.TabIndex = 13;
            this.lblScoreIndicator.Text = "Indicator";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Location = new System.Drawing.Point(59, 384);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(32, 16);
            this.lblTimeLeft.TabIndex = 14;
            this.lblTimeLeft.Text = "time";
            // 
            // tmrTimeLeft
            // 
            this.tmrTimeLeft.Enabled = true;
            this.tmrTimeLeft.Interval = 1000;
            this.tmrTimeLeft.Tick += new System.EventHandler(this.tmrTimeLeft_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.lblScoreIndicator);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblScoreIndicator;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer tmrTimeLeft;
    }
}