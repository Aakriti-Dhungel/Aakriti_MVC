using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

namespace Aakriti_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        //[Required]
        public string? FullName { get; set; }

        //[Range(16, 100)]
        public int Age { get; set; }

        [Column(TypeName = "timestamp without time zone")]
        public DateTime EnrollmentDate { get; set; }
    }
}

