using CalculatorWebApp.CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
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
        }
    }
}