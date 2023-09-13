using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS1._20_DvornyjVA
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"server=10.90.12.110;port=33333;user=st_1_20_10;database=is_1_20_st10_KURS;password=34088849;"); //Подключение к БД
        private void populate() //Обновление информации в датагриде
        {
            Con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populatebills() //Обновление информации в датагриде
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populatebills();
        }
        int flag = 0;
        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdName.Text = ProdDGV1.SelectedRows[0].Cells[0].Value.ToString();
            ProdQty.Text = ProdDGV1.SelectedRows[0].Cells[1].Value.ToString();
        }

        int Grdtotal = 0, n = 0;
        private void button4_Click(object sender, EventArgs e) //кнопка добавить продукт
        {
            if(ProdName.Text == "" || ProdQty.Text == "")
            {
                MessageBox.Show("Недостаточно данных");
            }
            else
            {
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ORDERDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                ORDERDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                Amtlbl.Text = "" + Grdtotal;
            }
        }

        private void button1_Click(object sender, EventArgs e) //нижний-правый датагрид
        {
            if(BillID.Text == "")
            {
                MessageBox.Show("Отсутствует ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values(" + BillID.Text + ",'" + SellerNamelbl.Text + "','" + Datelbl.Text + "'," + Amtlbl.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказ успешно добавлен");
                    Con.Close();
                    populatebills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Datelbl_Click(object sender, EventArgs e) //время
        {
            Datelbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void button2_Click(object sender, EventArgs e) //печать
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //тоже печатать
        {
            e.Graphics.DrawString("ПродуктФест", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.MediumPurple, new Point(230));
            e.Graphics.DrawString("ID: "+BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.MediumPurple, new Point(100, 70));
            e.Graphics.DrawString("Имя сотрудника: " + BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.MediumPurple, new Point(100, 100));
            e.Graphics.DrawString("Дата: " + BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.MediumPurple, new Point(100, 130));
            e.Graphics.DrawString("Общая сумма: " + BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 20, FontStyle.Bold), Brushes.MediumPurple, new Point(100, 160));
        }

        private void CatCb_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
