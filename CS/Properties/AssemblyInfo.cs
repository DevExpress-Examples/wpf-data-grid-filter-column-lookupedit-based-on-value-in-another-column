// Developer Express Code Central Example:
// How to filter a LookUpEdit in one column based on the value of another column
// 
// This example illustrates how to filter LookUpEdit item source values in one
// column based on the value of another column. This functionality can be
// implemented only when a filtered LookUpEdit is introduced using a cell template.
// In this case, every cell has an independent LookUpEdit editor, and we can
// manipulate its item source. The item source is filtered in the
// TableView.ShownEditor event handler. This event is raised when a cell gets
// focus, and its editor becomes active, so it is the best place to filter the item
// source.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3826

using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WPFDataGridApp13")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("WPFDataGridApp13")]
[assembly: AssemblyCopyright("Copyright ©  2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly: ThemeInfo(
	ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
	//(used if a resource is not found in the page, 
	// or application resource dictionaries)
	ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
	//(used if a resource is not found in the page, 
	// app, or any theme specific resource dictionaries)
)]


// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
