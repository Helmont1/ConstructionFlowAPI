﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstructionFlow.Domain.Model
{
    public class Construction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int StatusId { get; set; }
        [Required]
        public Status Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}