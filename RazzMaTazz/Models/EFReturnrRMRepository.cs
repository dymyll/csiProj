using System.Collections.Generic; 
using System.Linq;
using RazzMaTazz.Models;
using CSILibrary;



namespace RazzMaTazz.Models {
    public class EFReturnRMRepository : IReturnRMRepository {        
        private IB_RM_WTContext context;
        public EFReturnRMRepository(IB_RM_WTContext ctx) {
             context = ctx; 
             }
        public IQueryable<RequestMetrics> RequestMetricses => context.RequestMetrics;

        //IQueryable<CSILibrary.RequestMetrics> IReturnRepository.RequestMetricses => throw new System.NotImplementedException();
    } }
