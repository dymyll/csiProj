using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.DependencyInjection;
using CSILibrary;
using RazzMaTazz.Models;

namespace RazzMaTazz.Models
{
    public partial class IB_RM_WTContext : DbContext
    {
        public IB_RM_WTContext(DbContextOptions<IB_RM_WTContext> options)
        : base(options)
        {
            
        }
        public DbSet<RequestMetrics> RequestMetrics { get; set; }
        public virtual DbSet<RequestMetricsDetails> RequestMetricsDetails { get; set; }
        public virtual DbSet<RequestMetricsExtDetails> RequestMetricsExtDetails { get; set; }

    }
}