using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public class YesNoStatusBox : StatusBox
    {
        public override DialogResult Show()
        {
            return MessageBox.Show(Message, Title, MessageBoxButtons.YesNo);
        }
    }
}
