using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.SourceBadges
{
    class BadgeXboxSource : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Source == "Xbox/Microsoft Store" || game.Status == "Imported from Xbox/Microsoft Store";
            return r;
        }
        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }
        
        public BadgeXboxSource()
        {
            Name = "XboxSource";
            UniqueId = "XboxSource";
            Index = SourceBadgeStatic.Index;
            BadgeFileName = "XboxBadge.png";
            DefaultIcon = SourceBadgeStatic.GetImageByName(BadgeFileName);
        }
    }
}