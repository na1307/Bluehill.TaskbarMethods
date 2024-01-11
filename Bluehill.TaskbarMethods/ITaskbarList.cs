using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

[ComImport]
[Guid("56FDF342-FD6D-11d0-958A-006097C9A090")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITaskbarList {
    [PreserveSig]
    void HrInit();
    [PreserveSig]
    void AddTab(IntPtr hwnd);
    [PreserveSig]
    void DeleteTab(IntPtr hwnd);
    [PreserveSig]
    void ActivateTab(IntPtr hwnd);
    [PreserveSig]
    void SetActiveAlt(IntPtr hwnd);
}
