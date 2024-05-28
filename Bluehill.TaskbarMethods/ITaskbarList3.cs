using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

[ComImport]
[Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ITaskbarList3 : ITaskbarList2 {
    // ITaskbarList
    new void HrInit();
    new void AddTab(IntPtr hwnd);
    new void DeleteTab(IntPtr hwnd);
    new void ActivateTab(IntPtr hwnd);
    new void SetActiveAlt(IntPtr hwnd);

    // ITaskbarList2
    new void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

    // ITaskbarList3
    void SetProgressValue(IntPtr hwnd, ulong ullCompleted, ulong ullTotal);
    void SetProgressState(IntPtr hwnd, TaskbarStates tbpFlags);
    void RegisterTab(IntPtr hwndTab, IntPtr hwndMDI);
    void UnregisterTab(IntPtr hwndTab);
    void SetTabOrder(IntPtr hwndTab, IntPtr hwndInsertBefore);
    void SetTabActive(IntPtr hwndTab, IntPtr hwndMDI, uint dwReserved = 0);
    void ThumbBarAddButtons(IntPtr hwnd, uint cButtons, [MarshalAs(UnmanagedType.LPArray)] THUMBBUTTON[] pButtons);
    void ThumbBarUpdateButtons(IntPtr hwnd, uint cButtons, [MarshalAs(UnmanagedType.LPArray)] THUMBBUTTON[] pButtons);
    void ThumbBarSetImageList(IntPtr hwnd, IntPtr himl);
    void SetOverlayIcon(IntPtr hwnd, IntPtr hIcon, [MarshalAs(UnmanagedType.LPWStr)] string pszDescription);
    void SetThumbnailTooltip(IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string pszTip);
    void SetThumbnailClip(IntPtr hwnd, in RECT prcClip);
}
