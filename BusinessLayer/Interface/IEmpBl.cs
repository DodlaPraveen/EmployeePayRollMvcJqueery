using ModelLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IEmpBl
    {

        public void AddEmployee(EmployeeModel employeemodel);
        List<EmployeeModel> getEmployeeList();
        EmployeeModel getEmployeeById(int? id);
        void deleteEmployee(EmployeeModel employeeModel);
        void editEmployee(EmployeeModel employeeModel);

    }
}
