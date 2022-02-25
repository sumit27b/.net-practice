using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BOL;

namespace DAL
{
    public static class EmployeeDao
    {
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

                              //using system.configuration           //same name as in App.config from ecommerceTestApp 
            string conString = ConfigurationManager.ConnectionStrings["mysqlactsdb"].ConnectionString;

            MySqlConnection con =new MySqlConnection(conString);

            try
            {
                MySqlCommand cmd =new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from employees";
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return employees;
        }
    }
}
