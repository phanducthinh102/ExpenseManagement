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
    public partial class Menu : Form
    {
        private int month = DateTime.Now.Month;
        public Menu()
        {
            InitializeComponent();
        }
        private void btnExpenses_Click(object sener, EventArgs e)
        {
            Expenses EX = new Expenses();
            EX.ShowDialog(this);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            Statistics ST = new Statistics();
            ST.ShowDialog(this);
        }

        private void btnBudget_Click(object sender, EventArgs e)
        {
            Budget BG = new Budget();
            BG.ShowDialog(this);
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            Income IC = new Income();
            IC.ShowDialog(this);
        }
        public int MAvailable()
        {
            int MA;
            ExpenseManagementEntities DBE = new ExpenseManagementEntities();
            List<Money> MoneyA = DBE.Money.Where(i => i.Month == month).ToList();
            try
            {
                MA = MoneyA.Select(i => i.Money1).First();
            }
            catch
            {
                MA = 0;
            }
            return MA;
        }
        public int MoSpend()
        {
            int MS;
            ExpenseManagementEntities DBE = new ExpenseManagementEntities();
            List<SpendMoney> MoneySpend = DBE.SpendMoney.Where(i => i.Date.Month == month).ToList();
            MS = int.Parse(MoneySpend.Select(i => new { Sum = i.Money }).Sum(i => i.Sum).ToString());
            return MS;
        }
        public int MFSaving()
        {
            int MFS;
            ExpenseManagementEntities DBE = new ExpenseManagementEntities();
            List<MoneyForSavings> MoneySaving = DBE.MoneyForSavings.Where(i => i.Month == month).ToList();
            try
            {
                MFS = MoneySaving.Select(i => i.MoneyFSaving).First();
            }
            catch
            {
                MFS = 0;
            }
            return MFS;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}
