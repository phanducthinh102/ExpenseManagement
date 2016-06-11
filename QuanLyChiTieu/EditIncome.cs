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
    public partial class EditIncome : Form
    {
        public EditIncome(DateTime ID)
        {
            InitializeComponent();
            EME = new ExpenseManagementEntities();
            IC = EME.MoneyForSavings.Single(i => i.IDSaving == ID);
        }
        private MoneyForSavings IC;
       ExpenseManagementEntities EME;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Money = txtMoney.Text;
                IC.MoneyFSaving = int.Parse(Money);
                EME.SaveChanges();
                MessageBox.Show("Saved");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void EditIncome_Load(object sender, EventArgs e)
        {
            this.txtMoney.Text = "" + IC.MoneyFSaving;
            this.txtMonth.Text = "" + IC.Month;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
