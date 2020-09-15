using EPiServer.Framework.Web;
using EPiServer.Web;
using System.Web;

namespace AlloyTraining.Business.DisplayChannels
{
    public class MobileDisplayChannel : DisplayChannel
    {
        // C# 6.0 syntax for a read-only property
        public override string ChannelName => RenderingTags.Mobile;

        public override string ResolutionId => "iphone5";

        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }
    }

    public class iPhone5 : IDisplayResolution
    {
        public string Id => "iphone 5";
        public string Name => "iPhone 5 (320 x 568)";
        public int Width => 320;
        public int Height => 568;
    }

    public class iPhon45 : IDisplayResolution
    {
        public string Id => "iphone 4";
        public string Name => "iPhone 4 (320 x 480)";
        public int Width => 320;
        public int Height => 480;
    }
}