using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class NintendoWiiUBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Nintendo Wii U";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public NintendoWiiUBadge()
        {
            Name = "NintendoWiiU";
            UniqueId = "NintendoWiiU";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "NintendoWiiUConsole.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}