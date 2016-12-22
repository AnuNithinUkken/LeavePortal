﻿using LMS_WebAPI_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_WebAPI_DAL.Repositories.Interfaces
{
    public interface IApproveLeaveRepository
    {
        List<ApproveLeaveModel> GetApproveLeave(int id);

        bool ApproveEmployeeLeave(int id, string comments, int st);
    }
}