 using System;
using System.Windows.Forms;

namespace FarmaciaPikachu
{
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            
            InitializeComponent();
        }

        private void addProduct(object sender, EventArgs e)
        {
            var registerProductWindow = new RegisterProductForm(this);
            registerProductWindow.Show();
            this.Hide();
        }

        private void openDeletesWindow(object sender, EventArgs e) 
        {
            var deleteProductWindow = new DeleteProductWindow(this);
            deleteProductWindow.Show();
            this.Hide();
        }

        private void openChangesWindow(object sender, EventArgs e) 
        {
            var changeProductInfoWindow = new ChangeProductInfo(this);
            changeProductInfoWindow.Show();
            this.Hide();
        }

        private void openConsultsWindow(object sender, EventArgs e) 
        {
            var viewProductInfo = new ViewProductInfo(this);
            viewProductInfo.Show();
            this.Hide();
        }
    }
}
