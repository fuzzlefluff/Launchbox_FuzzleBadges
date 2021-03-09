using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class SonyPlatstation4Badge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Sony Playstation 4";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public SonyPlatstation4Badge()
        {
            Name = "SonyPlaystation4";
            UniqueId = "SonyPlaystation4";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "SonyPlaystation4Console.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}