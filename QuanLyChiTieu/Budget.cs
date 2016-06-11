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
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
            LoadMoneyList();
        }

        private void LoadMoneyList()
        {
            ExpenseManagementEntities DBE = new ExpenseManagementEntities();
            Money Money = new Money();
            List<Money> LM = DBE.Money.ToList();
            lstBudget.DataSource = LM.Select(i => new {Money = i.Money1,i.Month }).ToList();
            Menu MN = new Menu();
            MN.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBudget CT = new AddBudget();
            CT.ShowDialog(this);
            this.LoadMoneyList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBudget.SelectedRows.Count == 1) 
        {
            var row = lstBudget.SelectedRows[0]; 
            var cell = row.Cells["Month"]; 
            int Month = (int)cell.Value;
            ExpenseManagementEntities db = new ExpenseManagementEntities();
            List<SpendMoney> LM = db.SpendMoney.Where(i => i.Date.Month == Month).ToList();
            int MS = int.Parse(LM.Select(i => new { Sum = i.Money }).Sum(i => i.Sum).ToString());
            Money Money = db.Money.Single(st => st.Month == Month);
            if (MS <= 0)
            {
                db.Money.DeleteObject(Money);
                db.SaveChanges();
                this.LoadMoneyList();
            }
            else
            {
                MessageBox.Show("It can't be delete");
            }
        }
        else
        {
            MessageBox.Show("You should select a month!");
        }

        }
        private void lstBudget_DoubleClick(object sender, EventArgs e)
        {
            if (lstBudget.SelectedRows.Count == 1) 
            {
                var row = lstBudget.SelectedRows[0]; 
                var cell = row.Cells["month"];
                int month = (int)cell.Value;
                EditBudget Edit = new EditBudget(month); 
                Edit.ShowDialog();
                this.LoadMoneyList(); 
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
