
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSitesi.Model.Core;

namespace BlogSitesi.Model
{
    using System;

    public class ContentTag : ModelBase
    {
        public ContentTag(int contentId, int tagId)
        {
            TagId = TagId;
            ContendId = ContendId;
        }
        public int TagId { get; set; }
        public int ContendId { get; set; }

    }
}
