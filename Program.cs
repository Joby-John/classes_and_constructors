// See https://aka.ms/new-console-template for more information
Book book1 = new Book("harry potter", "JK rowling", 600);
Book book2 = new Book("And then there were None", " Agatha Christie", 400);
Console.WriteLine(book1.title + ",above 500 pg: " +book1.Abv500());
Console.WriteLine(book2.title + " above 500 pg: " + book2.Abv500());
Book book3 = new Book();