using ClientsOrders.Data.EFUOW.Entities;
using ClientsOrders.Data.EFUOW.Repositories;
using ClientsOrders.Data.EFUOW.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientsOrders.WF
{
    public partial class AddOrderForm : Form
    {
        EFUnitOfWork EFUnitOfWork;
        private Action updateDataGridView;
        public AddOrderForm(EFUnitOfWork eFUnitOfWork, Action UpdateDataGridView)
        {
            InitializeComponent();
            this.Load += AddOrderForm_Load;
            this.EFUnitOfWork = eFUnitOfWork;
            this.updateDataGridView = UpdateDataGridView;
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            List<Client> clients = EFUnitOfWork.Clients.GetAll().ToList();
            Dictionary<int, string> values = new Dictionary<int, string>();
            foreach (Client client in clients)
            {
                values.Add(client.ID, client.FirstName);
            }

            comboBox1.DataSource = new BindingSource(values, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string description = textBox1.Text;
            float price = float.Parse(textBox2.Text);
            DateTime datetime = dateTimePicker1.Value;
            int id = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
            Order order = new Order
            {
                Description = description,
                OrderPrice = price,
                ClientID = id,
                OrderDate = DateTime.Now,
                CloseDate = datetime
            };

            EFUnitOfWork.Orders.Add(order);
            Client client = EFUnitOfWork.Clients.GetClientById(id);
            client.OrderAmount++;
            EFUnitOfWork.Clients.Update(client);
            EFUnitOfWork.Save();
            updateDataGridView();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
