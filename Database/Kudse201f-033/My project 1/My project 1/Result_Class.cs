using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace My_project_1
{
    class Result_Class
    {
        Class1 mydb = new Class1();

        public bool insertResult(int studentId, int courseId, double result, string description)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `result`(`StudentId`, `courseId`, `Result`, `description`) VALUES (@sid,@cid,@scr,@dscr)", mydb.getConnection);

            cmd.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentId;
            cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;
            cmd.Parameters.Add("@scr", MySqlDbType.Double).Value = result;
            cmd.Parameters.Add("@dscr", MySqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeconnection();
                return true;
            }
            else
            {
                mydb.closeconnection();
                return false;
            }

        }

        public bool studentScoreExists(int studentId, int courseId)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `result` WHERE `StudentId`=@sid AND `courseId`=@cid", mydb.getConnection);

            cmd.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentId;
            cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpter.Fill(table);


            if (table.Rows.Count == 0)
            {
                return false;
            }
            else
            {

                return true;
            }

        }

        public DataTable getStudentsScore()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = ("SELECT result.StudentId,add_student.First_Name,add_student.Last_Name,result.courseId,course.label,result.result FROM add_student INNER JOIN result ON add_student.id=result.StudentId INNER JOIN course ON result.courseId=course.id");


            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpter.Fill(table);

            return table;
        }

        public bool deleteResult(int courseId, int studentId)
        {
            mydb.openConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `result` WHERE `StudentId`=@sid AND `courseId`=@cid", mydb.getConnection);


            cmd.Parameters.Add("@sid", MySqlDbType.Int32).Value = studentId;
            cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;



            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeconnection();
                return true;
            }
            else
            {
                mydb.closeconnection();
                return false;
            }
        }

        public DataTable avgResultByCourse()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mydb.getConnection;
            cmd.CommandText = ("SELECT course.label,AVG(result.Result)AS 'Average Result' FROM course,result WHERE course.id=result.courseId GROUP BY course.label");


            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpter.Fill(table);

            return table;
        }
    }
}
