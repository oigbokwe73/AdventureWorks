using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksDAL.DataContext;
using System.Configuration;

namespace AdventureWorksDAL.BusinessComponents
{
    public partial class  AdventureWorksDataContext
    {

        public List<Department> DepartmentList()
        {
            var getDepartment = Execute<List<Department>>(dal =>
            {
                var item = dal.Department.Skip(0).Take(100);
                return item.ToList();
            });
            return getDepartment;
        }

        public List<Department> DepartmentListAll()
        {
            var getDepartment = Execute<List<Department>>(dal =>
            {
                var item = dal.Department;
                return item.ToList();
            });
            return getDepartment;
        }

        public bool DepartmentUpdate(Department department)
        {
            return Execute<bool>(dal =>
           {
               Department departmentUpdate = dal.Department.Where(x => x.DepartmentID == department.DepartmentID).FirstOrDefault();
               if (departmentUpdate != null)
               {
                   departmentUpdate.DepartmentID = department.DepartmentID;
                   departmentUpdate.Name = department.Name;
                   departmentUpdate.GroupName = department.GroupName;
                   departmentUpdate.ModifiedDate = department.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool DepartmentAdd(Department department)
        {
            return Execute<bool>(dal =>
            {
                Department departmentAdd = dal.Department.Where(x => x.DepartmentID == department.DepartmentID).FirstOrDefault();
                if (departmentAdd != null)
                {
                    dal.Department.InsertOnSubmit(departmentAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool DepartmentDelete(Department department)
        {
            return Execute<bool>(dal =>
            {
                Department departmentDelete = dal.Department.Where(x => x.DepartmentID == department.DepartmentID).FirstOrDefault();
                if (departmentDelete != null)
                {
                    dal.Department.DeleteOnSubmit(departmentDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}
