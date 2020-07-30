using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleComent.Models
{
    public class Work
    {
        [Key]
        public int Id { get; set; }



        [Display(Name = "Title")]
        public string Details { get; set; }



        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int CommentId { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
