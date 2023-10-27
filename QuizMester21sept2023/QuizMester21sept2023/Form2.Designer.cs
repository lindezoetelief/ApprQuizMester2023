namespace QuizMester21sept2023
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegisterText = new System.Windows.Forms.Label();
            this.tbxUsernameRegister = new System.Windows.Forms.TextBox();
            this.tbxPasswordRegister = new System.Windows.Forms.TextBox();
            this.lblUsernameRegister = new System.Windows.Forms.Label();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 446);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRegisterText
            // 
            this.lblRegisterText.AutoSize = true;
            this.lblRegisterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterText.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblRegisterText.Location = new System.Drawing.Point(462, 75);
            this.lblRegisterText.Name = "lblRegisterText";
            this.lblRegisterText.Size = new System.Drawing.Size(198, 54);
            this.lblRegisterText.TabIndex = 1;
            this.lblRegisterText.Text = "Register";
            // 
            // tbxUsernameRegister
            // 
            this.tbxUsernameRegister.BackColor = System.Drawing.Color.Ivory;
            this.tbxUsernameRegister.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxUsernameRegister.Location = new System.Drawing.Point(471, 178);
            this.tbxUsernameRegister.Name = "tbxUsernameRegister";
            this.tbxUsernameRegister.Size = new System.Drawing.Size(174, 22);
            this.tbxUsernameRegister.TabIndex = 2;
            // 
            // tbxPasswordRegister
            // 
            this.tbxPasswordRegister.BackColor = System.Drawing.Color.Ivory;
            this.tbxPasswordRegister.Location = new System.Drawing.Point(471, 253);
            this.tbxPasswordRegister.Name = "tbxPasswordRegister";
            this.tbxPasswordRegister.Size = new System.Drawing.Size(174, 22);
            this.tbxPasswordRegister.TabIndex = 3;
            // 
            // lblUsernameRegister
            // 
            this.lblUsernameRegister.AutoSize = true;
            this.lblUsernameRegister.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameRegister.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblUsernameRegister.Location = new System.Drawing.Point(466, 146);
            this.lblUsernameRegister.Name = "lblUsernameRegister";
            this.lblUsernameRegister.Size = new System.Drawing.Size(121, 29);
            this.lblUsernameRegister.TabIndex = 4;
            this.lblUsernameRegister.Text = "Username: ";
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Font = new System.Drawing.Font("Bradley Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRegister.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPasswordRegister.Location = new System.Drawing.Point(466, 221);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(109, 29);
            this.lblPasswordRegister.TabIndex = 5;
            this.lblPasswordRegister.Text = "Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Ivory;
            this.btnRegister.Location = new System.Drawing.Point(471, 310);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(154, 39);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.BackColor = System.Drawing.Color.Ivory;
            this.lblLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginText.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLoginText.Location = new System.Drawing.Point(467, 367);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(201, 20);
            this.lblLoginText.TabIndex = 8;
            this.lblLoginText.Text = "Already have an account?";
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToLogin.FlatAppearance.BorderSize = 0;
            this.btnGoToLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoToLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGoToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToLogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGoToLogin.Location = new System.Drawing.Point(447, 387);
            this.btnGoToLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(128, 37);
            this.btnGoToLogin.TabIndex = 9;
            this.btnGoToLogin.Text = "Login";
            this.btnGoToLogin.UseVisualStyleBackColor = false;
            this.btnGoToLogin.Click += new System.EventHandler(this.btnGoToLogin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.lblLoginText);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPasswordRegister);
            this.Controls.Add(this.lblUsernameRegister);
            this.Controls.Add(this.tbxPasswordRegister);
            this.Controls.Add(this.tbxUsernameRegister);
            this.Controls.Add(this.lblRegisterText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegisterText;
        private System.Windows.Forms.TextBox tbxUsernameRegister;
        private System.Windows.Forms.TextBox tbxPasswordRegister;
        private System.Windows.Forms.Label lblUsernameRegister;
        private System.Windows.Forms.Label lblPasswordRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLoginText;
        private System.Windows.Forms.Button btnGoToLogin;
    }
}