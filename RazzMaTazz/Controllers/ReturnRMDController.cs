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
    public class ReturnRMDController : Controller 
    {

        private IReturnRMDRepository repository;
        public ReturnRMDController(IReturnRMDRepository repo) 
        { 
            repository = repo;        
        }    

         public ViewResult List() => View(repository.RequestMetricsDetailses); 
    }

}