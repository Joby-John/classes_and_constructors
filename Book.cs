using System;

public class Book
{
	public string title;
	public string author;
	public int pages;
	public Book()
	{
		//constructor with no parameter
		Console.Write("constructor with No parameter");
	}
	public Book(string aTitle, string aAuthor, int aPages)
    {
		//consturctor with parameters
        title = aTitle;
        author = aAuthor;
        pages = aPages;
    }
}
