using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace CourseWork
{
    class SQL_connector
    {
        static string host = "127.0.0.1";
        static int port = 3306;
        static string database = "PREDICTION_PERCENT";
        static string username = "admin";
        static string password = "password";

        String connString = "Server=" + host + ";" + ";port=" + port + ";User Id=" + username + ";password=" + password;
        String connString_with_DB = "Server=" + host + ";" + ";database=" + database + ";port=" + port + ";User Id=" + username + ";password=" + password;
        public SQL_connector()
        {
        }

        public void Get_Connection_First_Time()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `PREDICTION_PERCENT`;";
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn = new MySqlConnection(connString_with_DB);
            try
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `devisions`(iddevisions INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT); ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `indicators`(idindicators INTEGER PRIMARY KEY AUTO_INCREMENT, name TEXT, normal BOOLEAN); ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `provider`(idprovider INTEGER PRIMARY KEY AUTO_INCREMENT, number_car TEXT, FIO TEXT);";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `tp`(idtp INTEGER PRIMARY KEY AUTO_INCREMENT, number INTEGER, date DATE, time TIME, duration INTEGER);";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `PREDICTION_PERCENT`.`prediction_percent_defect` (" +
                    "`idprediction_percent_defect` INT NOT NULL AUTO_INCREMENT," +
                    "`idraw` INT NOT NULL," +
                    "`idtp` INT NOT NULL," +
                    "`assumed_percent` FLOAT NOT NULL," +
                    "`batch_number` INT NOT NULL," +
                    "PRIMARY KEY(`idprediction_percent_defect`)," +
                    "INDEX `tp_idx` (`idtp` ASC) VISIBLE," +
                    "INDEX `raw_idx` (`idraw` ASC) VISIBLE," +
                    "CONSTRAINT `tp_prediction`" +
                    "  FOREIGN KEY(`idtp`)" +
                    "  REFERENCES `PREDICTION_PERCENT`.`tp` (`idtp`)" +
                    "  ON DELETE CASCADE" +
                    " ON UPDATE CASCADE," +
                    "CONSTRAINT `raw`" +
                    "  FOREIGN KEY(`idraw`)" +
                    "  REFERENCES `PREDICTION_PERCENT`.`raw` (`idraw`)" +
                    " ON DELETE CASCADE" +
                    " ON UPDATE CASCADE)";
                cmd.ExecuteNonQuery(); 

                

                //подравнять и сделать по аналогии все таблицы со вторичными ключами (копипаст скриптов)
                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `PREDICTION_PERCENT`.`raw` (" +
                                "`idraw` INT NOT NULL AUTO_INCREMENT," +
                                "`idindicators` INT NOT NULL," +
                                "`date_of_receipt` DATE NOT NULL," +
                                "`time_of_receipt` TIME NOT NULL," +
                                "`volume_weight` INT NOT NULL," +
                                "PRIMARY KEY(`idraw`)," +
                                "INDEX `indic_idx` (`idindicators` ASC) VISIBLE," +
                                "CONSTRAINT `indic`" +
                                "  FOREIGN KEY(`idindicators`)" +
                                "  REFERENCES `PREDICTION_PERCENT`.`indicators` (`idindicators`)" +
                                "  ON DELETE CASCADE" +
                                " ON UPDATE CASCADE)";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `PREDICTION_PERCENT`.`stages_tp` (" +
                    "`idstages_tp` INT NOT NULL AUTO_INCREMENT," +
                    "`idtp` INT NOT NULL," +
                    "`iddevisions` INT NOT NULL," +
                    "`name` TEXT NOT NULL," +
                    "`duration_min` INT NOT NULL," +
                    "PRIMARY KEY(`idstages_tp`)," +
                    "INDEX `dev_idx` (`iddevisions` ASC) VISIBLE," +
                    "INDEX `tp_idx` (`idtp` ASC) VISIBLE," +
                    "CONSTRAINT `dev`" +
                    "  FOREIGN KEY(`iddevisions`)" +
                    "  REFERENCES `PREDICTION_PERCENT`.`devisions` (`iddevisions`)" +
                    "  ON DELETE CASCADE" +
                    " ON UPDATE CASCADE," +
                    "CONSTRAINT `tp`" +
                    "  FOREIGN KEY(`idtp`)" +
                    "  REFERENCES `PREDICTION_PERCENT`.`tp` (`idtp`)" +
                    "  ON DELETE CASCADE" +
                    " ON UPDATE CASCADE)";
                cmd.ExecuteNonQuery();


                cmd.CommandText = "CREATE TABLE IF NOT EXISTS `PREDICTION_PERCENT`.`types_of_raw` (" +
                    "`idtypes_of_raw` INT NOT NULL AUTO_INCREMENT," +
                    "`idraw` INT NOT NULL," +
                    "`idprovider` INT NOT NULL," +
                    "`name` TEXT NOT NULL," +
                    "PRIMARY KEY(`idtypes_of_raw`)," +
                    "INDEX `prov_idx` (`idprovider` ASC) VISIBLE," +
                    "INDEX `raw_idx` (`idraw` ASC) VISIBLE," +
                    "CONSTRAINT `prov`" +
                    "  FOREIGN KEY(`idprovider`)" +
                    "  REFERENCES `PREDICTION_PERCENT`.`provider` (`idprovider`)" +
                    "  ON DELETE CASCADE" +
                    " ON UPDATE CASCADE," +
                    "CONSTRAINT `raw_types`" +
                    "  FOREIGN KEY(`idraw`)" +
                    "  REFERENCES `PREDICTION_PERCENT`.`raw` (`idraw`)" +
                    "  ON DELETE CASCADE" +
                    " ON UPDATE CASCADE)";
                cmd.ExecuteNonQuery(); 

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public MySqlConnection Get_Connection_For_Operations()
        {
            return new MySqlConnection(connString_with_DB);
        }
    }
}
