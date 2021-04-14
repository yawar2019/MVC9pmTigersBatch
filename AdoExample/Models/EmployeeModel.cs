using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AdoExample.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");
        public List<EmployeeModel> getEmployees()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel obj = new EmployeeModel();
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]);
                listObj.Add(obj);
            }

            return listObj;

        }

        public int SaveEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("spr_insertEmpDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName",emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary",emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
        public EmployeeModel getEmployeeById(int? id)
        {
            EmployeeModel obj = new EmployeeModel();
            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                obj.EmpId = Convert.ToInt32(dr[0]);
                obj.EmpName = Convert.ToString(dr[1]);
                obj.EmpSalary = Convert.ToInt32(dr[2]); 
            }

            return obj;
        }
        public int UpdateEmployee(EmployeeModel emp)
        {
            SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Empid", emp.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", emp.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", emp.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

        

             public int DeleteEmployee(int? id)
        {
            SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Empid", id);
           
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }
    }
}