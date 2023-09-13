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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"server=10.90.12.110;port=33333;user=st_1_20_10;database=is_1_20_st10_KURS;password=34088849;"); //Подключение к БД
        private void fillcombo() //Выбор категории
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            CatCb.ValueMember = "catName";
            CatCb.DataSource = dt;
            Con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка для дабавление в таблицу информации
        {
            try
            {
                Con.Open();
                string query = "insert into ProductTbl values("+ProdId.Text+",'"+ProdName.Text+"',"+ ProdQty.Text+","+ProdPrice.Text+",'"+CatCb.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар успешно добавлен");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate() //Обновление информации в датагриде
        {
            Con.Open();
            string query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //Вывод таблицы в датагрид
        {
            ProdId.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            ProdName.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdQty.Text = ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            CatCb.SelectedValue = ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e) //Кнопка удаления
        {
            try
            {
                if (ProdId.Text == "")
                {
                    MessageBox.Show("Выберите продукт для удаления");
                }
                else
                {
                    Con.Open();
                    string query = "delete from ProductTbl where ProdId=" + ProdId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Товар успешно удалён");
                    Con.Close();
                    populate();
                }
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
                if (ProdId.Text == "" || ProdName.Text == "" || ProdQty.Text == "" || ProdPrice.Text == "")
                {
                    MessageBox.Show("Недостаточно информации");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTbl set ProdName='"+ProdName.Text+"',ProdQty='"+ProdQty.Text+"',ProdPrice='"+ProdPrice.Text+"',ProdCat='"+CatCb.SelectedValue.ToString()+"' where ProdId="+ProdId.Text+"";
                    SqlCommand cmd = new SqlCommand(@query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Товар успешно отредактирован");
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
