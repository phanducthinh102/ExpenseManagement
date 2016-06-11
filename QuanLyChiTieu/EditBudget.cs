using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class EditBudget : Form
    {
        public EditBudget(int month)
        {
            InitializeComponent();
            EME = new ExpenseManagementEntities();
            money = EME.Money.Single(i => i.Month == month);
        }
        private Money money;
        ExpenseManagementEntities EME;
        private void EditBudget_Load(object sender, EventArgs e)
        {
            this.txtMoney.Text = ""+money.Money1;
            this.txtMonth.Text = "" + money.Month;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Money = txtMoney.Text;
                money.Money1 = int.Parse(Money);
                EME.SaveChanges();
                MessageBox.Show("Saved");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
