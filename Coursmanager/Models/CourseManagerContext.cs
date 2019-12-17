namespace Coursmanager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CourseManagerContext : DbContext
    {
        public CourseManagerContext()
            : base("name=CourseManagerContext")
        {
        }

        public virtual DbSet<ActionLink> ActionLink { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseManagement> CourseManagement { get; set; }
        public virtual DbSet<Sidebar> Sidebar { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionLink>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ActionLink>()
                .Property(e => e.Controller)
                .IsFixedLength();

            modelBuilder.Entity<ActionLink>()
                .Property(e => e.Action)
                .IsFixedLength();

            modelBuilder.Entity<Classes>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Course>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Sidebar>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Sidebar>()
                .Property(e => e.Controller)
                .IsFixedLength();

            modelBuilder.Entity<Sidebar>()
                .Property(e => e.Action)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
