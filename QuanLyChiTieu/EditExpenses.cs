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
    public partial class EditExpenses : Form
    {
        public EditExpenses(DateTime ID)
        {
            InitializeComponent();
            EME = new ExpenseManagementEntities();
            Expense = EME.SpendMoney.Single(i => i.IDExpense == ID);
        }
        private SpendMoney Expense;
        ExpenseManagementEntities EME;
        private void EditExpenses_Load(object sender, EventArgs e)
        {
            this.txtName.Text = ""+Expense.Name;
            this.txtMoney.Text = ""+Expense.Money;
            this.DTPDate.Value = Expense.Date;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text;
                string Money = txtMoney.Text;
                DateTime Date = DTPDate.Value;
                Expense.Name = Name;
                Expense.Money = int.Parse(Money);
                Expense.Date = Date;
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
