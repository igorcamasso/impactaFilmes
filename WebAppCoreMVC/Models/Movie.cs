using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreMVC.Models
{
    public class Movie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [StringLength(150)]
        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Sinopse")]
        public string Synopsis { get; set; }

        [DisplayName("Ano de lançamento")]
        public int? Ano { get; set; }

        [StringLength(255)]
        [DisplayName("Capa do filme (URL)")]
        public string ThumbUrl { get; set; }

        [DisplayName("Preço")]
        public double Price { get; set; }
    }
}
