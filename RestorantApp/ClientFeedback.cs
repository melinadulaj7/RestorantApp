﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp
{
    public class ClientFeedback
    {
        [Key]
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; } 
    }
}
