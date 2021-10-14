﻿using CourseStore.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Infra.Data.Sql
{
    public static class CommandRepasitory
    {
        public static void CheckEntityState()
        {
            var ctx = ContextFactory.GetSqlDbContext();
            var tag = new Tag()
            {
                Title = "Tag 2"
            };
            // Added
            ctx.Add(tag);
            Console.WriteLine($"state {ctx.Entry(tag).State}");
            Console.WriteLine("______________________________");

            // Unchanged
            var course = ctx.Courses.FirstOrDefault();
            Console.WriteLine($"state {ctx.Entry(course).State}");
            Console.WriteLine("______________________________");


            //  Modified
            course.Title = "Change Title";
            Console.WriteLine($"state {ctx.Entry(course).State}");

            //ctx.Entry(course).Property(c => c.Title).CurrentValue = "Change Title";
            //ctx.ChangeTracker.DetectChanges();
            //Console.WriteLine(ctx.ChangeTracker.DebugView.LongView);

            Console.WriteLine("______________________________");

            // Deleted
            ctx.Remove(course);
            Console.WriteLine($"state {ctx.Entry(course).State}");
            Console.WriteLine("______________________________");


            var tag2 = new Tag()
            {
                Title = "Tag 2"
            };
              Console.WriteLine($"state {ctx.Entry(tag2).State}");

          
        }
    }
}
