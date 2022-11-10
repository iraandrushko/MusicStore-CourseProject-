using MusicStore.DTO;

namespace MusicStore.WinForms
{
    public interface IApplicationContext
    {
        public UserDto CurrentUser { get; set; }
    }
}