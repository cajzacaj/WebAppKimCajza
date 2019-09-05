using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public IdentityUser User { get; set; }
        public Hero Hero { get; set; }
        public int HeroId { get; set; }
    }
}
