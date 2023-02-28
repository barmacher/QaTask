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
    public partial class AddClientForm : Form
    {
        private EFUnitOfWork unitOfWork;

        Action updateDatagridview;


        public AddClientForm(EFUnitOfWork unitOfWork,Action updateDatagridview)
        {
            InitializeComponent();
            this.unitOfWork = unitOfWork;
            this.updateDatagridview = updateDatagridview;
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string phonenumber = textBox3.Text;

            DateTime dateTime = DateTime.Now;
            Client client = new Client()
            {
                FirstName = name,
                SecondName = surname,
                PhoneNum = phonenumber,
                DateAdd = dateTime

            };
            unitOfWork.Clients.Add(client);
            unitOfWork.Save();
            updateDatagridview();
        }
    }
}
