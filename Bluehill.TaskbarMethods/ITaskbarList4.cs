using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

[ComImport]
[Guid("c43dc798-95d1-4bea-9030-bb99e2983a1a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITaskbarList4 : ITaskbarList3 {
    [PreserveSig]
    void SetTabProperties(IntPtr hwndTab, StpFlag stpFlags);
}
