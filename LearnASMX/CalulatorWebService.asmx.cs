using System.Web.Services;

namespace LearnASMX
{
    /// <summary>
    /// Summary description for CalulatorWebService
    /// </summary>
    // The namespace does its job of uniquely identifying a web service on the web
    [WebService(Namespace = "http://tempuri.org/")] 
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class CalulatorWebService : WebService // Not Mandatory! But needs to be inherited if app uses Application State or Sessions
    {
        // Similar to an API Endpoint
        [WebMethod]
        public string HelloWorld() => "Hello World";

        [WebMethod]
        public decimal AddTwoNumber(decimal a, decimal b) => a + b;
    }
}
