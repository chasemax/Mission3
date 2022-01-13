using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission3.Models
{
    public class Calculator_Entries
    {
        [Required(ErrorMessage = "You must fill in the assignment grade.")]
        [Range(0, 100, ErrorMessage = "Assignment grade must be between 0 and 100")]
        public int? a_grade { get; set; }

        [Required(ErrorMessage = "You must fill in the group assignments grade.")]
        [Range(0, 100, ErrorMessage = "Group assignments grade must be between 0 and 100")]
        public int? g_grade { get; set; }

        [Required(ErrorMessage = "You must fill in the quizzes grade.")]
        [Range(0, 100, ErrorMessage = "Quizzes grade must be between 0 and 100")]
        public int? q_grade { get; set; }

        [Required(ErrorMessage = "You must fill in the exams grade.")]
        [Range(0, 100, ErrorMessage = "Exams grade must be between 0 and 100")]
        public int? e_grade { get; set; }

        [Required(ErrorMessage = "You must fill in the INTEX grade.")]
        [Range(0, 100, ErrorMessage = "INTEX grade must be between 0 and 100")]
        public int? i_grade { get; set; }

        public int final_grade { get; set; }
    }
}
