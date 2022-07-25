using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CourseWork
{    
    public partial class Form1 : Form
    {
        SQL_connector connector;

        public Form1()
        {
            InitializeComponent();
            connector = new SQL_connector();
            connector.Get_Connection_First_Time();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Вы действительно хотите выйти?";
            String caption = "Выход";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();

        }

        private void button_devisions_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            devisions frm2 = new devisions();
            dr = frm2.ShowDialog();

        }

        private void button_indicators_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            indicators frm3 = new indicators();
            dr = frm3.ShowDialog();
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            prediction_percent_defect frm4 = new prediction_percent_defect();
            dr = frm4.ShowDialog();
        }

        private void button_providers_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            provider frm5 = new provider();
            dr = frm5.ShowDialog();
        }

        private void button_raw_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            raw frm6 = new raw();
            dr = frm6.ShowDialog();

        }

        private void button_stages_tp_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            stages_tp frm7 = new stages_tp();
            dr = frm7.ShowDialog();

        }

        private void button_tp_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            tp frm8 = new tp();
            dr = frm8.ShowDialog();
        }

        private void button_types_raw_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            types_of_raw frm9 = new types_of_raw();
            dr = frm9.ShowDialog();
        }
    }
}
