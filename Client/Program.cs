using System.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var c1 = new WS1.WsRequest()
        {
            Id = "",
            Name = "",
            Password = "" //這樣一樣無法過弱掃
        };

        var s = new SecureString();
        s.AppendChar('P');
        s.AppendChar('a');
        s.AppendChar('s');
        s.AppendChar('s');

        var c2 = new WS2.WsRequest()
        {
            Id = "",
            Name = "",
            //Password = new SecureString(), //無法接受System.Security的SecureString
            Password = new WS2.SecureString(),
        };
        //c2.Password = s; //無法接受System.Security的SecureString
        //c2.AppendChar('P'); //也沒有AppendChar可以塞變數

    }
}