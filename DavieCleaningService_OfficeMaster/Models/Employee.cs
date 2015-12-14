using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DavieCleaningService_OfficeMaster.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<DateTimeOffset> BirthDate { get; set; }
        public string EmployeeId { get; set; }
        public decimal PayRate { get; set; }
        public int PositionId { get; set; }
        public Nullable<decimal> VacationTime { get; set; }
        public Nullable<decimal> SickTime { get; set; }
        public Nullable<decimal> PersonalTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTimeOffset StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<DateTimeOffset> EndDate { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public string Email { get; set; }

        public virtual Position Position { get; set; }
    }
}