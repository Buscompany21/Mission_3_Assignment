using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_3_Assignment.Models
{
    public class CalculatorModel
    {
        [Required]
        public byte Assignments { get; set; }

        [Required]
        public byte Projects { get; set; }

        [Required]
        public byte Quizzes { get; set; }

        [Required]
        public byte Exams { get; set; }

        [Required]
        public byte Intex { get; set; }
    }
}
