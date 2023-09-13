using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS1._20_DvornyjVA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //SqlConnection Con = new SqlConnection(@"server=10.90.12.110;port=33333;user=st_1_20_10;database=is_1_20_st10_KURS;password=34088849;"); //Подключение к БД
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null; //форма в форме
        private void openNewForm(Form openNewForm) //форма в форме
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = openNewForm;
            openNewForm.TopLevel = false;
            openNewForm.FormBorderStyle = FormBorderStyle.None;
            openNewForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(openNewForm);
            panel1.Tag = openNewForm;
            openNewForm.BringToFront();
            openNewForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Data_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openNewForm(new SellersForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openNewForm(new ProductsForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openNewForm(new CategoryForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openNewForm(new SellingForm());
        }
    }
}
