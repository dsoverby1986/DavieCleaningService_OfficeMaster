using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavieCleaningService_OfficeMaster.Models;

namespace DavieCleaningService_OfficeMaster.ViewModels
{
    public class AddEmployeeViewModel
    {
        public Employee Employee { get; set; }
        public IEnumerable<Position> Positions { get; set; }
    }
}