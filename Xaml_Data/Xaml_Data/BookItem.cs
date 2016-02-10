using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_Data
{
    class BookItem
    {
        public int Id
        {
            get;
            set;
        }
        public string Namei
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public string Image
        {
            get;
            set;
        }
        public string Name { get; private set; }

        public static ObservableCollection<BookItem> BooksList()

        {
        
        ObservableCollection<BookItem> books = new ObservableCollection<BookItem>()

        {
            new BookItem() { Id = 1, Name = "Mathematics", Author = "Adnan", Image = "Assets/b1.png" },
            new BookItem() { Id = 2, Name = "Physics", Author = "Ali", Image = "Assets/b2.png" },
            new BookItem() { Id = 3, Name = "Biology", Author = "Hamza", Image = "Assets/b3.png" },
            new BookItem() { Id = 4, Name = "Chemistry", Author = "Raheem", Image = "Assets/b4.png" },
            new BookItem() { Id = 5, Name = "English", Author = "Daniyal", Image = "Assets/b5.png" },
            new BookItem() { Id = 6, Name = "Computer", Author = "Umair", Image = "Assets/b6.png" },

        };
            return books;
        }

    }
}
