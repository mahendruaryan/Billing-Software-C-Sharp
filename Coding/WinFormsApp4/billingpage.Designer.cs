namespace WinFormsApp4
{
    partial class Billingpage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billingpage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.newcustomerbtn = new System.Windows.Forms.Button();
            this.signoutbtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.billinglbl = new System.Windows.Forms.Label();
            this.memidlabel = new System.Windows.Forms.Label();
            this.memidtxtbox = new System.Windows.Forms.TextBox();
            this.custnametxtbox = new System.Windows.Forms.TextBox();
            this.custnamelabel = new System.Windows.Forms.Label();
            this.custgendertxtbox = new System.Windows.Forms.TextBox();
            this.custgenderlbl = new System.Windows.Forms.Label();
            this.custmobiletxtbox = new System.Windows.Forms.TextBox();
            this.memvaliditylabel = new System.Windows.Forms.Label();
            this.memvaliditytxtbox = new System.Windows.Forms.TextBox();
            this.custmobilelbl = new System.Windows.Forms.Label();
            this.memidfetchbtn = new System.Windows.Forms.Button();
            this.proidfetchbtn = new System.Windows.Forms.Button();
            this.proquantitytxtbox = new System.Windows.Forms.TextBox();
            this.proquantitylbl = new System.Windows.Forms.Label();
            this.propricetxtbox = new System.Windows.Forms.TextBox();
            this.propricelbl = new System.Windows.Forms.Label();
            this.pronametxtbox = new System.Windows.Forms.TextBox();
            this.pronamelbl = new System.Windows.Forms.Label();
            this.proidtxtbox = new System.Windows.Forms.TextBox();
            this.proidlbl = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.shopcartgridview = new System.Windows.Forms.DataGridView();
            this.listViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delitembtn = new System.Windows.Forms.Button();
            this.notamemlbl = new System.Windows.Forms.Label();
            this.formemberlbl = new System.Windows.Forms.Label();
            this.noproidlbl = new System.Windows.Forms.Label();
            this.havproidlbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.totaltxtbox = new System.Windows.Forms.TextBox();
            this.printbtn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.searchprolbl = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopcartgridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 721);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 61);
            this.panel1.TabIndex = 90;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(0, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 120);
            this.label16.TabIndex = 7;
            this.label16.Text = "Welcome to \r\nSalary\r\nCalculating\r\n System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(361, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 375);
            this.panel2.TabIndex = 7;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel6.Controls.Add(this.back);
            this.Panel6.Controls.Add(this.newcustomerbtn);
            this.Panel6.Controls.Add(this.signoutbtn);
            this.Panel6.Controls.Add(this.label15);
            this.Panel6.Controls.Add(this.Panel9);
            this.Panel6.Controls.Add(this.billinglbl);
            this.Panel6.Location = new System.Drawing.Point(0, -1);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(798, 63);
            this.Panel6.TabIndex = 89;
            // 
            // newcustomerbtn
            // 
            this.newcustomerbtn.Location = new System.Drawing.Point(127, 22);
            this.newcustomerbtn.Name = "newcustomerbtn";
            this.newcustomerbtn.Size = new System.Drawing.Size(110, 23);
            this.newcustomerbtn.TabIndex = 32;
            this.newcustomerbtn.Text = "New Customer";
            this.newcustomerbtn.UseVisualStyleBackColor = true;
            this.newcustomerbtn.Click += new System.EventHandler(this.newcustomerbtn_Click_1);
            // 
            // signoutbtn
            // 
            this.signoutbtn.Location = new System.Drawing.Point(543, 22);
            this.signoutbtn.Name = "signoutbtn";
            this.signoutbtn.Size = new System.Drawing.Size(75, 23);
            this.signoutbtn.TabIndex = 31;
            this.signoutbtn.Text = "Sign Out";
            this.signoutbtn.UseVisualStyleBackColor = true;
            this.signoutbtn.Click += new System.EventHandler(this.signoutbtn_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(0, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(172, 120);
            this.label15.TabIndex = 7;
            this.label15.Text = "Welcome to \r\nSalary\r\nCalculating\r\n System";
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.ForestGreen;
            this.Panel9.Location = new System.Drawing.Point(361, 75);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(442, 375);
            this.Panel9.TabIndex = 7;
            // 
            // billinglbl
            // 
            this.billinglbl.AutoSize = true;
            this.billinglbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.billinglbl.Location = new System.Drawing.Point(17, 22);
            this.billinglbl.Name = "billinglbl";
            this.billinglbl.Size = new System.Drawing.Size(86, 25);
            this.billinglbl.TabIndex = 30;
            this.billinglbl.Text = "Billing";
            // 
            // memidlabel
            // 
            this.memidlabel.AutoSize = true;
            this.memidlabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memidlabel.Location = new System.Drawing.Point(19, 95);
            this.memidlabel.Name = "memidlabel";
            this.memidlabel.Size = new System.Drawing.Size(131, 17);
            this.memidlabel.TabIndex = 91;
            this.memidlabel.Text = "MEMEBRSHIP  ID";
            // 
            // memidtxtbox
            // 
            this.memidtxtbox.Location = new System.Drawing.Point(162, 94);
            this.memidtxtbox.Name = "memidtxtbox";
            this.memidtxtbox.Size = new System.Drawing.Size(148, 23);
            this.memidtxtbox.TabIndex = 92;
            // 
            // custnametxtbox
            // 
            this.custnametxtbox.Location = new System.Drawing.Point(504, 93);
            this.custnametxtbox.Name = "custnametxtbox";
            this.custnametxtbox.Size = new System.Drawing.Size(148, 23);
            this.custnametxtbox.TabIndex = 94;
            // 
            // custnamelabel
            // 
            this.custnamelabel.AutoSize = true;
            this.custnamelabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custnamelabel.Location = new System.Drawing.Point(361, 94);
            this.custnamelabel.Name = "custnamelabel";
            this.custnamelabel.Size = new System.Drawing.Size(131, 17);
            this.custnamelabel.TabIndex = 93;
            this.custnamelabel.Text = "CUSTOMER NAME";
            // 
            // custgendertxtbox
            // 
            this.custgendertxtbox.Location = new System.Drawing.Point(504, 132);
            this.custgendertxtbox.Name = "custgendertxtbox";
            this.custgendertxtbox.Size = new System.Drawing.Size(148, 23);
            this.custgendertxtbox.TabIndex = 96;
            // 
            // custgenderlbl
            // 
            this.custgenderlbl.AutoSize = true;
            this.custgenderlbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custgenderlbl.Location = new System.Drawing.Point(361, 133);
            this.custgenderlbl.Name = "custgenderlbl";
            this.custgenderlbl.Size = new System.Drawing.Size(67, 17);
            this.custgenderlbl.TabIndex = 95;
            this.custgenderlbl.Text = "GENDER";
            // 
            // custmobiletxtbox
            // 
            this.custmobiletxtbox.Location = new System.Drawing.Point(504, 171);
            this.custmobiletxtbox.Name = "custmobiletxtbox";
            this.custmobiletxtbox.Size = new System.Drawing.Size(148, 23);
            this.custmobiletxtbox.TabIndex = 100;
            this.custmobiletxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custmobiletxtbox_KeyPress);
            // 
            // memvaliditylabel
            // 
            this.memvaliditylabel.AutoSize = true;
            this.memvaliditylabel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memvaliditylabel.Location = new System.Drawing.Point(361, 210);
            this.memvaliditylabel.Name = "memvaliditylabel";
            this.memvaliditylabel.Size = new System.Drawing.Size(71, 17);
            this.memvaliditylabel.TabIndex = 99;
            this.memvaliditylabel.Text = "VALIDITY";
            // 
            // memvaliditytxtbox
            // 
            this.memvaliditytxtbox.Location = new System.Drawing.Point(504, 210);
            this.memvaliditytxtbox.Name = "memvaliditytxtbox";
            this.memvaliditytxtbox.Size = new System.Drawing.Size(148, 23);
            this.memvaliditytxtbox.TabIndex = 98;
            // 
            // custmobilelbl
            // 
            this.custmobilelbl.AutoSize = true;
            this.custmobilelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custmobilelbl.Location = new System.Drawing.Point(361, 171);
            this.custmobilelbl.Name = "custmobilelbl";
            this.custmobilelbl.Size = new System.Drawing.Size(62, 17);
            this.custmobilelbl.TabIndex = 97;
            this.custmobilelbl.Text = "MOBILE";
            // 
            // memidfetchbtn
            // 
            this.memidfetchbtn.Location = new System.Drawing.Point(127, 140);
            this.memidfetchbtn.Name = "memidfetchbtn";
            this.memidfetchbtn.Size = new System.Drawing.Size(75, 23);
            this.memidfetchbtn.TabIndex = 101;
            this.memidfetchbtn.Text = "Fetch";
            this.memidfetchbtn.UseVisualStyleBackColor = true;
            this.memidfetchbtn.Click += new System.EventHandler(this.memidfetchbtn_Click);
            // 
            // proidfetchbtn
            // 
            this.proidfetchbtn.Location = new System.Drawing.Point(127, 323);
            this.proidfetchbtn.Name = "proidfetchbtn";
            this.proidfetchbtn.Size = new System.Drawing.Size(75, 23);
            this.proidfetchbtn.TabIndex = 112;
            this.proidfetchbtn.Text = "Fetch";
            this.proidfetchbtn.UseVisualStyleBackColor = true;
            this.proidfetchbtn.Click += new System.EventHandler(this.proidfetchbtn_Click);
            // 
            // proquantitytxtbox
            // 
            this.proquantitytxtbox.Location = new System.Drawing.Point(504, 347);
            this.proquantitytxtbox.Name = "proquantitytxtbox";
            this.proquantitytxtbox.Size = new System.Drawing.Size(148, 23);
            this.proquantitytxtbox.TabIndex = 109;
            this.proquantitytxtbox.TextChanged += new System.EventHandler(this.proquantitytxtbox_TextChanged);
            this.proquantitytxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proquantitytxtbox_KeyPress);
            // 
            // proquantitylbl
            // 
            this.proquantitylbl.AutoSize = true;
            this.proquantitylbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proquantitylbl.Location = new System.Drawing.Point(361, 348);
            this.proquantitylbl.Name = "proquantitylbl";
            this.proquantitylbl.Size = new System.Drawing.Size(76, 17);
            this.proquantitylbl.TabIndex = 108;
            this.proquantitylbl.Text = "QUANTITY";
            // 
            // propricetxtbox
            // 
            this.propricetxtbox.Location = new System.Drawing.Point(504, 309);
            this.propricetxtbox.Name = "propricetxtbox";
            this.propricetxtbox.Size = new System.Drawing.Size(148, 23);
            this.propricetxtbox.TabIndex = 107;
            this.propricetxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propricetxtbox_KeyPress);
            // 
            // propricelbl
            // 
            this.propricelbl.AutoSize = true;
            this.propricelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.propricelbl.Location = new System.Drawing.Point(361, 310);
            this.propricelbl.Name = "propricelbl";
            this.propricelbl.Size = new System.Drawing.Size(52, 17);
            this.propricelbl.TabIndex = 106;
            this.propricelbl.Text = "PRICE";
            // 
            // pronametxtbox
            // 
            this.pronametxtbox.Location = new System.Drawing.Point(504, 270);
            this.pronametxtbox.Name = "pronametxtbox";
            this.pronametxtbox.Size = new System.Drawing.Size(148, 23);
            this.pronametxtbox.TabIndex = 105;
            // 
            // pronamelbl
            // 
            this.pronamelbl.AutoSize = true;
            this.pronamelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pronamelbl.Location = new System.Drawing.Point(361, 271);
            this.pronamelbl.Name = "pronamelbl";
            this.pronamelbl.Size = new System.Drawing.Size(122, 17);
            this.pronamelbl.TabIndex = 104;
            this.pronamelbl.Text = "PRODUCT NAME";
            // 
            // proidtxtbox
            // 
            this.proidtxtbox.Location = new System.Drawing.Point(160, 267);
            this.proidtxtbox.Name = "proidtxtbox";
            this.proidtxtbox.Size = new System.Drawing.Size(148, 23);
            this.proidtxtbox.TabIndex = 103;
            // 
            // proidlbl
            // 
            this.proidlbl.AutoSize = true;
            this.proidlbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proidlbl.Location = new System.Drawing.Point(22, 268);
            this.proidlbl.Name = "proidlbl";
            this.proidlbl.Size = new System.Drawing.Size(98, 17);
            this.proidlbl.TabIndex = 102;
            this.proidlbl.Text = "PRODUCT ID";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(362, 392);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 113;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // shopcartgridview
            // 
            this.shopcartgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shopcartgridview.Location = new System.Drawing.Point(22, 430);
            this.shopcartgridview.Name = "shopcartgridview";
            this.shopcartgridview.ReadOnly = true;
            this.shopcartgridview.RowHeadersWidth = 51;
            this.shopcartgridview.RowTemplate.Height = 25;
            this.shopcartgridview.Size = new System.Drawing.Size(409, 185);
            this.shopcartgridview.TabIndex = 114;
            // 
            // listViewBindingSource
            // 
            this.listViewBindingSource.DataSource = typeof(System.Windows.Forms.ListView);
            // 
            // delitembtn
            // 
            this.delitembtn.Location = new System.Drawing.Point(271, 649);
            this.delitembtn.Name = "delitembtn";
            this.delitembtn.Size = new System.Drawing.Size(75, 23);
            this.delitembtn.TabIndex = 115;
            this.delitembtn.Text = "Delete";
            this.delitembtn.UseVisualStyleBackColor = true;
            this.delitembtn.Click += new System.EventHandler(this.delitembtn_Click);
            // 
            // notamemlbl
            // 
            this.notamemlbl.AutoSize = true;
            this.notamemlbl.Location = new System.Drawing.Point(92, 172);
            this.notamemlbl.Name = "notamemlbl";
            this.notamemlbl.Size = new System.Drawing.Size(163, 15);
            this.notamemlbl.TabIndex = 116;
            this.notamemlbl.Text = "NOT A MEMBER ?CLICK HERE";
            this.notamemlbl.Click += new System.EventHandler(this.notamemlbl_Click);
            // 
            // formemberlbl
            // 
            this.formemberlbl.AutoSize = true;
            this.formemberlbl.Location = new System.Drawing.Point(99, 171);
            this.formemberlbl.Name = "formemberlbl";
            this.formemberlbl.Size = new System.Drawing.Size(148, 15);
            this.formemberlbl.TabIndex = 117;
            this.formemberlbl.Text = "FOR MEMBER?CLICK HERE";
            this.formemberlbl.Click += new System.EventHandler(this.formemberlbl_Click);
            // 
            // noproidlbl
            // 
            this.noproidlbl.AutoSize = true;
            this.noproidlbl.Location = new System.Drawing.Point(92, 359);
            this.noproidlbl.Name = "noproidlbl";
            this.noproidlbl.Size = new System.Drawing.Size(163, 15);
            this.noproidlbl.TabIndex = 118;
            this.noproidlbl.Text = "NO PRODUCT ID?CLICK HERE";
            this.noproidlbl.Click += new System.EventHandler(this.noproidlbl_Click);
            // 
            // havproidlbl
            // 
            this.havproidlbl.AutoSize = true;
            this.havproidlbl.Location = new System.Drawing.Point(85, 362);
            this.havproidlbl.Name = "havproidlbl";
            this.havproidlbl.Size = new System.Drawing.Size(188, 15);
            this.havproidlbl.TabIndex = 119;
            this.havproidlbl.Text = "HAVING PRODUCT ID?CLICK HERE";
            this.havproidlbl.Click += new System.EventHandler(this.havproidlbl_Click);
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totallbl.Location = new System.Drawing.Point(27, 655);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(51, 17);
            this.totallbl.TabIndex = 120;
            this.totallbl.Text = "TOTAL";
            // 
            // totaltxtbox
            // 
            this.totaltxtbox.Location = new System.Drawing.Point(85, 653);
            this.totaltxtbox.Name = "totaltxtbox";
            this.totaltxtbox.Size = new System.Drawing.Size(117, 23);
            this.totaltxtbox.TabIndex = 121;
            // 
            // printbtn
            // 
            this.printbtn.Location = new System.Drawing.Point(504, 649);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(94, 23);
            this.printbtn.TabIndex = 123;
            this.printbtn.Text = "Print ";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // searchprolbl
            // 
            this.searchprolbl.AutoSize = true;
            this.searchprolbl.Location = new System.Drawing.Point(73, 293);
            this.searchprolbl.Name = "searchprolbl";
            this.searchprolbl.Size = new System.Drawing.Size(237, 15);
            this.searchprolbl.TabIndex = 124;
            this.searchprolbl.Text = "SEARCHING FOR PRODUCT ID? CLICK HERE";
            this.searchprolbl.Click += new System.EventHandler(this.searchprolbl_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(338, 22);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 135;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Billingpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 781);
            this.Controls.Add(this.searchprolbl);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.totaltxtbox);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.havproidlbl);
            this.Controls.Add(this.noproidlbl);
            this.Controls.Add(this.formemberlbl);
            this.Controls.Add(this.notamemlbl);
            this.Controls.Add(this.delitembtn);
            this.Controls.Add(this.shopcartgridview);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.proidfetchbtn);
            this.Controls.Add(this.proquantitytxtbox);
            this.Controls.Add(this.proquantitylbl);
            this.Controls.Add(this.propricetxtbox);
            this.Controls.Add(this.propricelbl);
            this.Controls.Add(this.pronametxtbox);
            this.Controls.Add(this.pronamelbl);
            this.Controls.Add(this.proidtxtbox);
            this.Controls.Add(this.proidlbl);
            this.Controls.Add(this.memidfetchbtn);
            this.Controls.Add(this.custmobiletxtbox);
            this.Controls.Add(this.memvaliditylabel);
            this.Controls.Add(this.memvaliditytxtbox);
            this.Controls.Add(this.custmobilelbl);
            this.Controls.Add(this.custgendertxtbox);
            this.Controls.Add(this.custgenderlbl);
            this.Controls.Add(this.custnametxtbox);
            this.Controls.Add(this.custnamelabel);
            this.Controls.Add(this.memidtxtbox);
            this.Controls.Add(this.memidlabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel6);
            this.Name = "Billingpage";
            this.Text = "Billing Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Billingpage_FormClosed);
            this.Load += new System.EventHandler(this.Billingpage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopcartgridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Panel panel1;
        internal Label label16;
        internal Panel panel2;
        internal Panel Panel6;
        internal Label label15;
        internal Panel Panel9;
        private Label billinglbl;
        internal Label memidlabel;
        private TextBox memidtxtbox;
        private TextBox custnametxtbox;
        internal Label custnamelabel;
        private TextBox custgendertxtbox;
        internal Label custgenderlbl;
        private TextBox custmobiletxtbox;
        internal Label memvaliditylabel;
        private TextBox memvaliditytxtbox;
        internal Label custmobilelbl;
        private Button memidfetchbtn;
        private Button proidfetchbtn;
        private TextBox proquantitytxtbox;
        internal Label proquantitylbl;
        private TextBox propricetxtbox;
        internal Label propricelbl;
        private TextBox pronametxtbox;
        internal Label pronamelbl;
        private TextBox proidtxtbox;
        internal Label proidlbl;
        private Button addbtn;
        private DataGridView shopcartgridview;
        private BindingSource listViewBindingSource;
        private Button delitembtn;
        private Label notamemlbl;
        private Label formemberlbl;
        private Button signoutbtn;
        private Label noproidlbl;
        private Label havproidlbl;
        internal Label totallbl;
        private TextBox totaltxtbox;
        private Button newcustomerbtn;
        private Button printbtn;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label searchprolbl;
        private Button back;
    }
}