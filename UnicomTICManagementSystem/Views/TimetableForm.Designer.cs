namespace UnicomTICManagementSystem.Views
{
    partial class TimetableForm
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
            this.dataGridView2_TimeTable = new System.Windows.Forms.DataGridView();
            this.button2_delete = new System.Windows.Forms.Button();
            this.button2_edit = new System.Windows.Forms.Button();
            this.button2_add = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_coursename2 = new System.Windows.Forms.Label();
            this.label_form_title = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_TimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Back to DashBoard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2_TimeTable
            // 
            this.dataGridView2_TimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_TimeTable.Location = new System.Drawing.Point(88, 214);
            this.dataGridView2_TimeTable.Name = "dataGridView2_TimeTable";
            this.dataGridView2_TimeTable.RowHeadersWidth = 51;
            this.dataGridView2_TimeTable.RowTemplate.Height = 24;
            this.dataGridView2_TimeTable.Size = new System.Drawing.Size(525, 176);
            this.dataGridView2_TimeTable.TabIndex = 35;
            // 
            // button2_delete
            // 
            this.button2_delete.Location = new System.Drawing.Point(448, 176);
            this.button2_delete.Name = "button2_delete";
            this.button2_delete.Size = new System.Drawing.Size(75, 23);
            this.button2_delete.TabIndex = 34;
            this.button2_delete.Text = "DELETE";
            this.button2_delete.UseVisualStyleBackColor = true;
            // 
            // button2_edit
            // 
            this.button2_edit.Location = new System.Drawing.Point(330, 176);
            this.button2_edit.Name = "button2_edit";
            this.button2_edit.Size = new System.Drawing.Size(75, 23);
            this.button2_edit.TabIndex = 33;
            this.button2_edit.Text = "UPDATE";
            this.button2_edit.UseVisualStyleBackColor = true;
            // 
            // button2_add
            // 
            this.button2_add.Location = new System.Drawing.Point(212, 176);
            this.button2_add.Name = "button2_add";
            this.button2_add.Size = new System.Drawing.Size(75, 23);
            this.button2_add.TabIndex = 32;
            this.button2_add.Text = "ADD";
            this.button2_add.UseVisualStyleBackColor = true;
            this.button2_add.Click += new System.EventHandler(this.button2_add_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // label_coursename2
            // 
            this.label_coursename2.AutoSize = true;
            this.label_coursename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coursename2.Location = new System.Drawing.Point(139, 66);
            this.label_coursename2.Name = "label_coursename2";
            this.label_coursename2.Size = new System.Drawing.Size(118, 20);
            this.label_coursename2.TabIndex = 28;
            this.label_coursename2.Text = "Subject_Name";
            // 
            // label_form_title
            // 
            this.label_form_title.AutoSize = true;
            this.label_form_title.BackColor = System.Drawing.Color.Honeydew;
            this.label_form_title.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_title.Location = new System.Drawing.Point(258, 17);
            this.label_form_title.Name = "label_form_title";
            this.label_form_title.Size = new System.Drawing.Size(289, 26);
            this.label_form_title.TabIndex = 27;
            this.label_form_title.Text = "TimeTable Management";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(281, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 24);
            this.comboBox2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Room_Name";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(281, 129);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(299, 24);
            this.comboBox3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Time-Slot";
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2_TimeTable);
            this.Controls.Add(this.button2_delete);
            this.Controls.Add(this.button2_edit);
            this.Controls.Add(this.button2_add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_coursename2);
            this.Controls.Add(this.label_form_title);
            this.Name = "TimetableForm";
            this.Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_TimeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2_TimeTable;
        private System.Windows.Forms.Button button2_delete;
        private System.Windows.Forms.Button button2_edit;
        private System.Windows.Forms.Button button2_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_coursename2;
        private System.Windows.Forms.Label label_form_title;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
    }
}