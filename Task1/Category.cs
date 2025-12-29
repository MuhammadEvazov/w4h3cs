using System;

namespace Task1;

public class Category
{
     public int Id {get; set;}

    public string Name { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }


    private static List<Category> _categories = new();

    public static void CreateCategory(string name)
    {
        var category = new Category()
        {
            Name = name,
        };
        _categories.Add(category);
    }

    public static List<Category> GetCategories()
    {
        return _categories;
    }

    public static Category? GetCategoryById(int id)
    {
        var category = _categories.Find(p => p.Id == id);

        return category;
    }

    public static List<Category> GetCategoryByName(string name)
    {
        var filteredCategories = _categories.Where(post => post.Name.ToLower().Contains(name.ToLower())).ToList();

        return filteredCategories;
    }

    public static List<Category> GetPostsByDate(DateTime date)
    {
        var filteredDates = _categories.Where(post => post.CreatedAt == date).ToList();

        return filteredDates;
    }

    public static void DeleteCategory(int id)
    {
        var deleteId = _categories.Find(post => post.Id == id)!;

        _categories.Remove(deleteId);
    }
}
