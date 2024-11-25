/*
 * David Vega Lescano
 * CST-150
 * Activity 1
 * Date 24 NOV 2024
 * Citations(s) Here https://mygcuedu6961.sharepoint.com/:w:/r/sites/CSETGuides/_layouts/15/Doc.aspx?sourcedoc=%7BE00E2660-FE0A-417C-976C-8AC8600B9EC7%7D&file=CST-150-RS-T1-Activity1.docx&action=default&mobileredirect=true
 */


namespace HelloWorldFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Create an event handler for the click here button
        /// Method name must be PascalCasing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            lblHelloWorldLabel.Text = "Hello World!!!";
        }
    }
}
