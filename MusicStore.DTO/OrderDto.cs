﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DTO
{
    public class OrderDto
    {
        public UserDto User { get; set; }
        public AlbumDto Album { get; set; }
    }
}
