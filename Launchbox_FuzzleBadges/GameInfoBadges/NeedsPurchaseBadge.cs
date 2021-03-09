using System;
using System.Drawing;
using System.Reflection;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.GameInfoBadges
{
    class NeedsPurchaseBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false;

            var customFields = game.GetAllCustomFields();

            foreach (var i in customFields)
            {
                if (i.Name == "Needs Purchase" && i.Value.ToUpper() == "TRUE")
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

        public NeedsPurchaseBadge()
        {
            Name = "NeedsPurchase";
            UniqueId = "NeedsPurchase";
            Index = 3;
            BadgeFileName = "NeedsPurchaseBadge.png";
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
