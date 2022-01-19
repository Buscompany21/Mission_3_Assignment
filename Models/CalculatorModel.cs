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
        public float Assignments { get; set; }

        [Required]
        public float Projects { get; set; }

        [Required]
        public float Quizzes { get; set; }

        [Required]
        public float Exams { get; set; }

        [Required]
        public float Intex { get; set; }
    }
}
