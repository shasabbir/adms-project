
namespace ADMS_Project
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clinic Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.loginPasswordTextBox);
            this.loginGroupBox.Controls.Add(this.loginPasswordLabel);
            this.loginGroupBox.Controls.Add(this.loginUsernameTextBox);
            this.loginGroupBox.Controls.Add(this.loginUsernameLabel);
            this.loginGroupBox.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginGroupBox.Location = new System.Drawing.Point(70, 98);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(404, 256);
            this.loginGroupBox.TabIndex = 2;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "User Login";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightCyan;
            this.loginButton.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(192, 177);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 41);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(157, 111);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(187, 35);
            this.loginPasswordTextBox.TabIndex = 3;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordLabel.Location = new System.Drawing.Point(46, 118);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(85, 23);
            this.loginPasswordLabel.TabIndex = 2;
            this.loginPasswordLabel.Text = "Password";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Location = new System.Drawing.Point(157, 55);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(187, 35);
            this.loginUsernameTextBox.TabIndex = 1;
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsernameLabel.Location = new System.Drawing.Point(44, 62);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(87, 23);
            this.loginUsernameLabel.TabIndex = 0;
            this.loginUsernameLabel.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.Label loginUsernameLabel;
    }
}

