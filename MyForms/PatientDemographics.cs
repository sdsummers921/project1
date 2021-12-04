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
    public partial class PatientDemographics : Form
    {
        int myPatientID = -1;
        DataSet1 myDataSet = null;

        public PatientDemographics(DataSet1 dataSet, int patientID)
        {
            InitializeComponent();

            myDataSet = dataSet;
            myPatientID = patientID;

            SetupControls();

            CopyPatientRowToFields();
        }

        void CopyPatientRowToFields()
        {
            DataSet1.PatientsDTRow myPatientRow = myDataSet.PatientsDT[myPatientID];

            textBoxFirstName.Text = myPatientRow.FirstName;
            textBoxMiddleName.Text = myPatientRow.MiddleName;
            textBoxLastName.Text = myPatientRow.LastName;
            textBoxDOB.Text = myPatientRow.DateOfBirth;
            textBoxSSN.Text = myPatientRow.SSN;
            textBoxAddressStreet.Text = myPatientRow.AddressStreet;
            textBoxApt_POBox_Ste.Text = myPatientRow.Apt_POBox_Ste;
            textBoxAddressCity.Text= myPatientRow.AddressCity;
            listBoxState.SelectedIndex = myPatientRow.StateID;
            textBoxAddressZip.Text = myPatientRow.ZIP;
            textBoxPrimaryPhone.Text = myPatientRow.PhonePrimary;
            textBoxSecondaryPhone.Text = myPatientRow.PhoneSecondary;
            textBoxECFirstName.Text = myPatientRow.EmergencyFirstName;
            textBoxECLastName.Text = myPatientRow.EmergencyLastName;
            textBoxECPhone.Text = myPatientRow.EmergencyPhone;

            //  marital status

            listBoxMaritalStatus.SelectedIndex = myPatientRow.MartialStatusID_;

            //  gender

            radioButtonMale.Checked = myPatientRow.GenderID == 0;
            radioButtonFemale.Checked = myPatientRow.GenderID == 1;

            // primary phone type

            checkBoxPrimaryHome.Checked = myPatientRow.PhonePrimaryTypeID == 0;
            checkBoxPrimaryCell.Checked = myPatientRow.PhonePrimaryTypeID == 1;
            checkBoxPrimaryWork.Checked = myPatientRow.PhonePrimaryTypeID == 2;
            checkBoxPrimaryOther.Checked = myPatientRow.PhonePrimaryTypeID == 3;

            // secondary phone type

            checkBoxSecondaryHome.Checked = myPatientRow.PhoneSecondaryTypeID == 0;
            checkBoxSecondaryCell.Checked = myPatientRow.PhoneSecondaryTypeID == 1;
            checkBoxSecondaryWork.Checked = myPatientRow.PhoneSecondaryTypeID == 2;
            checkBoxSecondaryOther.Checked = myPatientRow.PhoneSecondaryTypeID == 3;

            // insurance

            radioButtonSelfPay.Checked = myPatientRow.PaymentTypeID == 0;
            radioButtonInsurance.Checked = myPatientRow.PaymentTypeID == 1;
            if (myPatientRow.PaymentTypeID == 1)
            {
                textBoxInsuranceCompany.Text = myPatientRow.InsuranceCompany;
                textBoxInsuranceSubscriber.Text = myPatientRow.InsuranceSubscriber;
                textBoxInsuranceSubscriberDOB.Text = myPatientRow.InsuranceSubscriberDOB;
                textBoxInsuranceMemberID.Text = myPatientRow.InsuranceMemberID;
                textBoxInsuranceGroupNumber.Text = myPatientRow.InsuranceGroupNumber;
                listBoxInsuranceRelation.SelectedIndex = myPatientRow.InsuranceRelationID;
            }
        }

        void SetupControls()
        {
            //  controlBoxMaritalStatus
            listBoxMaritalStatus.Items.Clear();
            listBoxMaritalStatus.BeginUpdate();
            for (int n = 0; n < myDataSet.MaritalStatusDT.Count; n++)
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientDemographics_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DataSet1.PatientsDTRow patientRow = myDataSet.PatientsDT[myPatientID];

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
    }
}
