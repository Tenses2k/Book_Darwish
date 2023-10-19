using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Darwish.Classes
{
   public class Autor
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public Autor (int Id, string FIO)
        {
            this.Id = Id;
            this.FIO = FIO;
        }
        public static List<Autor> AllAutors()
        {
            List<Autor> allAutors = new List<Autor>();
            allAutors.Add(new Autor(1, "Хасбулла Магомедов"));
            allAutors.Add(new Autor(2, "Абдурозик Шахов"));
            allAutors.Add(new Autor(3, "Эрен Егер"));
            allAutors.Add(new Autor(4, "Ичиго Курасаки"));
            allAutors.Add(new Autor(5, "Александр Валерьевич Шишко"));
            return allAutors;
        }
    }
}
