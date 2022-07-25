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

// дописать проверку времени получения
namespace CourseWork
{
    public partial class add_raw : Form
    {
        SQL_connector connector;
        public add_raw()
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
            if (string.IsNullOrWhiteSpace(idind_Box.Text))
            {
                MessageBox.Show("Поле \"ID показателя\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (Get_Correct_Date() == "")
            {
                MessageBox.Show("Некорректно введена дата ( корректно:ГГГГ-ММ-ДД) ", "Предупреждение"); //предупреждение о некорректно введенем формате даты
                return;
            }

            if (string.IsNullOrWhiteSpace(time_Box.Text))
            {
                MessageBox.Show("Поле \"Время получения\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(volume_Box.Text))
            {
                MessageBox.Show("Поле \"Объем_вес\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO raw(idindicators, date_of_receipt, time_of_receipt, volume_weight) VALUES(@idindicators, @date_of_receipt, @time_of_receipt, @volume_weight)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@idindicators", idind_Box.Text);
                cmd.Parameters.AddWithValue("@date_of_receipt", date_Box.Text);
                cmd.Parameters.AddWithValue("@time_of_receipt", time_Box.Text);
                cmd.Parameters.AddWithValue("@volume_weight", volume_Box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления нового сырья", " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("Сырье успешно добавлено", "Успешно");
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
    }
}
