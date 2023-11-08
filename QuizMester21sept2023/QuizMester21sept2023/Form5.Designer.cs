namespace QuizMester21sept2023
{
    partial class Form5
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
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lblTimeCounter = new System.Windows.Forms.Label();
            this.lblTimeIndicator = new System.Windows.Forms.Label();
            this.tmrTimeCounter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Bradley Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuestion.Location = new System.Drawing.Point(230, 144);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(377, 41);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "Question is displayed here";
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerA.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerA.Location = new System.Drawing.Point(133, 228);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerA.TabIndex = 9;
            this.btnAnswerA.Text = "Answer A";
            this.btnAnswerA.UseVisualStyleBackColor = false;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerC.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerC.Location = new System.Drawing.Point(133, 312);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerC.TabIndex = 11;
            this.btnAnswerC.Text = "Answer C";
            this.btnAnswerC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnswerC.UseVisualStyleBackColor = false;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerB.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerB.Location = new System.Drawing.Point(404, 228);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerB.TabIndex = 12;
            this.btnAnswerB.Text = "Answer B";
            this.btnAnswerB.UseVisualStyleBackColor = false;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerD.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnswerD.Location = new System.Drawing.Point(404, 312);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(203, 39);
            this.btnAnswerD.TabIndex = 13;
            this.btnAnswerD.Text = "Answer D";
            this.btnAnswerD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnswerD.UseVisualStyleBackColor = false;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // lblTimeCounter
            // 
            this.lblTimeCounter.AutoSize = true;
            this.lblTimeCounter.Location = new System.Drawing.Point(70, 74);
            this.lblTimeCounter.Name = "lblTimeCounter";
            this.lblTimeCounter.Size = new System.Drawing.Size(32, 16);
            this.lblTimeCounter.TabIndex = 15;
            this.lblTimeCounter.Text = "time";
            // 
            // lblTimeIndicator
            // 
            this.lblTimeIndicator.AutoSize = true;
            this.lblTimeIndicator.Location = new System.Drawing.Point(44, 106);
            this.lblTimeIndicator.Name = "lblTimeIndicator";
            this.lblTimeIndicator.Size = new System.Drawing.Size(58, 16);
            this.lblTimeIndicator.TabIndex = 16;
            this.lblTimeIndicator.Text = "Indicator";
            // 
            // tmrTimeCounter
            // 
            this.tmrTimeCounter.Interval = 1000;
            this.tmrTimeCounter.Tick += new System.EventHandler(this.tmrTimeCounter_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeIndicator);
            this.Controls.Add(this.lblTimeCounter);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.Label lblTimeCounter;
        private System.Windows.Forms.Label lblTimeIndicator;
        private System.Windows.Forms.Timer tmrTimeCounter;
    }
}