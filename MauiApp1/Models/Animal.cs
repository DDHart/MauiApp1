﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    internal class Animal
    {
        private String name; 
        public string Name { get { return name; } set { name = value; } }
        public Animal(String name) { this.name = name; }

    }
}
