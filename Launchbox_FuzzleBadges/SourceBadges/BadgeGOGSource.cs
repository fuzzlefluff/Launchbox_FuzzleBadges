using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.SourceBadges
{
    class BadgeGOGSource : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = game.Source == "GOG" || game.Status == "Imported from GOG for Windows" || game.Status == "Imported from GOG for MS-DOS";
            return r;
        }
        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }
        
        public BadgeGOGSource()
        {
            Name = "GOGSource";
            UniqueId = "GOGSource";
            Index = SourceBadgeStatic.Index;
            BadgeFileName = "GoGGalaxyBadge.png";
            DefaultIcon = SourceBadgeStatic.GetImageByName(BadgeFileName);
        }
    }
}