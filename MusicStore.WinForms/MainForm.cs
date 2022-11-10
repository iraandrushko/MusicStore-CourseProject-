using Microsoft.Extensions.DependencyInjection;
using MusicStore.BLL.Services;
using MusicStore.DTO;
using MusicStore.WinForms.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicStore.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IApplicationContext context;
        private readonly IAlbumService albumService;
        private readonly IOrderService orderService;

        public MainForm(IApplicationContext context, IAlbumService albumService, IOrderService orderService)
        {

            context.CurrentUser = Program.ServiceProvider.GetService<IAuthenticationService>().SignIn("AnneHathaway", "veryfamous");

            if (context.CurrentUser == null)
            {
                var form = Program.ServiceProvider.GetRequiredService<LoginForm>();
                form.ShowDialog();
            }
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;

            InitializeComponent();
            this.context = context;
            this.albumService = albumService;
            this.orderService = orderService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var albums = this.albumService.GetAlbumsWithArtists();
            var albumVMs = albums.Select(a => 
                new AlbumViewModel(
                    a.Id,
                    a.Name,
                    a.Artist.Name,
                    "$" + a.Price
                ))
                .ToList();

            var blist = new BindingList<AlbumViewModel>(albumVMs);

            dtAlbums.DataSource = blist;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            int? albumId = null; 
            var selectedCells = this.dtAlbums.SelectedCells;
            foreach (DataGridViewCell cell in selectedCells)
            {
                if (cell.OwningColumn.Name == "Id")
                {
                    albumId = int.Parse(cell.Value.ToString());
                    break;
                }
            }

            if (albumId.HasValue)
            {
                this.orderService.Create(new OrderDto
                {
                    UserId = context.CurrentUser.Id,
                    AlbumId = albumId.Value
                });
            }
            else 
            {
                MessageBox.Show("No album(s) selected", "Error");
            }

        }

        private void SHowMyOrdersButton_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<MyOrdersForm>();
            form.ShowDialog();
        }
    }
}
