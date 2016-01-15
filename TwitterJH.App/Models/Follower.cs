using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterJH.App.Models
{
    public class Follower
    {
        public List<User> Users { get; set; }
        public int FollowerId { get; set; } 
    }
}
