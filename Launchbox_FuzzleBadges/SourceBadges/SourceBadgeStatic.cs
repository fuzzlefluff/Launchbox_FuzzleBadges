using System.Drawing;
using System.Reflection;

namespace Launchbox_FuzzleBadges.SourceBadges
{
    static class SourceBadgeStatic
    {
        public static int Index = 9;

        public static Bitmap GetImageByName(string imageName)
        {
            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Launchbox_FuzzleBadges.Images." + imageName);
            Bitmap r = new Bitmap(stream);
            return r;
        }
    }
}
