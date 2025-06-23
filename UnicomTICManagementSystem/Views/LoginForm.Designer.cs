namespace UnicomTICManagementSystem.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDummy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tUsername
            // 
            this.tUsername.BackColor = System.Drawing.Color.Azure;
            this.tUsername.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUsername.Location = new System.Drawing.Point(82, 88);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(214, 31);
            this.tUsername.TabIndex = 3;
            this.tUsername.Text = "Username";
            this.tUsername.Click += new System.EventHandler(this.tUsername_Click);
            this.tUsername.TextChanged += new System.EventHandler(this.tUsername_TextChanged);
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.Color.Azure;
            this.tPassword.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.Location = new System.Drawing.Point(82, 154);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(214, 31);
            this.tPassword.TabIndex = 4;
            this.tPassword.Text = "Password";
            this.tPassword.Click += new System.EventHandler(this.tPassword_Click);
            this.tPassword.TextChanged += new System.EventHandler(this.tPassword_TextChanged);
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.BackColor = System.Drawing.Color.Azure;
            this.comboBox_Role.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Location = new System.Drawing.Point(82, 220);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(214, 31);
            this.comboBox_Role.TabIndex = 5;
            this.comboBox_Role.Text = "Role";
            this.comboBox_Role.SelectedIndexChanged += new System.EventHandler(this.comboBox_Role_SelectedIndexChanged);
            this.comboBox_Role.Click += new System.EventHandler(this.comboBox_Role_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.button_Login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tUsername);
            this.panel1.Controls.Add(this.comboBox_Role);
            this.panel1.Controls.Add(this.tPassword);
            this.panel1.Location = new System.Drawing.Point(41, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 319);
            this.panel1.TabIndex = 6;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_Login.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.Location = new System.Drawing.Point(124, 274);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(110, 34);
            this.button_Login.TabIndex = 13;
            this.button_Login.Text = "LOG IN";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Log in to continue";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(23, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 46);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(16, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 47);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(24, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(746, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 87);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unicom TIC Management System";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDummy
            // 
            this.lblDummy.AutoSize = true;
            this.lblDummy.Location = new System.Drawing.Point(743, 403);
            this.lblDummy.Name = "lblDummy";
            this.lblDummy.Size = new System.Drawing.Size(10, 16);
            this.lblDummy.TabIndex = 12;
            this.lblDummy.Text = "l";
            this.lblDummy.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 507);
            this.Controls.Add(this.lblDummy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDummy;
        private System.Windows.Forms.Button button_Login;
    }
}