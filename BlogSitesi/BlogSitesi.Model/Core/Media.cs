﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model.Core
{
    using System;

    public class Media : ModelBase
    {
        public string FileName { get; set; }
        public string FileSlug { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public string MediaUrl { get; set; }

    }
}
