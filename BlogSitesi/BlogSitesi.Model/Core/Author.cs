
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSitesi.Model.Core;

namespace BlogSitesi.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Author : ModelBase
    {
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }

        [NotMapped]
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
