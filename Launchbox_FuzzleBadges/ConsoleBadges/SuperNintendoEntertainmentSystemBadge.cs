using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class SuperNintendoEntertainmentSystemBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Super Nintendo Entertainment System";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public SuperNintendoEntertainmentSystemBadge()
        {
            Name = "SuperNintendoEntertainmentSystem";
            UniqueId = "SuperNintendoEntertainmentSystem";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "SuperNintendoEntertainmentConsole.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}