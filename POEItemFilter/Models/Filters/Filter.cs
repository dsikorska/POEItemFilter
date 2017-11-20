﻿using System;
using POEItemFilter.Library.Enumerables;

namespace POEItemFilter.Models.Filters
{
    public class Filter
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public ICollection<ItemUser> Items { get; set; }

        public string Description { get; set; }

        //public string UserId { get; set; } //nvarchar(128)

        public DateTime CreateDate { get; set; }

        public DateTime EditDate { get; set; }

        public Classes? Dedicated { get; set; }

        //public Filter()
        //{
        //    Items = new HashSet<ItemUser>();
        //}
    }
}