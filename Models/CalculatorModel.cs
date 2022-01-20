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
        [Range(1,100)]
        public float Assignments { get; set; }

        [Required]
        [Range(1, 100)]
        public float Projects { get; set; }

        [Required]
        [Range(1, 100)]
        public float Quizzes { get; set; }

        [Required]
        [Range(1, 100)]
        public float Exams { get; set; }

        [Required]
        [Range(1, 100)]
        public float Intex { get; set; }
    }
}
