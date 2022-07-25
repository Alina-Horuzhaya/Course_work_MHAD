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

// в процессе! 
namespace CourseWork
{
    public partial class add_ind : Form
    {
        SQL_connector connector;
        public add_ind()
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
            if (string.IsNullOrWhiteSpace(name_Box.Text))
            {
                MessageBox.Show("Поле \"Наименование индикатора\" не заполнено", "Предупреждение");    //предупреждение о незаполненном поле 
                return;
            }

            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();    //открываем соединение
                MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO indicators(name, normal) VALUES(@name, @normal)"; //если таблица отсутствует, создает
                cmd.Parameters.AddWithValue("@name", name_Box.Text);

                if (Check_Current_CheckBox())
                {
                    cmd.Parameters.AddWithValue("@normal", 1);    //вывод 1 при нажатии на "ДА"
                }
                else
                {
                    cmd.Parameters.AddWithValue("@normal", 0); //вывод 0 при нажатии на "НЕТ"
                }
                
                cmd.ExecuteNonQuery();

                conn.Close();   //передаем данные и закрываем соединение
                //MessageBox.Show("Показатель добавлен", "Успешно");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления нового показателя", " Ошибка "); //сообщение о результате
            }
            MessageBox.Show("Показатель успешно добавлен", "Успешно");
            this.Close();
        }

        private void checkBox_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_yes.Checked) checkBox_no.Checked = false;
        }

        private void checkBox_no_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_no.Checked) checkBox_yes.Checked = false;
        }

        private bool Check_Current_CheckBox()
        {
            bool result = false;
            if (checkBox_yes.Checked)   //проверка на заполненность чекбокса
            {
                result = true;
            }
            return result;
        } 

    }
}
