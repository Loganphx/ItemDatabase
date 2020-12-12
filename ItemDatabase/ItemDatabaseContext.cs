using System;
using Microsoft.EntityFrameworkCore;

namespace ItemDatabase
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
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string SpritePath { get; set; }
        public float AttackDamage { get; set; }
        public int AddedProjectiles { get; set; }
            public float AttackSpeed { get; set; }
            public float ItemHealing { get; set; }
            public float MoveSpeed { get; set; }
            public int MaxLife { get; set; }

        }
}