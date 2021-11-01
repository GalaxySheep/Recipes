using System.Collections.Generic;
using Recipes.Models;
using SQLite;
using System.Threading.Tasks;
using System;

namespace Recipes.Data
{
    public class RecipeDatabase
    {
        readonly SQLiteAsyncConnection database;

        public RecipeDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Recipe>().Wait();
        }

        public Task<List<Recipe>> GetNotesAsync()
        {
            //Get all notes.
            return database.Table<Recipe>().ToListAsync();
        }

        public Task<Recipe> GetNoteAsync(int id)
        {
            // Get a specific note.
            return database.Table<Recipe>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Recipe recipe)
        {
            if (recipe.ID != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(recipe);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(recipe);
            }
        }

        public Task<int> DeleteNoteAsync(Recipe recipe)
        {
            // Delete a note.
            return database.DeleteAsync(recipe);
        }
    }
}