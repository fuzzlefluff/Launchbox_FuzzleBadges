using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class SonyPlatstation2Badge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Sony Playstation 2";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public SonyPlatstation2Badge()
        {
            Name = "SonyPlaystation2";
            UniqueId = "SonyPlaystation2";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "SonyPlaystation2Console.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}