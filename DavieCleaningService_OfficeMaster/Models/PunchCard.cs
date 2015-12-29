using System;

namespace DavieCleaningService_OfficeMaster.Models
{
    public class PunchCard
    {
        public int Id { get; set; }
        public Employee EmployeeId { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public DateTimeOffset? EndTime  {get; set; }
        public WorkSite WorkSiteId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual WorkSite WorkSite { get; set; }
    }
}