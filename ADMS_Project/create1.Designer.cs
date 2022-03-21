
namespace ADMS_Project
{
    partial class create1
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
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbCId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbCNameEdit = new System.Windows.Forms.TextBox();
            this.tbCCodeEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCourses = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCName = new System.Windows.Forms.TextBox();
            this.tbCCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 43);
            this.label7.TabIndex = 36;
            this.label7.Text = "Admin page";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(72, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Delete);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(326, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SearchCourse);
            // 
            // tbCId
            // 
            this.tbCId.Location = new System.Drawing.Point(125, 186);
            this.tbCId.Name = "tbCId";
            this.tbCId.Size = new System.Drawing.Size(175, 20);
            this.tbCId.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Course Id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.UpdateCourse);
            // 
            // tbCNameEdit
            // 
            this.tbCNameEdit.Location = new System.Drawing.Point(128, 249);
            this.tbCNameEdit.Name = "tbCNameEdit";
            this.tbCNameEdit.Size = new System.Drawing.Size(175, 20);
            this.tbCNameEdit.TabIndex = 30;
            // 
            // tbCCodeEdit
            // 
            this.tbCCodeEdit.Location = new System.Drawing.Point(128, 218);
            this.tbCCodeEdit.Name = "tbCCodeEdit";
            this.tbCCodeEdit.Size = new System.Drawing.Size(175, 20);
            this.tbCCodeEdit.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Course Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Course Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Edit Courses";
            // 
            // dtCourses
            // 
            this.dtCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCourses.Location = new System.Drawing.Point(459, 18);
            this.dtCourses.Name = "dtCourses";
            this.dtCourses.Size = new System.Drawing.Size(299, 385);
            this.dtCourses.TabIndex = 25;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(72, 84);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load Course";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddCourse);
            // 
            // tbCName
            // 
            this.tbCName.Location = new System.Drawing.Point(128, 58);
            this.tbCName.Name = "tbCName";
            this.tbCName.Size = new System.Drawing.Size(175, 20);
            this.tbCName.TabIndex = 22;
            // 
            // tbCCode
            // 
            this.tbCCode.Location = new System.Drawing.Point(128, 27);
            this.tbCCode.Name = "tbCCode";
            this.tbCCode.Size = new System.Drawing.Size(175, 20);
            this.tbCCode.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Course Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Course Code";
            // 
            // create1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbCId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbCNameEdit);
            this.Controls.Add(this.tbCCodeEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtCourses);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCName);
            this.Controls.Add(this.tbCCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "create1";
            this.Text = "create1";
            ((System.ComponentModel.ISupportInitialize)(this.dtCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbCId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbCNameEdit;
        private System.Windows.Forms.TextBox tbCCodeEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtCourses;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCName;
        private System.Windows.Forms.TextBox tbCCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}