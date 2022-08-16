using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace My_project_1
{
    // in this class We creat connection betwean our app and the mysql db
    class Class1
    {
       private MySqlConnection con = new MySqlConnection("server=localhost;database=student_db;username=root;");

       public MySqlConnection getConnection //to getconection
        {
            get
            {
                return con;
            }
        }

        public void openConnection()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeconnection ()
        {
            if(con.State== ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
