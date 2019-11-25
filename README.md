# herokuapp

Open the project in Visual Studio.  You will need to refresh/restore the Nuget packages in order to successfully compile this project.  To do this:
In Solution Explorer, right-click  the "herokuapp" solution and select "Restore Nuget packages"
To run the tests, compile and then run it (F5).

By default this test will run against Chrome.  If you want to use IE, edit the Configuration.cs file and change this:
public const BrowerTypes Browser = BrowerTypes.Chrome;
to:
public const BrowerTypes Browser = BrowerTypes.IE;

IMPORTANT NOTE if using IE:
Make sure the Protected Mode settings are not the same for all zones. Enable Protected Mode must be set to the same value (enabled or disabled) for all zones.
To do this:
Launch IE
Go to Tools/Internet Options
Go to the Security Tab
Set the "Enable Protected Mode" option to same value for all zones.
