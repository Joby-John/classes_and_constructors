using System;

public class Book
{
	public string title;
	public string author;
	private string pages;
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
        Pages = Convert.ToString(aPages);
    }
	public string Pages
    {
        get {
			return  pages;
		}
		set //here only more than 500 and less than 500 is the only allowed values for pages 
		{ 
		if (Convert.ToInt32(value) > 500)
            {
				pages = "More than 500";
            }
            else
            {
				pages = "Less than 500";
            }
		}
    }

}
