using System;
using SQLite;

namespace MyRecipesApp.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Maker { get; set; }
        public string Ingre { get; set; }
        public string Steps { get; set; }
    }
}