using System.Collections.Generic; 
using System.Linq;
using RazzMaTazz.Models;
using CSILibrary;



namespace RazzMaTazz.Models {
    public class EFReturnRMDRepository : IReturnRMDRepository {        
        private IB_RM_WTContext context;
        public EFReturnRMDRepository(IB_RM_WTContext ctx) {
             context = ctx; 
             }
        public IQueryable<RequestMetricsDetails> RequestMetricsDetailses => context.RequestMetricsDetails;

        //IQueryable<CSILibrary.RequestMetrics> IReturnRepository.RequestMetricses => throw new System.NotImplementedException();
    } }
