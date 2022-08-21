using DataAccessLayer.ProjectContext;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_UILayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context c = new Context();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = c.Customers.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();//kontrol edilecek
            customer.CustomerName = txtCustomerName.Text;
            customer.CustomerSurname = txtSurname.Text;
            customer.CustomerGender = CmbGender.Text;
            customer.CustomerPhone = txtPhone.Text;
            c.Customers.Add(customer);
            c.SaveChanges();
            MessageBox.Show("Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCustomerID.Text);
            var values = c.Customers.Where(x => x.CustomerID == id).FirstOrDefault();
            c.Customers.Remove(values);
            c.SaveChanges();
            MessageBox.Show("Silindi");
        }
    }
}
