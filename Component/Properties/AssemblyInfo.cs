﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.EnterpriseServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Component")]
[assembly: AssemblyDescription("Component template")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("DomConsult Sp. z o.o.")]
[assembly: AssemblyProduct("Component")]
[assembly: AssemblyCopyright("Copyright ©  2021 All rights reserved")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e07b178d-34a8-4eeb-a569-f74d79de1f12")]

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
[assembly: AssemblyVersion("21.4.1.2")]
[assembly: AssemblyFileVersion("21.4.1.2")]
[assembly: ApplicationAccessControl(
        AccessChecksLevel = AccessChecksLevelOption.ApplicationComponent,
        Authentication = AuthenticationOption.Packet,
        ImpersonationLevel = ImpersonationLevelOption.Impersonate,
        Value = false)]
[assembly: ApplicationActivation(ActivationOption.Server)]
