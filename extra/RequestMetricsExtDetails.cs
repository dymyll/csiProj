using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazzMaTazz.Models
{
    public partial class RequestMetricsExtDetails
    {
        [Key]
        public long RequestMetricsExtId { get; set; }
        public string RequestDetail { get; set; }
        public string ResponseDetail { get; set; }
    }
}
