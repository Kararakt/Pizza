﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Data.Database.Models
{
    public class PizzaSize
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}