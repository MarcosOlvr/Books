namespace Books.Api.Models;

public class Book
{
    public string Id {get; set;}
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public DateTime PublishDate { get; set; }
    public int Pages { get; set; }
    public string Image { get; set; }
    public List<string> Categories { get; set; }
}