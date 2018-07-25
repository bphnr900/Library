using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public int GroupId { get; set; }
        public int BookTypeId { get; set; }
        public double No { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Group Group { get; set; }
        public BookType BookType { get; set; }
    }
}