namespace Movila_Beatrice.Models;

public class Publisher
{
    public int ID { get; set; }
    public string PublisherName { get; set; }
    public ICollection<Book>? Books { get; set; } 
}