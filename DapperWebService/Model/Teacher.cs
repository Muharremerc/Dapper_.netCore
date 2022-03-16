﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWebService.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Lesson> LessonList { get; set; } = new List<Lesson>();
    }
}
