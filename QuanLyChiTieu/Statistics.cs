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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            string[] arr = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            for (int i = 0; i < arr.Length; i++)
            {
                cbbMonth.Items.Add(arr[i]);
            }
            LoadL();
        }

        private void LoadL()
        {
            ExpenseManagementEntities DBE = new ExpenseManagementEntities();
            SpendMoney Money = new SpendMoney();
            lstSatistics.DataSource = DBE.SpendMoney.ToList();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseManagementEntities DBE = new ExpenseManagementEntities();
                int month = int.Parse(cbbMonth.Text);
                List<SpendMoney> SpendM = DBE.SpendMoney.Where(i => i.Date.Month == month).ToList();
                lstSatistics.DataSource = SpendM.ToList();
            }
            catch
            {
                MessageBox.Show("You should select a month!");
            }
        }

        private void lstStatistics_DoubleClick(object sender, EventArgs e)
        {
            if (lstSatistics.SelectedRows.Count == 1)
            {
                var row = lstSatistics.SelectedRows[0];
                var cell = row.Cells["IDExpense"];
                DateTime Date = (DateTime)cell.Value;
                EditExpenses Edit = new EditExpenses(Date);
                Edit.ShowDialog();
                this.LoadL();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSatistics.SelectedRows.Count == 1)
            {
                var row = lstSatistics.SelectedRows[0];
                var cell = row.Cells["IDExpense"];
                DateTime ID = (DateTime)cell.Value;
                ExpenseManagementEntities db = new ExpenseManagementEntities();
                SpendMoney Money = db.SpendMoney.Single(st => st.IDExpense == ID);
                db.SpendMoney.DeleteObject(Money);
                db.SaveChanges();
                this.LoadL();
            }
            else
            {
                MessageBox.Show("You should select a month!");
            }
        }
        }
    }

