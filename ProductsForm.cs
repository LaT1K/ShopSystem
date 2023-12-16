using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main {
    public partial class ProductsForm : Form {
        public ProductsForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                BaseProduct product = new Products(
                    textBox1.Text,
                    Convert.ToDouble(textBox2.Text),
                    BaseProduct.Counter++,
                    Convert.ToInt32(textBox4.Text)
                );

                MainForm mainForm = (MainForm)Owner;

                mainForm.AddProduct(product);

                this.Close();
            }
            catch (FormatException) {
                MessageBox.Show("Invalid data format. Please enter valid numeric values.", "Error");
            }
            catch (Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
            finally {
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }
        }
    }
}
