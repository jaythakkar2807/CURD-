using RegistrationApplicationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationApplicationRepos.User
{
    
    public class UserData
    {
        
        public List<spAllEmployee_Result> getUser()
        {
            using (EmployeeConnection connection = new EmployeeConnection())
            {
                List<spAllEmployee_Result> listUser = new List<spAllEmployee_Result>();
                listUser = connection.spAllEmployee().ToList();

                return listUser;
            }
        }

        public List<getEmpDetailById_Result> getUserDetailById(int id)
        {
            using (EmployeeConnection connection = new EmployeeConnection())
            {
                List<getEmpDetailById_Result> user = new List<getEmpDetailById_Result>();
                user = connection.getEmpDetailById(id).ToList();

                return user;
            }
            
        } 

        //EmployeeContextString  r = new EmployeeContextString();
        public int addempl(string n, string b)
        {
            try
            {
                using (EmployeeConnection str = new EmployeeConnection())
                {
                    int vv = str.AddEmployee(n, b);
                    str.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
            return 0;
        }

        public int deleterecord(int id)
        {
            try
            {
                using (EmployeeConnection connection = new EmployeeConnection())
                {
                    int returnval = connection.spDeleteEmployee(id);
                    connection.SaveChanges();
                }
            }catch(Exception e)
            {

            }
            return 0;
        }

        public int UpdateRecord(int id, string name, string location)
        {
            try
            {
                using (EmployeeConnection connection = new EmployeeConnection())
                {
                    connection.spEditEmployee(id, name, location);
                    connection.SaveChanges();
                }
            }catch(Exception e)
            {

            }
            return 0;
        }



    }
}
