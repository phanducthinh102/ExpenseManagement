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
    public partial class AddIncome : Form
    {
        public AddIncome()
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
                MoneyForSavings Money = new MoneyForSavings();
                string money = txtMoney.Text;
                string month = cbbMonth.Text;
                Money.IDSaving = DateTime.Now;
                Money.MoneyFSaving = int.Parse(money);
                Money.Month = int.Parse(month);
                DBE.MoneyForSavings.AddObject(Money);
                DBE.SaveChanges();
                MessageBox.Show("Add sucesscesful");
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
    }
}
