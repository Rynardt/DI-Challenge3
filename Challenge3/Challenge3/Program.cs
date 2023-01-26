using Xunit;

public class TestsPart1 : TestBase
{
    [Fact]
    public void Given_When_Then()
    {
        //Properties of Startup and Testbase are used here
    }
}

public class TestsPart2 : ScriptsBase
{
    [Fact]
    public void Given_When_Then()
    {
        //Properties of Startup, ScriptsBase and Testbase are used here
    }
}

public class TestBase : StartUp
{
    //Properties of Startup is accessed in this base class
}

public class ScriptsBase : TestBase
{
    //Properties of TestBase are accessed here
}

public class JSonConfigModel
{
    //Add your properties from your Json config here
    public JSonConfigModel() 
    { 
        //This is where the properties gets the values
    }
}

public class StartUp
{
    public JSonConfigModel model { get; set; }
    
    public StartUp() 
    {
        model = new JSonConfigModel();
    }
}