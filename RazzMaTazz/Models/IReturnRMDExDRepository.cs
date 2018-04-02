using System.Collections.Generic;
using System.Linq;
using CSILibrary;

//ISP
//Smaller interfaces to handle specific jobs instead of all in one

namespace RazzMaTazz.Models{

    public interface IReturnRMDExDRepository
    {
        IQueryable<RequestMetricsExtDetails> RequestMetricsExtDetailses {get;}
        //void AddApiMethod(RequestMetrics RM);
       // IEnumerable<Test> Tests {get; }
       // void AddFirstName(Test RM);
    }
}