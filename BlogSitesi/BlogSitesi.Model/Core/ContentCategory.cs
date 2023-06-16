
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.Model.Core
{
    using System;
    public class ContentCategory : ModelBase
    {
        public ContentCategory(int contentId, int categoryId)
        {
            CategoryId = CategoryId;
            ContendId = ContendId;
        }
        public int CategoryId { get; set; }
        public int ContendId { get; set; }

    }
}
