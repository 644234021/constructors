using System;

namespace HW_constructors
{
    internal class Book
    {
        String BookTitle;
        String Author;
        int PublishYear;
        String ISBN;
        int PageCount;

        public Book()
        {
            BookTitle = "Unknown";
            Author = "Unknown";
            ISBN = "Unknown";
            PublishYear= 0;
            PageCount = 0;
        }

        public void booktitle1(String ti,String au)
        {
            BookTitle = ti;
            Author = au;
        }

        public void booktitle2(String ti,String au ,int year)
        {
            BookTitle = ti;
            Author = au;
            PublishYear = year;
        }
        public void display()
        {
            Console.WriteLine("Book title : {0}. ", BookTitle);
            Console.WriteLine("Author : {0}. ", Author);
            Console.WriteLine("ISBN : {0}.", ISBN);
            Console.WriteLine("Publish Year : {0}", PublishYear);
            Console.WriteLine("Page Count : {0}", PageCount);
            Console.WriteLine("----------------------------------");
        }
    }
}
