using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FarmaciaPikachu 
{
    public partial class ChangeProductInfo : Form 
    {
        private Form parent;
        private List<ModifiableProduct> productList;
        private int currentProductNumber;
        private List<Int32> changedProducts;
        
        
        public ChangeProductInfo(Form parent) 
        {
            InitializeComponent();
            this.parent = parent;
            this.productList = new List<ModifiableProduct>();
            this.currentProductNumber = -1;
            this.changedProducts = new List<Int32>();
            this.productNameBox.Enabled = false;
        }

        public void searchProducts(object sender, KeyPressEventArgs e)
        {
            if(this.searchBox.TextLength >= 3)
            {
                Search search = new Search();
                this.productList.Clear();
                this.searchResultsList.Items.Clear(); // This is the visual list on the window
                var products = search.SearchByName(this.searchBox.Text);
                foreach(ModifiableProduct el in products) {
                    this.productList.Add(
                        new ModifiableProduct()
                        {
                            Name = el.Name,
                            Price = el.Price,
                            Provider = el.Provider,
                            Description = el.Description
                        }
                    );
                    this.searchResultsList.Items.Add(el.Name);
                }
            }
        }

        private void ChangeProductInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose(); 
            this.parent.Show();
        }

        private void resetValues()
        {
            this.productList.Clear();
            this.currentProductNumber = -1;
            this.changedProducts.Clear();
            this.productNameBox.Text = "";
            this.productPriceBox.Text = "";
            this.productProviderBox.Text = "";
            this.productDescriptionBox.Text = "";
            this.searchResultsList.Items.Clear();
            this.modifiedProductList.Items.Clear();
        }

        private void dataHasChanged(object sender, KeyPressEventArgs e)
        {
            this.productList.ElementAt(this.currentProductNumber).Changed = true;
        }

        private void InProductSelected(object sender, EventArgs e)
        {
            if(this.searchResultsList.SelectedIndex != -1)
            {
                if(this.currentProductNumber != -1)
                    if(this.productList.ElementAt(this.currentProductNumber).Changed)
                    {
                        if(!this.changedProducts.Contains(this.currentProductNumber))
                        { 
                            this.changedProducts.Add(this.currentProductNumber);
                            this.modifiedProductList.Items.Add(this.productList.ElementAt(this.currentProductNumber).Name);
                        }
                        this.productList.ElementAt(this.currentProductNumber).Price = Convert.ToSingle(this.productPriceBox.Text.Trim());
                        this.productList.ElementAt(this.currentProductNumber).Provider = this.productProviderBox.Text.Trim();
                        this.productList.ElementAt(this.currentProductNumber).Description = this.productDescriptionBox.Text.Trim();
                        this.productList.ElementAt(this.currentProductNumber).Changed = false;
                    }
                this.updateCurrentProductNumber();
                this.fillProductDetails(this.searchResultsList.SelectedIndex);
            }
        }

        private void updateCurrentProductNumber()
        {
            this.currentProductNumber = this.searchResultsList.SelectedIndex;
        }

        private void fillProductDetails(int productIndex)
        {
            this.productNameBox.Text = this.productList.ElementAt(productIndex).Name;
            this.productPriceBox.Text = this.productList.ElementAt(productIndex).Price.ToString();
            this.productProviderBox.Text = this.productList.ElementAt(productIndex).Provider;
            this.productDescriptionBox.Text = this.productList.ElementAt(productIndex).Description;
        }

        private void verifyChangeProductData(object sender, EventArgs e)
        {
            if(this.modifiedProductList.Items.Count == 0)
                MessageBox.Show("> No se han realizado cambios.", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
            {
                var selectedOption = MessageBox.Show("> ¿Quieres guardar los cambios hechos a la información?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(selectedOption == DialogResult.Yes)
                {
                    if(this.saveChanges())
                    {
                        MessageBox.Show("> ¡Guardado exitoso!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.resetValues();
                    }
                    else
                    {
                        MessageBox.Show("> ¡Ops! Hubo un error al guardar, intentelo de nuevo.", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private Boolean saveChanges()
        {
            DataBase db = new DataBase();
            String command = null;
            foreach(int e in this.changedProducts)
            {
                command = "UPDATE product SET " + 
                          $"Price = '{this.productList.ElementAt(e).Price}', " +
                          $"Provider = '{this.productList.ElementAt(e).Provider}', " +
                          $"Description = '{this.productList.ElementAt(e).Description}' " +
                          $"WHERE Name = '{this.productList.ElementAt(e).Name}'";
                var result = db.executeCommand(command);
                if(result == null)
                    return false;
            }
            db.closeConnection();
            return true;
        }

        private void onCloseWindow(object sender, EventArgs e)
        {
            this.Dispose(); 
            this.parent.Show();
        }
    }
}
