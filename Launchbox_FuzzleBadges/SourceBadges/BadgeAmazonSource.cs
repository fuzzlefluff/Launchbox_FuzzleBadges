using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.SourceBadges
{
    class BadgeAmazonSource : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = game.Source == "Amazon Games" || game.Status == "Import from Amazon Games";
            return r;
        }
        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }
        
        public BadgeAmazonSource()
        {
            Name = "AmazonSource";
            UniqueId = "AmazonSource";
            Index = SourceBadgeStatic.Index;
            BadgeFileName = "AmazonGamesBadge.png";
            DefaultIcon = SourceBadgeStatic.GetImageByName(BadgeFileName);
        }
    }
}