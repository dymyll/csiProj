using System.Collections.Generic;
using System.Linq;
using CSILibrary;


namespace RazzMaTazz.Models{

    public interface IReturnRMDRepository
    {
        IQueryable<RequestMetricsDetails> RequestMetricsDetailses {get;}
        //void AddApiMethod(RequestMetrics RM);
       // IEnumerable<Test> Tests {get; }
       // void AddFirstName(Test RM);
    }
}