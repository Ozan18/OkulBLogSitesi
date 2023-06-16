﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model.Core
{
    using System;
    public class Tag : ModelBase
    {
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
