using System.Collections.Generic;
using System.Web.Services;

namespace LearnASMX
{
    /// <summary>
    /// Summary description for CalulatorWebService
    /// </summary>
    // The namespace does its job of uniquely identifying a web service on the web
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)] // For Overloades, we need to set the Profile to None
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class CalulatorWebService : WebService // Not Mandatory! But needs to be inherited if app uses Application State or Sessions
    {
        #region Dependencies

        private List<string> _calulations;

        public CalulatorWebService()
        {
            _calulations = new List<string>();
        }

        #endregion

        // Similar to an API Endpoint
        [WebMethod(Description = "Just a Simple Hello World!")]
        public string HelloWorld() => "Hello World";
        
        // Web Methods can be overloaded however, they require the
        // MessageName attribute to be set. By default the MessageName
        // attribute equates to the name of the method.
        [WebMethod(MessageName = "HelloWorldWithName", Description = "Just a Simple Hello World!")]
        public string HelloWorld(string name) => $"Hello {name}!";

        [WebMethod(EnableSession = true, Description = "Adds two numbers.", CacheDuration = 30)]
        public decimal AddTwoNumber(decimal a, decimal b)
        {
            if (Session["CALULATIONS"] != null)
                _calulations = (List<string>)Session["CALULATIONS"];
            
            _calulations.Add($"{a:N2} + {b:N2} = {a + b:N2}");
            Session["CALULATIONS"] = _calulations;

            return a + b;
        }

        [WebMethod(EnableSession = true)]
        public decimal SubtractTwoNumber(decimal a, decimal b)
        {
            if (Session["CALULATIONS"] != null)
                _calulations = (List<string>)Session["CALULATIONS"];

            _calulations.Add($"{a:N2} - {b:N2} = {a - b:N2}");
            Session["CALULATIONS"] = _calulations;

            return a - b;
        }

        [WebMethod(EnableSession = true)]
        public decimal MultiplyTwoNumber(decimal a, decimal b)
        {
            if (Session["CALULATIONS"] != null)
                _calulations = (List<string>)Session["CALULATIONS"];
            
            _calulations.Add($"{a:N2} * {b:N2} = {a * b:N2}");
            Session["CALULATIONS"] = _calulations;
            
            return a * b;
        }

        [WebMethod(EnableSession = true)]
        public decimal DivideTwoNumber(decimal a, decimal b)
        {
            if (Session["CALULATIONS"] != null)
                _calulations = (List<string>)Session["CALULATIONS"];

            if (b == 0)
            {
                _calulations.Add($"Cannot Divide {a:N2} / {b:N2}");
                Session["CALULATIONS"] = _calulations;
                return 0;
            }
            else
            {
                _calulations.Add($"Cannot Divide {a:N2} / {b:N2}");
                Session["CALULATIONS"] = _calulations;
                return a / b;
            }
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalulations()
        {
            if (Session["CALULATIONS"] != null)
                return _calulations = (List<string>)Session["CALULATIONS"];
            else
            {
                _calulations.Add("No Operations we Carried Out!");
                Session["CALULATIONS"] = _calulations;
                return _calulations;
            }
        }
    }
}
