﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWorkflow
{
    enum CourseLevel : byte
    {
        Beginner = 0,
        Intermediate = 1,
        Advanced = 2
    }

    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags{ get; set; }
    }
}
