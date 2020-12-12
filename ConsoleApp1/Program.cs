using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    

    public class ItemDatabaseContext : DbContext
    {
        public ItemDatabaseContext() : base(new DbContextOptionsBuilder<ItemDatabaseContext>()
            .UseSqlite(@"Data Source=items.db")
            .Options)
        {

        }

        public DbSet<Item> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable(
                "ItemTable"
            );
        }
    }

    public class Item
        {
            public int ItemID { get; set; }
            public string ItemName { get; set; }
        
        }
    }