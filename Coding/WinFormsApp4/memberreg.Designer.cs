namespace WinFormsApp4
{
    partial class Memberreg
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
            this.mobtxtbox = new System.Windows.Forms.TextBox();
            this.moblbl = new System.Windows.Forms.Label();
            this.gentxtbox = new System.Windows.Forms.TextBox();
            this.genlbl = new System.Windows.Forms.Label();
            this.fnametxtbox = new System.Windows.Forms.TextBox();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.memidtxtbox = new System.Windows.Forms.TextBox();
            this.memidlbl = new System.Windows.Forms.Label();
            this.newmemcheckbox = new System.Windows.Forms.CheckBox();
            this.renewmemcheckbox = new System.Windows.Forms.CheckBox();
            this.fetchbtn = new System.Windows.Forms.Button();
            this.lnametxtbox = new System.Windows.Forms.TextBox();
            this.lnamelbl = new System.Windows.Forms.Label();
            this.doblbl = new System.Windows.Forms.Label();
            this.dobdatetime = new System.Windows.Forms.DateTimePicker();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.streetlbl = new System.Windows.Forms.Label();
            this.streettxtbox = new System.Windows.Forms.TextBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.citytxtbox = new System.Windows.Forms.TextBox();
            this.provincetxtbox = new System.Windows.Forms.TextBox();
            this.provincelbl = new System.Windows.Forms.Label();
            this.countrytxtbox = new System.Windows.Forms.TextBox();
            this.countrylbl = new System.Windows.Forms.Label();
            this.postalcodetxtbox = new System.Windows.Forms.TextBox();
            this.postalcodelbl = new System.Windows.Forms.Label();
            this.paymentlbl = new System.Windows.Forms.Label();
            this.cardcheckbox = new System.Windows.Forms.CheckBox();
            this.cashcheckbox = new System.Windows.Forms.CheckBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.mempricetxtbox = new System.Windows.Forms.TextBox();
            this.mempricelbl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mobtxtbox
            // 
            this.mobtxtbox.Location = new System.Drawing.Point(115, 217);
            this.mobtxtbox.Name = "mobtxtbox";
            this.mobtxtbox.Size = new System.Drawing.Size(148, 23);
            this.mobtxtbox.TabIndex = 106;
            this.mobtxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobtxtbox_KeyPress);
            // 
            // moblbl
            // 
            this.moblbl.AutoSize = true;
            this.moblbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moblbl.Location = new System.Drawing.Point(16, 218);
            this.moblbl.Name = "moblbl";
            this.moblbl.Size = new System.Drawing.Size(62, 17);
            this.moblbl.TabIndex = 105;
            this.moblbl.Text = "MOBILE";
            // 
            // gentxtbox
            // 
            this.gentxtbox.Location = new System.Drawing.Point(479, 173);
            this.gentxtbox.Name = "gentxtbox";
            this.gentxtbox.Size = new System.Drawing.Size(148, 23);
            this.gentxtbox.TabIndex = 105;
            // 
            // genlbl
            // 
            this.genlbl.AutoSize = true;
            this.genlbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genlbl.Location = new System.Drawing.Point(365, 177);
            this.genlbl.Name = "genlbl";
            this.genlbl.Size = new System.Drawing.Size(67, 17);
            this.genlbl.TabIndex = 103;
            this.genlbl.Text = "GENDER";
            // 
            // fnametxtbox
            // 
            this.fnametxtbox.Location = new System.Drawing.Point(115, 135);
            this.fnametxtbox.Name = "fnametxtbox";
            this.fnametxtbox.Size = new System.Drawing.Size(148, 23);
            this.fnametxtbox.TabIndex = 102;
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnamelbl.Location = new System.Drawing.Point(16, 137);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(93, 17);
            this.fnamelbl.TabIndex = 101;
            this.fnamelbl.Text = "FIRST NAME";
            // 
            // memidtxtbox
            // 
            this.memidtxtbox.Location = new System.Drawing.Point(157, 50);
            this.memidtxtbox.Name = "memidtxtbox";
            this.memidtxtbox.Size = new System.Drawing.Size(148, 23);
            this.memidtxtbox.TabIndex = 3;
            // 
            // memidlbl
            // 
            this.memidlbl.AutoSize = true;
            this.memidlbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memidlbl.Location = new System.Drawing.Point(14, 51);
            this.memidlbl.Name = "memidlbl";
            this.memidlbl.Size = new System.Drawing.Size(91, 17);
            this.memidlbl.TabIndex = 107;
            this.memidlbl.Text = "MEMBER ID";
            // 
            // newmemcheckbox
            // 
            this.newmemcheckbox.AutoSize = true;
            this.newmemcheckbox.Location = new System.Drawing.Point(10, 20);
            this.newmemcheckbox.Name = "newmemcheckbox";
            this.newmemcheckbox.Size = new System.Drawing.Size(120, 19);
            this.newmemcheckbox.TabIndex = 2;
            this.newmemcheckbox.Text = "New Membership";
            this.newmemcheckbox.UseVisualStyleBackColor = true;
            this.newmemcheckbox.CheckedChanged += new System.EventHandler(this.newmemcheckbox_CheckedChanged);
            // 
            // renewmemcheckbox
            // 
            this.renewmemcheckbox.AutoSize = true;
            this.renewmemcheckbox.Location = new System.Drawing.Point(145, 20);
            this.renewmemcheckbox.Name = "renewmemcheckbox";
            this.renewmemcheckbox.Size = new System.Drawing.Size(131, 19);
            this.renewmemcheckbox.TabIndex = 1;
            this.renewmemcheckbox.Text = "Renew Membership";
            this.renewmemcheckbox.UseVisualStyleBackColor = true;
            this.renewmemcheckbox.CheckedChanged += new System.EventHandler(this.renewmemcheckbox_CheckedChanged);
            // 
            // fetchbtn
            // 
            this.fetchbtn.Location = new System.Drawing.Point(157, 91);
            this.fetchbtn.Name = "fetchbtn";
            this.fetchbtn.Size = new System.Drawing.Size(75, 23);
            this.fetchbtn.TabIndex = 4;
            this.fetchbtn.Text = "Fetch";
            this.fetchbtn.UseVisualStyleBackColor = true;
            this.fetchbtn.Click += new System.EventHandler(this.fetchbtn_Click);
            // 
            // lnametxtbox
            // 
            this.lnametxtbox.Location = new System.Drawing.Point(479, 135);
            this.lnametxtbox.Name = "lnametxtbox";
            this.lnametxtbox.Size = new System.Drawing.Size(148, 23);
            this.lnametxtbox.TabIndex = 103;
            // 
            // lnamelbl
            // 
            this.lnamelbl.AutoSize = true;
            this.lnamelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnamelbl.Location = new System.Drawing.Point(365, 137);
            this.lnamelbl.Name = "lnamelbl";
            this.lnamelbl.Size = new System.Drawing.Size(87, 17);
            this.lnamelbl.TabIndex = 110;
            this.lnamelbl.Text = "LAST NAME";
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doblbl.Location = new System.Drawing.Point(16, 179);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(39, 17);
            this.doblbl.TabIndex = 112;
            this.doblbl.Text = "DOB";
            // 
            // dobdatetime
            // 
            this.dobdatetime.CustomFormat = "dd-MM-yyyy";
            this.dobdatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dobdatetime.Location = new System.Drawing.Point(115, 173);
            this.dobdatetime.Name = "dobdatetime";
            this.dobdatetime.Size = new System.Drawing.Size(151, 23);
            this.dobdatetime.TabIndex = 104;
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(479, 217);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.Size = new System.Drawing.Size(148, 23);
            this.emailtxtbox.TabIndex = 107;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emaillbl.Location = new System.Drawing.Point(365, 220);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(51, 17);
            this.emaillbl.TabIndex = 114;
            this.emaillbl.Text = "EMAIL";
            // 
            // streetlbl
            // 
            this.streetlbl.AutoSize = true;
            this.streetlbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.streetlbl.Location = new System.Drawing.Point(19, 262);
            this.streetlbl.Name = "streetlbl";
            this.streetlbl.Size = new System.Drawing.Size(134, 17);
            this.streetlbl.TabIndex = 116;
            this.streetlbl.Text = "STREET ADDRESS";
            // 
            // streettxtbox
            // 
            this.streettxtbox.Location = new System.Drawing.Point(19, 294);
            this.streettxtbox.Name = "streettxtbox";
            this.streettxtbox.Size = new System.Drawing.Size(370, 23);
            this.streettxtbox.TabIndex = 108;
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.citylbl.Location = new System.Drawing.Point(456, 262);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(39, 17);
            this.citylbl.TabIndex = 118;
            this.citylbl.Text = "CITY";
            // 
            // citytxtbox
            // 
            this.citytxtbox.Location = new System.Drawing.Point(456, 294);
            this.citytxtbox.Name = "citytxtbox";
            this.citytxtbox.Size = new System.Drawing.Size(154, 23);
            this.citytxtbox.TabIndex = 109;
            // 
            // provincetxtbox
            // 
            this.provincetxtbox.Location = new System.Drawing.Point(19, 368);
            this.provincetxtbox.Name = "provincetxtbox";
            this.provincetxtbox.Size = new System.Drawing.Size(154, 23);
            this.provincetxtbox.TabIndex = 110;
            // 
            // provincelbl
            // 
            this.provincelbl.AutoSize = true;
            this.provincelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provincelbl.Location = new System.Drawing.Point(19, 336);
            this.provincelbl.Name = "provincelbl";
            this.provincelbl.Size = new System.Drawing.Size(81, 17);
            this.provincelbl.TabIndex = 120;
            this.provincelbl.Text = "PROVINCE";
            // 
            // countrytxtbox
            // 
            this.countrytxtbox.Location = new System.Drawing.Point(236, 368);
            this.countrytxtbox.Name = "countrytxtbox";
            this.countrytxtbox.Size = new System.Drawing.Size(154, 23);
            this.countrytxtbox.TabIndex = 111;
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countrylbl.Location = new System.Drawing.Point(236, 336);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(74, 17);
            this.countrylbl.TabIndex = 122;
            this.countrylbl.Text = "COUNTRY";
            // 
            // postalcodetxtbox
            // 
            this.postalcodetxtbox.Location = new System.Drawing.Point(456, 368);
            this.postalcodetxtbox.Name = "postalcodetxtbox";
            this.postalcodetxtbox.Size = new System.Drawing.Size(154, 23);
            this.postalcodetxtbox.TabIndex = 112;
            // 
            // postalcodelbl
            // 
            this.postalcodelbl.AutoSize = true;
            this.postalcodelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.postalcodelbl.Location = new System.Drawing.Point(456, 336);
            this.postalcodelbl.Name = "postalcodelbl";
            this.postalcodelbl.Size = new System.Drawing.Size(107, 17);
            this.postalcodelbl.TabIndex = 124;
            this.postalcodelbl.Text = "POSTAL CODE";
            // 
            // paymentlbl
            // 
            this.paymentlbl.AutoSize = true;
            this.paymentlbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.paymentlbl.Location = new System.Drawing.Point(19, 455);
            this.paymentlbl.Name = "paymentlbl";
            this.paymentlbl.Size = new System.Drawing.Size(74, 17);
            this.paymentlbl.TabIndex = 128;
            this.paymentlbl.Text = "PAYMENT";
            // 
            // cardcheckbox
            // 
            this.cardcheckbox.AutoSize = true;
            this.cardcheckbox.Location = new System.Drawing.Point(236, 455);
            this.cardcheckbox.Name = "cardcheckbox";
            this.cardcheckbox.Size = new System.Drawing.Size(57, 19);
            this.cardcheckbox.TabIndex = 114;
            this.cardcheckbox.Text = "CARD";
            this.cardcheckbox.UseVisualStyleBackColor = true;
            this.cardcheckbox.CheckedChanged += new System.EventHandler(this.cardcheckbox_CheckedChanged);
            // 
            // cashcheckbox
            // 
            this.cashcheckbox.AutoSize = true;
            this.cashcheckbox.Location = new System.Drawing.Point(112, 455);
            this.cashcheckbox.Name = "cashcheckbox";
            this.cashcheckbox.Size = new System.Drawing.Size(57, 19);
            this.cashcheckbox.TabIndex = 113;
            this.cashcheckbox.Text = "CASH";
            this.cashcheckbox.UseVisualStyleBackColor = true;
            this.cashcheckbox.CheckedChanged += new System.EventHandler(this.cashcheckbox_CheckedChanged);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(552, 655);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 115;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // mempricetxtbox
            // 
            this.mempricetxtbox.Location = new System.Drawing.Point(112, 507);
            this.mempricetxtbox.Name = "mempricetxtbox";
            this.mempricetxtbox.Size = new System.Drawing.Size(77, 23);
            this.mempricetxtbox.TabIndex = 132;
            this.mempricetxtbox.TextChanged += new System.EventHandler(this.mempricetxtbox_TextChanged);
            // 
            // mempricelbl
            // 
            this.mempricelbl.AutoSize = true;
            this.mempricelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mempricelbl.Location = new System.Drawing.Point(19, 508);
            this.mempricelbl.Name = "mempricelbl";
            this.mempricelbl.Size = new System.Drawing.Size(74, 17);
            this.mempricelbl.TabIndex = 133;
            this.mempricelbl.Text = "PAYMENT";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(553, 10);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 134;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Memberreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 718);
            this.Controls.Add(this.back);
            this.Controls.Add(this.mempricelbl);
            this.Controls.Add(this.mempricetxtbox);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.cardcheckbox);
            this.Controls.Add(this.cashcheckbox);
            this.Controls.Add(this.paymentlbl);
            this.Controls.Add(this.postalcodetxtbox);
            this.Controls.Add(this.postalcodelbl);
            this.Controls.Add(this.countrytxtbox);
            this.Controls.Add(this.countrylbl);
            this.Controls.Add(this.provincetxtbox);
            this.Controls.Add(this.provincelbl);
            this.Controls.Add(this.citytxtbox);
            this.Controls.Add(this.citylbl);
            this.Controls.Add(this.streettxtbox);
            this.Controls.Add(this.streetlbl);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.dobdatetime);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.lnametxtbox);
            this.Controls.Add(this.lnamelbl);
            this.Controls.Add(this.fetchbtn);
            this.Controls.Add(this.memidtxtbox);
            this.Controls.Add(this.memidlbl);
            this.Controls.Add(this.mobtxtbox);
            this.Controls.Add(this.moblbl);
            this.Controls.Add(this.gentxtbox);
            this.Controls.Add(this.genlbl);
            this.Controls.Add(this.fnametxtbox);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.renewmemcheckbox);
            this.Controls.Add(this.newmemcheckbox);
            this.Name = "Memberreg";
            this.Text = "Member Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Memberreg_FormClosed);
            this.Load += new System.EventHandler(this.Memberreg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox mobtxtbox;
        internal Label moblbl;
        private TextBox gentxtbox;
        internal Label genlbl;
        private TextBox fnametxtbox;
        internal Label fnamelbl;
        private TextBox memidtxtbox;
        internal Label memidlbl;
        private CheckBox newmemcheckbox;
        private CheckBox renewmemcheckbox;
        private Button fetchbtn;
        private TextBox lnametxtbox;
        internal Label lnamelbl;
        internal Label doblbl;
        private DateTimePicker dobdatetime;
        private TextBox emailtxtbox;
        internal Label emaillbl;
        internal Label streetlbl;
        private TextBox streettxtbox;
        internal Label citylbl;
        private TextBox citytxtbox;
        private TextBox provincetxtbox;
        internal Label provincelbl;
        private TextBox countrytxtbox;
        internal Label countrylbl;
        private TextBox postalcodetxtbox;
        internal Label postalcodelbl;
        internal Label paymentlbl;
        private CheckBox cardcheckbox;
        private CheckBox cashcheckbox;
        private Button addbtn;
        private TextBox mempricetxtbox;
        internal Label mempricelbl;
        private Button back;
    }
}