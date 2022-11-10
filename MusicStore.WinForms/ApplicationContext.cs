using MusicStore.DTO;

namespace MusicStore.WinForms
{
    public class ApplicationContext : IApplicationContext
    {
        public UserDto CurrentUser { get; set; }
    }
}
