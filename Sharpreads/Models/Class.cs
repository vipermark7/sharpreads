using System;

namespace Sharpreads.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Summary { get; set; }
        public double? Rating { get; set; }
        public DateTime? Created { get; set; }
        public string? CoverURL { get; set; }

        public Book()
        {

        }
    }
    

}
