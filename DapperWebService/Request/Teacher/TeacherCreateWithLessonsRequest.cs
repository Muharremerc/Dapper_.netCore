﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperWebService.Request.Teacher
{
    public class TeacherCreateWithLessonsRequest
    {
        public string Name { get; set; }
        public List<int> LessonIdList { get; set; }
    }
}
