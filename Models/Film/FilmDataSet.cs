using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deneme1.Models.Film
{
    public class FilmDataSet
    {
        public static List<Film> Items { get; set; }

        static FilmDataSet()
        {
            Items = new List<Film>
            {
                new Film { Id = 1, Ad = "Inception", Tur = 1, Yonetmen = "Christopher Nolan" },
                new Film { Id = 2, Ad = "The Dark Knight", Tur = 2, Yonetmen = "Christopher Nolan" },
                new Film { Id = 3, Ad = "Interstellar", Tur = 1, Yonetmen = "Christopher Nolan" },
                new Film { Id = 4, Ad = "The Prestige", Tur = 1, Yonetmen = "Christopher Nolan" },
                new Film { Id = 5, Ad = "Forrest Gump", Tur = 3, Yonetmen = "Robert Zemeckis" },
                new Film { Id = 6, Ad = "The Matrix", Tur = 4, Yonetmen = "Lana Wachowski, Lilly Wachowski" },
                new Film { Id = 7, Ad = "Pulp Fiction", Tur = 5, Yonetmen = "Quentin Tarantino" },
                new Film { Id = 8, Ad = "The Shawshank Redemption", Tur = 3, Yonetmen = "Frank Darabont" },
                new Film { Id = 9, Ad = "The Godfather", Tur = 5, Yonetmen = "Francis Ford Coppola" },
                new Film { Id = 10, Ad = "Gladiator", Tur = 2, Yonetmen = "Ridley Scott" }
            };
        }

        public static void Ekle(Film film)
        {
            film.Id = (Items.Count > 0) ? Items.Max(x => x.Id) + 1 : 1;
            Items.Add(film);    
        }

        public static void Guncelle(Film film)
        {
            var item = Items.FirstOrDefault(x => x.Id == film.Id);
            if (item != null)
            {
                item.Ad = film.Ad;
                item.Tur = film.Tur;
                item.Yonetmen = film.Yonetmen;
            }
        }   

        public static void Sil(int id)
        {
            var item = Items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                Items.Remove(item);
            }
        }
    }
}