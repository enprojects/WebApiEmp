using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DAL
{
    public class UnitOfWork
    {
        private GenericRepo<Employee> employeeRepo;
     

        private NorthwindCtx ctx;
        public UnitOfWork()
        {
            ctx = new NorthwindCtx();
        }

        public GenericRepo<Employee> EmployeeRepo
        {
            get
            {
                if (employeeRepo == null)
                {
                    this.employeeRepo = new GenericRepo<Employee>(ctx);
                }
                return this.employeeRepo;
            }
        }

        
    }
}
