using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.SourceBadges
{
    class BadgeEpicSource : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = game.Source == "Epic Games" || game.Status == "Imported from Epic Games";
            return r;
        }
        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }
        private string BadgeFileName { get; }
        
        public BadgeEpicSource()
        {
            Name = "EpicGamesSource";
            UniqueId = "EpicGamesSource";
            Index = SourceBadgeStatic.Index;
            BadgeFileName = "EpicGamesBadge.png";
            DefaultIcon = SourceBadgeStatic.GetImageByName(BadgeFileName);
        }
    }
}