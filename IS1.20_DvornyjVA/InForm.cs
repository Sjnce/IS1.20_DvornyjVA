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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace IS1._20_DvornyjVA
{
    public partial class InForm : Form
    {
        public InForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"server=10.90.12.110;port=33333;user=st_1_20_10;database=is_1_20_st10_KURS;password=34088849;"); //Подключение к БД. chuc.caseum.ru - дома, 10.90.12.110 - в чюке

        //Вычисление хэша строки и возрат его из метода
        static string sha256(string randomString)
        {
            //Тут происходит криптографическая магия. Смысл данного метода заключается в том, что строка залетает в метод
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
        public void GetUserInfo(string login_user)
        {
            //Объявлем переменную для запроса в БД
            string selected_id_stud = UnameTb.Text;
            // устанавливаем соединение с БД
            Con.Open();
            // запрос
            string sql = $"select SellerName, SellerId from SellerTbl where SellerName='{UnameTb}'";
            // объект для выполнения SQL-запроса
            SqlCommand command = new SqlCommand(sql, Con);
            // объект для чтения ответа сервера
            SqlDataReader reader = command.ExecuteReader();
            // читаем результат
            while (reader.Read())
            {
                // элементы массива [] - это значения столбцов из запроса SELECT
                Auth.auth_id = reader[1].ToString();
                Auth.auth_fio = reader[0].ToString();
                //Auth.auth_role = Convert.ToInt32(reader[4].ToString());
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            Con.Close();
        }
        private void InForm_Load(object sender, EventArgs e)
        {
            
        }

        public delegate void ThreadStart();
        void Vhod()
        {
            this.Invoke(new Action(() => { this.Hide(); })); // Новый поток
            LoadingForm loa = new LoadingForm();
            loa.Show();
            //Запрос в БД на предмет того, если ли строка с подходящим логином, паролем
            string sql = "select * from SellerTbl where SellerName = @un and SellerPass= @up";
            //Открытие соединения
            Con.Open();
            //Объявляем таблицу
            DataTable table = new DataTable();
            //Объявляем адаптер
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Объявляем команду
            SqlCommand command = new SqlCommand(sql, Con);
            //Определяем параметры
            command.Parameters.Add("@un", SqlDbType.VarChar, 25);
            command.Parameters.Add("@up", SqlDbType.VarChar, 25);
            //Присваиваем параметрам значение
            command.Parameters["@un"].Value = UnameTb.Text;
            command.Parameters["@up"].Value = sha256(PassTb.Text);
            //Заносим команду в адаптер
            adapter.SelectCommand = command;
            //Заполняем таблицу
            adapter.Fill(table);
            //Закрываем соединение
            Con.Close();
            //Если вернулась больше 0 строк, значит такой пользователь существует
            if (table.Rows.Count > 0)
            {
                //Присваеваем глобальный признак авторизации
                Auth.auth = true;
                //Достаем данные пользователя в случае успеха
                GetUserInfo(UnameTb.Text);

                Thread.Sleep(5000); // Новый поток
                UnameTb.Invoke(new Action(() => { this.Close(); })); // Новый поток
            }
            else
            {
                MessageBox.Show("Произошла ошибка входа, попробуйте снова");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) //Кнопка очистить
        {
            UnameTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка входа
        {
            Thread myThread1 = new Thread(Vhod); // Создаем новый поток
            myThread1.Start();

            if (UnameTb.Text == "" ||  PassTb.Text == "")
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                if(RoleCb.SelectedIndex > -1)
                {
                    if (RoleCb.SelectedItem.ToString() == "Администратор")
                    {
                        if (UnameTb.Text == "Администратор" && PassTb.Text == "Администратор")
                        {
                            MainForm prod = new MainForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Если вы администратор, то введите правильные логин и пароль");
                        }
                    }/*
                    else if (RoleCb.SelectedItem.ToString() == "Продавец")
                    {
                        MessageBox.Show("Вы в должности продавца");
                    */
                }
                else
                {
                    MessageBox.Show("Выберите Должность");
                }
            }
        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
