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
    public partial class OrdersForm : Form
    {
        private EFUnitOfWork unitOfWork;
        public OrdersForm()
        {
            InitializeComponent();
            this.Load += LoadMethod;
        }
        private void LoadMethod(object sender, EventArgs e)
        {
            unitOfWork= new EFUnitOfWork();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
