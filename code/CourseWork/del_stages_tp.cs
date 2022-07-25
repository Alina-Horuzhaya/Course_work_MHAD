﻿using System;
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
    public partial class del_stages_tp : Form
    {
        SQL_connector connector;
        public del_stages_tp()
        {
            InitializeComponent();
            connector = new SQL_connector();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(id_Box.Text))
            {
                string message = "Поле \"ID стадии ТП\" не заполнено";
                string title = "Предупреждение";
                MessageBox.Show(message, title);
                return;
            }
            else
            {
                MySqlConnection conn = connector.Get_Connection_For_Operations();
                try
                {
                    conn.Open();    //открываем соединение
                    MySqlCommand cmd = new MySqlCommand();  //подключаемся к таблице
                    cmd.Connection = conn;

                    cmd.CommandText = "DELETE FROM stages_tp WHERE idstages_tp = @id;"; //если таблица отсутствует, создает
                    cmd.Parameters.AddWithValue("@id", int.Parse(id_Box.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Успешно удалено по ID", "Успешно");

                    conn.Close();   //передаем данные и закрываем соединение
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Ошибка "); //сообщение о результате
                }
                this.Close();
            }
        }
    }
}
