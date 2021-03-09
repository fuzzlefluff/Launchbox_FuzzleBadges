using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class NintendoGameBoyAdvanceBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Nintendo Game Boy Advance";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public NintendoGameBoyAdvanceBadge()
        {
            Name = "NintendoGameBoyAdvance";
            UniqueId = "NintendoGameBoyAdvance";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "NintendoGameboyAdvanceConsole.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}