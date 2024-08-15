using System;
using DataAccess.Entities;
using DataAccess.StoredProcedues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.Context
{
    public partial class JumpInTicketsContext : DbContext
    {
        public JumpInTicketsContext()
        {
        }

        public JumpInTicketsContext(DbContextOptions<JumpInTicketsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tbPriorityLevel> PriorityLevels { get; set; }
        public virtual DbSet<TbCategory> TbCategories { get; set; }
        public virtual DbSet<TbDeparment> TbDeparments { get; set; }
        public virtual DbSet<TbStatus> TbStatuses { get; set; }
        public virtual DbSet<TbSubCategory> TbSubCategories { get; set; }
        public virtual DbSet<TbTicket> Tickets { get; set; }

        #region SP_DBSETS
        public DbSet<TICKET_LIST> PR_Ticket_List { get; set; }
        #endregion SP_DBSETS

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            #region StoredProceduresEntity
            modelBuilder.Entity<TICKET_LIST>().HasNoKey();
            #endregion StoredProceduresEntity

            modelBuilder.Entity<tbPriorityLevel>(entity =>
            {
                entity.Property(e => e.PriortyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbCategory>(entity =>
            {
                entity.ToTable("tbCategories");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbDeparment>(entity =>
            {
                entity.ToTable("tbDeparments");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStatus>(entity =>
            {
                entity.ToTable("tbStatuses");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSubCategory>(entity =>
            {
                entity.ToTable("tbSubCategory");

                entity.Property(e => e.SubCategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTicket>(entity =>
            {
                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TicketDescription).HasMaxLength(4000);

                entity.Property(e => e.TicketTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
