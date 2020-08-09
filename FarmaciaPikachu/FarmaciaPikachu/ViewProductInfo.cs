using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaPikachu
{
    public partial class ViewProductInfo : Form
    {
        private Form parent;
        private List<Product> productList;

        public ViewProductInfo(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.productList = new List<Product>();

            //Buttons disabled by default
            //this.productNameBox.Enabled = false;
            this.productNameBox.ReadOnly = true;
            this.productPriceBox.ReadOnly = true;
            this.productProviderBox.ReadOnly = true;
            this.productDescriptionBox.ReadOnly = true;
            this.validDateBox.Enabled = false;
        }

        private void onWindowClosed(object sender, EventArgs e)
        {
            this.Dispose();
            this.parent.Show();
        }

        private void ViewProductInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
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

        private void inProductSelected(object sender, EventArgs e)
        {
            if(this.searchResultsList.SelectedIndex != -1)
                this.fillProductDetails(this.searchResultsList.SelectedIndex);
        }

        private void fillProductDetails(Int32 productIndex)
        {
            this.productNameBox.Text = this.productList.ElementAt(productIndex).Name;
            this.productPriceBox.Text = this.productList.ElementAt(productIndex).Price.ToString();
            this.productProviderBox.Text = this.productList.ElementAt(productIndex).Provider;
            this.productDescriptionBox.Text = this.productList.ElementAt(productIndex).Description;
            this.validDateBox.Value = this.productList.ElementAt(productIndex).ExpirationDate;
        }
    }
}
