using MusicStore.BLL.Services;
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
    public partial class MyOrdersForm : Form
    {
        private readonly IApplicationContext context;
        private readonly IOrderService orderService;

        public MyOrdersForm(IApplicationContext context, IOrderService orderService)
        {
            InitializeComponent();
            this.context = context;
            this.orderService = orderService;
        }

        private void MyOrdersForm_Load(object sender, EventArgs e)
        {
            var myOrders = orderService.GetOrdersByUser(context.CurrentUser.Id);
            var myOrdersVMs = myOrders.Select(o =>
                new MyOrderViewModel(
                    o.Album.Name,
                    "$" + o.Album.Price,
                    o.CreatedDate
                ))
                .ToList();

            var blist = new BindingList<MyOrderViewModel>(myOrdersVMs);
            dtOrders.DataSource = blist;
        }
    }
}
