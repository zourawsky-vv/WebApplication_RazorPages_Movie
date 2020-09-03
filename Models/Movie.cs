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

        [Display(Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Дата выпуска")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Жанр")]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        [Display(Name = "Стоимость")]
        public decimal Price { get; set; }
    }
}
