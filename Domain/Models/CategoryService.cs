﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CategoryService
    {
        public CategoryService()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid SectorId { get; set; }
        public Sector Sector { get; set; }
        public ICollection<Service> Services { get; set; }

    }
}
