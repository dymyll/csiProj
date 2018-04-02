using System;
using System.Collections.Generic;
using CSILibrary;
using RazzMaTazz.Models;
using System.ComponentModel.DataAnnotations;


namespace RazzMaTazz.Models
{
    public partial class RequestMetrics
    {
        public RequestMetrics()
        {
            RequestMetricsDetails = new HashSet<RequestMetricsDetails>();
        }

        [Key]
        public long RequestMetricId { get; set; }
        public DateTime Timestamp { get; set; }
        public string SourceIp { get; set; }
        public int SourcePort { get; set; }
        public string Uri { get; set; }
        public string Verb { get; set; }
        public string RequestBody { get; set; }
        public string ReasonPhrase { get; set; }
        public string ResponseBody { get; set; }
        public int? ResponseCode { get; set; }
        public long? Duration { get; set; }
        public int? Channel { get; set; }
        public string Apiversion { get; set; }
        public string Apicontroller { get; set; }
        public string Apimethod { get; set; }
        public int? BankNumber { get; set; }
        public string ServerName { get; set; }
        public long? UserId { get; set; }
        public long? EmpId { get; set; }
        public long? SessionId { get; set; }
        public string RequestCert { get; set; }
        public string PartnerKey { get; set; }

        public ICollection<RequestMetricsDetails> RequestMetricsDetails { get; set; }
    }
}
