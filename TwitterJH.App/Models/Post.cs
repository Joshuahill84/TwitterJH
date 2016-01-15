using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterJH.App.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Text { get; set; }
        public DateTime PostedDate { get; set; }
        public virtual User User { get; set; }
    }
}
