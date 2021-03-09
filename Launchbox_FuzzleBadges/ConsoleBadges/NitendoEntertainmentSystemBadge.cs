using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class NintendoEntertainmentSystemBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Nintendo Entertainment System";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public NintendoEntertainmentSystemBadge()
        {
            Name = "NintendoEntertainmentSystem";
            UniqueId = "NintendoEntertainmentSystem";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "NintendoEntertainmentSystemConsole.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}