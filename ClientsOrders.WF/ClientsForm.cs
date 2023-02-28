using ClientsOrders.Data.EFUOW.Entities;
using ClientsOrders.Data.EFUOW.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientsOrders.WF
{
    public partial class ClientsForm : Form
    {
        private EFUnitOfWork unitOfWork;
        int selectedClientId;
        public ClientsForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm newForm = new AddClientForm(unitOfWork, UpdateDataGridView);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string id = selectedRow.Cells["ID"].Value.ToString();
            selectedClientId = int.Parse(id);
            if (selectedClientId < 1)
            {
                MessageBox.Show("Выберите нужного клиента");
            }
            else
            {
                unitOfWork.Clients.Delete(selectedClientId);
                unitOfWork.Save();
                UpdateDataGridView();
            }
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
            IEnumerable<Client> clients = unitOfWork.Clients.GetAll();
            dataGridView1.DataSource = clients.ToList();
        }
    }
}
