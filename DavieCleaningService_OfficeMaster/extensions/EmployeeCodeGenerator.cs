using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavieCleaningService_OfficeMaster.extensions
{
    public class EmployeeCodeGenerator
    {
        public static string CreateEmployeeCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 7)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}