using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Darwish.Classes
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public  List<Genre> Genres { get; set; }

        public  List<Autor> Autors { get; set; }

        public int Year { get; set; }
        public Book(int Id, string Name, List<Genre> Genres, List<Autor> Autors, int Year)

        {
            this.Id = Id;
            this.Name = Name;
            this.Genres = Genres;
            this.Autors = Autors;
            this.Year = Year;
        }
        public static List<Book> AllBook()
        {
            List<Book> allBook = new List<Book>();
            allBook.Add(new Book(
                1, "Юность в сапогах",
                Genre.AllGenres().FindAll(x => x.Id == 1),
                Autor.AllAutors().FindAll(x => x.Id == 1), 2023));
            return allBook;
        }
        public string ToGenres()
        {
            string toGenres = "";
            for (int iGenre = 0; iGenre < this.Genres.Count; iGenre++)
            {
                toGenres += this.Genres[iGenre].Name;
                if (iGenre < this.Genres.Count - 1)
                    toGenres += ", ";
            }
            return toGenres;
        }
        public string ToAutors()
        {
            string toAutors = "";
            for (int iAutor = 0; iAutor < this.Autors.Count; iAutor++)
            {
                toAutors += this.Autors[iAutor].FIO;
                if (iAutor < this.Autors.Count - 1)
                    toAutors += ", ";
            }
            return toAutors;
        }
    }
}
