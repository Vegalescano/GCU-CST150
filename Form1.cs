/*
 * David Vega Lescano
 * CST-150
 * Activity 1
 * 24 NOV 2024
 * Citations(s) Here https://mygcuedu6961.sharepoint.com/:w:/r/sites/CSETGuides/_layouts/15/Doc.aspx?sourcedoc=%7BE00E2660-FE0A-417C-976C-8AC8600B9EC7%7D&file=CST-150-RS-T1-Activity1.docx&action=default&mobileredirect=true
 */


namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Hide the Weight on Mars labels
            lblMars.Visible = false;
            lblMarsWeight.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Click Event for Convert Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            // Declare and Initialize
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.81M;
            decimal gravAccMars = 3.711M;

            // Read in the earth weight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            // Calculate the final value
            finalValue = (earthWeight /  gravAccEarth) * gravAccMars;

            // Display the results
            // Use string.formt to format the string and show on;y 2 decimal places.
            // This is a string argument
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            // Make sure to show hte mars value and label
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;
        }
    }
}
