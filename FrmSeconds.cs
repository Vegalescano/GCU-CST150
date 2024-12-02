/*
 * David Vega Lescano
 * CST-150
 * Activity 2
 * 1 December 2024
 * Citations https://mygcuedu6961.sharepoint.com/:w:/r/sites/CSETGuides/_layouts/15/Doc.aspx?sourcedoc=%7B6ECD78D9-CDB4-49CD-8E50-BCF7042858C5%7D&file=CST-150-RS-T2-Activity2.docx&action=default&mobileredirect=true
 */
namespace CST_150_Activity_2A
{
    public partial class FrmSeconds : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FrmSeconds()
        {
            InitializeComponent();
            // Make sure the label is not visible
            lblResults.Visible = false;
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResults_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Event Handler to Evaluate Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            // Declare and Initialize
            int seconds = 0;         // Declare the value user entered in seconds
            // Working with Constants in C#
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;
            // Define flags
            // Make sure the label is not visible
            lblResults.Visible = false;
            //Default the color to black
            lblResults.ForeColor = Color.Black;

            // Test to determine if integer was entered correctly by user
            // if try to parse string to int is successful continue else show message to user
            //If try to parse string to int is successfult continue else show message to user
            if (int.TryParse(txtUserEntry.Text, out seconds) )
            {
                // This block of code is where all our business logic will be placed.
                // In future classes we will put this code (business logic) in the business layer
                // Practice with nested if statements
                if (seconds >= SecondsInMinutes)
                {
                    // if we are here we know the user has entered a value that we can, at a minimun
                    // display how many minutes are in the seconds entered.
                    lblResults.Text = string.Format("There are {0:#,#} minute(s) in {1:#,#} seconds.\n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;

                    //_________________________________________________
                    // Now that we know there were minutes - test for hours
                    // using nested if statements
                    // Nested statements stops code from being executed is there is
                    // no need
                    //___________________________________________________
                    if (seconds >= SecondsInHours)
                    {
                        // Display how many hours are in the seconds entered.
                        lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds.\n", seconds / SecondsInHours, seconds);

                        //_______________________________________________
                        //Now that we know there were hours - test for days
                        // using nested if statements
                        //_______________________________________________
                        if (seconds >= SecondsInDays)
                        {
                            // Display how many days are in the seconds entered.
                            lblResults.Text += string.Format("There are {0:#,#} days in {1:#,#} seconds.\n", seconds / SecondsInDays, seconds);

                        }
                        else
                        {
                            // if we are here we know the user did not enter a value that meets the minimun
                            //requirements of at least 60
                            //Ask the user to enter a valid number

                            // This is the code block that be executed if the user did not put an int in
                            lblResults.Text = "Please enter an integer larger than 59.";
                            lblResults.ForeColor = Color.Red;
                            lblResults.Visible = true;
                        }
                    }
            } else
        }
}
        
