using System.Collections.Generic; 
using System.Linq;
using RazzMaTazz.Models;
using CSILibrary;

//SRP
//Responsilbe for only communicating with the ReturnExtD Repository to reach that particular table 

namespace RazzMaTazz.Models {
    public class EFReturnRMExDRepository : IReturnRMDExDRepository {        
        private IB_RM_WTContext context;
        public EFReturnRMExDRepository(IB_RM_WTContext ctx) {
             context = ctx; 
             }
        public IQueryable<RequestMetricsExtDetails> RequestMetricsExtDetailses => context.RequestMetricsExtDetails;

        //IQueryable<CSILibrary.RequestMetrics> IReturnRepository.RequestMetricses => throw new System.NotImplementedException();
    } }
