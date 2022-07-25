using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

// здесь не отображается последний столбец в форме??
namespace CourseWork
{
    public partial class add_tp : Form
    {
        SQL_connector connector;
        public add_tp()
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
            if (Get_Correct_Date() == "")
            {
                MessageBox.Show("Некорректно введена дата ( корректно: гггг-мм-дд) ", "Предупреждение"); //предупреждение о некорректно введенем формате даты
                return;
            }

            if (Get_Correct_Time() == "")
            {
                MessageBox.Show("Некорректно введено время(корректно ЧЧ:ММ) ", "Предупреждение");     //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(number_Box.Text))
            {
                MessageBox.Show("Поле\"Номер ТП\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(duration_Box.Text))
            {
                MessageBox.Show("Поле\"Продолжительность\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO tp(number, date, time, duration) VALUES(@number, @date, @time, @duration)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@number", number_Box.Text);
                cmd.Parameters.AddWithValue("@date", date_Box.Text);
                cmd.Parameters.AddWithValue("@time", time_Box.Text);
                cmd.Parameters.AddWithValue("@duration", duration_Box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show("ТП не добавлен", " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("ТП успешно добавлен", "Успешно");
            this.Close();
        }

        private string Get_Correct_Date()
        {
            string result = "";
            if (Regex.IsMatch(date_Box.Text, @"[0-9]{4}\-[0-9]{2}\-[0-9]{2}", RegexOptions.IgnoreCase))   //условие для корректного ввода даты
            {
                result = date_Box.Text;
            }
            return result;
        }

        private string Get_Correct_Time()
        {
            string result = "";
            if (Regex.IsMatch(time_Box.Text, @"([01][0-9]|2[0-3]):([0-5][0-9])", RegexOptions.IgnoreCase))
            {
                result = time_Box.Text;
            }
            return result;
        }

    }
}
