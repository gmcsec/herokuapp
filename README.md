# herokuapp

Open the project in Visual Studio.  You will need to refresh/restore the Nuget packages in order to successfully compile this project.  If using Visual Studio you can do this:
In Solution Explorer, right-click  the "herokuapp" solution and select "Restore Nuget packages"
To run the tests, compile and then run it (F5).

By default this test will run against Chrome.  If you want to use IE, edit the Configuration.cs file and change this:
public const BrowerTypes Browser = BrowerTypes.Chrome;
to:
public const BrowerTypes Browser = BrowerTypes.IE;

IMPORTANT NOTE: If using IE you will likely need to update IE settings/registry key for successful operation.  Please see this link for details:
https://github.com/SeleniumHQ/selenium/wiki/InternetExplorerDriver#required-configuration

Alternate method to run is to compile the project and run the herokuapp.exe app directly from a folder on your hard drive.  This folder will need to contain the following files:
herokuapp.exe
herokuapp.dll
Newtonsoft.Json.dll
SeleniumExtras.WaitHelpers.dll
WebDriver.dll
WebDriver.Support.dll
herokuapp.deps.json
herokuapp.runtimeconfig.dev.json
herokuapp.runtimeconfig.json

Plus one or more of the following depending on what browser you want to use:
chromedriver.exe (this is default)
IEDriverServer.exe
