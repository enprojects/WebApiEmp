using Application.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class AppServices
    {
        private readonly UnitOfWork uow;
        public AppServices( )
        {
            uow = new UnitOfWork();
        }


        public IEnumerable<Employee> GetAllEmployee()
        {
            var employees = uow.EmployeeRepo.Get();
            return employees;
        }

    }
}
