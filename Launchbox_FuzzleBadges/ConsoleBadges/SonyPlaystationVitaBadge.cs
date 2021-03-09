using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class SonyPlatstationVitaBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Sony Playstation Vita";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public SonyPlatstationVitaBadge()
        {
            Name = "SonyPlaystationVita";
            UniqueId = "SonyPlaystationVita";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "SonyVitaConsole.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}