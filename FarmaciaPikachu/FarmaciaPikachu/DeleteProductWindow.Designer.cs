namespace FarmaciaPikachu
{
    partial class DeleteProductWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteProductWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.validProductDate = new System.Windows.Forms.DateTimePicker();
            this.productDescriptionBox = new System.Windows.Forms.TextBox();
            this.productPriceBox = new System.Windows.Forms.TextBox();
            this.productProviderBox = new System.Windows.Forms.TextBox();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchResultsList = new System.Windows.Forms.ListBox();
            this.productsToDelete = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deleteProductsButton = new System.Windows.Forms.Button();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.validProductDate);
            this.groupBox1.Controls.Add(this.productDescriptionBox);
            this.groupBox1.Controls.Add(this.productPriceBox);
            this.groupBox1.Controls.Add(this.productProviderBox);
            this.groupBox1.Controls.Add(this.productNameBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 379);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Producto";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(125, 344);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(139, 23);
            this.addProductButton.TabIndex = 10;
            this.addProductButton.Text = "Agregar producto a la lista";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de caducidad";
            // 
            // validProductDate
            // 
            this.validProductDate.Location = new System.Drawing.Point(9, 318);
            this.validProductDate.Name = "validProductDate";
            this.validProductDate.Size = new System.Drawing.Size(371, 20);
            this.validProductDate.TabIndex = 8;
            // 
            // productDescriptionBox
            // 
            this.productDescriptionBox.Location = new System.Drawing.Point(9, 180);
            this.productDescriptionBox.Multiline = true;
            this.productDescriptionBox.Name = "productDescriptionBox";
            this.productDescriptionBox.Size = new System.Drawing.Size(371, 115);
            this.productDescriptionBox.TabIndex = 7;
            // 
            // productPriceBox
            // 
            this.productPriceBox.Location = new System.Drawing.Point(9, 84);
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(371, 20);
            this.productPriceBox.TabIndex = 6;
            // 
            // productProviderBox
            // 
            this.productProviderBox.Location = new System.Drawing.Point(9, 132);
            this.productProviderBox.Name = "productProviderBox";
            this.productProviderBox.Size = new System.Drawing.Size(371, 20);
            this.productProviderBox.TabIndex = 5;
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(9, 32);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(371, 20);
            this.productNameBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Proveedor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Búscar";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(16, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(380, 20);
            this.searchBox.TabIndex = 8;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchProducts);
            // 
            // searchResultsList
            // 
            this.searchResultsList.FormattingEnabled = true;
            this.searchResultsList.Location = new System.Drawing.Point(15, 77);
            this.searchResultsList.Name = "searchResultsList";
            this.searchResultsList.Size = new System.Drawing.Size(380, 108);
            this.searchResultsList.TabIndex = 9;
            this.searchResultsList.SelectedIndexChanged += new System.EventHandler(this.searchResultsList_SelectedIndexChanged);
            // 
            // productsToDelete
            // 
            this.productsToDelete.FormattingEnabled = true;
            this.productsToDelete.Location = new System.Drawing.Point(15, 212);
            this.productsToDelete.Name = "productsToDelete";
            this.productsToDelete.Size = new System.Drawing.Size(381, 173);
            this.productsToDelete.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Productos a eliminar";
            // 
            // deleteProductsButton
            // 
            this.deleteProductsButton.Location = new System.Drawing.Point(285, 409);
            this.deleteProductsButton.Name = "deleteProductsButton";
            this.deleteProductsButton.Size = new System.Drawing.Size(110, 23);
            this.deleteProductsButton.TabIndex = 13;
            this.deleteProductsButton.Text = "Eliminar productos";
            this.deleteProductsButton.UseVisualStyleBackColor = true;
            this.deleteProductsButton.Click += new System.EventHandler(this.deleteProductsButton_Click);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(402, 409);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(75, 23);
            this.closeWindowButton.TabIndex = 14;
            this.closeWindowButton.Text = "Cerrar";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // DeleteProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.deleteProductsButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productsToDelete);
            this.Controls.Add(this.searchResultsList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DeleteProductWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bajas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteProductWindow_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox productDescriptionBox;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.TextBox productProviderBox;
        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker validProductDate;
        private System.Windows.Forms.ListBox searchResultsList;
        private System.Windows.Forms.ListBox productsToDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteProductsButton;
        private System.Windows.Forms.Button closeWindowButton;
    }
}