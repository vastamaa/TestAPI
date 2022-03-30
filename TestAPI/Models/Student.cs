﻿using System.Collections.Generic;

#nullable disable

namespace TestAPI.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
