using System;
using System.Threading;
using System.Windows.Forms;

namespace AvigilonSDKPractice
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void m_CreateInstance_Click(object sender, EventArgs e)
        {
            VideoStreamer.VideoStreamer videoStreamer = new VideoStreamer.VideoStreamer();

            bool isAutoDiscoverChecked = m_AutoDiscoverChecked.Checked;

            AvigilonDotNet.IAvigilonControlCenter controlCenter = videoStreamer.CreateInstance(isAutoDiscoverChecked);

            if (isAutoDiscoverChecked)
            {
                //Required since discovering sites take time. 
                Thread.Sleep(10000);
            }
            else
            {
                AddSite addSite = new AddSite(controlCenter);

                addSite.Show();

                this.Hide();
            }
        }
    }
}
