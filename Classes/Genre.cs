using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Darwish.Classes
{
   public  class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public static List<Genre> AllGenres()
        {
            List<Genre> allGenres = new List<Genre>();
            allGenres.Add(new Genre(1, "Чиловая походка"));
            allGenres.Add(new Genre(2, "тру стафчик"));
            allGenres.Add(new Genre(3, "на раслаБоне "));
            allGenres.Add(new Genre(4, "Миша"));
            allGenres.Add(new Genre(5, "миша, путь киберспотсмена 'Стендофф 2'"));
            return allGenres;
        }

    }
}
