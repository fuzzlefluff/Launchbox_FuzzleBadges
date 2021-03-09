using System;
using System.Drawing;
using System.Reflection;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.GameInfoBadges
{
    class GamePlayedBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = game.LastPlayedDate == null;
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }

        public GamePlayedBadge()
        {
            Name = "GamePlayed";
            UniqueId = "GamePlayed";
            Index = 1;
            BadgeFileName = "PlayedBadge.png";
            DefaultIcon = GetImageByName(BadgeFileName);
        }
        public static Bitmap GetImageByName(string imageName)
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Launchbox_FuzzleBadges.Images." + imageName);
            Bitmap r = new Bitmap(stream);
            return r;
        }
    }
}
