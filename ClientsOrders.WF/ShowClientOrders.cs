using ClientsOrders.Data.EFUOW.Entities;
using ClientsOrders.Data.EFUOW.Repositories;
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
    public partial class ShowClientOrders : Form
    {
        private int cliendId;
        private EFUnitOfWork unitOfWork;
        public ShowClientOrders(int cliendId, EFUnitOfWork unitOfWork)
        {
            InitializeComponent();
            this.cliendId = cliendId;
            this.unitOfWork = unitOfWork;
            this.Load += ShowClientOrdersLoad;
        }
        private void ShowClientOrdersLoad(object sender, EventArgs e)
        {
            List<Order> orders = unitOfWork.Orders.GetUserOrders(this.cliendId);
            dataGridView1.DataSource = orders;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
