using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmsApi.Models
{
    [Keyless]
    [Table("V_EMS_MASTER_DAILY")]
    public class EmsMasterView
    {
        [Column("tag_id")]
        public int TagId { get; set; }

        [Column("tag_name")]
        public string TagName { get; set; }

        [Column("entry_time")]
        public DateTime Entry_Time { get; set; }

        [Column("lsl")]
        public int Lsl { get; set; }

        [Column("usl")]
        public int Usl { get; set; }

        [Column("value")]
        public double Value { get; set; }
    }
}