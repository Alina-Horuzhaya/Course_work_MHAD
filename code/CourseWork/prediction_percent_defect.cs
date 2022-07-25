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
using System.Text.RegularExpressions;
using System.Globalization;

namespace CourseWork
{
    public partial class prediction_percent_defect : Form
    {

        SQL_connector connector;
        public prediction_percent_defect()
        {
            InitializeComponent();
            connector = new SQL_connector();
            connector.Get_Connection_First_Time();
            LoadData();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            MySqlConnection conn = connector.Get_Connection_For_Operations();
            try
            {
                conn.Open();
                string query = "SELECT * FROM prediction_percent_defect ORDER BY idprediction_percent_defect";
                MySqlCommand cmd = new MySqlCommand(query);
                cmd.Connection = conn;
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (rdr.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = rdr[0].ToString();  //прочитываем 0 столбец ID
                    data[data.Count - 1][1] = rdr[1].ToString(); //прочитываем 1 столбец idraw 
                    data[data.Count - 1][2] = rdr[2].ToString(); //прочитываем 2 столбец idtp
                    data[data.Count - 1][3] = rdr[3].ToString(); //прочитываем 3 столбец assumed_percent 
                    data[data.Count - 1][4] = rdr[4].ToString(); //прочитываем 4 столбец  batch_number


                }
                rdr.Close();

                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода данных", "Ошибка");
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "% брака";
            app.Columns.ColumnWidth = 20;

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Прогнозируемый % брака";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh_window();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            add_ppd frm20 = new add_ppd();
            dr = frm20.ShowDialog();
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            del_ppd frm21 = new del_ppd();
            dr = frm21.ShowDialog();
            
        }

        private void refresh_window()
        {
            this.Hide(); //закрывает предыдущую форму
            tp tp = new tp(); // показывает заново форму
            tp.ShowDialog();
        }
    }
}
