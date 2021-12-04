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

    public partial class CreatePatientForm : Form
    {
        DataSet1 myDataSet = null;

        public CreatePatientForm(DataSet1 dataSet)
        {
            myDataSet = dataSet;

            InitializeComponent();

            SetupControls();
        }

        void SetupControls()
        {
            //  controlBoxMaritalStatus
            listBoxMaritalStatus.Items.Clear();
            listBoxMaritalStatus.BeginUpdate();
            for (int n=0; n<myDataSet.MaritalStatusDT.Count; n++)
            {
                DataSet1.MaritalStatusDTRow row = myDataSet.MaritalStatusDT.Rows[n] as DataSet1.MaritalStatusDTRow;
                listBoxMaritalStatus.Items.Add(new MyData(row.MartialStatus, row.MartialStatusID));
            }
            listBoxMaritalStatus.SelectedIndex = 0;
            listBoxMaritalStatus.EndUpdate();

            //  listBoxState
            listBoxState.Items.Clear();
            listBoxState.BeginUpdate();
            for (int n = 0; n < myDataSet.StateDT.Count; n++)
            {
                DataSet1.StateDTRow row = myDataSet.StateDT.Rows[n] as DataSet1.StateDTRow;
                listBoxState.Items.Add(new MyData(row.State, row.StateID));
            }
            listBoxState.SelectedIndex = 0;
            listBoxState.EndUpdate();

            //  listBoxInsuranceRelation
            listBoxInsuranceRelation.Items.Clear();
            listBoxInsuranceRelation.BeginUpdate();
            for (int n = 0; n < myDataSet.InsuranceRelationDT.Count; n++)
            {
                DataSet1.InsuranceRelationDTRow row = myDataSet.InsuranceRelationDT.Rows[n] as DataSet1.InsuranceRelationDTRow;
                listBoxInsuranceRelation.Items.Add(new MyData(row.InsuranceRelation, row.InsuranceRelationID));
            }
            listBoxInsuranceRelation.SelectedIndex = 0;
            listBoxInsuranceRelation.EndUpdate();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            YesNoStatusBox sb = new YesNoStatusBox();
            sb.Message = "Are you sure you want to exit? Any unsaved changes will be lost.";

            if (sb.Show() == DialogResult.Yes)
            {
                Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataSet1.PatientsDTRow patientRow = myDataSet.PatientsDT.NewPatientsDTRow();

            //  fill the fields

            patientRow.FirstName = textBoxFirstName.Text;
            patientRow.MiddleName = textBoxMiddleName.Text;
            patientRow.LastName = textBoxLastName.Text;
            patientRow.DateOfBirth = textBoxDOB.Text;
            patientRow.SSN = textBoxSSN.Text;
            patientRow.AddressStreet = textBoxAddressStreet.Text;
            patientRow.Apt_POBox_Ste = textBoxApt_POBox_Ste.Text;
            patientRow.AddressCity = textBoxAddressCity.Text;
            patientRow.StateID = (listBoxState.SelectedItem as MyData).myTag; 
            patientRow.ZIP = textBoxAddressZip.Text;
            patientRow.PhonePrimary = textBoxPrimaryPhone.Text;
            patientRow.PhoneSecondary = textBoxSecondaryPhone.Text;
            patientRow.EmergencyFirstName = textBoxECFirstName.Text;
            patientRow.EmergencyLastName = textBoxECLastName.Text;
            patientRow.EmergencyPhone = textBoxECPhone.Text;

            //  material status

            patientRow.MartialStatusID_ = (listBoxMaritalStatus.SelectedItem as MyData).myTag;

            //  gender

            patientRow.GenderID = radioButtonMale.Checked ? 0 : 1;

            // primary phone type

            int n = -1;
            if (checkBoxPrimaryHome.Checked) n = 0;
            if (checkBoxPrimaryCell.Checked) n = 1;
            if (checkBoxPrimaryWork.Checked) n = 2;
            if (checkBoxPrimaryOther.Checked) n = 3;

            patientRow.PhonePrimaryTypeID = n;

            // secondary phone type

            n = -1;
            if (checkBoxSecondaryHome.Checked) n = 0;
            if (checkBoxSecondaryCell.Checked) n = 1;
            if (checkBoxSecondaryWork.Checked) n = 2;
            if (checkBoxSecondaryOther.Checked) n = 3;

            patientRow.PhoneSecondaryTypeID = n;

            // insurance

            patientRow.PaymentTypeID = radioButtonSelfPay.Checked ? 0 : 1;
            if (patientRow.PaymentTypeID == 1)
            {
                patientRow.InsuranceCompany = textBoxInsuranceCompany.Text;
                patientRow.InsuranceSubscriber = textBoxInsuranceSubscriber.Text;
                patientRow.InsuranceSubscriberDOB = textBoxInsuranceSubscriberDOB.Text;
                patientRow.InsuranceMemberID = textBoxInsuranceMemberID.Text;
                patientRow.InsuranceGroupNumber = textBoxInsuranceGroupNumber.Text;
                patientRow.InsuranceRelationID = (listBoxInsuranceRelation.SelectedItem as MyData).myTag;
            } 

            //  finally add to table
            myDataSet.PatientsDT.AddPatientsDTRow(patientRow);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
