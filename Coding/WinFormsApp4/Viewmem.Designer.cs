namespace WinFormsApp4
{
    partial class Viewmem
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
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxbox = new System.Windows.Forms.TextBox();
            this.memdatagid = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.memdatagid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(328, 61);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxbox
            // 
            this.searchtxbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtxbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchtxbox.Location = new System.Drawing.Point(29, 61);
            this.searchtxbox.Name = "searchtxbox";
            this.searchtxbox.Size = new System.Drawing.Size(290, 23);
            this.searchtxbox.TabIndex = 4;
            this.searchtxbox.Text = "Please enter Name or Last Name";
            this.searchtxbox.Click += new System.EventHandler(this.searchtxbox_Click);
            // 
            // memdatagid
            // 
            this.memdatagid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memdatagid.Location = new System.Drawing.Point(12, 107);
            this.memdatagid.Name = "memdatagid";
            this.memdatagid.ReadOnly = true;
            this.memdatagid.RowTemplate.Height = 25;
            this.memdatagid.Size = new System.Drawing.Size(403, 256);
            this.memdatagid.TabIndex = 3;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Location = new System.Drawing.Point(-8, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 53);
            this.panel1.TabIndex = 122;
            // 
            // Viewmem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxbox);
            this.Controls.Add(this.memdatagid);
            this.Name = "Viewmem";
            this.Text = "Viewmem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Viewmem_FormClosed);
            this.Load += new System.EventHandler(this.Viewmem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memdatagid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchbtn;
        private TextBox searchtxbox;
        private DataGridView memdatagid;
        private Button backbtn;
        private Panel panel1;
    }
}