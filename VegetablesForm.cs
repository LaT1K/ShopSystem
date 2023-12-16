namespace main {
    public partial class VegetablesForm : Form {
        public VegetablesForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                BaseProduct product = new Vegetables(
                    textBox1.Text,
                    Convert.ToDouble(textBox2.Text),
                    BaseProduct.Counter++,
                    Convert.ToDouble(textBox4.Text)
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
