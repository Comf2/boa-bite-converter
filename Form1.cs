using System.Globalization;

namespace CS_REG_ContestantNumber
{
    public partial class frmDataStorageConversion : Form
    {
        public frmDataStorageConversion()
        {
            InitializeComponent();
        }

        //all bit values relative to a single byte
        private double Byte = 1;
        private double kilobit  = 125;
        private double megabit = 125000;
        private double gigabit = 125000000;
        private double terabit = 125000000000;
        //on convert it will validate all user inputs, returning the user the converted
        //value
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //checks if there if the user has entered everything into the form,
            //gives them an error if not 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var convFromRdo = grpConvFrom.Controls.OfType<RadioButton>()
                              .FirstOrDefault(rdoFrom => rdoFrom.Checked);
                var convToRdo = grpConvTo.Controls.OfType<RadioButton>()
                           .FirstOrDefault(rdoTo => rdoTo.Checked);
                try
                {
                    //gets the values were converting from
                    string convFromVal = convFromRdo.Text;
                    string convToVal = convToRdo.Text;


                    double finalVal = convertFinalVal(convFromVal, convToVal);
                    decimal finalValue = decimal.Round((decimal)finalVal, 15);
                    txtFinalVal.Text = finalValue.ToString("F99").TrimEnd('0');
                    System.Diagnostics.Debug.WriteLine(finalVal);

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private double convertFinalVal(string convFrom, string convTo)
        {
            //if both rdos are the same value, no math is needed to be done
            //meaning I can return safely with just the txt value
            if (convFrom == convTo) return double.Parse(txtConvertVal.Text);

            double convertVal = double.Parse(txtConvertVal.Text);
            //convert value to bytes so to have a consistant form to do math on
            double byteVal = ConvToBytes(convFrom);

            double finalVal = byteToFinal(byteVal, convTo);
            
            return finalVal;
        }
        private double ConvToBytes(string bitVal)
        {
            double convertVal = double.Parse(txtConvertVal.Text);

            double finalVal = 0 ;
            switch(bitVal)
            {
                case "Byte": 
                    finalVal = convertVal; 
                    break;
                case "Kilobit":
                    finalVal = convertVal * kilobit;
                    break; 
                case "Megabit":
                    finalVal = convertVal * megabit;
                    break;
                case "Gigabit":
                    finalVal = convertVal * gigabit;
                    break;
                case "Terabit":
                    finalVal = convertVal * terabit;
                    break;
            }

            return finalVal;
        }
        private double byteToFinal(double byteVal, string convTo)
        {
            double finalVal = 0 ;
               
            switch(convTo)
            {
                case "Byte":
                    finalVal = byteVal;
                    break;
                case "Kilobit":
                    finalVal = byteVal / kilobit;
                    break;
                case "Megabit":
                    finalVal = byteVal / megabit;
                    break;
                case "Gigabit":
                    finalVal = byteVal / gigabit;
                    break;
                case "Terabit":
                    finalVal = byteVal / terabit;
                    break;
            }

            return finalVal;
        }
        //validates the textbox by checking if the text is empty, and showing an error provider if not

        private void txtConvertVal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConvertVal.Text))
            {
                e.Cancel = true;
                txtConvertVal.Focus();
                errConvertVal.SetError(txtConvertVal, "Amount should not be left blank!");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtConvertVal.Text, "[^0-9]")) {
                e.Cancel = true;
                txtConvertVal.Focus();
                errConvertVal.SetError(txtConvertVal, "Should only contain numbers");
            }
            else
            {
                e.Cancel = false;
                errConvertVal.SetError(txtConvertVal, "");
            }
        }
    }
}