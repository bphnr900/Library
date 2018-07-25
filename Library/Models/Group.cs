using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}