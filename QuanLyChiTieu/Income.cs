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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            LoadMoneyList();
        }
        private void LoadMoneyList()
        {
            ExpenseManagementEntities DBE = new ExpenseManagementEntities();
            List<MoneyForSavings> LstIncome = DBE.MoneyForSavings.ToList();
            lstIncome.DataSource = LstIncome.Select(i => new {ID = i.IDSaving, Month = i.Month,Income = i.MoneyFSaving }).ToList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddIncome CT = new AddIncome();
            CT.ShowDialog(this);
            this.LoadMoneyList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstIncome.SelectedRows.Count == 1)
        {
            var row = lstIncome.SelectedRows[0];
            var cell = row.Cells["ID"];
            DateTime ID = (DateTime)cell.Value;
            ExpenseManagementEntities db = new ExpenseManagementEntities();
            MoneyForSavings Money = db.MoneyForSavings.Single(st => st.IDSaving == ID); 
            db.MoneyForSavings.DeleteObject(Money); 
            db.SaveChanges();
            this.LoadMoneyList(); 
        }
        else
        {
            MessageBox.Show("You should select a month!");
        }

        }

        private void lstIncome_DoubleClick(object sender, EventArgs e)
        {
            if (lstIncome.SelectedRows.Count == 1)
            {
                var row = lstIncome.SelectedRows[0];
                var cell = row.Cells["ID"];
                DateTime ID = (DateTime)cell.Value;
                EditIncome Edit = new EditIncome(ID);
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

