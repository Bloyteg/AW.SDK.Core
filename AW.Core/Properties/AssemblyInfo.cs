// // (c) 2007 - 2011 Joshua R. Rodgers under the terms of the Ms-PL license.
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

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
[assembly: AssemblyCopyright("Copyright �2007 - 2011 Joshua R. Rodgers")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: AssemblyVersion("0.3.12.100")]

//CLS compliance
[assembly: CLSCompliant(true)]

//Assembly signing
[assembly: AssemblyDelaySign(false)]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

[assembly: ComVisible(false)]
