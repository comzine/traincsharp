class Book
{
  string title;
  string author;
  int publicationYear;
  string isbn;
  int pageCount;

  public Book(string title, string author, int publicationYear, string isbn, int pageCount)
  {
    this.title = title;
    this.author = author;
    this.publicationYear = publicationYear;
    this.isbn = isbn;
    this.pageCount = pageCount;
  }

  public override string ToString()
  {
    return $"{title} by {author} ({publicationYear})";
  }

  public int GetAgeInYears()
  {
    return DateTime.Now.Year - publicationYear;
  }

  public bool HasMorePagesThan(Book otherBook)
  {
    return pageCount > otherBook.pageCount;
  }
}