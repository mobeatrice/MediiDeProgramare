using Movila_Beatrice.Models;
namespace Movila_Beatrice.Models.ViewModels;

public class PublisherIndexData
{

    public IEnumerable<Publisher> Publishers { get; set; }
    public IEnumerable<Book> Books { get; set; }

}