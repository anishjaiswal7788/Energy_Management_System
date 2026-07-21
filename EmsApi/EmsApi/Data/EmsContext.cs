using Microsoft.EntityFrameworkCore;
using EmsApi.Models;

namespace EmsApi.Data
{
    public class EmsContext : DbContext
    {
        public EmsContext(DbContextOptions<EmsContext> options) : base(options) { }

        // Use the new specific classes here
        public DbSet<EmsRawRecord> T_PLC_LOG_EMS { get; set; }
        public DbSet<EmsHourlyRecord> T_PLC_LOG_EMS_HOURLY { get; set; }
        public DbSet<EmsDailyRecord> T_PLC_LOG_EMS_DAILY { get; set; }
        public DbSet<EmsMonthlyRecord> T_PLC_LOG_EMS_MONTHLY { get; set; }

        public DbSet<EmsMasterView> V_EMS_MASTER_DAILY { get; set; }
    }   
}