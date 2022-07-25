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

//при добавлении поля в таблицу убрать сочетание int.Parse ( во всех файлах, где успела написать этот блок)
namespace CourseWork
{
    public partial class add_dev : Form
    {
        SQL_connector connector;
        public add_dev()
        {
            InitializeComponent();
            connector = new SQL_connector();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_dev_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dev_Box.Text))
            {
                MessageBox.Show("Поле \"Наименование подразделения\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO devisions (name) VALUES (@name)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@name", dev_Box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("Подразделение успешно добавлено", "Успешно");
            this.Close();
        }
    }
}
