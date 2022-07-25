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
    public partial class add_types_raw : Form
    {
        SQL_connector connector;
        public add_types_raw()
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
            if (string.IsNullOrWhiteSpace(idraw_Box.Text))
            {
                MessageBox.Show("Поле \"ID сырья\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(idprovider_box.Text))
            {
                MessageBox.Show("Поле \"ID поставщика\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(name_Box.Text))
            {
                MessageBox.Show("Поле \"Наименование типа сырья\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO types_of_raw (idraw, idprovider, name) VALUES (@idraw, @idprovider, @name)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@idraw", idraw_Box.Text);
                cmd.Parameters.AddWithValue("@idprovider", provider_Box.Text);
                cmd.Parameters.AddWithValue("@name", name_Box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("Тип сырья успешно добавлен", "Успешно");
            this.Close();
        }

    }
    
}
