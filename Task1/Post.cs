using System;

namespace Task1;

public class Post
{
    public int Id {get; set;}

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public int CategoryId { get; set; }


    private static List<Post> _posts = new();

    public static void CreatePost(string title, string description, int categoryId)
    {
        var post = new Post()
        {
            Title = title,
            Description = description,
            CategoryId = categoryId
        };
        _posts.Add(post);
    }

    public static List<Post> GetPosts()
    {
        return _posts;
    }

    public static Post? GetPostById(int id)
    {
        var post = _posts.Find(p => p.Id == id);

        return post;
    }

    public static List<Post> GetPostByName(string name)
    {
        var filteredPosts = _posts.Where(post => post.Title.ToLower().Contains(name.ToLower())).ToList();

        return filteredPosts;
    }

    public static List<Post> GetPostsByDate(DateTime date)
    {
        var filteredDates = _posts.Where(post => post.CreatedAt == date).ToList();

        return filteredDates;
    }

    public static List<Post> GetPostByCategoryId(int id)
    {
        var filteredCategoruId = _posts.FindAll(post => post.CategoryId == id).ToList();

        return filteredCategoruId;
    }

    public static void DeletePost(int id)
    {
        var deleteId = _posts.Find(post => post.Id == id)!;

        _posts.Remove(deleteId);
    }





}
