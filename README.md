# Project Description

The ActiveWorlds SDK .NET Wrapper is a wrapper for the ActiveWorlds SDK written in C# using DllImport attributes to import all methods from the SDK. It exposes these methods through an object oriented interface more familiar to .NET programmers.


This project exists to help users of the ActiveWorlds SDK utilize the SDK from any .NET language. On-going are efforts being made to optimize and automate the build process as much as possible and to allow users the greatest flexibility with all .NET languages.


The project itself is targeted at the .NET Framework 2.0, but some tools require newer versions. It is recommended that you compile this project using Visual Studio 2010 or newer, however the compiled wrapper itself will work with Visual Studio 2005. This project remains untested with Mono and has the potential to break any existing compatibility with Mono at any point in the future. However, if you get it working with Mono under Linux, let me know!

Portions of this project depend on external libraries including the following:
* ActiveWorlds SDK - http://www.activeworlds.com/sdk/ - Required by AW.Core.dll at run-time.


### Related Sites

* ActiveWorlds Managed .NET SDK - http://awmanaged.codeplex.com/ - Abstraction layer built over the top of the ActiveWorlds .NET SDK Wrapper
* ActiveWorlds C SDK Documentation - http://wiki.activeworlds.com/index.php?title=SDK - Documentation on the C library that the wrapper is based on, very useful information on general SDK concepts.


### Distribution Note

This wrapper is not distributed with the ActiveWorlds SDK. You will need to download and provide your own copy of aw.dll to go along with the version of the AW SDK that the wrapper is built against (current build is 85).


### Special Usage Note

Since the ActiveWorlds SDK is compiled as a 32-bit DLL, the platform target for this assembly is also 32-bit (to ensure it works correctly with the 32-bit DLL on 64-bit platforms). This also means that you MUST target 32-bit platforms with any application you develop using this wrapper, if you wish for it to work correctly on a 64-bit platform. Targeting a 32-bit platform will causes .NET to use WOW64 to properly execute your application and use the 32-bit ActiveWorlds SDK.


Unfortunately the Express editions of Visual Studio do not support platform targets, and any application produced with these versions will not run properly on a 64-bit platform.


If you are using a non-Express edition of Visual Studio you can follow these steps to target your application at 32-bit platforms and ensure it will run properly everywhere:
* Right click your project in Solution Explorer and select "Properties"
* Select the "Build" tab from the solution properties window
* Find the "Platform Target" drop-down box
* Use the drop-down box to select "x86"
* Save your project
At this point you may recompile your application and it will work as normal, but this will ensure it will work everywhere and not throw any exceptions related to the platform it is being run on.


Community members of the ActiveWorlds Universe have requested a 64-bit version of the ActiveWorlds SDK, but have not heard any news in regards to this request. If a 64-bit version does become available, it will become possible to run applications compiled with the wrapper as native 64-bit applications, without having to select any platform targets. This will also alleviate issues that Express Edition users have in regards to this issue.
