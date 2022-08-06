
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxName = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAddlProductName = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.cbxAddCategoryName = new System.Windows.Forms.ComboBox();
            this.tbxAddQuantity = new System.Windows.Forms.TextBox();
            this.tbxAddStockAmount = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateCategoryName = new System.Windows.Forms.ComboBox();
            this.tbxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 183);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(789, 181);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(106, 28);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(164, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(25, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(25, 42);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(106, 39);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(164, 20);
            this.tbxProductName.TabIndex = 4;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(299, 85);
            this.gbxCategory.TabIndex = 5;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search By Category";
            // 
            // gbxName
            // 
            this.gbxName.Controls.Add(this.lblProductName);
            this.gbxName.Controls.Add(this.tbxProductName);
            this.gbxName.Location = new System.Drawing.Point(12, 103);
            this.gbxName.Name = "gbxName";
            this.gbxName.Size = new System.Drawing.Size(299, 74);
            this.gbxName.TabIndex = 3;
            this.gbxName.TabStop = false;
            this.gbxName.Text = "Search By Product Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.cbxAddCategoryName);
            this.groupBox1.Controls.Add(this.tbxAddQuantity);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.tbxAddStockAmount);
            this.groupBox1.Controls.Add(this.lblStockAmount);
            this.groupBox1.Controls.Add(this.tbxAddUnitPrice);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.lblAddCategory);
            this.groupBox1.Controls.Add(this.tbxAddProductName);
            this.groupBox1.Controls.Add(this.lbAddlProductName);
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Product";
            // 
            // lbAddlProductName
            // 
            this.lbAddlProductName.AutoSize = true;
            this.lbAddlProductName.Location = new System.Drawing.Point(25, 30);
            this.lbAddlProductName.Name = "lbAddlProductName";
            this.lbAddlProductName.Size = new System.Drawing.Size(75, 13);
            this.lbAddlProductName.TabIndex = 0;
            this.lbAddlProductName.Text = "Product Name";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(116, 28);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(121, 20);
            this.tbxAddProductName.TabIndex = 1;
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(25, 67);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(49, 13);
            this.lblAddCategory.TabIndex = 2;
            this.lblAddCategory.Text = "Category";
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(116, 105);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxAddUnitPrice.TabIndex = 5;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(25, 107);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(259, 66);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(259, 29);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(74, 13);
            this.lblStockAmount.TabIndex = 6;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // cbxAddCategoryName
            // 
            this.cbxAddCategoryName.FormattingEnabled = true;
            this.cbxAddCategoryName.Location = new System.Drawing.Point(116, 64);
            this.cbxAddCategoryName.Name = "cbxAddCategoryName";
            this.cbxAddCategoryName.Size = new System.Drawing.Size(121, 21);
            this.cbxAddCategoryName.TabIndex = 10;
            // 
            // tbxAddQuantity
            // 
            this.tbxAddQuantity.Location = new System.Drawing.Point(350, 64);
            this.tbxAddQuantity.Name = "tbxAddQuantity";
            this.tbxAddQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxAddQuantity.TabIndex = 9;
            // 
            // tbxAddStockAmount
            // 
            this.tbxAddStockAmount.Location = new System.Drawing.Point(350, 27);
            this.tbxAddStockAmount.Name = "tbxAddStockAmount";
            this.tbxAddStockAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxAddStockAmount.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(350, 103);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 23);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnRemove);
            this.gbxProductUpdate.Controls.Add(this.btnUpdate);
            this.gbxProductUpdate.Controls.Add(this.cbxUpdateCategoryName);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateQuantity);
            this.gbxProductUpdate.Controls.Add(this.label1);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxProductUpdate.Controls.Add(this.label2);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxProductUpdate.Controls.Add(this.label3);
            this.gbxProductUpdate.Controls.Add(this.label4);
            this.gbxProductUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxProductUpdate.Controls.Add(this.label5);
            this.gbxProductUpdate.Location = new System.Drawing.Point(12, 370);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(789, 92);
            this.gbxProductUpdate.TabIndex = 7;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Update Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(579, 61);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxUpdateCategoryName
            // 
            this.cbxUpdateCategoryName.FormattingEnabled = true;
            this.cbxUpdateCategoryName.Location = new System.Drawing.Point(106, 63);
            this.cbxUpdateCategoryName.Name = "cbxUpdateCategoryName";
            this.cbxUpdateCategoryName.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateCategoryName.TabIndex = 10;
            // 
            // tbxUpdateQuantity
            // 
            this.tbxUpdateQuantity.Location = new System.Drawing.Point(350, 64);
            this.tbxUpdateQuantity.Name = "tbxUpdateQuantity";
            this.tbxUpdateQuantity.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateQuantity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantity";
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(350, 27);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateStockAmount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stock Amount";
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(579, 29);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateUnitPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category";
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(106, 27);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(121, 20);
            this.tbxUpdateProductName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(509, 61);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(64, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 509);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxName.ResumeLayout(false);
            this.gbxName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbxAddCategoryName;
        private System.Windows.Forms.TextBox tbxAddQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbxAddStockAmount;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.Label lbAddlProductName;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryName;
        private System.Windows.Forms.TextBox tbxUpdateQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

