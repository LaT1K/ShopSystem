namespace main {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private List<BaseProduct> productList = new List<BaseProduct>();


        public void AddProduct(BaseProduct product) {
            productList.Add(product);
            if (listBox1.Items.Count == 0)
                listBox1.Items.Add("ID\tPrice\tName\tWeight/Count\tType");
            listBox1.Items.Add(product.ToString());
        }
        private void addVegetableToolStripMenuItem_Click(object sender, EventArgs e) {
            VegetablesForm vegetablesForm = new VegetablesForm();
            vegetablesForm.Owner = this;
            vegetablesForm.ShowDialog();
        }

        private void addFruitToolStripMenuItem_Click(object sender, EventArgs e) {
            FruitsForm fruitsForm = new FruitsForm();
            fruitsForm.Owner = this;
            fruitsForm.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e) {
            ProductsForm productsForm = new ProductsForm();
            productsForm.Owner = this;
            productsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }
}