using PatientManagement.MyForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class MainForm : Form
    {
        DataSet1 myDataSet = new DataSet1();

        public MainForm()
        {
            InitializeComponent();

            Shown += MainForm_Shown;
        }

        private void MainForm_Shown(Object sender, EventArgs e)
        {
            RunLogIn();
        }

        void RunLogIn()
        {
            //  Log in or exit
            using (LogInForm form = new LogInForm())
            {
                form.Owner = this;
                if (form.ShowDialog() != DialogResult.OK)
                {
                    StatusBox sb = new StatusBox();
                    sb.Message = "Log In Unsuccessful. Goodbye.";
                    sb.Show();
                    Close();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            string filePath = System.IO.Path.Combine(dir, "DataSet.xml");

            try
            {
                DataSet1 temp = new DataSet1();
                temp.ReadXml(filePath);
                if (temp != null)
                {
                    myDataSet = temp;
                }
            }
            catch
            {
                //MessageBox.Show("Could not load data file.", "Attention!");
            }

            if (myDataSet.GenderDT.Count != 2 ||
                myDataSet.MaritalStatusDT.Count != 5 ||
                myDataSet.StateDT.Count != 50 ||
                myDataSet.PhoneTypeDT.Count != 4 ||
                myDataSet.PaymentTypeDT.Count != 2 ||
                myDataSet.InsuranceRelationDT.Count != 8)
            {
                StatusBox sb = new StatusBox();
                sb.Message = "Could not load data file.  Creating new.";
                sb.Show();
                InitializeDataSet(myDataSet);
            }

        }
         
        void InitializeDataSet(DataSet1 dataSet)
        {
            //  initialize the tables of the data set

            //  GenderDT
            DataSet1.GenderDTRow gRow = myDataSet.GenderDT.NewGenderDTRow();
            gRow.Gender = "Male";
            myDataSet.GenderDT.AddGenderDTRow(gRow);

            gRow = myDataSet.GenderDT.NewGenderDTRow();
            gRow.Gender = "Female";
            myDataSet.GenderDT.AddGenderDTRow(gRow);

            //  MaritalStatusDT
            DataSet1.MaritalStatusDTRow msRow = myDataSet.MaritalStatusDT.NewMaritalStatusDTRow();
            msRow.MartialStatus = "Single";
            myDataSet.MaritalStatusDT.AddMaritalStatusDTRow(msRow);

            msRow = myDataSet.MaritalStatusDT.NewMaritalStatusDTRow();
            msRow.MartialStatus = "Married";
            myDataSet.MaritalStatusDT.AddMaritalStatusDTRow(msRow);

            msRow = myDataSet.MaritalStatusDT.NewMaritalStatusDTRow();
            msRow.MartialStatus = "Divorced";
            myDataSet.MaritalStatusDT.AddMaritalStatusDTRow(msRow);

            msRow = myDataSet.MaritalStatusDT.NewMaritalStatusDTRow();
            msRow.MartialStatus = "Widowed";
            myDataSet.MaritalStatusDT.AddMaritalStatusDTRow(msRow);

            msRow = myDataSet.MaritalStatusDT.NewMaritalStatusDTRow();
            msRow.MartialStatus = "Separated";
            myDataSet.MaritalStatusDT.AddMaritalStatusDTRow(msRow);

            // StateDT
            DataSet1.StateDTRow sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "AL";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "AK";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "AZ";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "AR";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "CA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "CO";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "CT";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "DE";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "FL";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "GA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "HI";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "ID";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "IL";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "IN";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "IA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "KS";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "KY";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "LA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "ME";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "MD";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "MA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "MI";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "MN";
            myDataSet.StateDT.AddStateDTRow(sRow); 
            
            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "MS";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "MO";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "MT";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "NE";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "NV";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "NH";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "NJ";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "NM";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "NY";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "NC";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "ND";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "OH";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "OK";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "OR";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "PA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "RI";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "SC";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "SD";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "TN";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "TX";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "UT";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "VT";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "VA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "WA";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "WV";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "WI";
            myDataSet.StateDT.AddStateDTRow(sRow);

            sRow = myDataSet.StateDT.NewStateDTRow();
            sRow.State = "WY";
            myDataSet.StateDT.AddStateDTRow(sRow);

            // PhoneTypeDT
            DataSet1.PhoneTypeDTRow phtRow = myDataSet.PhoneTypeDT.NewPhoneTypeDTRow();
            phtRow.PhoneType = "Home";
            myDataSet.PhoneTypeDT.AddPhoneTypeDTRow(phtRow);

            phtRow = myDataSet.PhoneTypeDT.NewPhoneTypeDTRow();
            phtRow.PhoneType = "Cell";
            myDataSet.PhoneTypeDT.AddPhoneTypeDTRow(phtRow);

            phtRow = myDataSet.PhoneTypeDT.NewPhoneTypeDTRow();
            phtRow.PhoneType = "Work";
            myDataSet.PhoneTypeDT.AddPhoneTypeDTRow(phtRow);

            phtRow = myDataSet.PhoneTypeDT.NewPhoneTypeDTRow();
            phtRow.PhoneType = "Other";
            myDataSet.PhoneTypeDT.AddPhoneTypeDTRow(phtRow);

            // PaymentTypeDT
            DataSet1.PaymentTypeDTRow patRow = myDataSet.PaymentTypeDT.NewPaymentTypeDTRow();
            patRow.PaymentType = "Self Pay";
            myDataSet.PaymentTypeDT.AddPaymentTypeDTRow(patRow);

            patRow = myDataSet.PaymentTypeDT.NewPaymentTypeDTRow();
            patRow.PaymentType = "Insurance";
            myDataSet.PaymentTypeDT.AddPaymentTypeDTRow(patRow);

            //InsuranceRelationDT
            DataSet1.InsuranceRelationDTRow iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Self";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

            iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Spouse";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

            iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Mother";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

            iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Father";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

            iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Parent";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

            iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Grandmother";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

            iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Grandfather";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

            iRow = myDataSet.InsuranceRelationDT.NewInsuranceRelationDTRow();
            iRow.InsuranceRelation = "Other";
            myDataSet.InsuranceRelationDT.AddInsuranceRelationDTRow(iRow);

        }
        private void buttonSwitchUserLogOut_Click(object sender, EventArgs e)
        {
            //  Log in or exit
            using (LogInForm form = new LogInForm())
            {
                form.Owner = this;
                if (form.ShowDialog() != DialogResult.OK)
                {
                    StatusBox sb = new StatusBox();
                    sb.Message = "Log in Unsuccessful. Goodbye.";
                    sb.Show();
                    Close();
                }
            }
        }

        private void buttonSearchForPatient_Click(object sender, EventArgs e)
        {
            using(PatientSearchForm form = new PatientSearchForm(myDataSet))
            {
                form.Owner = this;
                if (form.ShowDialog() == DialogResult.OK)
                {
//                    MessageBox.Show("Return from Patient Search");

                }
            }
        }

        private void buttonCreateNewPatient_Click(object sender, EventArgs e)
        {
            using (CreatePatientForm form = new CreatePatientForm(myDataSet))
            {
                form.Owner = this;
                if (form.ShowDialog() == DialogResult.OK)
                {
//                    MessageBox.Show("Return from Create Patient");
                }
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string dir = Application.StartupPath;
            string filePath = System.IO.Path.Combine(dir, "DataSet.xml");

            myDataSet.WriteXml(filePath);
        }
    }
}
