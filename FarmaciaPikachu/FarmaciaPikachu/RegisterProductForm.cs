using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FarmaciaPikachu {
    public partial class RegisterProductForm : Form {
        private List<Product> products;
        private Form parent;

        public RegisterProductForm(Form parent)
        {
            this.parent = parent;
            this.products = new List<Product>();
            /*
            using(SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                    Console.WriteLine("Id: {0}, Nombre: {1}", reader[0], reader[1]);
            }*/
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e) {}

        private void groupBox3_Enter(object sender, EventArgs e) {}

        public void registerProduct() {}

        private void button1_Click(object sender, EventArgs e) //Add product to list
        {
            var productToAdd = new Product();
            productToAdd.Name = this.nameBox.Text;
            productToAdd.Price = (this.priceBox.Text != "") ? float.Parse(this.priceBox.Text) : 0.0f;
            productToAdd.Provider = this.providerBox.Text;
            productToAdd.Description = this.descriptionBox.Text;
            productToAdd.ExpirationDate = this.validDateTimePicker.Value;
            this.checkedListBox1.Items.Add(productToAdd.Name + " $" + productToAdd.Price);
            int lastItemIndex = this.checkedListBox1.Items.Count - 1;
            this.checkedListBox1.SetItemChecked(lastItemIndex, true); //Marca el ultimo objeto agregado
            this.products.Add(productToAdd);
            this.clearFields();
        }

        private void validateFields() {
            if(this.nameBox.Text != String.Empty &&
               this.priceBox.Text != String.Empty && isNumber(this.priceBox.Text) &&
               this.providerBox.Text != String.Empty)                
                this.addProductToList.Enabled = true;
            else
                this.addProductToList.Enabled = false;
        }

        private void textChanged(object sender, EventArgs e) //Validates price field
        {
            if(this.priceBox.Text != String.Empty)
                if(!isNumber(this.priceBox.Text) || this.priceBox.Text.Contains("-")) {
                    this.priceBox.BackColor = Color.Red;
                }
                else {
                    this.priceBox.BackColor = Color.White;
                }
            this.validateFields();
        }

        private bool isNumber(string text)
        {
            if (Regex.IsMatch(text, @"^\d\d*$") || Regex.IsMatch(text, @"^\d\d*\.\d\d*$") || Regex.IsMatch(text, @"^\d\d*\.$"))
                return true;
            else
                return false;
        }

        private void clearFields() {
            this.nameBox.Clear();
            this.priceBox.Clear();
            this.providerBox.Clear();
            this.descriptionBox.Clear();
            this.validDateTimePicker.Value = DateTime.Now;
        }

        private void clearProductList() {
            this.checkedListBox1.Items.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {}

        private void closeButton_Click(object sender, EventArgs e) { 
            this.Dispose(); 
            this.parent.Show();    
        }

        private void AcceptButton_Click(object sender, EventArgs e) {
            DataBase db = new DataBase();
            String command = null;
            int i = 0;
            foreach (Product p in this.products) {
                if (this.checkedListBox1.GetItemChecked(i)) { 
                    command = "insert into product(Name, Price, Provider, Description, ValidDate) " +
                        $"values('{p.Name}', '{p.Price}', '{p.Provider}', '{p.Description}', '{p.ExpirationDate}')";
                    db.executeCommand(command);
                }
                i++;
            }
            db.closeConnection();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("> ¡Guardado exitoso!", "Mensaje", buttons);
            this.checkedListBox1.Items.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {}

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            this.validateFields();
        }

        private void providerBox_TextChanged(object sender, EventArgs e)
        {
            this.validateFields();
        }

        private void RegisterProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }
    }
}
