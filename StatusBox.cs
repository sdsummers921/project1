using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public class StatusBox
    {
        public string Message { get; set; }

        string title = "Attention!";
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }


        public virtual DialogResult Show()
        {
            MessageBox.Show(Message, Title);
            return DialogResult.OK;
        }
    }
}
