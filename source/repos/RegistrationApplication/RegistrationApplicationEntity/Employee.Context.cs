﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationApplicationEntity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmployeeConnection : DbContext
    {
        public EmployeeConnection()
            : base("name=EmployeeConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<registration> registration { get; set; }
        public virtual DbSet<Table_1> Table_1 { get; set; }
    
        public virtual int AddEmployee(string empName, string empLocation)
        {
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empLocationParameter = empLocation != null ?
                new ObjectParameter("EmpLocation", empLocation) :
                new ObjectParameter("EmpLocation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddEmployee", empNameParameter, empLocationParameter);
        }
    
        public virtual ObjectResult<getEmpDetailById_Result> getEmpDetailById(Nullable<int> emp_Id)
        {
            var emp_IdParameter = emp_Id.HasValue ?
                new ObjectParameter("Emp_Id", emp_Id) :
                new ObjectParameter("Emp_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmpDetailById_Result>("getEmpDetailById", emp_IdParameter);
        }
    
        public virtual ObjectResult<spAllEmployee_Result> spAllEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAllEmployee_Result>("spAllEmployee");
        }
    
        public virtual int spDeleteEmployee(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteEmployee", idParameter);
        }
    
        public virtual int spEditEmployee(Nullable<int> id, string empName, string empLocation)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var empLocationParameter = empLocation != null ?
                new ObjectParameter("EmpLocation", empLocation) :
                new ObjectParameter("EmpLocation", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditEmployee", idParameter, empNameParameter, empLocationParameter);
        }
    }
}