using System.Drawing;
using Unbroken.LaunchBox.Plugins.Data;

namespace Launchbox_FuzzleBadges.ConsoleBadges
{
    class MicrosoftXbox360Badge : IGameBadge
    {
        public bool GetAppliesToGame(IGame game)
        {
            bool r = false || game.Platform == "Microsoft Xbox 360";
            return r;
        }

        public string Name { get; }
        public string UniqueId { get; }
        public Image DefaultIcon { get; }
        public int Index { get; set; }

        private string BadgeFileName { get; }
        public MicrosoftXbox360Badge()
        {
            Name = "MicrosoftXbox360";
            UniqueId = "MicrosoftXbox360";
            Index = ConsoleBadgesStatic.Index;
            BadgeFileName = "Xbox360Console.png";
            DefaultIcon = ConsoleBadgesStatic.GetImageByName(BadgeFileName);
        }
    }
}
