using ClientsOrders.Data.EFUOW.Entities;
using ClientsOrders.Data.EFUOW.Repositories;
using Microsoft.EntityFrameworkCore;
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
    public partial class OrdersForm : Form
    {
        private EFUnitOfWork unitOfWork;
        int selectedClientId;
        public OrdersForm()
        {
            this.Load += LoadMethod;
            InitializeComponent();

        }
        private void LoadMethod(object sender, EventArgs e)
        {
            unitOfWork = new EFUnitOfWork();
            UpdateDataGridView();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    string id = row.Cells["ID"].Value.ToString();
            //    selectedClientId = int.Parse(id);
            //}
        }
        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

            }

        }
        private void UpdateDataGridView()
        {
            IEnumerable<Order> orders = unitOfWork.Orders.GetAll();
            dataGridView1.DataSource = orders.ToList();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddOrderForm newForm = new AddOrderForm(unitOfWork, UpdateDataGridView);
            newForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
