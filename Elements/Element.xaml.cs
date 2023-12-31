﻿using System;
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

namespace Book_Darwish.Elements
{
    /// <summary>
    /// Логика взаимодействия для UserControl.xaml
    /// </summary>
    public partial class Element : UserControl
    {
        public Element(Classes.Book Book)
        {
            InitializeComponent();
            tbName.Text = $"Наименование: {Book.Name} ({Book.Year} г.)";
            tbGenre.Text = $"Жанр: {Book.ToGenres()}";
            tbAutor.Text = $"Автор: {Book.ToAutors()}";
        }
    }
}
