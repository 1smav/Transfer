﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ICD.Models
{
    public class Agreement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Author { get; set; }
        public string LastModifiedDate { get; set; } 

    }
}