using System.Reflection;
using System.Resources;

//General information
[assembly: AssemblyTitle("AW SDK .NET WRAPPER")]
[assembly: AssemblyDescription("ActiveWorlds SDK .NET Wrapper")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug - x86 - .NET 2.0")]
#else
[assembly: AssemblyConfiguration("Release - x86 - .NET 2.0")]
#endif

[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("AW.NET")]
[assembly: AssemblyCopyright("Copyright ©2007 - 2010 Joshua R. Rodgers")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("0.2.10.85")]

//CLS compliance
[assembly: System.CLSCompliant(true)]

//Assembly signing
[assembly: AssemblyDelaySign(false)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]
