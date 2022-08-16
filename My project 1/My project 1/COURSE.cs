using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace My_project_1
{
    class COURSE
    {
        Class1 mydb = new Class1();

        public bool insertCourse(string courseName,int hoursNumber,string description) //insert course
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `course`(`label`,`hours_number`,`description`) VALUES (@name,@hrs,@dscr)", mydb.getConnection);

            //@name,@hrs,@dscr
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hoursNumber;
            cmd.Parameters.Add("@dscr", MySqlDbType.Text).Value = description; 

            mydb.openConnection();

            if(cmd.ExecuteNonQuery()==1)
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

        public bool checkCourseName(string courseName,int courseid=0 ) // to check if the course name already exists in the database
       {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `course` WHERE `label`=@cName AND id<> @cid",mydb.getConnection);

            cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseid;
            cmd.Parameters.Add("@cName", MySqlDbType.VarChar).Value = courseName;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if(table.Rows.Count>0)
            {
                // this course name alrady exists
                return false;
            }
            else
            {
                return true;
            }
      }

        public bool deleteCourse(int courseId)
        {
            mydb.openConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `course` WHERE `id`=@CID", mydb.getConnection);

            cmd.Parameters.Add("@CID",MySqlDbType.Int32).Value = courseId;
            

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

        public DataTable getAllCourses()   // Get All Course
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `course`", mydb.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCoursesById(int courseID)   // Get a Course by id
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `course` WHERE id=@cid", mydb.getConnection);
            cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseID;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateCourse(int courseid,string courseName,int hoursNumber,string description)
        {
            MySqlCommand cmd = new MySqlCommand("UPDATE `course` SET `label`=@name,`hours_number`=@hrs,`description`=@dscr WHERE `id`=@cid", mydb.getConnection);

            //@name,@hrs,@dscr
            cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseid;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = courseName;
            cmd.Parameters.Add("@hrs", MySqlDbType.Int32).Value = hoursNumber;
            cmd.Parameters.Add("@dscr", MySqlDbType.Text).Value = description;

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

        public string execCount(string query) // excute count queries
        {
            MySqlCommand cmd = new MySqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            mydb.closeconnection();

            return count;
        }

        public string totalCourse()  // get total Courses
        {
            return execCount("SELECT COUNT(*) FROM `course`");
        }
    }
}
