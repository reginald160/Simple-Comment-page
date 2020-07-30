using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleComent.Models
{
    public class CommentViewModel
    {
        [Required]
        public int WorkId { get; set; }
        public int CommentId { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Text { get; set; }
        public string User { get; set; }
    }
}
    