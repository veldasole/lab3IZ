using System.Windows;
using library.Helper;
using library.ViewModel;
using library.Model;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace library.View
{
    /// <summary>
    /// Логика взаимодействия для WindowBook.xaml
    /// </summary>
    public partial class WindowBook : Window
    {
        public WindowBook()
        {
            InitializeComponent();
            BookViewModel vmBook = new BookViewModel();
            AuthorViewModel vmAuthor = new AuthorViewModel();
            PublishViewModel vmPublish = new PublishViewModel();

            List<Author> authors = new List<Author>();
            foreach (Author a in vmAuthor.ListAuthor)
            {
                authors.Add(a);
            }

            List<Publish> publishes = new List<Publish>();
            foreach (Publish p in vmPublish.ListPublish)
            {
                publishes.Add(p);
            }

            ObservableCollection<BookDPO> boooks = new ObservableCollection<BookDPO>();
            FindAuthor findAu;
            FindPublish findPub;

            foreach (var b in vmBook.ListBook)
            {
                findAu = new FindAuthor(b.AuthorId);
                Author auth = authors.Find(new Predicate<Author>(findAu.AuthorPredicate));
                
                findPub = new FindPublish(b.PublishId);
                Publish pub = publishes.Find(new Predicate<Publish>(findPub.PublishPredicate));

                boooks.Add(new BookDPO
                {
                    Id = b.Id,
                    Author = auth.FirstName + " " + auth.LastName,             
                    Publish = pub.NamePublish,
                    Title = b.Title,
                    Code = b.Code,
                    YearPublish = b.YearPublish,
                    CountPage = b.CountPage,
                    Hardcover = b.Hardcover,
                    Abstract = b.Abstract,
                    Statuc = b.Statuc,
                });
            }
            lvBook.ItemsSource = boooks;
        }
    }
}
