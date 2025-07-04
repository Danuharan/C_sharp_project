namespace UnicomTICManagementSystem.Views
{
    partial class ExamForm
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
            this.dataGridView2_exam_marks = new System.Windows.Forms.DataGridView();
            this.button2_edit = new System.Windows.Forms.Button();
            this.button2_add = new System.Windows.Forms.Button();
            this.textBox2_examname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_coursename2 = new System.Windows.Forms.Label();
            this.label_form_title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_exam_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2_exam_marks
            // 
            this.dataGridView2_exam_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_exam_marks.Location = new System.Drawing.Point(75, 219);
            this.dataGridView2_exam_marks.Name = "dataGridView2_exam_marks";
            this.dataGridView2_exam_marks.RowHeadersWidth = 51;
            this.dataGridView2_exam_marks.RowTemplate.Height = 24;
            this.dataGridView2_exam_marks.Size = new System.Drawing.Size(525, 176);
            this.dataGridView2_exam_marks.TabIndex = 25;
            this.dataGridView2_exam_marks.SelectionChanged += new System.EventHandler(this.dataGridView2_exam_marks_SelectionChanged);
            // 
            // button2_edit
            // 
            this.button2_edit.Location = new System.Drawing.Point(447, 181);
            this.button2_edit.Name = "button2_edit";
            this.button2_edit.Size = new System.Drawing.Size(75, 23);
            this.button2_edit.TabIndex = 23;
            this.button2_edit.Text = "UPDATE";
            this.button2_edit.UseVisualStyleBackColor = true;
            this.button2_edit.Click += new System.EventHandler(this.button2_edit_Click);
            // 
            // button2_add
            // 
            this.button2_add.Location = new System.Drawing.Point(311, 181);
            this.button2_add.Name = "button2_add";
            this.button2_add.Size = new System.Drawing.Size(75, 23);
            this.button2_add.TabIndex = 22;
            this.button2_add.Text = "ADD";
            this.button2_add.UseVisualStyleBackColor = true;
            this.button2_add.Click += new System.EventHandler(this.button2_add_Click);
            // 
            // textBox2_examname
            // 
            this.textBox2_examname.Location = new System.Drawing.Point(286, 93);
            this.textBox2_examname.Name = "textBox2_examname";
            this.textBox2_examname.Size = new System.Drawing.Size(281, 22);
            this.textBox2_examname.TabIndex = 19;
            this.textBox2_examname.TextChanged += new System.EventHandler(this.textBox2_examname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Exam_Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(286, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // label_coursename2
            // 
            this.label_coursename2.AutoSize = true;
            this.label_coursename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coursename2.Location = new System.Drawing.Point(144, 132);
            this.label_coursename2.Name = "label_coursename2";
            this.label_coursename2.Size = new System.Drawing.Size(118, 20);
            this.label_coursename2.TabIndex = 18;
            this.label_coursename2.Text = "Subject_Name";
            // 
            // label_form_title
            // 
            this.label_form_title.AutoSize = true;
            this.label_form_title.BackColor = System.Drawing.Color.Honeydew;
            this.label_form_title.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_title.Location = new System.Drawing.Point(245, 22);
            this.label_form_title.Name = "label_form_title";
            this.label_form_title.Size = new System.Drawing.Size(355, 26);
            this.label_form_title.TabIndex = 17;
            this.label_form_title.Text = "Exam and Marks Management";
            this.label_form_title.Click += new System.EventHandler(this.label_form_title_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 37);
            this.button1.TabIndex = 26;
            this.button1.Text = "Click here To Marks ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(620, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 48);
            this.button2.TabIndex = 27;
            this.button2.Text = "Back to DashBoard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2_exam_marks);
            this.Controls.Add(this.button2_edit);
            this.Controls.Add(this.button2_add);
            this.Controls.Add(this.textBox2_examname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_coursename2);
            this.Controls.Add(this.label_form_title);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_exam_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2_exam_marks;
        private System.Windows.Forms.Button button2_edit;
        private System.Windows.Forms.Button button2_add;
        private System.Windows.Forms.TextBox textBox2_examname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_coursename2;
        private System.Windows.Forms.Label label_form_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}