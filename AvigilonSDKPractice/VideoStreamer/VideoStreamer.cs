
using System.Net;
namespace VideoStreamer
{
    public class VideoStreamer
    {
        private AvigilonDotNet.AvigilonSdk _avigilonSdk;

        public VideoStreamer()
        {
            _avigilonSdk = new AvigilonDotNet.AvigilonSdk();
        }

        public AvigilonDotNet.IAvigilonControlCenter CreateInstance(bool isAutoDiscoverChecked)
        {
            AvigilonDotNet.SdkInitParams initParams = new AvigilonDotNet.SdkInitParams(
                    AvigilonDotNet.AvigilonSdk.MajorVersion,
                    AvigilonDotNet.AvigilonSdk.MinorVersion);
            initParams.AutoDiscoverNvrs = isAutoDiscoverChecked;
            initParams.ServiceMode = false;

            return _avigilonSdk.CreateInstance(initParams);
        }

        public AvigilonDotNet.AvgError AddSite(ref AvigilonDotNet.IAvigilonControlCenter controlCenter, string ip, int port)
        {
            IPAddress ipAddress;
            IPAddress.TryParse(ip, out ipAddress);
            var ipEndPoint = new IPEndPoint(ipAddress, port);
            return controlCenter.AddNvr(ipEndPoint);
        }

        public AvigilonDotNet.INvr GetNvr(AvigilonDotNet.IAvigilonControlCenter controlCenter, IPAddress ip)
        {
            return controlCenter.GetNvr(ip);
        }
    }
}
