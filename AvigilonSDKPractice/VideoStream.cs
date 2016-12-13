using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvigilonSDKPractice
{
    public partial class VideoStream : Form
    {
        private AvigilonDotNet.IEntityCamera m_device;
        private AvigilonDotNet.IAvigilonControlCenter m_controlCenter;
        private AvigilonDotNet.IStreamGroup m_streamGroup;
        private AvigilonDotNet.IStreamWindow m_streamWindow;

        public VideoStream(AvigilonDotNet.IEntityCamera device, AvigilonDotNet.IAvigilonControlCenter controlCenter)
        {
            m_device = device;
            m_controlCenter = controlCenter;
            InitializeComponent();

            Run();
        }

        /// <summary>
        /// Function to get the windows stream on Image panel.
        /// </summary>
        public void Run()
        {
            m_streamGroup = m_controlCenter.CreateStreamGroup(AvigilonDotNet.PlaybackMode.Live);
            AvigilonDotNet.ImagePanel m_imagePanel = new AvigilonDotNet.ImagePanel();
            m_imagePanel.Size = new System.Drawing.Size(1000,1000);

            if (m_streamGroup != null)
            {
                 m_controlCenter.CreateStreamWindow(
                     m_device,
                     m_streamGroup,
                     out m_streamWindow);
            }

            m_streamWindow.Enable = true;

            m_imagePanel.StreamWindow =  m_streamWindow;

            Controls.Add(m_imagePanel);
        }
    }
}
