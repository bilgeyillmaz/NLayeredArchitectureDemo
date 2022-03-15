namespace WepFormAppUI
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.tbxUpdateUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblUpdateUnitsInStock = new System.Windows.Forms.Label();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateQantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateCategoryId = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.gbxAddProducts = new System.Windows.Forms.GroupBox();
            this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.cbsAddCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.lblQantityPerUnit = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxUpdateProduct.SuspendLayout();
            this.gbxAddProducts.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(591, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(527, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateUnitsInStock);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateUnitsInStock);
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdateCategoryId);
            this.gbxUpdateProduct.Controls.Add(this.btnUpdate);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateQantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateCategoryId);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(568, 458);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(550, 176);
            this.gbxUpdateProduct.TabIndex = 18;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Update Product";
            // 
            // tbxUpdateUnitsInStock
            // 
            this.tbxUpdateUnitsInStock.Location = new System.Drawing.Point(387, 112);
            this.tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            this.tbxUpdateUnitsInStock.Size = new System.Drawing.Size(143, 22);
            this.tbxUpdateUnitsInStock.TabIndex = 11;
            // 
            // lblUpdateUnitsInStock
            // 
            this.lblUpdateUnitsInStock.AutoSize = true;
            this.lblUpdateUnitsInStock.Location = new System.Drawing.Point(276, 115);
            this.lblUpdateUnitsInStock.Name = "lblUpdateUnitsInStock";
            this.lblUpdateUnitsInStock.Size = new System.Drawing.Size(87, 16);
            this.lblUpdateUnitsInStock.TabIndex = 10;
            this.lblUpdateUnitsInStock.Text = "Units In Stock";
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(118, 66);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(144, 24);
            this.cbxUpdateCategoryId.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(23, 147);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(507, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(387, 68);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(143, 22);
            this.tbxUpdateQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(119, 112);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(143, 22);
            this.tbxUpdateUnitPrice.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(119, 30);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(143, 22);
            this.tbxUpdateProductName.TabIndex = 3;
            // 
            // lblUpdateQantityPerUnit
            // 
            this.lblUpdateQantityPerUnit.AutoSize = true;
            this.lblUpdateQantityPerUnit.Location = new System.Drawing.Point(276, 74);
            this.lblUpdateQantityPerUnit.Name = "lblUpdateQantityPerUnit";
            this.lblUpdateQantityPerUnit.Size = new System.Drawing.Size(105, 16);
            this.lblUpdateQantityPerUnit.TabIndex = 4;
            this.lblUpdateQantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(20, 115);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.lblUpdateUnitPrice.TabIndex = 2;
            this.lblUpdateUnitPrice.Text = "Unit Price";
            // 
            // lblUpdateCategoryId
            // 
            this.lblUpdateCategoryId.AutoSize = true;
            this.lblUpdateCategoryId.Location = new System.Drawing.Point(20, 74);
            this.lblUpdateCategoryId.Name = "lblUpdateCategoryId";
            this.lblUpdateCategoryId.Size = new System.Drawing.Size(62, 16);
            this.lblUpdateCategoryId.TabIndex = 1;
            this.lblUpdateCategoryId.Text = "Category";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(20, 36);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(93, 16);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Product Name";
            // 
            // gbxAddProducts
            // 
            this.gbxAddProducts.Controls.Add(this.tbxUnitsInStock);
            this.gbxAddProducts.Controls.Add(this.lblUnitsInStock);
            this.gbxAddProducts.Controls.Add(this.cbsAddCategory);
            this.gbxAddProducts.Controls.Add(this.btnAdd);
            this.gbxAddProducts.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxAddProducts.Controls.Add(this.tbxUnitPrice);
            this.gbxAddProducts.Controls.Add(this.tbxAddProductName);
            this.gbxAddProducts.Controls.Add(this.lblQantityPerUnit);
            this.gbxAddProducts.Controls.Add(this.lblUnitPrice);
            this.gbxAddProducts.Controls.Add(this.lblCategoryId);
            this.gbxAddProducts.Controls.Add(this.lblAddProductName);
            this.gbxAddProducts.Location = new System.Drawing.Point(12, 458);
            this.gbxAddProducts.Name = "gbxAddProducts";
            this.gbxAddProducts.Size = new System.Drawing.Size(550, 176);
            this.gbxAddProducts.TabIndex = 15;
            this.gbxAddProducts.TabStop = false;
            this.gbxAddProducts.Text = "Add New Product";
            // 
            // tbxUnitsInStock
            // 
            this.tbxUnitsInStock.Location = new System.Drawing.Point(387, 112);
            this.tbxUnitsInStock.Name = "tbxUnitsInStock";
            this.tbxUnitsInStock.Size = new System.Drawing.Size(143, 22);
            this.tbxUnitsInStock.TabIndex = 11;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(276, 115);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(87, 16);
            this.lblUnitsInStock.TabIndex = 10;
            this.lblUnitsInStock.Text = "Units In Stock";
            // 
            // cbsAddCategory
            // 
            this.cbsAddCategory.FormattingEnabled = true;
            this.cbsAddCategory.Location = new System.Drawing.Point(118, 66);
            this.cbsAddCategory.Name = "cbsAddCategory";
            this.cbsAddCategory.Size = new System.Drawing.Size(144, 24);
            this.cbsAddCategory.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(23, 147);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(507, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(387, 68);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(143, 22);
            this.tbxQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(119, 112);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(143, 22);
            this.tbxUnitPrice.TabIndex = 6;
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(119, 30);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(143, 22);
            this.tbxAddProductName.TabIndex = 3;
            // 
            // lblQantityPerUnit
            // 
            this.lblQantityPerUnit.AutoSize = true;
            this.lblQantityPerUnit.Location = new System.Drawing.Point(276, 74);
            this.lblQantityPerUnit.Name = "lblQantityPerUnit";
            this.lblQantityPerUnit.Size = new System.Drawing.Size(105, 16);
            this.lblQantityPerUnit.TabIndex = 4;
            this.lblQantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(20, 115);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(64, 16);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(20, 74);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(62, 16);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(20, 36);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(93, 16);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Product Name";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.tbxProductName);
            this.gbxProduct.Controls.Add(this.lblProductName);
            this.gbxProduct.Location = new System.Drawing.Point(12, 104);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(481, 84);
            this.gbxProduct.TabIndex = 16;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Search by Product Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(118, 33);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(335, 22);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(20, 39);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(481, 77);
            this.gbxCategory.TabIndex = 14;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search by Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(119, 36);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(335, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(51, 36);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 205);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1106, 238);
            this.dgwProduct.TabIndex = 13;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 642);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProducts);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.gbxAddProducts.ResumeLayout(false);
            this.gbxAddProducts.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.TextBox tbxUpdateUnitsInStock;
        private System.Windows.Forms.Label lblUpdateUnitsInStock;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateQantityPerUnit;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateCategoryId;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.GroupBox gbxAddProducts;
        private System.Windows.Forms.TextBox tbxUnitsInStock;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.ComboBox cbsAddCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.Label lblQantityPerUnit;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}

