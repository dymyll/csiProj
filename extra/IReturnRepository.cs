using System.Collections.Generic;
using RazzMaTazz.Models;
using System.Linq;


namespace RazzMaTazz.Models{

    public interface IReturnRepository
    {
        IQueryable<RequestMetrics> RequestMetricses {get;}
        //void AddApiMethod(RequestMetrics RM);
       // IEnumerable<Test> Tests {get; }
       // void AddFirstName(Test RM);
    }
}