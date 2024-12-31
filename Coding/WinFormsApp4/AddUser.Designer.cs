namespace WinFormsApp4
{
    partial class AddUser
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
            this.createbtn = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.passphoto = new System.Windows.Forms.PictureBox();
            this.usernamephoto = new System.Windows.Forms.PictureBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.signuplbl = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.typelbl = new System.Windows.Forms.Label();
            this.typecombobox = new System.Windows.Forms.ComboBox();
            this.confirmpasstxtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.confirmpsslbl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.passphoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamephoto)).BeginInit();
            this.Panel6.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.createbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createbtn.FlatAppearance.BorderSize = 2;
            this.createbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Location = new System.Drawing.Point(404, 379);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(77, 34);
            this.createbtn.TabIndex = 5;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = false;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.Location = new System.Drawing.Point(-6, 237);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(172, 120);
            this.Label7.TabIndex = 7;
            this.Label7.Text = "Welcome to \r\nSalary\r\nCalculating\r\n System";
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.ForestGreen;
            this.Panel9.Location = new System.Drawing.Point(355, 70);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(442, 375);
            this.Panel9.TabIndex = 7;
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordtxtbox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordtxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordtxtbox.Location = new System.Drawing.Point(207, 187);
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.PasswordChar = '*';
            this.passwordtxtbox.Size = new System.Drawing.Size(254, 23);
            this.passwordtxtbox.TabIndex = 2;
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.usernametxtbox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernametxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernametxtbox.Location = new System.Drawing.Point(207, 87);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(254, 23);
            this.usernametxtbox.TabIndex = 0;
            // 
            // passphoto
            // 
            this.passphoto.Image = global::WinFormsApp4.Properties.Resources.gdbkb;
            this.passphoto.Location = new System.Drawing.Point(45, 179);
            this.passphoto.Name = "passphoto";
            this.passphoto.Size = new System.Drawing.Size(43, 34);
            this.passphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passphoto.TabIndex = 6;
            this.passphoto.TabStop = false;
            // 
            // usernamephoto
            // 
            this.usernamephoto.Image = global::WinFormsApp4.Properties.Resources.clipart153139;
            this.usernamephoto.Location = new System.Drawing.Point(45, 82);
            this.usernamephoto.Name = "usernamephoto";
            this.usernamephoto.Size = new System.Drawing.Size(33, 33);
            this.usernamephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamephoto.TabIndex = 5;
            this.usernamephoto.TabStop = false;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(94, 187);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(57, 15);
            this.passwordlbl.TabIndex = 4;
            this.passwordlbl.Text = "Password";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(90, 87);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(60, 15);
            this.usernamelbl.TabIndex = 3;
            this.usernamelbl.Text = "Username";
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel6.Controls.Add(this.back);
            this.Panel6.Controls.Add(this.Label7);
            this.Panel6.Controls.Add(this.Panel9);
            this.Panel6.Location = new System.Drawing.Point(2, -4);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(636, 32);
            this.Panel6.TabIndex = 15;
            // 
            // signuplbl
            // 
            this.signuplbl.AutoSize = true;
            this.signuplbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signuplbl.Location = new System.Drawing.Point(21, 33);
            this.signuplbl.Name = "signuplbl";
            this.signuplbl.Size = new System.Drawing.Size(165, 25);
            this.signuplbl.TabIndex = 2;
            this.signuplbl.Text = "Register New User";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Panel4.Controls.Add(this.typelbl);
            this.Panel4.Controls.Add(this.typecombobox);
            this.Panel4.Controls.Add(this.confirmpasstxtbox);
            this.Panel4.Controls.Add(this.pictureBox1);
            this.Panel4.Controls.Add(this.confirmpsslbl);
            this.Panel4.Controls.Add(this.createbtn);
            this.Panel4.Controls.Add(this.passwordtxtbox);
            this.Panel4.Controls.Add(this.usernametxtbox);
            this.Panel4.Controls.Add(this.passphoto);
            this.Panel4.Controls.Add(this.usernamephoto);
            this.Panel4.Controls.Add(this.signuplbl);
            this.Panel4.Controls.Add(this.usernamelbl);
            this.Panel4.Controls.Add(this.passwordlbl);
            this.Panel4.Location = new System.Drawing.Point(2, -3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(532, 450);
            this.Panel4.TabIndex = 14;
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typelbl.Location = new System.Drawing.Point(48, 363);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(40, 20);
            this.typelbl.TabIndex = 20;
            this.typelbl.Text = "Type";
            // 
            // typecombobox
            // 
            this.typecombobox.FormattingEnabled = true;
            this.typecombobox.Items.AddRange(new object[] {
            "Manager",
            "General"});
            this.typecombobox.Location = new System.Drawing.Point(113, 364);
            this.typecombobox.Name = "typecombobox";
            this.typecombobox.Size = new System.Drawing.Size(121, 23);
            this.typecombobox.TabIndex = 4;
            this.typecombobox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typecombobox_KeyPress);
            // 
            // confirmpasstxtbox
            // 
            this.confirmpasstxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.confirmpasstxtbox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmpasstxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmpasstxtbox.Location = new System.Drawing.Point(207, 289);
            this.confirmpasstxtbox.Name = "confirmpasstxtbox";
            this.confirmpasstxtbox.PasswordChar = '*';
            this.confirmpasstxtbox.Size = new System.Drawing.Size(254, 23);
            this.confirmpasstxtbox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp4.Properties.Resources.gdbkb;
            this.pictureBox1.Location = new System.Drawing.Point(45, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // confirmpsslbl
            // 
            this.confirmpsslbl.AutoSize = true;
            this.confirmpsslbl.Location = new System.Drawing.Point(94, 289);
            this.confirmpsslbl.Name = "confirmpsslbl";
            this.confirmpsslbl.Size = new System.Drawing.Size(104, 15);
            this.confirmpsslbl.TabIndex = 16;
            this.confirmpsslbl.Text = "Confirm Password";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(440, 6);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 136;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 434);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel4);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passphoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamephoto)).EndInit();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal Button createbtn;
        internal Label Label7;
        internal Panel Panel9;
        internal TextBox passwordtxtbox;
        internal TextBox usernametxtbox;
        internal PictureBox passphoto;
        internal PictureBox usernamephoto;
        internal Label passwordlbl;
        internal Label usernamelbl;
        internal Panel Panel6;
        internal Label signuplbl;
        internal Panel Panel4;
        internal TextBox confirmpasstxtbox;
        internal PictureBox pictureBox1;
        internal Label confirmpsslbl;
        internal Label typelbl;
        private ComboBox typecombobox;
        private Button back;
    }
}