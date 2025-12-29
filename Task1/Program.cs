using Task1;

var posts = new List<Post>();

Post.CreatePost("Fandorin", "Detective book", 1);
Post.CreatePost("Robinson Kruzo", "Adventure book", 2);
Post.CreatePost("Game of Thrones", "Fantasy book", 3);

List<Post> filteredPost = Post.GetPostByName("in");
foreach (var post in filteredPost)
{
    System.Console.WriteLine($"Id: {post.CategoryId}, Title: {post.Title}, Description: {post.Description}");
}
System.Console.WriteLine("***********************************************************");

var categories = new List<Category>();

Category.CreateCategory("Detective book");
Category.CreateCategory("Adventure book");
Category.CreateCategory("Fantasy book");

List<Category> filteredCategory = Category.GetCategoryByName("in");
foreach (var category in filteredCategory)
{
    System.Console.WriteLine($"Id: {category.Id}, Title: {category.Name}, Description: {category.CreatedAt}");
};


