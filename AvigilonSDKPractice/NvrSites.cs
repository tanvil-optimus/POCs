using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvigilonSDKPractice
{
    class NvrSites
    {
        private AvigilonDotNet.IAvigilonControlCenter m_controlCenter;

        public AvigilonDotNet.IAvigilonControlCenter ControlCenter
        {
            get;
            set
            {
                m_controlCenter = value;
                if (m_controlCenter != null)
                {
                    m_controlCenter.NvrListAdd += NvrListAddHandler_;

                    AddAllNvrs_();
                }
            }
        };
            

       
        private void AddAllNvrs_()
        {
            // Go through the list of Nvrs add any new Nvrs
            System.Collections.Generic.List<AvigilonDotNet.INvr> nvrs = m_controlCenter.Nvrs;

            foreach (AvigilonDotNet.INvr nvr in nvrs)
            {
                newNvrNode = new TreeNodeNvr(nvr);
                newNvrNode.DisplayEntity += OnDisplayEntity_;
                newNvrNode.ExportEntity += OnExportEntity_;
                newNvrNode.ImageQueryEntity += OnImageQueryEntity_;
                newNvrNode.BackupNvr += OnBackupNvr_;
                newNvrNode.RemoveNvr += OnRemoveNvr_;

                Nodes.Add(newNvrNode);
            }
        }

        /// <summary>
		/// Nvr list change event handler
		/// </summary>
		private void NvrListAddHandler_(System.String nvrUuid)
        {
			AvigilonDotNet.INvr nvr = m_controlCenter.GetNvr(nvrUuid);
			if (nvr != null &&
				Nodes.Find(TreeNodeNvr.ExtractNodeName(nvr), false).Length == 0)
			{
				// Does not already exist in the tree
				TreeNodeNvr newNvrNode = new TreeNodeNvr(nvr);
				newNvrNode.DisplayEntity += OnDisplayEntity_;
				newNvrNode.ExportEntity += OnExportEntity_;
				newNvrNode.ImageQueryEntity += OnImageQueryEntity_;
				newNvrNode.BackupNvr += OnBackupNvr_;
				newNvrNode.RemoveNvr += OnRemoveNvr_;

				Nodes.Add(newNvrNode);
			}
        }
    }
}
