﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFcoreEg.Models;

public partial class WiproSampleDbContext : DbContext
{
    //Constructor
    public WiproSampleDbContext()
    {
    }

    //overloaded constructor
    public WiproSampleDbContext(DbContextOptions<WiproSampleDbContext> options)
        : base(options)
    {
    }

    //list of entity classes - Recordset
    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=WiproSampleDb;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__courses__D837D05F2AA7D8EB");

            entity.ToTable("courses");

            entity.Property(e => e.Cid)
                .ValueGeneratedNever()
                .HasColumnName("cid");
            entity.Property(e => e.Cname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.Fees).HasColumnName("fees");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Student__DDDFDD36120B36AE");

            entity.ToTable("Student");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Chennai")
                .HasColumnName("city");
            entity.Property(e => e.Courseid).HasColumnName("courseid");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");

            entity.HasOne(d => d.Course).WithMany(p => p.Students)
                .HasForeignKey(d => d.Courseid)
                .HasConstraintName("FK__Student__coursei__25869641");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
