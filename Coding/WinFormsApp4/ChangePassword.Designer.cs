namespace WinFormsApp4
{
    partial class ChangePassword
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
            this.Panel6 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.reentertxtbox = new System.Windows.Forms.TextBox();
            this.reenterpasslbl = new System.Windows.Forms.Label();
            this.newpasstxtbox = new System.Windows.Forms.TextBox();
            this.newpasslbl = new System.Windows.Forms.Label();
            this.chnpassbtn = new System.Windows.Forms.Button();
            this.currpasswordtxtbox = new System.Windows.Forms.TextBox();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.chnpasswordlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.currentpasswordlbl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.Panel6.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel6.Controls.Add(this.back);
            this.Panel6.Controls.Add(this.Label7);
            this.Panel6.Controls.Add(this.Panel9);
            this.Panel6.Location = new System.Drawing.Point(0, 0);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(636, 34);
            this.Panel6.TabIndex = 14;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label7.Location = new System.Drawing.Point(-3, 240);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(172, 120);
            this.Label7.TabIndex = 7;
            this.Label7.Text = "Welcome to \r\nSalary\r\nCalculating\r\n System";
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.ForestGreen;
            this.Panel9.Location = new System.Drawing.Point(358, 73);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(442, 375);
            this.Panel9.TabIndex = 7;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Panel4.Controls.Add(this.reentertxtbox);
            this.Panel4.Controls.Add(this.reenterpasslbl);
            this.Panel4.Controls.Add(this.newpasstxtbox);
            this.Panel4.Controls.Add(this.newpasslbl);
            this.Panel4.Controls.Add(this.chnpassbtn);
            this.Panel4.Controls.Add(this.currpasswordtxtbox);
            this.Panel4.Controls.Add(this.usernametxtbox);
            this.Panel4.Controls.Add(this.chnpasswordlbl);
            this.Panel4.Controls.Add(this.usernamelbl);
            this.Panel4.Controls.Add(this.currentpasswordlbl);
            this.Panel4.Location = new System.Drawing.Point(0, 1);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(532, 450);
            this.Panel4.TabIndex = 13;
            // 
            // reentertxtbox
            // 
            this.reentertxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.reentertxtbox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reentertxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.reentertxtbox.Location = new System.Drawing.Point(140, 278);
            this.reentertxtbox.Name = "reentertxtbox";
            this.reentertxtbox.PasswordChar = '*';
            this.reentertxtbox.Size = new System.Drawing.Size(254, 23);
            this.reentertxtbox.TabIndex = 24;
            // 
            // reenterpasslbl
            // 
            this.reenterpasslbl.AutoSize = true;
            this.reenterpasslbl.Location = new System.Drawing.Point(27, 282);
            this.reenterpasslbl.Name = "reenterpasslbl";
            this.reenterpasslbl.Size = new System.Drawing.Size(94, 15);
            this.reenterpasslbl.TabIndex = 23;
            this.reenterpasslbl.Text = "Renter Password";
            // 
            // newpasstxtbox
            // 
            this.newpasstxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.newpasstxtbox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpasstxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.newpasstxtbox.Location = new System.Drawing.Point(139, 213);
            this.newpasstxtbox.Name = "newpasstxtbox";
            this.newpasstxtbox.PasswordChar = '*';
            this.newpasstxtbox.Size = new System.Drawing.Size(254, 23);
            this.newpasstxtbox.TabIndex = 20;
            // 
            // newpasslbl
            // 
            this.newpasslbl.AutoSize = true;
            this.newpasslbl.Location = new System.Drawing.Point(26, 217);
            this.newpasslbl.Name = "newpasslbl";
            this.newpasslbl.Size = new System.Drawing.Size(84, 15);
            this.newpasslbl.TabIndex = 19;
            this.newpasslbl.Text = "New Password";
            // 
            // chnpassbtn
            // 
            this.chnpassbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chnpassbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chnpassbtn.FlatAppearance.BorderSize = 2;
            this.chnpassbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.chnpassbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.chnpassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chnpassbtn.Location = new System.Drawing.Point(279, 391);
            this.chnpassbtn.Name = "chnpassbtn";
            this.chnpassbtn.Size = new System.Drawing.Size(132, 26);
            this.chnpassbtn.TabIndex = 15;
            this.chnpassbtn.Text = "Change Password";
            this.chnpassbtn.UseVisualStyleBackColor = false;
            this.chnpassbtn.Click += new System.EventHandler(this.chnpassbtn_Click);
            // 
            // currpasswordtxtbox
            // 
            this.currpasswordtxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.currpasswordtxtbox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currpasswordtxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currpasswordtxtbox.Location = new System.Drawing.Point(139, 153);
            this.currpasswordtxtbox.Name = "currpasswordtxtbox";
            this.currpasswordtxtbox.PasswordChar = '*';
            this.currpasswordtxtbox.Size = new System.Drawing.Size(254, 23);
            this.currpasswordtxtbox.TabIndex = 14;
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.usernametxtbox.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernametxtbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernametxtbox.Location = new System.Drawing.Point(139, 95);
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.ReadOnly = true;
            this.usernametxtbox.Size = new System.Drawing.Size(254, 23);
            this.usernametxtbox.TabIndex = 13;
            // 
            // chnpasswordlbl
            // 
            this.chnpasswordlbl.AutoSize = true;
            this.chnpasswordlbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chnpasswordlbl.Location = new System.Drawing.Point(24, 36);
            this.chnpasswordlbl.Name = "chnpasswordlbl";
            this.chnpasswordlbl.Size = new System.Drawing.Size(161, 25);
            this.chnpasswordlbl.TabIndex = 2;
            this.chnpasswordlbl.Text = "Change Password";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Location = new System.Drawing.Point(26, 99);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(60, 15);
            this.usernamelbl.TabIndex = 3;
            this.usernamelbl.Text = "Username";
            // 
            // currentpasswordlbl
            // 
            this.currentpasswordlbl.AutoSize = true;
            this.currentpasswordlbl.Location = new System.Drawing.Point(26, 157);
            this.currentpasswordlbl.Name = "currentpasswordlbl";
            this.currentpasswordlbl.Size = new System.Drawing.Size(100, 15);
            this.currentpasswordlbl.TabIndex = 4;
            this.currentpasswordlbl.Text = "Current Password";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(340, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 135;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 444);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel4);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePassword_FormClosed);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Panel Panel6;
        internal Label Label7;
        internal Panel Panel9;
        internal Panel Panel4;
        internal TextBox newpasstxtbox;
        internal Label newpasslbl;
        internal Button chnpassbtn;
        internal TextBox currpasswordtxtbox;
        internal TextBox usernametxtbox;
        internal Label chnpasswordlbl;
        internal Label usernamelbl;
        internal Label currentpasswordlbl;
        internal Label reenterpasslbl;
        internal TextBox reentertxtbox;
        private Button back;
    }
}