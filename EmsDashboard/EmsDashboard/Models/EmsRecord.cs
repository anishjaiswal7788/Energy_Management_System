using System;

namespace EmsDashboard.Models
{
    public class EmsRecord
    {
        public int Id { get; set; }
        public DateTime Entry_Time { get; set; }
        public double Value { get; set; }
    }
}