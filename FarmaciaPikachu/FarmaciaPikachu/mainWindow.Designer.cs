namespace FarmaciaPikachu
{
    partial class ventanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.registerProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.changeInfoButton = new System.Windows.Forms.Button();
            this.watchInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "FARMACIA PIKACHÚ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.registerProductButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteProductButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.changeInfoButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.watchInfoButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 330);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 192);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // registerProductButton
            // 
            this.registerProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerProductButton.Location = new System.Drawing.Point(3, 3);
            this.registerProductButton.Name = "registerProductButton";
            this.registerProductButton.Size = new System.Drawing.Size(416, 90);
            this.registerProductButton.TabIndex = 0;
            this.registerProductButton.Text = "Dar de alta producto(s)";
            this.registerProductButton.UseVisualStyleBackColor = true;
            this.registerProductButton.Click += new System.EventHandler(this.addProduct);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProductButton.Location = new System.Drawing.Point(425, 3);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(416, 90);
            this.deleteProductButton.TabIndex = 1;
            this.deleteProductButton.Text = "Dar de baja producto(s)";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.openDeletesWindow);
            // 
            // changeInfoButton
            // 
            this.changeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeInfoButton.Location = new System.Drawing.Point(3, 99);
            this.changeInfoButton.Name = "changeInfoButton";
            this.changeInfoButton.Size = new System.Drawing.Size(416, 90);
            this.changeInfoButton.TabIndex = 2;
            this.changeInfoButton.Text = "Cambiar información de algún producto";
            this.changeInfoButton.UseVisualStyleBackColor = true;
            this.changeInfoButton.Click += new System.EventHandler(this.openChangesWindow);
            // 
            // watchInfoButton
            // 
            this.watchInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.watchInfoButton.Location = new System.Drawing.Point(425, 99);
            this.watchInfoButton.Name = "watchInfoButton";
            this.watchInfoButton.Size = new System.Drawing.Size(416, 90);
            this.watchInfoButton.TabIndex = 3;
            this.watchInfoButton.Text = "Consultar información de algún producto";
            this.watchInfoButton.UseVisualStyleBackColor = true;
            this.watchInfoButton.Click += new System.EventHandler(this.openConsultsWindow);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 534);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(884, 573);
            this.MinimumSize = new System.Drawing.Size(884, 573);
            this.Name = "ventanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button registerProductButton;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button changeInfoButton;
        private System.Windows.Forms.Button watchInfoButton;
    }
}

