using System;
using System.Collections.Generic;

namespace DavieCleaningService_OfficeMaster.Models
{
    public class WorkSite
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public decimal ServicePrice { get; set; }
        public DateTimeOffset ServiceStartDate { get; set; }
        public DateTimeOffset? ServiceEndDate { get; set; }
        public virtual ServiceSchedule ServiceSchedule { get; set; }
    }

    public class ServiceSchedule
    {
        public int WorkSiteId { get; set; }
        public ICollection<DateTime> Day_s_OfTheWeek { get; set; }
        public DateTimeOffset TimeOfService { get; set; }
    }
}