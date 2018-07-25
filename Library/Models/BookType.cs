using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookType
    {
        [Key]
        public int BookTypeId { get; set; }
        public string Type { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}