namespace UnicomTICManagementSystem.Views
{
    partial class MarkForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2_exam_marks = new System.Windows.Forms.DataGridView();
            this.button2_edit = new System.Windows.Forms.Button();
            this.button2_add = new System.Windows.Forms.Button();
            this.textBox2_subname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_coursename2 = new System.Windows.Forms.Label();
            this.label_form_title = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_exam_marks)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Back to Exams Field";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2_exam_marks
            // 
            this.dataGridView2_exam_marks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_exam_marks.Location = new System.Drawing.Point(55, 231);
            this.dataGridView2_exam_marks.Name = "dataGridView2_exam_marks";
            this.dataGridView2_exam_marks.RowHeadersWidth = 51;
            this.dataGridView2_exam_marks.RowTemplate.Height = 24;
            this.dataGridView2_exam_marks.Size = new System.Drawing.Size(525, 176);
            this.dataGridView2_exam_marks.TabIndex = 35;
            this.dataGridView2_exam_marks.SelectionChanged += new System.EventHandler(this.dataGridView2_exam_marks_SelectionChanged_1);
            // 
            // button2_edit
            // 
            this.button2_edit.Location = new System.Drawing.Point(459, 191);
            this.button2_edit.Name = "button2_edit";
            this.button2_edit.Size = new System.Drawing.Size(75, 23);
            this.button2_edit.TabIndex = 33;
            this.button2_edit.Text = "UPDATE";
            this.button2_edit.UseVisualStyleBackColor = true;
            this.button2_edit.Click += new System.EventHandler(this.button2_edit_Click);
            // 
            // button2_add
            // 
            this.button2_add.Location = new System.Drawing.Point(234, 191);
            this.button2_add.Name = "button2_add";
            this.button2_add.Size = new System.Drawing.Size(75, 23);
            this.button2_add.TabIndex = 32;
            this.button2_add.Text = "ADD";
            this.button2_add.UseVisualStyleBackColor = true;
            this.button2_add.Click += new System.EventHandler(this.button2_add_Click);
            // 
            // textBox2_subname
            // 
            this.textBox2_subname.Location = new System.Drawing.Point(281, 152);
            this.textBox2_subname.Name = "textBox2_subname";
            this.textBox2_subname.Size = new System.Drawing.Size(56, 22);
            this.textBox2_subname.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Score";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // label_coursename2
            // 
            this.label_coursename2.AutoSize = true;
            this.label_coursename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coursename2.Location = new System.Drawing.Point(139, 61);
            this.label_coursename2.Name = "label_coursename2";
            this.label_coursename2.Size = new System.Drawing.Size(119, 20);
            this.label_coursename2.TabIndex = 28;
            this.label_coursename2.Text = "Student_Name";
            // 
            // label_form_title
            // 
            this.label_form_title.AutoSize = true;
            this.label_form_title.BackColor = System.Drawing.Color.Honeydew;
            this.label_form_title.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_title.Location = new System.Drawing.Point(243, 9);
            this.label_form_title.Name = "label_form_title";
            this.label_form_title.Size = new System.Drawing.Size(235, 26);
            this.label_form_title.TabIndex = 27;
            this.label_form_title.Text = "Marks Management";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(281, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 24);
            this.comboBox2.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Exam_Name";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(281, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(299, 24);
            this.comboBox3.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Subject_Name";
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2_exam_marks);
            this.Controls.Add(this.button2_edit);
            this.Controls.Add(this.button2_add);
            this.Controls.Add(this.textBox2_subname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_coursename2);
            this.Controls.Add(this.label_form_title);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_exam_marks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2_exam_marks;
        private System.Windows.Forms.Button button2_edit;
        private System.Windows.Forms.Button button2_add;
        private System.Windows.Forms.TextBox textBox2_subname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_coursename2;
        private System.Windows.Forms.Label label_form_title;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
    }
}