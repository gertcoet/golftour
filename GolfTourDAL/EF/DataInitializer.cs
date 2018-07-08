﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GolfTourDAL.Model;

namespace GolfTourDAL.EF
{
    public class DataInitializer : DropCreateDatabaseAlways<GolfTourEntities>
    {
        protected override void Seed(GolfTourEntities context)
        {
            var golfers = new List<Golfer>
            {
                new Golfer {Name = "Gert", Surname = "Coetzee",},
                new Golfer {Name = "The", Surname = "Dude"},
                new Golfer {Name = "Name1", Surname = "Surname1"}
            };
            golfers.ForEach(g => context.Golfers.Add(g));

            var testCourse = new GolfCourse {Name = "TestCourse"};
            context.GolfCourses.Add(testCourse);

            var holes = new List<Hole>
            {
                new Hole {HoleNumber = 1, GolfCourseId = testCourse.GolfCourseId, Par = 4, Stroke = 1}
            //    new Hole {HoleNumber = 2, GolfCourse = testCourse, Par = 4, Stroke = 2},
            //    new Hole {HoleNumber = 3, GolfCourse = testCourse, Par = 3, Stroke = 3},
            //    new Hole {HoleNumber = 4, GolfCourse = testCourse, Par = 4, Stroke = 4},
            //    new Hole {HoleNumber = 5, GolfCourse = testCourse, Par = 3, Stroke = 5},
            //    new Hole {HoleNumber = 6, GolfCourse = testCourse, Par = 4, Stroke = 6},
            //    new Hole {HoleNumber = 7, GolfCourse = testCourse, Par = 5, Stroke = 7},
            //    new Hole {HoleNumber = 8, GolfCourse = testCourse, Par = 4, Stroke = 8},
            //    new Hole {HoleNumber = 9, GolfCourse = testCourse, Par = 5, Stroke = 9}
            };

            context.SaveChanges();
        }
    }
}