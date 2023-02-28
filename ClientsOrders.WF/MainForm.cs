namespace ClientsOrders.WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsForm newForm = new ClientsForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdersForm newForm = new OrdersForm();
            newForm.Show();
        }
    }
}