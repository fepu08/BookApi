﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi_Project.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Review Headline must be between 3 and 10 characters")]
        public string Headline { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 50, ErrorMessage = "Review Text must be between 50 and 2000 characters")]
        public string ReviewText { get; set; }

        [Required]
        public int Rating { get; set; }

        public virtual Reviewer Reviewer { get; set; }
        public virtual Book Book { get; set; }
    }
}
