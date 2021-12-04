using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.MyForms
{
    public partial class PatientSearchForm : Form
    {
        DataSet1 myDataSet = null;
        DataView myDataView = null;

        public PatientSearchForm(DataSet1 dataSet)
        {
            InitializeComponent();

            myDataSet = dataSet;
            myDataView = new DataView(myDataSet.PatientsDT);
            UpdateDataGridView();

            Shown += PatientSearchForm_Shown;
        }

        private void PatientSearchForm_Shown(Object sender, EventArgs e)
        {
            // Make sure patients are available for search
            int numPatients = myDataSet.PatientsDT.Count;
            if (numPatients == 0)
            {
                StatusBox sb = new StatusBox();
                sb.Message = "No patients in database for search.";
                sb.Show();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  search for patients that match name, dob, ssn 

            string myRowFilter = "(FirstName LIKE '" + GetFirstName() + "*')";
            myRowFilter += " AND (LastName LIKE '" + GetLastName() + "*')";
            myRowFilter += " AND (DateOfBirth LIKE '" + textBoxDOB.Text + "*')";
            myRowFilter += " AND (SSN LIKE '" + textBoxSSN.Text + "*')";

            myDataView.RowFilter = myRowFilter;

            if (myDataView.Count == 0)
            {
                StatusBox sb = new StatusBox();
                sb.Message = "No patients found with the specified information.";
                sb.Show();
            }
            else
            {
            }
        }

        void UpdateDataGridView()
        {
            dataGridView1.DataSource = myDataView;

            //  hide columns we don't want to show
            for (int n = 0; n < dataGridView1.Columns.Count; n++)
            {
                if (dataGridView1.Columns[n].Name != "FirstName" &&
                    dataGridView1.Columns[n].Name != "LastName" &&
                    dataGridView1.Columns[n].Name != "DateOfBirth" &&
                    dataGridView1.Columns[n].Name != "SSN")
                {
                    dataGridView1.Columns[n].Visible = false;
                }
            }
        }

        string GetFirstName()
        {
            string firstName = "";

            string s = this.textBoxPatientName.Text;
            string[] sa = s.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            try
            {
                firstName = sa[1];
            }
            catch
            {

            }
            return firstName;
        }

        string GetLastName()
        {
            string lastName = "";

            string s = this.textBoxPatientName.Text;
            string[] sa = s.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            try
            {
                lastName = sa[0];
            }
            catch
            {

            }
            return lastName;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //  row selected

            if (dataGridView1.SelectedRows.Count < 1)
            {
                return;
            }

            int myPatientID = (int)dataGridView1.SelectedRows[0].Cells[0].Value ;


            using (PatientDemographics form = new PatientDemographics(myDataSet, myPatientID))
            {
                form.Owner = this;
                if (form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
