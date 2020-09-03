using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_RazorPages_Movie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required, Display(Name = "Название"), StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Дата выпуска"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(30), RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Display(Name = "Жанр")]
        public string Genre { get; set; }

        [Display(Name = "Стоимость"), Column(TypeName = "decimal(18, 0)"), DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Display(Name = "Рейтинг"), StringLength(5)]
        public string Raiting { get; set; }
    }
}
