namespace WinFormsApp4
{
    partial class Productid
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
            this.productsdatagid = new System.Windows.Forms.DataGridView();
            this.searchtxbox = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsdatagid)).BeginInit();
            this.SuspendLayout();
            // 
            // productsdatagid
            // 
            this.productsdatagid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsdatagid.Location = new System.Drawing.Point(8, 58);
            this.productsdatagid.Name = "productsdatagid";
            this.productsdatagid.ReadOnly = true;
            this.productsdatagid.RowTemplate.Height = 25;
            this.productsdatagid.Size = new System.Drawing.Size(403, 256);
            this.productsdatagid.TabIndex = 0;
            this.productsdatagid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsdatagid_CellContentClick);
            // 
            // searchtxbox
            // 
            this.searchtxbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtxbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchtxbox.Location = new System.Drawing.Point(28, 13);
            this.searchtxbox.Name = "searchtxbox";
            this.searchtxbox.Size = new System.Drawing.Size(290, 23);
            this.searchtxbox.TabIndex = 1;
            this.searchtxbox.Text = "Please enter Name or ID of product";
            this.searchtxbox.Click += new System.EventHandler(this.searchtxbox_Click);
            this.searchtxbox.TextChanged += new System.EventHandler(this.searchtxbox_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(324, 12);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Productid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 326);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxbox);
            this.Controls.Add(this.productsdatagid);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Productid";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Productid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsdatagid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView productsdatagid;
        private TextBox searchtxbox;
        private Button searchbtn;
    }
}