using System;

class Book
{
    public string title;
    public string author;
    public int pages;
    private double rating;

    public Book(string titlebook, string authorbook, int pagesbook, double ratingbook)
    {
        Console.WriteLine("title: ");
        titlebook = Console.ReadLine();
        Console.WriteLine("author: ");
        authorbook = Console.ReadLine();
        Console.WriteLine("pages: ");
        pagesbook = Convert.ToInt32(Console.ReadLine());

        title = titlebook;
        author = authorbook;
        pages = pagesbook;
        Rating = ratingbook;
    }
    public void largebook()
    {
        if(pages>100){
            Console.WriteLine("The book is too long. ");
        }else{
            Console.WriteLine("The book is fine");
        }
    }

    public double Rating{
        get { return rating; }
        set {
            if(value <= 5 ){
                rating = value;
            }else{
                rating = 0;
            }
        }
    }
}