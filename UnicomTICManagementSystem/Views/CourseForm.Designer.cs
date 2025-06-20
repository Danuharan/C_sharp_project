namespace UnicomTICManagementSystem.Views
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_form_title = new System.Windows.Forms.Label();
            this.label_coursename = new System.Windows.Forms.Label();
            this.textBox_course = new System.Windows.Forms.TextBox();
            this.button1_add = new System.Windows.Forms.Button();
            this.button2_edit = new System.Windows.Forms.Button();
            this.button3_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button3_delete);
            this.panel1.Controls.Add(this.button2_edit);
            this.panel1.Controls.Add(this.button1_add);
            this.panel1.Controls.Add(this.textBox_course);
            this.panel1.Controls.Add(this.label_coursename);
            this.panel1.Controls.Add(this.label_form_title);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 426);
            this.panel1.TabIndex = 0;
            // 
            // label_form_title
            // 
            this.label_form_title.AutoSize = true;
            this.label_form_title.BackColor = System.Drawing.Color.Honeydew;
            this.label_form_title.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_title.Location = new System.Drawing.Point(155, 0);
            this.label_form_title.Name = "label_form_title";
            this.label_form_title.Size = new System.Drawing.Size(389, 26);
            this.label_form_title.TabIndex = 0;
            this.label_form_title.Text = "Course and Subject Management";
            // 
            // label_coursename
            // 
            this.label_coursename.AutoSize = true;
            this.label_coursename.Location = new System.Drawing.Point(68, 73);
            this.label_coursename.Name = "label_coursename";
            this.label_coursename.Size = new System.Drawing.Size(94, 16);
            this.label_coursename.TabIndex = 1;
            this.label_coursename.Text = "Course_Name";
            // 
            // textBox_course
            // 
            this.textBox_course.Location = new System.Drawing.Point(212, 67);
            this.textBox_course.Name = "textBox_course";
            this.textBox_course.Size = new System.Drawing.Size(100, 22);
            this.textBox_course.TabIndex = 2;
            // 
            // button1_add
            // 
            this.button1_add.Location = new System.Drawing.Point(86, 126);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(75, 23);
            this.button1_add.TabIndex = 3;
            this.button1_add.Text = "ADD";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // button2_edit
            // 
            this.button2_edit.Location = new System.Drawing.Point(212, 126);
            this.button2_edit.Name = "button2_edit";
            this.button2_edit.Size = new System.Drawing.Size(75, 23);
            this.button2_edit.TabIndex = 4;
            this.button2_edit.Text = "EDIT";
            this.button2_edit.UseVisualStyleBackColor = true;
            // 
            // button3_delete
            // 
            this.button3_delete.Location = new System.Drawing.Point(336, 126);
            this.button3_delete.Name = "button3_delete";
            this.button3_delete.Size = new System.Drawing.Size(75, 23);
            this.button3_delete.TabIndex = 5;
            this.button3_delete.Text = "DELETE";
            this.button3_delete.UseVisualStyleBackColor = true;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_form_title;
        private System.Windows.Forms.TextBox textBox_course;
        private System.Windows.Forms.Label label_coursename;
        private System.Windows.Forms.Button button3_delete;
        private System.Windows.Forms.Button button2_edit;
        private System.Windows.Forms.Button button1_add;
    }
}