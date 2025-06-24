namespace UnicomTICManagementSystem.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_Dashboard_head = new System.Windows.Forms.Label();
            this.label_Rolebased_welcome = new System.Windows.Forms.Label();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DB_User = new System.Windows.Forms.Button();
            this.DB_view_timetable = new System.Windows.Forms.Button();
            this.DB_view_marks = new System.Windows.Forms.Button();
            this.button5_logout = new System.Windows.Forms.Button();
            this.DB_timetable = new System.Windows.Forms.Button();
            this.DB_exam_marks = new System.Windows.Forms.Button();
            this.DB_student = new System.Windows.Forms.Button();
            this.DB_course_sub = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Dashboard_head
            // 
            this.label_Dashboard_head.AutoSize = true;
            this.label_Dashboard_head.BackColor = System.Drawing.Color.Azure;
            this.label_Dashboard_head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Dashboard_head.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dashboard_head.Location = new System.Drawing.Point(43, 0);
            this.label_Dashboard_head.Name = "label_Dashboard_head";
            this.label_Dashboard_head.Size = new System.Drawing.Size(709, 37);
            this.label_Dashboard_head.TabIndex = 0;
            this.label_Dashboard_head.Text = "Unicom TIC Management System - Dashboard";
            // 
            // label_Rolebased_welcome
            // 
            this.label_Rolebased_welcome.AutoSize = true;
            this.label_Rolebased_welcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Rolebased_welcome.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rolebased_welcome.Location = new System.Drawing.Point(156, 54);
            this.label_Rolebased_welcome.Name = "label_Rolebased_welcome";
            this.label_Rolebased_welcome.Size = new System.Drawing.Size(81, 26);
            this.label_Rolebased_welcome.TabIndex = 1;
            this.label_Rolebased_welcome.Text = "label1";
            this.label_Rolebased_welcome.Click += new System.EventHandler(this.label_Rolebased_welcome_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Welcome.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.Location = new System.Drawing.Point(26, 54);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(124, 26);
            this.label_Welcome.TabIndex = 2;
            this.label_Welcome.Text = "Welcome,";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DB_User);
            this.panel1.Controls.Add(this.DB_view_timetable);
            this.panel1.Controls.Add(this.DB_view_marks);
            this.panel1.Controls.Add(this.button5_logout);
            this.panel1.Controls.Add(this.DB_timetable);
            this.panel1.Controls.Add(this.DB_exam_marks);
            this.panel1.Controls.Add(this.DB_student);
            this.panel1.Controls.Add(this.DB_course_sub);
            this.panel1.Location = new System.Drawing.Point(106, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 388);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DB_User
            // 
            this.DB_User.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DB_User.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_User.Location = new System.Drawing.Point(15, 19);
            this.DB_User.Name = "DB_User";
            this.DB_User.Size = new System.Drawing.Size(371, 34);
            this.DB_User.TabIndex = 7;
            this.DB_User.Text = "User Register Management";
            this.DB_User.UseVisualStyleBackColor = false;
            this.DB_User.Click += new System.EventHandler(this.DB_User_Click);
            // 
            // DB_view_timetable
            // 
            this.DB_view_timetable.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DB_view_timetable.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_view_timetable.Location = new System.Drawing.Point(17, 124);
            this.DB_view_timetable.Name = "DB_view_timetable";
            this.DB_view_timetable.Size = new System.Drawing.Size(371, 36);
            this.DB_view_timetable.TabIndex = 6;
            this.DB_view_timetable.Text = "View My Timetable";
            this.DB_view_timetable.UseVisualStyleBackColor = false;
            // 
            // DB_view_marks
            // 
            this.DB_view_marks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DB_view_marks.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_view_marks.Location = new System.Drawing.Point(17, 267);
            this.DB_view_marks.Name = "DB_view_marks";
            this.DB_view_marks.Size = new System.Drawing.Size(371, 31);
            this.DB_view_marks.TabIndex = 5;
            this.DB_view_marks.Text = "View My Marks";
            this.DB_view_marks.UseVisualStyleBackColor = false;
            // 
            // button5_logout
            // 
            this.button5_logout.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_logout.Location = new System.Drawing.Point(478, 318);
            this.button5_logout.Name = "button5_logout";
            this.button5_logout.Size = new System.Drawing.Size(107, 36);
            this.button5_logout.TabIndex = 4;
            this.button5_logout.Text = "Logout";
            this.button5_logout.UseVisualStyleBackColor = true;
            this.button5_logout.Click += new System.EventHandler(this.button5_logout_Click);
            // 
            // DB_timetable
            // 
            this.DB_timetable.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DB_timetable.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_timetable.Location = new System.Drawing.Point(15, 215);
            this.DB_timetable.Name = "DB_timetable";
            this.DB_timetable.Size = new System.Drawing.Size(373, 35);
            this.DB_timetable.TabIndex = 3;
            this.DB_timetable.Text = "Timetable Management";
            this.DB_timetable.UseVisualStyleBackColor = false;
            this.DB_timetable.Click += new System.EventHandler(this.DB_timetable_Click);
            // 
            // DB_exam_marks
            // 
            this.DB_exam_marks.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DB_exam_marks.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_exam_marks.Location = new System.Drawing.Point(17, 175);
            this.DB_exam_marks.Name = "DB_exam_marks";
            this.DB_exam_marks.Size = new System.Drawing.Size(371, 31);
            this.DB_exam_marks.TabIndex = 2;
            this.DB_exam_marks.Text = "Exam and Marks Management";
            this.DB_exam_marks.UseVisualStyleBackColor = false;
            this.DB_exam_marks.Click += new System.EventHandler(this.DB_exam_marks_Click);
            // 
            // DB_student
            // 
            this.DB_student.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DB_student.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_student.Location = new System.Drawing.Point(17, 320);
            this.DB_student.Name = "DB_student";
            this.DB_student.Size = new System.Drawing.Size(371, 34);
            this.DB_student.TabIndex = 1;
            this.DB_student.Text = "Student Management";
            this.DB_student.UseVisualStyleBackColor = false;
            this.DB_student.Click += new System.EventHandler(this.DB_student_Click);
            // 
            // DB_course_sub
            // 
            this.DB_course_sub.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DB_course_sub.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_course_sub.Location = new System.Drawing.Point(17, 75);
            this.DB_course_sub.Name = "DB_course_sub";
            this.DB_course_sub.Size = new System.Drawing.Size(371, 33);
            this.DB_course_sub.TabIndex = 0;
            this.DB_course_sub.Text = "Course and Subject Management";
            this.DB_course_sub.UseVisualStyleBackColor = false;
            this.DB_course_sub.VisibleChanged += new System.EventHandler(this.DB_course_sub_VisibleChanged);
            this.DB_course_sub.Click += new System.EventHandler(this.DB_course_sub_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.label_Rolebased_welcome);
            this.Controls.Add(this.label_Dashboard_head);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Dashboard_head;
        private System.Windows.Forms.Label label_Rolebased_welcome;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5_logout;
        private System.Windows.Forms.Button DB_timetable;
        private System.Windows.Forms.Button DB_exam_marks;
        private System.Windows.Forms.Button DB_student;
        private System.Windows.Forms.Button DB_course_sub;
        private System.Windows.Forms.Button DB_view_timetable;
        private System.Windows.Forms.Button DB_view_marks;
        private System.Windows.Forms.Button DB_User;
    }
}