try
{
    /*string s = "qwdqd";
    int n = Convert.ToInt32(s);
    Console.WriteLine(n);*/

    int num = 1;
    if (num == 1)
    {
        // throw new exception
        Exception ex = new("num not be 1");
        ex.HelpLink = "https://google.com";
        throw ex;
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); // num not be 1
    Console.WriteLine(ex.HelpLink); // https://google.com

    /*Console.WriteLine(ex.Message);
    Console.WriteLine(ex.Data);
    Console.WriteLine(ex.HelpLink);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.ToString());
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.TargetSite);*/
}