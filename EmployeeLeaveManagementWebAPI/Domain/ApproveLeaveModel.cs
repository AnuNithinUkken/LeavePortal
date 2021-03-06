﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WebAPI_Domain
{
    public class ApproveLeaveModel
    {
        public long Id { get; set; }
        public int RefEmployeeId { get; set; }
        public System.DateTime FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int RefStatus { get; set; }
        public int NumberOfWorkingDays { get; set; }
        public int RefLeaveType { get; set; }

        public string EmployeeName;
        public string LeaveTypeName { get; set; }
        public string StatusName { get; set; }

        public string LeaveType { get; set; }
        public string EmployeeComment { get; set; }
        public string ManagerComments { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
