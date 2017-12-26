using Application;
using Application.Models.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAppForDelete.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly AppServices appServ;
        public EmployeeController()
        {
            appServ = new AppServices();
        }
        public IEnumerable<EmployeeDto> Get()
        {

            return appServ.GetAllEmployee().Select(x => new EmployeeDto
            {
                EmployeeID = x.EmployeeID,
                FirstName = x.FirstName,
                LastName = x.LastName
            });
        }

        // GET api/<controller>/5



    }
}