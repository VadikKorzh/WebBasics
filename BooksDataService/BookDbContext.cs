namespace BooksDataService
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookDbContext : DbContext
    {
        // Your context has been configured to use a 'BookModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BooksDataService.BookModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BookModel' 
        // connection string in the application configuration file.
        public BookDbContext()
            : base("name=BookDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BookDbContext>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}