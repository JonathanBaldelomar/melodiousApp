using MelodiousApp.Models.Base;

namespace MelodiousApp.Models
{
    public class Song : BaseEntity
    {
        public string Title { get; set; } = null!;
        public int? Length { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}