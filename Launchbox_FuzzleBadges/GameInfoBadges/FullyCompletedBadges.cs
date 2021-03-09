using System;
using System.Drawing;
using System.Reflection;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.GameInfoBadges
{
    class FullyCompletedBadges : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false;

            var customFields = game.GetAllCustomFields();

            foreach (var i in customFields)
            {
                if (i.Name == "100% Completed" && i.Value.ToUpper() == "TRUE")
                {
                    r = true;
                }
            }
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }

        public FullyCompletedBadges()
        {
            Name = "GameFullyCompleted";
            UniqueId = "GameFullyCompleted";
            Index = 5;
            BadgeFileName = "FullyCompletedBadge.png";
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
