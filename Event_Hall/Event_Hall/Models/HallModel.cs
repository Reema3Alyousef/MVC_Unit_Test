﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Event_Hall.Models
{
    public class HallModel
    {
        public int Id { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Avaliability { get; set; }
        public List<AttendeeModel> Event { get; set; }
    }
}
