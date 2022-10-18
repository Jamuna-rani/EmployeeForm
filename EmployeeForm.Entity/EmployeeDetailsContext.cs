﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeForm.Entity
{
    public partial class EmployeeDetailsContext : DbContext
    {
        public EmployeeDetailsContext()
        {
        }

        public EmployeeDetailsContext(DbContextOptions<EmployeeDetailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeInfo> EmployeeInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSqlLocalDb;Initial Catalog=EmployeeDetails;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeInfo>(entity =>
            {
                entity.HasKey(e => e.Employee_Id);

                entity.Property(e => e.Confirm_Password)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Create_Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created_Time_Stamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date_of_Joining)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Employee_Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Employee_work_Location)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.First_Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Last_Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Updated_Time_Stamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}