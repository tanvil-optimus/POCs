using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace AvigilonSDKPractice
{
    public partial class AddSite : Form
    {
        private VideoStreamer.VideoStreamer m_videoStreamer;
        private AvigilonDotNet.IAvigilonControlCenter m_controlCenter;

        public AddSite(AvigilonDotNet.IAvigilonControlCenter controlCenter)
        {
            m_videoStreamer = new VideoStreamer.VideoStreamer();
            m_controlCenter = controlCenter;

            InitializeComponent();
        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            string ip = txtIP.Text;

            //TODO : Check for validity of IP.

            //Hard Coded for time being.
            //This one is used by default for 
            var port = 38880;

            AvigilonDotNet.AvgError siteAdditonStatus = m_videoStreamer.AddSite(ref m_controlCenter, ip, port);
            
            if (siteAdditonStatus == AvigilonDotNet.AvgError.Success)
            {
                //Proceed further
                Thread.Sleep(10000);

                IPAddress ipAddress;
                IPAddress.TryParse(ip, out ipAddress);

                //Other overload that uses IP Address and Port can also be used.
                AvigilonDotNet.INvr nvr = m_videoStreamer.GetNvr(m_controlCenter, ipAddress);
             
                // Log in to the NVR
                //TODO : Add dynamic username and password.
                AvigilonDotNet.LoginResult loginResult = nvr.Login(txtUserName.Text, txtPassword.Text);

                if (loginResult == AvigilonDotNet.LoginResult.Successful)
                {
                    Thread.Sleep(10000);

                    //HardCoded to get the camera with logical Id 1.
                    //TODO : Give user option to enter logical ID of the camera and also explore other methods to fetch a particular camera.
                    AvigilonDotNet.IEntityCamera device = (AvigilonDotNet.IEntityCamera)nvr.GetEntityByLogicalId(1);
                    
                    VideoStream videoStream = new VideoStream(device, m_controlCenter);

                    videoStream.Show();

                    this.Hide();
                }
                else
                { 
                    //TODO : Show relevant message.
                }
            }
            else
            {
                //TODO : Display a relevant message.
            }
        }
    }
}
