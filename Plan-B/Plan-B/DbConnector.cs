using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Plan_B
{
    class DbConnector
    {
        static string connectionString = @"Data Source=DESKTOP-6GTJNQE\SQLEXPRESS;Initial Catalog=PROFINTERES;" + "Integrated Security=true;";
        private SqlConnection sqlcon = new SqlConnection(connectionString);

        public void ExecCommand(string execCom)
        {
            //Выполнение запроса
            try
            {
                sqlcon.Open();
                using (SqlCommand command = new SqlCommand(execCom, sqlcon))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
            finally
            {
                sqlcon.Close();
            }
        }


        public DataTable GetTable(string getTablCommand)
        {
            //Получить таблицу из БД
            var table = new DataTable();

            try
            {
                sqlcon.Open();

                var adapter = new SqlDataAdapter(getTablCommand, sqlcon);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }

            return table;
        }
    }

}
