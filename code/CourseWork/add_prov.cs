using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class add_prov : Form
    {
        SQL_connector connector;
        public add_prov()
        {
            InitializeComponent();
            connector = new SQL_connector();
            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(number_car_Box.Text))
            {
                MessageBox.Show("Поле \"Номер машины\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(FIO_Box.Text))
            {
                MessageBox.Show("Поле \"ФИО\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO provider(number_car, FIO) VALUES(@number_car, @FIO)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@number_car", number_car_Box.Text);
                cmd.Parameters.AddWithValue("@FIO", FIO_Box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления нового поставщика", " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("Поставщик успешно добавлен", "Успешно");
            this.Close();
        }
    }
    
}
