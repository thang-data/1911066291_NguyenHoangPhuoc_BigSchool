using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1911066291_NguyenHoangPhuoc_BigSchool.Models
{
    public class Course
    {
        public int id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public Byte CategoryId { get; set; }
    }

    public class Category
    {
        public Byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}