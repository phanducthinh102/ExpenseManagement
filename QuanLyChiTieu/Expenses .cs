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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            ExpenseManagementEntities DBE = new ExpenseManagementEntities();
            int m = DTPDate.Value.Month;
            List<Money> List = DBE.Money.Where(i => i.Month == m).ToList();
            Menu MN = new Menu();
            txtTotal.Text = "Total:" + (MN.MAvailable() - MN.MoSpend() - MN.MFSaving());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Menu MN = new Menu();
            try
            {
                int money = int.Parse(txtMoney.Text);
                int MoneyTotal = MN.MAvailable() - MN.MoSpend() - MN.MFSaving();
                if ((MoneyTotal - money) < 0 || (MoneyTotal - money) <= MN.MFSaving())
                {
                    MessageBox.Show("Out of money");
                }
                else
                {
                    try
                    {
                        DateTime Date = DateTime.Now;
                        string Name = txtName.Text;
                        DateTime datepick = DTPDate.Value;
                        ExpenseManagementEntities DBE = new ExpenseManagementEntities();
                        SpendMoney SpendMoney = new SpendMoney();
                        Money Money = new Money();
                        SpendMoney.IDExpense = Date;
                        SpendMoney.Name = Name;
                        SpendMoney.Date = datepick;
                        SpendMoney.Money = money;
                        DBE.SpendMoney.AddObject(SpendMoney);
                        DBE.SaveChanges();
                        MessageBox.Show("Add sucesscesful");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Input");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Menu MN = new Menu();
            MN.Refresh();
            Expenses.ActiveForm.Close();   
        }
    }
}
