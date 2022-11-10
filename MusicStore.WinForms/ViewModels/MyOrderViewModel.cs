using System;

namespace MusicStore.WinForms.ViewModels
{
    public class MyOrderViewModel
    {
        public string AlbumName { get; private set; }
        public string AlbumPrice { get; private set; }

        public DateTime Date { get; private set; }

        public MyOrderViewModel(string albumName, string albumPrice, DateTime date)
        {
            AlbumName = albumName;
            AlbumPrice = albumPrice;
            Date = date;
        }

    }
}
