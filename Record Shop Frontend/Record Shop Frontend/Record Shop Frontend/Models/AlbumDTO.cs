namespace Record_Shop_Frontend.Models;

public record AlbumDTO
{
    public string Title { get; set; }
    public string Label { get; set; }
    public DateOnly ReleaseDate { get; set; }
    public List<Genre> Genres { get; set; }
    public int ArtistId { get; set; }
}