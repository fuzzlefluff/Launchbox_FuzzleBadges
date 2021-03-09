using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.SourceBadges
{
    class BadgeSteamSource : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = game.Source == "Steam" || game.Status == "Imported from Steam";
            return r;
        }
        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }
        
        public BadgeSteamSource()
        {
            Name = "SteamSource";
            UniqueId = "SteamSource";
            Index = SourceBadgeStatic.Index;
            BadgeFileName = "SteamBadge.png";
            DefaultIcon = SourceBadgeStatic.GetImageByName(BadgeFileName);
        }
    }
}
