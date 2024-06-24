Book book1 = new Book("Der Herr der Ringe", "J.R.R. Tolkien", 1954, "978-3-608-93501-6", 1216);
Book book2 = new Book("Harry Potter und der Stein der Weißen", "J.K. Rowling", 1997, "978-3-551-55118-4", 352);

Console.WriteLine(book1);
System.Console.WriteLine("Dieses Buch ist {0} Jahre alt.", book1.GetAgeInYears());
Console.WriteLine(book2);
System.Console.WriteLine("Dieses Buch ist {0} Jahre alt.", book2.GetAgeInYears());

if (book1.HasMorePagesThan(book2))
{
  System.Console.WriteLine("Das erste Buch hat mehr Seiten als das zweite Buch.");
}
else
{
  System.Console.WriteLine("Das zweite Buch hat mehr Seiten als das erste Buch.");
}