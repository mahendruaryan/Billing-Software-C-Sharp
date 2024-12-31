namespace WinFormsApp4
{
    partial class AddProduct
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
            this.pronametxtbox = new System.Windows.Forms.TextBox();
            this.pronamelbl = new System.Windows.Forms.Label();
            this.propricextbox = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pronametxtbox
            // 
            this.pronametxtbox.Location = new System.Drawing.Point(153, 75);
            this.pronametxtbox.Name = "pronametxtbox";
            this.pronametxtbox.Size = new System.Drawing.Size(148, 23);
            this.pronametxtbox.TabIndex = 1;
            // 
            // pronamelbl
            // 
            this.pronamelbl.AutoSize = true;
            this.pronamelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pronamelbl.Location = new System.Drawing.Point(15, 76);
            this.pronamelbl.Name = "pronamelbl";
            this.pronamelbl.Size = new System.Drawing.Size(122, 17);
            this.pronamelbl.TabIndex = 118;
            this.pronamelbl.Text = "PRODUCT NAME";
            // 
            // propricextbox
            // 
            this.propricextbox.Location = new System.Drawing.Point(153, 141);
            this.propricextbox.Name = "propricextbox";
            this.propricextbox.Size = new System.Drawing.Size(148, 23);
            this.propricextbox.TabIndex = 2;
            this.propricextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.propricextbox_KeyPress);
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pricelbl.Location = new System.Drawing.Point(15, 141);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(52, 17);
            this.pricelbl.TabIndex = 116;
            this.pricelbl.Text = "PRICE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Location = new System.Drawing.Point(-21, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 53);
            this.panel1.TabIndex = 121;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(26, 24);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(239, 262);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 309);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pronametxtbox);
            this.Controls.Add(this.pronamelbl);
            this.Controls.Add(this.propricextbox);
            this.Controls.Add(this.pricelbl);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddProduct_FormClosed);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox pronametxtbox;
        internal Label pronamelbl;
        private TextBox propricextbox;
        internal Label pricelbl;
        private Panel panel1;
        private Button backbtn;
        private Button addbtn;
    }
}