﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS_WebAPI_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeaveManagementSystemEntities1 : DbContext
    {
        public LeaveManagementSystemEntities1()
            : base("name=LeaveManagementSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EmployeeContactDetail> EmployeeContactDetails { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<EmployeeLeaveTransaction> EmployeeLeaveTransactions { get; set; }
        public virtual DbSet<EmployeeLeaveTransactionHistory> EmployeeLeaveTransactionHistories { get; set; }
        public virtual DbSet<EmployeeProjectDetail> EmployeeProjectDetails { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<LeaveMaster> LeaveMasters { get; set; }
        public virtual DbSet<MasterDataType> MasterDataTypes { get; set; }
        public virtual DbSet<MasterDataValue> MasterDataValues { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }
        public virtual DbSet<Workflow> Workflows { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<EmployeeEducationDetail> EmployeeEducationDetails { get; set; }
        public virtual DbSet<EmployeeExperienceDetail> EmployeeExperienceDetails { get; set; }
        public virtual DbSet<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
