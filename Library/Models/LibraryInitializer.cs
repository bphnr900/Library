using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    public class LibraryInitializer : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var Groups = new List<Group>
            {
                new Group{GroupCode="7580",GroupName="一迅社"},
                new Group{GroupCode="8322",GroupName="芳文社"}
            };
            Groups.ForEach(m => context.Groups.Add(m));
            context.SaveChanges();
            var booktypes = new List<BookType>
            {
                new BookType{Type="A",TypeName="一般"},
                new BookType{Type="B",TypeName="教養"}
            };
            booktypes.ForEach(m => context.BookTypes.Add(m));
            context.SaveChanges();
            var books = new List<Book>
            {
                new Book
                {
                    //GroupId = "T31",
                    GroupId = 1,
                    BookTypeId = 1,
                    No = 1,
                    Name = "ご注文はうさぎですか?",
                    Author = "Koi"
                },
                new Book
                {
                    GroupId = 2,
                    BookTypeId = 2,
                    No = 2,
                    Name = "きんいろモザイク",
                    Author = "原悠衣"
                }
            };
            books.ForEach(m => context.Books.Add(m));
            context.SaveChanges();
        }
    }
}