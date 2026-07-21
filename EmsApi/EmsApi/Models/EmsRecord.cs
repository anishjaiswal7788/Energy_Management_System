using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmsApi.Models
{
    // 1. The Base Class (Holds your attributes so you don't repeat yourself)
    public abstract class EmsRecordBase
    {
        public int Id { get; set; }
        public DateTime Entry_Time { get; set; }
        public double Value { get; set; }
    }

    // 2. The Specific Classes (Mapped directly to your SQL tables)

    [Keyless]
    [Table("T_PLC_LOG_EMS")]
    public class EmsRawRecord : EmsRecordBase { }

    [Keyless]
    [Table("T_PLC_LOG_EMS_HOURLY")]
    public class EmsHourlyRecord : EmsRecordBase { }

    [Keyless]
    [Table("T_PLC_LOG_EMS_DAILY")]
    public class EmsDailyRecord : EmsRecordBase { }

    [Keyless]
    [Table("T_PLC_LOG_EMS_MONTHLY")]
    public class EmsMonthlyRecord : EmsRecordBase { }
}