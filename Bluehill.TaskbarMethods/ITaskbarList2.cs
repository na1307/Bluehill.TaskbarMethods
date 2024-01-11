using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

[ComImport]
[Guid("602D4995-B13A-429b-A66E-1935E44F4317")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITaskbarList2 {
    // ITaskbarList
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

    // ITaskbarList2
    [PreserveSig]
    void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);
}
