using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Exam.Code
{
    public class DataOperation
    {
        public static SqlConnection DBCon()
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
        }
        public static void OperateData(string strsql)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public static bool CheckStudent(string studentID, string studentPwd)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from tb_Student where StudentID='" + studentID + "' and StudentPwd='" + studentPwd + "'", conn);//sql有问题噶
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (i > 0) return true;
            else return false;
        }

        public static bool CheckTeacher(string adminID, string adminPwd)
        {
            SqlConnection conn = DBCon();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Manager where managerID='" + adminID + "' and pwd='" + adminPwd + "'", conn);//sql有问题噶
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (i > 0) return true;
            else return false;
        }
    }
}