using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Xaml_Data
{    

    public sealed partial class MainPage : Page


    {

        private ObservableCollection<BookItem> bookItems_;
        private ObservableCollection<BookItem> BookItems

        {
            get
            {
                return bookItems_;
            }

            set
            {
                bookItems_ = value;
            }
        }

        public MainPage()

        {
            this.InitializeComponent();
            bookItems_ = BookItem.BooksList();
            this.DataContext = BookItems;
        }


    }
}

