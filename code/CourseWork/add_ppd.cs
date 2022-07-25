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

namespace CourseWork
{
    public partial class add_ppd : Form
    {
        SQL_connector connector;
        public add_ppd()
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
            if (string.IsNullOrWhiteSpace(idtp_Box.Text))
            {
                MessageBox.Show("Поле \"ID ТП \" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(idraw_Box.Text))
            {
                MessageBox.Show("Поле \"ID сырья\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(number_Box.Text))
            {
                MessageBox.Show("Поле \"Номер партии\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(percent_Box.Text))
            {
                MessageBox.Show("Поле \"Предполагаемый %\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO prediction_percent_defect (idraw, idtp, assumed_percent, batch_number) VALUES (@idraw, @idtp, @assumed_percent, @batch_number)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@idraw", idraw_Box.Text);
                cmd.Parameters.AddWithValue("@idtp", idtp_Box.Text);
                cmd.Parameters.AddWithValue("@assumed_percent", percent_Box.Text);
                cmd.Parameters.AddWithValue("@batch_number", number_Box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Ошибка "); //сообщение о результате
            }
            MessageBox.Show(" Процент брака успешно добавлено", "Успешно");
            this.Close();
        }
    }
    
}
