using System.Security;
using System.Web.Services;

/// <summary>
/// TestWebService_1 的摘要描述
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
// [System.Web.Script.Services.ScriptService]
public class TestWebService_1 : System.Web.Services.WebService
{

    public TestWebService_1()
    {

        //如果使用設計的元件，請取消註解下列一行
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld(WsRequest wsRequest)
    {
        return "Hello World";
    }

    public class WsRequest
    {
        private SecureString _password;
        public string Name;
        public string Id;
        public string Password
        {
            get
            {
                return _password.ToText();
            }
            set
            {
                _password = value.ToSecureString();
            }
        }
    }
}
