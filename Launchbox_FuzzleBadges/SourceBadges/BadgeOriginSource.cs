using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.SourceBadges
{
    class BadgeOriginSource : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = game.Source == "Origin" || game.Status == "Imported from Origin";
            return r;
        }
        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }
        
        public BadgeOriginSource()
        {
            Name = "OriginSource";
            UniqueId = "OriginSource";
            Index = SourceBadgeStatic.Index;
            BadgeFileName = "OriginBadge.png";
            DefaultIcon = SourceBadgeStatic.GetImageByName(BadgeFileName);
        }
    }
}