#AutoPoco.Extensions

Additional conventions and data sources for AutoPoco.

##Download

The AutoPoco Extensions library is available on nuget.org via package name `AutoPoco.Extensions`.

To install AutoPoco.Extensions, run the following command in the Package Manager Console

    PM> Install-Package AutoPoco.Extensions
    
More information about NuGet package avaliable at
https://nuget.org/packages/AutoPoco.Extensions

##Development Builds

Development builds are available on the myget.org feed.  A development build is promoted to the main NuGet feed when it's determined to be stable. 

In your Package Manager settings add the following package source for development builds:
http://www.myget.org/F/loresoft/

##Usage

    var factory = AutoPocoContainer.Configure(x =>
    {
        x.Conventions(c =>
        {
            c.UseExtendedConventions();
            c.UseDefaultConventions();
        });
        x.AddFromAssemblyContainingType<SampleData>();
    });

    var session = factory.CreateSession();

    var sampleData = session.Single<SampleData>().Get();
