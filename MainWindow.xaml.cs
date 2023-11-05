using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Book_Darwish
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Classes.Autor> AllAutors = Classes.Autor.AllAutors();
        List<Classes.Genre> AllGenres = Classes.Genre.AllGenres();
        List<Classes.Book> AllBooks = Classes.Book.AllBook();

        public MainWindow()
        {
            InitializeComponent();
            AddAutors();
            AddGenres();
            AddYears();

            CreateUI(AllBooks);
        }

        public void CreateUI(List<Classes.Book> AllBooks)
        {
            parent.Children.Clear();
            foreach (Classes.Book Book in AllBooks)
                parent.Children.Add(new Elements.Element(Book));
        }
        public void AddAutors()
        {
            cbAutors.Items.Add("Выберите...");
            foreach (Classes.Autor Autor in AllAutors)
                cbAutors.Items.Add(Autor.FIO);
        }

        public void AddGenres()
        {
            cbGenres.Items.Add("Выберите...");
            foreach (Classes.Genre Genre in AllGenres)
                cbGenres.Items.Add(Genre.Name);
        }

        public void AddYears()
        {
            cbYear.Items.Add("Выберите...");
            List<int> AllYears = new List<int>();
            foreach (Classes.Book Book in AllBooks)
                if (AllYears.Find(x => x == Book.Year) == 0)
                {
                    AllYears.Add(Book.Year);
                    cbYear.Items.Add(Book.Year);
                }
        }

        private void Search_Book(Object sender, KeyEventArgs e) =>
            Search();
        private void SelectAutor(Object sender, SelectionChangedEventArgs e) =>
            Search();
        public void Search()
        {
            List<Classes.Book> FindBook = AllBooks.FindAll(x => x.Name.ToLower().Contains(tbSearch.Text.ToLower()));

            if (cbAutors.SelectedIndex > 0)
            {
                Classes.Autor SelectAutor = AllAutors.Find(x => x.FIO == cbAutors.SelectedItem.ToString());
                FindBook = FindBook.FindAll(x => x.Autors.Find(y => y.Id == SelectAutor.Id) != null);
            }
            if (cbGenres.SelectedIndex > 0)
            {
                Classes.Genre SelectGender = AllGenres.Find(x => x.Name == cbGenres.SelectedItem.ToString());
                FindBook = FindBook.FindAll(x => x.Genres.Find(y => y.Id == SelectGender.Id) != null);
            }
            if (cbYear.SelectedIndex > 0)

                FindBook = FindBook.FindAll(x => x.Year == Convert.ToInt32(cbYear.SelectedItem.ToString()));
            CreateUI(FindBook);

        }
    }
}
