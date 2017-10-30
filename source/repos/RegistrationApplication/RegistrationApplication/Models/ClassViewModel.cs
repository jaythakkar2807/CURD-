using RegistrationApplicationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationApplication.Models
{
    public class ClassViewModel
    {
        public registration r { get; set; }
        public List<spAllEmployee_Result> listUser { get; set; }

        public List<getEmpDetailById_Result> userById { get; set; }

    }
}