using AspNetMvc_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvc_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuiler)
        //{
        //    modelBuiler.Entity<Student>().ToTable("Student");
        //    modelBuiler.Entity<Course>().ToTable("Course");
        //    modelBuiler.Entity<StudentCourse>().ToTable("StudentCourse");
        //}

        // then add-migration ----> update-database
    }
}
