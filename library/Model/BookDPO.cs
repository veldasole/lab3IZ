using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Model
{
    class BookDPO
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Publish { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public int YearPublish { get; set; }
        public int CountPage { get; set; }
        public string Hardcover { get; set; }
        public string Abstract { get; set; }
        public bool Statuc { get; set; }
        public BookDPO() { }
        public BookDPO(int id, string author, string publish, string title, string code,
            int yearPublish, int countPage, string hardcover, string bstract, bool statuc)
        {
            this.Id = id;
            this.Author = author;
            this.Publish = publish;
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
