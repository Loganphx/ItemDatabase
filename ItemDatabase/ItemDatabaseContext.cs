using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace ItemDatabase
{
   
    class Program
    {
        public static ItemDatabaseContext db = new ItemDatabaseContext();
        static void Main(string[] args)
        {
            var allItems = db.GetAllItems();
            Console.WriteLine("ALL");
            foreach (var item in allItems)
            {
                Console.WriteLine(item.ItemName);
            }
            Console.WriteLine();
            var unlockedItems = db.GetUnlockedItems();
            Console.WriteLine("Unlocked\n");
            foreach (var item in unlockedItems)
            {
                Console.WriteLine(item.ItemName);
            }
            Console.WriteLine("\nLocked\n");
            var lockedItems = db.getLockedItems();
            foreach (var item in lockedItems)
            {
                Console.WriteLine(item.ItemName);
            }
        }

       
    }
    
    

    public class ItemDatabaseContext : DbContext
    {
        public ItemDatabaseContext() : base(new DbContextOptionsBuilder<ItemDatabaseContext>()
            .UseSqlite(@"Data Source=C:\Users\ericr\RiderProjects\ItemDatabase\ItemDatabase\items.db")
            .Options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable(
                "ItemTable"
            );
        }
        public IQueryable<Item> GetUnlockedItems()
        {
            var unlockedItems = Items.Where(item => item.Unlocked);
            return unlockedItems;
        }

        public IQueryable<Item> GetAllItems()
        {
            var allItems = Items.AsQueryable();
            return allItems;
        }

        public IQueryable<Item> getLockedItems()
        {
            var lockedItems = Items.Where(item => !item.Unlocked);
            return lockedItems;
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
        
        [Column("unlocked", TypeName = "bool")]
        public bool Unlocked { get; set; }

        public string ToString()
        {
            var toString = "ID: " + Id + ", Name: " + ItemName + ", itemDescription: " + ItemDescription + 
                           ", spritePath: " + SpritePath + ", " + AttackDamage + ", " + AttackSpeed +
                           ", addedProjectiles: " + AddedProjectiles + ", itemHealing: " + ItemHealing + ", moveSpeed: " 
                           + MoveSpeed + ", maxLife: " + MaxLife;
            return toString;

        }

    }
}