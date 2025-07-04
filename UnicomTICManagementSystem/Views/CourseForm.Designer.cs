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
            this.dataGridView1_course = new System.Windows.Forms.DataGridView();
            this.button1_delete = new System.Windows.Forms.Button();
            this.button1_edit = new System.Windows.Forms.Button();
            this.button1_add = new System.Windows.Forms.Button();
            this.textBox_course = new System.Windows.Forms.TextBox();
            this.label_coursename = new System.Windows.Forms.Label();
            this.label_form_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2_subname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2_subject = new System.Windows.Forms.DataGridView();
            this.button2_delete = new System.Windows.Forms.Button();
            this.button2_edit = new System.Windows.Forms.Button();
            this.button2_add = new System.Windows.Forms.Button();
            this.label_coursename2 = new System.Windows.Forms.Label();
            this.label_Rolebased_welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_course)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_subject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1_course);
            this.panel1.Controls.Add(this.button1_delete);
            this.panel1.Controls.Add(this.button1_edit);
            this.panel1.Controls.Add(this.button1_add);
            this.panel1.Controls.Add(this.textBox_course);
            this.panel1.Controls.Add(this.label_coursename);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 470);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1_course
            // 
            this.dataGridView1_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_course.Location = new System.Drawing.Point(22, 175);
            this.dataGridView1_course.Name = "dataGridView1_course";
            this.dataGridView1_course.RowHeadersWidth = 51;
            this.dataGridView1_course.RowTemplate.Height = 24;
            this.dataGridView1_course.Size = new System.Drawing.Size(464, 259);
            this.dataGridView1_course.TabIndex = 6;
            this.dataGridView1_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_course_CellContentClick);
            this.dataGridView1_course.SelectionChanged += new System.EventHandler(this.dataGridView1_course_SelectionChanged);
            // 
            // button1_delete
            // 
            this.button1_delete.Location = new System.Drawing.Point(311, 67);
            this.button1_delete.Name = "button1_delete";
            this.button1_delete.Size = new System.Drawing.Size(75, 23);
            this.button1_delete.TabIndex = 5;
            this.button1_delete.Text = "DELETE";
            this.button1_delete.UseVisualStyleBackColor = true;
            this.button1_delete.Click += new System.EventHandler(this.button1_delete_Click);
            // 
            // button1_edit
            // 
            this.button1_edit.Location = new System.Drawing.Point(187, 67);
            this.button1_edit.Name = "button1_edit";
            this.button1_edit.Size = new System.Drawing.Size(75, 23);
            this.button1_edit.TabIndex = 4;
            this.button1_edit.Text = "UPDATE";
            this.button1_edit.UseVisualStyleBackColor = true;
            this.button1_edit.Click += new System.EventHandler(this.button1_edit_Click);
            // 
            // button1_add
            // 
            this.button1_add.Location = new System.Drawing.Point(61, 67);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(75, 23);
            this.button1_add.TabIndex = 3;
            this.button1_add.Text = "ADD";
            this.button1_add.UseVisualStyleBackColor = true;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // textBox_course
            // 
            this.textBox_course.Location = new System.Drawing.Point(187, 29);
            this.textBox_course.Name = "textBox_course";
            this.textBox_course.Size = new System.Drawing.Size(281, 22);
            this.textBox_course.TabIndex = 2;
            // 
            // label_coursename
            // 
            this.label_coursename.AutoSize = true;
            this.label_coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coursename.Location = new System.Drawing.Point(45, 31);
            this.label_coursename.Name = "label_coursename";
            this.label_coursename.Size = new System.Drawing.Size(116, 20);
            this.label_coursename.TabIndex = 1;
            this.label_coursename.Text = "Course_Name";
            // 
            // label_form_title
            // 
            this.label_form_title.AutoSize = true;
            this.label_form_title.BackColor = System.Drawing.Color.Honeydew;
            this.label_form_title.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_title.Location = new System.Drawing.Point(345, 9);
            this.label_form_title.Name = "label_form_title";
            this.label_form_title.Size = new System.Drawing.Size(389, 26);
            this.label_form_title.TabIndex = 0;
            this.label_form_title.Text = "Course and Subject Management";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox2_subname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dataGridView2_subject);
            this.panel2.Controls.Add(this.button2_delete);
            this.panel2.Controls.Add(this.button2_edit);
            this.panel2.Controls.Add(this.button2_add);
            this.panel2.Controls.Add(this.label_coursename2);
            this.panel2.Location = new System.Drawing.Point(528, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(510, 470);
            this.panel2.TabIndex = 7;
            // 
            // textBox2_subname
            // 
            this.textBox2_subname.Location = new System.Drawing.Point(187, 80);
            this.textBox2_subname.Name = "textBox2_subname";
            this.textBox2_subname.Size = new System.Drawing.Size(281, 22);
            this.textBox2_subname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Subject_Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // dataGridView2_subject
            // 
            this.dataGridView2_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_subject.Location = new System.Drawing.Point(22, 175);
            this.dataGridView2_subject.Name = "dataGridView2_subject";
            this.dataGridView2_subject.RowHeadersWidth = 51;
            this.dataGridView2_subject.RowTemplate.Height = 24;
            this.dataGridView2_subject.Size = new System.Drawing.Size(464, 259);
            this.dataGridView2_subject.TabIndex = 6;
            this.dataGridView2_subject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_subject_CellContentClick);
            this.dataGridView2_subject.SelectionChanged += new System.EventHandler(this.dataGridView2_subject_SelectionChanged);
            // 
            // button2_delete
            // 
            this.button2_delete.Location = new System.Drawing.Point(336, 136);
            this.button2_delete.Name = "button2_delete";
            this.button2_delete.Size = new System.Drawing.Size(75, 23);
            this.button2_delete.TabIndex = 5;
            this.button2_delete.Text = "DELETE";
            this.button2_delete.UseVisualStyleBackColor = true;
            this.button2_delete.Click += new System.EventHandler(this.button2_delete_Click);
            // 
            // button2_edit
            // 
            this.button2_edit.Location = new System.Drawing.Point(212, 136);
            this.button2_edit.Name = "button2_edit";
            this.button2_edit.Size = new System.Drawing.Size(75, 23);
            this.button2_edit.TabIndex = 4;
            this.button2_edit.Text = "UPDATE";
            this.button2_edit.UseVisualStyleBackColor = true;
            this.button2_edit.Click += new System.EventHandler(this.button2_edit_Click);
            // 
            // button2_add
            // 
            this.button2_add.Location = new System.Drawing.Point(86, 136);
            this.button2_add.Name = "button2_add";
            this.button2_add.Size = new System.Drawing.Size(75, 23);
            this.button2_add.TabIndex = 3;
            this.button2_add.Text = "ADD";
            this.button2_add.UseVisualStyleBackColor = true;
            this.button2_add.Click += new System.EventHandler(this.button2_add_Click);
            // 
            // label_coursename2
            // 
            this.label_coursename2.AutoSize = true;
            this.label_coursename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coursename2.Location = new System.Drawing.Point(45, 31);
            this.label_coursename2.Name = "label_coursename2";
            this.label_coursename2.Size = new System.Drawing.Size(116, 20);
            this.label_coursename2.TabIndex = 1;
            this.label_coursename2.Text = "Course_Name";
            // 
            // label_Rolebased_welcome
            // 
            this.label_Rolebased_welcome.AutoSize = true;
            this.label_Rolebased_welcome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_Rolebased_welcome.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rolebased_welcome.Location = new System.Drawing.Point(12, 10);
            this.label_Rolebased_welcome.Name = "label_Rolebased_welcome";
            this.label_Rolebased_welcome.Size = new System.Drawing.Size(81, 26);
            this.label_Rolebased_welcome.TabIndex = 8;
            this.label_Rolebased_welcome.Text = "label1";
            this.label_Rolebased_welcome.Click += new System.EventHandler(this.label_Rolebased_welcome_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(926, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back to Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Rolebased_welcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_form_title);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_course)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_subject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_form_title;
        private System.Windows.Forms.TextBox textBox_course;
        private System.Windows.Forms.Label label_coursename;
        private System.Windows.Forms.Button button1_delete;
        private System.Windows.Forms.Button button1_edit;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.DataGridView dataGridView1_course;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2_subject;
        private System.Windows.Forms.Button button2_delete;
        private System.Windows.Forms.Button button2_edit;
        private System.Windows.Forms.Button button2_add;
        private System.Windows.Forms.Label label_coursename2;
        private System.Windows.Forms.TextBox textBox2_subname;
        private System.Windows.Forms.Label label_Rolebased_welcome;
        private System.Windows.Forms.Button button1;
    }
}