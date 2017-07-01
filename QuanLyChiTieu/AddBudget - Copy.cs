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
    public partial class AddBudget : Form
    {
        public AddBudget()
        {
            InitializeComponent();
            string[] arr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            for (int i = 0; i < arr.Length; i++)
            {
                cbbMonth.Items.Add(arr[i]);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseManagementEntities DBE = new ExpenseManagementEntities();
                Money Money = new Money();
                string money = txtMoney.Text;
                string month = cbbMonth.Text;
                Money.Money1 = int.Parse(money);
                Money.Month = int.Parse(month);
                DBE.Money.AddObject(Money);
                DBE.SaveChanges();
                MessageBox.Show("Add sucesscesful");
                Menu MN = new Menu();
                MN.Refresh();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMonth_Click(object sender, EventArgs e)
        {

        }
    }
}
