namespace Karaoke.Domain.Models.Karaoke
{
    public class Karaokes
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string? Music { get; set; }
        public int Ordem { get; set; }
    }
}
