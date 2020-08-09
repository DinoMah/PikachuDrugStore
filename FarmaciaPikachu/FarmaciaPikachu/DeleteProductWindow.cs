using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Linq;

namespace FarmaciaPikachu
{
    public partial class DeleteProductWindow : Form
    {
        private Form parent;
        private List<Product> productList;

        public DeleteProductWindow(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.productList = new List<Product>();

            //Disable product info fields
            this.productNameBox.ReadOnly = true;
            this.productPriceBox.ReadOnly = true;
            this.productProviderBox.ReadOnly = true;
            this.productDescriptionBox.ReadOnly = true;
            this.validProductDate.Enabled = false;
        }

        private void DeleteProductWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.parent.Show();
        }

        private void searchProducts(object sender, KeyPressEventArgs e)
        {
            if(this.searchBox.TextLength >= 3)
            {
                Search search = new Search();
                this.productList.Clear();
                this.searchResultsList.Items.Clear(); // This is the visual list on the window
                this.productList = search.SearchByName(this.searchBox.Text);
                foreach(ModifiableProduct el in this.productList) 
                    this.searchResultsList.Items.Add(el.Name);
            }
        }

        private void searchResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.searchResultsList.SelectedIndex != -1)
            {
                this.fillProductDetails(this.searchResultsList.SelectedIndex);
            }
        }

        private void fillProductDetails(int productIndex)
        {
            this.productNameBox.Text = this.productList.ElementAt(productIndex).Name;
            this.productPriceBox.Text = this.productList.ElementAt(productIndex).Price.ToString();
            this.productProviderBox.Text = this.productList.ElementAt(productIndex).Provider;
            this.productDescriptionBox.Text = this.productList.ElementAt(productIndex).Description;
            this.validProductDate.Value = this.productList.ElementAt(productIndex).ExpirationDate;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            if(!this.productsToDelete.Items.Contains(this.productNameBox.Text) && !this.productNameBox.Text.Equals(""))
                this.productsToDelete.Items.Add(this.productNameBox.Text);
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.parent.Show();
        }

        private void deleteProductsButton_Click(object sender, EventArgs e)
        {
            var optionSelected = MessageBox.Show("¿Estás seguro de eliminar los elementos de la lista?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(optionSelected == DialogResult.Yes)
                if(deleteRecords()) 
                {
                    MessageBox.Show("> Elementos eliminados satisfactoriamente.", "Admin", MessageBoxButtons.OK);
                    this.resetValues();
                }
                else
                    MessageBox.Show("> ¡Ops! Algo salió mal, intentalo de nuevo.", "Admin", MessageBoxButtons.OK);
        }

        private bool deleteRecords()
        {
            DataBase db = new DataBase();
            String command = $"DELETE FROM product WHERE Name = '{this.productNameBox.Text.Trim()}'";
            var reader = db.executeCommand(command);
            if(reader.RecordsAffected >= 1)
                return true;
            else
                return false;
        }

        private void resetValues()
        {
            this.productList.Clear();
            this.productsToDelete.Items.Clear();
            this.productNameBox.Text = "";
            this.productPriceBox.Text = "";
            this.productProviderBox.Text = "";
            this.productDescriptionBox.Text = "";
            this.searchResultsList.Items.Clear();
            this.validProductDate.Value = DateTime.Now;
        }
    }
}
