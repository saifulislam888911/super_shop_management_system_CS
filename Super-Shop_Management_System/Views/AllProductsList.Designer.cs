namespace Super_Shop_Management_System.Views
{
    partial class AllProductsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAllProductList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "All Products List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewAllProductList
            // 
            this.dataGridViewAllProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllProductList.Location = new System.Drawing.Point(137, 113);
            this.dataGridViewAllProductList.Name = "dataGridViewAllProductList";
            this.dataGridViewAllProductList.Size = new System.Drawing.Size(524, 159);
            this.dataGridViewAllProductList.TabIndex = 42;
            this.dataGridViewAllProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllProductList_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 35);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "<--Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AllProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewAllProductList);
            this.Controls.Add(this.label1);
            this.Name = "AllProductsList";
            this.Text = "AllProductsList";
            this.Load += new System.EventHandler(this.AllProductsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAllProductList;
        private System.Windows.Forms.Button btnBack;
    }
}