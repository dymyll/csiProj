using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazzMaTazz.Models;
using CSILibrary;

namespace RazzMaTazz.Controllers
{
   // [Route("api/[controller]")]
    public class ReturnRMController : Controller 
    {
//DIP
//Depends on the IReturnRMRepository in order to tell the View what to display. 
        private IReturnRMRepository RMrepository;

        public ReturnRMController(IReturnRMRepository repo) 
        { 
            RMrepository = repo;        
        }    

         public ViewResult List() => View(RMrepository.RequestMetricses); 
    }

   

}