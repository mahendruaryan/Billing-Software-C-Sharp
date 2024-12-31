namespace WinFormsApp4
{
    partial class Dashboard
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
            this.billingbtn = new System.Windows.Forms.Button();
            this.addmembtn = new System.Windows.Forms.Button();
            this.managerbtn = new System.Windows.Forms.Button();
            this.addprobtn = new System.Windows.Forms.Button();
            this.viewprobtn = new System.Windows.Forms.Button();
            this.chnpassbtn = new System.Windows.Forms.Button();
            this.signoutbtn = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.memviewbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // billingbtn
            // 
            this.billingbtn.Location = new System.Drawing.Point(29, 115);
            this.billingbtn.Name = "billingbtn";
            this.billingbtn.Size = new System.Drawing.Size(116, 85);
            this.billingbtn.TabIndex = 0;
            this.billingbtn.Text = "Billing";
            this.billingbtn.UseVisualStyleBackColor = true;
            this.billingbtn.Click += new System.EventHandler(this.billingbtn_Click);
            // 
            // addmembtn
            // 
            this.addmembtn.Location = new System.Drawing.Point(320, 115);
            this.addmembtn.Name = "addmembtn";
            this.addmembtn.Size = new System.Drawing.Size(118, 85);
            this.addmembtn.TabIndex = 1;
            this.addmembtn.Text = "Add Member";
            this.addmembtn.UseVisualStyleBackColor = true;
            this.addmembtn.Click += new System.EventHandler(this.addmembtn_Click);
            // 
            // managerbtn
            // 
            this.managerbtn.Location = new System.Drawing.Point(320, 231);
            this.managerbtn.Name = "managerbtn";
            this.managerbtn.Size = new System.Drawing.Size(240, 85);
            this.managerbtn.TabIndex = 2;
            this.managerbtn.Text = "Manager ";
            this.managerbtn.UseVisualStyleBackColor = true;
            this.managerbtn.Click += new System.EventHandler(this.managerbtn_Click);
            // 
            // addprobtn
            // 
            this.addprobtn.Location = new System.Drawing.Point(29, 231);
            this.addprobtn.Name = "addprobtn";
            this.addprobtn.Size = new System.Drawing.Size(116, 85);
            this.addprobtn.TabIndex = 3;
            this.addprobtn.Text = "Add Product";
            this.addprobtn.UseVisualStyleBackColor = true;
            this.addprobtn.Click += new System.EventHandler(this.addprobtn_Click);
            // 
            // viewprobtn
            // 
            this.viewprobtn.Location = new System.Drawing.Point(151, 231);
            this.viewprobtn.Name = "viewprobtn";
            this.viewprobtn.Size = new System.Drawing.Size(118, 85);
            this.viewprobtn.TabIndex = 4;
            this.viewprobtn.Text = "View Product";
            this.viewprobtn.UseVisualStyleBackColor = true;
            this.viewprobtn.Click += new System.EventHandler(this.viewprobtn_Click);
            // 
            // chnpassbtn
            // 
            this.chnpassbtn.Location = new System.Drawing.Point(151, 115);
            this.chnpassbtn.Name = "chnpassbtn";
            this.chnpassbtn.Size = new System.Drawing.Size(118, 85);
            this.chnpassbtn.TabIndex = 5;
            this.chnpassbtn.Text = "Change Password";
            this.chnpassbtn.UseVisualStyleBackColor = true;
            this.chnpassbtn.Click += new System.EventHandler(this.chnpassbtn_Click);
            // 
            // signoutbtn
            // 
            this.signoutbtn.Location = new System.Drawing.Point(481, 372);
            this.signoutbtn.Name = "signoutbtn";
            this.signoutbtn.Size = new System.Drawing.Size(79, 24);
            this.signoutbtn.TabIndex = 6;
            this.signoutbtn.Text = "Sign Out";
            this.signoutbtn.UseVisualStyleBackColor = true;
            this.signoutbtn.Click += new System.EventHandler(this.signoutbtn_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel1.Controls.Add(this.Panel3);
            this.Panel1.Location = new System.Drawing.Point(-7, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(640, 44);
            this.Panel1.TabIndex = 11;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.Panel3.Location = new System.Drawing.Point(361, 75);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(442, 375);
            this.Panel3.TabIndex = 7;
            // 
            // memviewbtn
            // 
            this.memviewbtn.Location = new System.Drawing.Point(444, 115);
            this.memviewbtn.Name = "memviewbtn";
            this.memviewbtn.Size = new System.Drawing.Size(116, 85);
            this.memviewbtn.TabIndex = 12;
            this.memviewbtn.Text = "View Members";
            this.memviewbtn.UseVisualStyleBackColor = true;
            this.memviewbtn.Click += new System.EventHandler(this.memviewbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGreen;
            this.panel2.Location = new System.Drawing.Point(-4, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 443);
            this.panel2.TabIndex = 12;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 480);
            this.Controls.Add(this.memviewbtn);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.signoutbtn);
            this.Controls.Add(this.chnpassbtn);
            this.Controls.Add(this.viewprobtn);
            this.Controls.Add(this.addprobtn);
            this.Controls.Add(this.managerbtn);
            this.Controls.Add(this.addmembtn);
            this.Controls.Add(this.billingbtn);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button billingbtn;
        private Button addmembtn;
        private Button managerbtn;
        private Button addprobtn;
        private Button viewprobtn;
        private Button chnpassbtn;
        private Button signoutbtn;
        internal Panel Panel1;
        internal Panel Panel3;
        private Button memviewbtn;
        internal Panel panel2;
    }
}