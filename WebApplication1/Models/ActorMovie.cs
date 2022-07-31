﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class ActorMovie
    {
        [Key]
        public int Id { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
