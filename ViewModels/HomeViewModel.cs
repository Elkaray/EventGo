﻿using EventGo.Models;
using System.Collections.Generic;

namespace EventGo.ViewModels
{
    public class HomeViewModel
    {
        public User user { get; set; }
        public List<Cinema> Cinemas { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Category> Categories { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
