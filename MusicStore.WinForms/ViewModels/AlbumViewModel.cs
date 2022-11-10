using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.WinForms.ViewModels
{
    public class AlbumViewModel
    {
        public int Id { get; private set; }
        public string AlbumName { get; private set; }
        public string ArtistName { get; private set; }
        public string Price { get; private set; }

        public AlbumViewModel(int id, string albumName, string artistName, string price)
        {
            Id = id;
            AlbumName = albumName;
            ArtistName = artistName;
            Price = price;
        }

    }
}
