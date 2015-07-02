using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CMTools.AOP.StatsDMetrics.Aspects;
using PostSharp.Extensibility;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("PostSharpBug")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("PostSharpBug")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b7ff4ddd-aad4-430a-a18d-7e7d37bd8fda")]

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

//-----------repro instructions------------
// build project as it currently stands. Open exe in decompiler of choice.
//      ** note that the properties in the UserLoggedOnEvent class have the aspect attached to them
// uncomment line with AspectPriority = 19, recompile and check in the decompiler
//      ** note that the properties in the UserLoggedOnEvent class no longer have the aspect attached to them
//      ?? Why does adding this exclude make the previous exclude work now?
//



//[assembly: MetricsAspect(AspectPriority = 19, AttributeExclude = true, AttributeTargetMembers = ".ctor", ApplyToStateMachine = false)]
[assembly: MetricsAspect(AspectPriority = 20, AttributeExclude = true, AttributeTargetMembers = "regex:^get_|^set_", ApplyToStateMachine = false)]
[assembly: MetricsAspect(AspectPriority = 1, AttributeTargetMemberAttributes = MulticastAttributes.Instance, ApplyToStateMachine = false)]