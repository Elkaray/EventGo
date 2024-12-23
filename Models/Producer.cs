﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventGo.Models
{
    public class Producer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public string Bio { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
