namespace UnicomTICManagementSystem.Views
{
    partial class StudentForm
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
            this.label_form_title = new System.Windows.Forms.Label();
            this.textBox2_subname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_coursename2 = new System.Windows.Forms.Label();
            this.button2_delete = new System.Windows.Forms.Button();
            this.button2_edit = new System.Windows.Forms.Button();
            this.button2_add = new System.Windows.Forms.Button();
            this.dataGridView2_subject = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_subject)).BeginInit();
            this.SuspendLayout();
            // 
            // label_form_title
            // 
            this.label_form_title.AutoSize = true;
            this.label_form_title.BackColor = System.Drawing.Color.Honeydew;
            this.label_form_title.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_title.Location = new System.Drawing.Point(308, 9);
            this.label_form_title.Name = "label_form_title";
            this.label_form_title.Size = new System.Drawing.Size(255, 26);
            this.label_form_title.TabIndex = 1;
            this.label_form_title.Text = "Student Management";
            this.label_form_title.Click += new System.EventHandler(this.label_form_title_Click);
            // 
            // textBox2_subname
            // 
            this.textBox2_subname.Location = new System.Drawing.Point(282, 70);
            this.textBox2_subname.Name = "textBox2_subname";
            this.textBox2_subname.Size = new System.Drawing.Size(281, 22);
            this.textBox2_subname.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student_Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(282, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label_coursename2
            // 
            this.label_coursename2.AutoSize = true;
            this.label_coursename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coursename2.Location = new System.Drawing.Point(140, 109);
            this.label_coursename2.Name = "label_coursename2";
            this.label_coursename2.Size = new System.Drawing.Size(116, 20);
            this.label_coursename2.TabIndex = 9;
            this.label_coursename2.Text = "Course_Name";
            // 
            // button2_delete
            // 
            this.button2_delete.Location = new System.Drawing.Point(431, 158);
            this.button2_delete.Name = "button2_delete";
            this.button2_delete.Size = new System.Drawing.Size(75, 23);
            this.button2_delete.TabIndex = 15;
            this.button2_delete.Text = "DELETE";
            this.button2_delete.UseVisualStyleBackColor = true;
            // 
            // button2_edit
            // 
            this.button2_edit.Location = new System.Drawing.Point(313, 158);
            this.button2_edit.Name = "button2_edit";
            this.button2_edit.Size = new System.Drawing.Size(75, 23);
            this.button2_edit.TabIndex = 14;
            this.button2_edit.Text = "UPDATE";
            this.button2_edit.UseVisualStyleBackColor = true;
            // 
            // button2_add
            // 
            this.button2_add.Location = new System.Drawing.Point(195, 158);
            this.button2_add.Name = "button2_add";
            this.button2_add.Size = new System.Drawing.Size(75, 23);
            this.button2_add.TabIndex = 13;
            this.button2_add.Text = "ADD";
            this.button2_add.UseVisualStyleBackColor = true;
            // 
            // dataGridView2_subject
            // 
            this.dataGridView2_subject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_subject.Location = new System.Drawing.Point(134, 220);
            this.dataGridView2_subject.Name = "dataGridView2_subject";
            this.dataGridView2_subject.RowHeadersWidth = 51;
            this.dataGridView2_subject.RowTemplate.Height = 24;
            this.dataGridView2_subject.Size = new System.Drawing.Size(525, 176);
            this.dataGridView2_subject.TabIndex = 16;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 456);
            this.Controls.Add(this.dataGridView2_subject);
            this.Controls.Add(this.button2_delete);
            this.Controls.Add(this.button2_edit);
            this.Controls.Add(this.button2_add);
            this.Controls.Add(this.textBox2_subname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_coursename2);
            this.Controls.Add(this.label_form_title);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_subject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_form_title;
        private System.Windows.Forms.TextBox textBox2_subname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_coursename2;
        private System.Windows.Forms.Button button2_delete;
        private System.Windows.Forms.Button button2_edit;
        private System.Windows.Forms.Button button2_add;
        private System.Windows.Forms.DataGridView dataGridView2_subject;
    }
}