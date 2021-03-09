using System;
using System.Drawing;
using System.Reflection;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.GameInfoBadges
{
    class CompletedBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = game.Completed;
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }
        public CompletedBadge()
        {
            Name = "GameCompleted";
            UniqueId = "GameCompleted";
            Index = 6;
            BadgeFileName = "GameCompletedBadge.png";
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
