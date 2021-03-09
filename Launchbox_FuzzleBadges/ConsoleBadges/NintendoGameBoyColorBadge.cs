using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class NintendoGameBoyColorBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Nintendo Game Boy Color";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public NintendoGameBoyColorBadge()
        {
            Name = "NintendoGameBoyColor";
            UniqueId = "NintendoGameBoyColor";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "NintendoGameboyColorConsole.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}