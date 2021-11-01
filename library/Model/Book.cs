using System;

namespace library.Model
{
    public class Book
    {
        public int Id { get; set; } 
        public int AuthorId { get; set; }
        public int PublishId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int YearPublish { get; set; }
        public int CountPage { get; set; }
        public string Hardcover { get; set; }
        public string Abstract { get; set; }
        public bool Statuc { get; set; }

        public Book() { }
        public Book(int id, int authorId, int publishId, string title, string code,
            int yearPublish, int countPage, string hardcover, string bstract, bool statuc)
        {
            this.Id = id;
            this.AuthorId = authorId;
            this.PublishId = publishId;
            this.Title = title;
            this.Code = code;
            this.YearPublish = yearPublish;
            this.CountPage = countPage;
            this.Hardcover = hardcover;
            this.Abstract = bstract;
            this.Statuc = statuc;
        }
    }
}
