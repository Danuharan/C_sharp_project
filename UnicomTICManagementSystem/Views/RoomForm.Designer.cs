namespace UnicomTICManagementSystem.Views
{
    partial class RoomForm
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2_Room = new System.Windows.Forms.DataGridView();
            this.button2_edit = new System.Windows.Forms.Button();
            this.button2_add = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_coursename2 = new System.Windows.Forms.Label();
            this.label_form_title = new System.Windows.Forms.Label();
            this.button2_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Room)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(284, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 24);
            this.comboBox2.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Room_Type";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(460, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 37);
            this.button1.TabIndex = 47;
            this.button1.Text = "Back to DashBoard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2_Room
            // 
            this.dataGridView2_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_Room.Location = new System.Drawing.Point(97, 220);
            this.dataGridView2_Room.Name = "dataGridView2_Room";
            this.dataGridView2_Room.RowHeadersWidth = 51;
            this.dataGridView2_Room.RowTemplate.Height = 24;
            this.dataGridView2_Room.Size = new System.Drawing.Size(525, 176);
            this.dataGridView2_Room.TabIndex = 46;
            this.dataGridView2_Room.SelectionChanged += new System.EventHandler(this.dataGridView2_Room_SelectionChanged_1);
            // 
            // button2_edit
            // 
            this.button2_edit.Location = new System.Drawing.Point(312, 170);
            this.button2_edit.Name = "button2_edit";
            this.button2_edit.Size = new System.Drawing.Size(75, 23);
            this.button2_edit.TabIndex = 45;
            this.button2_edit.Text = "UPDATE";
            this.button2_edit.UseVisualStyleBackColor = true;
            this.button2_edit.Click += new System.EventHandler(this.button2_edit_Click_1);
            // 
            // button2_add
            // 
            this.button2_add.Location = new System.Drawing.Point(208, 170);
            this.button2_add.Name = "button2_add";
            this.button2_add.Size = new System.Drawing.Size(75, 23);
            this.button2_add.TabIndex = 44;
            this.button2_add.Text = "ADD";
            this.button2_add.UseVisualStyleBackColor = true;
            this.button2_add.Click += new System.EventHandler(this.button2_add_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 24);
            this.comboBox1.TabIndex = 42;
            // 
            // label_coursename2
            // 
            this.label_coursename2.AutoSize = true;
            this.label_coursename2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_coursename2.Location = new System.Drawing.Point(142, 71);
            this.label_coursename2.Name = "label_coursename2";
            this.label_coursename2.Size = new System.Drawing.Size(106, 20);
            this.label_coursename2.TabIndex = 40;
            this.label_coursename2.Text = "Room_Name";
            // 
            // label_form_title
            // 
            this.label_form_title.AutoSize = true;
            this.label_form_title.BackColor = System.Drawing.Color.Honeydew;
            this.label_form_title.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_title.Location = new System.Drawing.Point(261, 11);
            this.label_form_title.Name = "label_form_title";
            this.label_form_title.Size = new System.Drawing.Size(243, 26);
            this.label_form_title.TabIndex = 39;
            this.label_form_title.Text = "Rooms Management";
            // 
            // button2_delete
            // 
            this.button2_delete.Location = new System.Drawing.Point(413, 170);
            this.button2_delete.Name = "button2_delete";
            this.button2_delete.Size = new System.Drawing.Size(75, 23);
            this.button2_delete.TabIndex = 50;
            this.button2_delete.Text = "DELETE";
            this.button2_delete.UseVisualStyleBackColor = true;
            this.button2_delete.Click += new System.EventHandler(this.button2_delete_Click_1);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_delete);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2_Room);
            this.Controls.Add(this.button2_edit);
            this.Controls.Add(this.button2_add);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_coursename2);
            this.Controls.Add(this.label_form_title);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2_Room;
        private System.Windows.Forms.Button button2_edit;
        private System.Windows.Forms.Button button2_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_coursename2;
        private System.Windows.Forms.Label label_form_title;
        private System.Windows.Forms.Button button2_delete;
    }
}