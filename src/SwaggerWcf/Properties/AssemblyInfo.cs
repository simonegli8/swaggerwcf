using System;
using System.Reflection;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]
[assembly: Guid("d2eeaa63-60e5-4fda-8b62-e05dc8be8b5f")]
//DONT ADD: [assembly: AssemblyFileVersion] !!!