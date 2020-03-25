using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager.view
{

    public partial class FormExpenseManager : Form
    {
        public FormExpenseManager()
        {
            InitializeComponent();
            this.StartUp();
        }

        private void StartUp()
        {
            this.OpenChildForm(new Home());
        }

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if(this.activeForm != null)
            {
                this.activeForm.Close();
            }
            this.activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new Home());
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new NewIncome());
        }

        private void btnOutcome_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new NewOutcome());
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new IncomeHistory());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new OutcomeHistory());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginPage = new LoginPage();
            loginPage.FormClosed += (s, args) => this.Close();
            loginPage.Show();
        }
    }
}
