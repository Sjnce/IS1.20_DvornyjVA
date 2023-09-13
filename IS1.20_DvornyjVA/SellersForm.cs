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
using System.Text.RegularExpressions;

namespace IS1._20_DvornyjVA
{
    public partial class SellersForm : Form
    {
        public SellersForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"server=10.90.12.110;port=33333;user=st_1_20_10;database=is_1_20_st10_KURS;password=34088849;"); //Подключение к БД

        private void SellersForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate() //Обновление информации в датагриде
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sid.Text = SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            Sname.Text = SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            Sage.Text = SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            Sphone.Text = SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            Spass.Text = SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //Кнопка удаления
        {
            try
            {
                if (Sid.Text == "")
                {
                    MessageBox.Show("Выберите персонал для удаления");
                }
                else
                {
                    Con.Open();
                    string query = "delete from SellerTbl where SellerId=" + Sid.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Товар успешно удалён");
                    Con.Close();
                    populate();
                    Sid.Text = "";
                    Sname.Text = "";
                    Sphone.Text = "";
                    Spass.Text = "";
                    Sage.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка добавления
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values("+Sid.Text+",'"+ Sname.Text+"','"+ Sphone.Text + "','"+Spass.Text+"','"+Sage.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Персонал успешно добавлен");
                Con.Close();
                populate();
                Sid.Text = "";
                Sname.Text = "";
                Sphone.Text = "";
                Spass.Text = "";
                Sage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Кнопка редактирования
        {
            try
            {
                if (Sname.Text == "" || Sid.Text == "" || Sage.Text == "" || Sphone.Text == "" || Spass.Text == "")
                {
                    MessageBox.Show("Недостаточно информации");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName='"+Sname.Text+"',SellerAge='"+Sage.Text+"',SellerPhone='"+Sphone.Text+ "',SellerPass='"+Spass.Text+"' where SellerId=" + Sid.Text+"";
                    SqlCommand cmd = new SqlCommand(@query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Персонал успешно отредактирован");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
