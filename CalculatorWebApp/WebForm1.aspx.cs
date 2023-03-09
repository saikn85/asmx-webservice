using CalculatorWebApp.CalculatorService;
using System;
using System.Web.UI;

namespace CalculatorWebApp
{
    public partial class WebForm1 : Page
    {
        private readonly CalulatorWebServiceSoapClient client;

        public WebForm1()
        {
            client = new CalulatorWebServiceSoapClient();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string hello = client.HelloWorld();
            lblResult.Text = hello;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            decimal result = client.AddTwoNumber(Convert.ToDecimal(txtfirstNum.Text), Convert.ToDecimal(txtSecondNum.Text));
            lblResult.Text = result.ToString();

            gvCalculations.DataSource = client.GetCalulations();
            gvCalculations.DataBind();

            gvCalculations.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}