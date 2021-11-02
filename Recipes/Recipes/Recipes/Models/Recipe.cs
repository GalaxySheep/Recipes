using SQLite;

namespace Recipes.Models
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public string Creator { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
    }
}
