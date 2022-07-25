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

// ошибка вторичных ключей. не дает добавить ни тут, ни в workbench
namespace CourseWork
{
    public partial class add_stages_tp : Form
    {

        SQL_connector connector;
        public add_stages_tp()
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
                MessageBox.Show("Поле \"ID ТП\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(iddev_Box.Text))
            {
                MessageBox.Show("Поле \"ID подразделения\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(name_Box.Text))
            {
                MessageBox.Show("Поле \"Наименование\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            if (string.IsNullOrWhiteSpace(dur_Box.Text))
            {
                MessageBox.Show("Поле \"Продолжительность\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO stages_tp(idtp, iddevisions, name, duration_min) VALUES(@idtp, @iddevisions, @name, @duration_min)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@idtp", idtp_Box.Text);
                cmd.Parameters.AddWithValue("@iddevisions", iddev_Box.Text);
                cmd.Parameters.AddWithValue("@name", name_Box.Text);
                cmd.Parameters.AddWithValue("@duration_min", dur_Box.Text);
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("Стадия ТП успешно добавлена", "Успешно");
            this.Close();
        }
    }
}
