using System.Collections.Generic;
using System.Linq;
using CSILibrary;


namespace RazzMaTazz.Models{

    public interface IReturnRMRepository
    {
        IQueryable<RequestMetrics> RequestMetricses {get;}
        //void AddApiMethod(RequestMetrics RM);
       // IEnumerable<Test> Tests {get; }
       // void AddFirstName(Test RM);
    }
}