namespace SSTTEK.Entity
{

   public class Books
   {
      public int Id { get; set; }
      public string Title { get; set; }
      public string Author { get; set; }
      public string ISBN { get; set; }
      public int PublicationYear { get; set; }
      public string Genre { get; set; }
      public string Publisher { get; set; }
      public int PageCount { get; set; }
      public string Language { get; set; }
      public string Summary { get; set; }


      public Books(int ıd, string title, string author, string ısbn, int publicationYear, string genre,
         string publisher, int pageCount, string language, string summary)
      {
         Id = ıd;
         Title = title;
         Author = author;
         ISBN = ısbn;
         PublicationYear = publicationYear;
         Genre = genre;
         Publisher = publisher;
         PageCount = pageCount;
         Language = language;
         Summary = summary;
      }
   }
}