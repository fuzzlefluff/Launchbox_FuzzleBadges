using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class MicrosoftXboxBadge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Microsoft Xbox";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public MicrosoftXboxBadge()
        {
            Name = "MicrosoftXbox";
            UniqueId = "MicrosoftXbox";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "XboxConsole.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}
