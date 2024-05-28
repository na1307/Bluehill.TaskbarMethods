namespace Bluehill.TaskbarMethods;

/// <summary>
/// Includes taskbar methods supported starting from Windows 7.
/// </summary>
public class Win7TaskbarMethods : WinXPTaskbarMethods {
    private static ITaskbarList4? taskbarList4 = null;
    private static readonly bool win7orGreater = Environment.OSVersion.Version >= new Version(6, 1);

    private protected Win7TaskbarMethods() { }

    /// <summary>
    /// Displays or updates a progress bar hosted in a taskbar button to show the specific percentage completed of the full operation.
    /// </summary>
    /// <param name="windowHandle">The handle of the window whose associated taskbar button is being used as a progress indicator.</param>
    /// <param name="progressValue">An application-defined value that indicates the proportion of the operation that has been completed at the time the method is called.</param>
    /// <param name="progressMax">An application-defined value that specifies the value <paramref name="progressValue"/> will have when the operation is complete.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetProgressValue(IntPtr windowHandle, int progressValue, int progressMax) {
        checked {
            getTaskbarList4().SetProgressValue(windowHandle, (ulong)progressValue, (ulong)progressMax);
        }
    }

    /// <summary>
    /// Sets the type and state of the progress indicator displayed on a taskbar button.
    /// </summary>
    /// <param name="windowHandle">The handle of the window in which the progress of an operation is being shown. This window's associated taskbar button will display the progress bar.</param>
    /// <param name="taskbarState">Flags that control the current state of the progress button. Specify only one of the following flags; all states are mutually exclusive of all others.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetProgressState(IntPtr windowHandle, TBPFLAG taskbarState) => getTaskbarList4().SetProgressState(windowHandle, taskbarState);

    /// <summary>
    /// Informs the taskbar that a new tab or document thumbnail has been provided for display in an application's taskbar group flyout.
    /// </summary>
    /// <param name="hwndTab">Handle of the tab or document window.</param>
    /// <param name="hwndMDI">Handle of the application's main window. This value tells the taskbar which application's preview group to attach the new thumbnail to.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void RegisterTab(IntPtr hwndTab, IntPtr hwndMDI) => getTaskbarList4().RegisterTab(hwndTab, hwndMDI);

    /// <summary>
    /// Removes a thumbnail from an application's preview group when that tab or document is closed in the application.
    /// </summary>
    /// <param name="hwndTab">The handle of the tab window whose thumbnail is being removed. This is the same value with which the thumbnail was registered as part the group through <see cref="RegisterTab(IntPtr, IntPtr)"/>.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void UnregisterTab(IntPtr hwndTab) => getTaskbarList4().UnregisterTab(hwndTab);

    /// <summary>
    /// Inserts a new thumbnail into a tabbed-document interface (TDI) or multiple-document interface (MDI) application's group flyout or moves an existing thumbnail to a new position in the application's group.
    /// </summary>
    /// <param name="hwndTab">The handle of the tab window whose thumbnail is being placed. Must already be registered through <see cref="RegisterTab(IntPtr, IntPtr)"/>.</param>
    /// <param name="hwndInsertBefore">The handle of the tab window whose thumbnail that hwndTab is inserted to the left of. This handle must already be registered through <see cref="RegisterTab(IntPtr, IntPtr)"/>. If this value is <see cref="IntPtr.Zero"/>, the new thumbnail is added to the end of the list.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetTabOrder(IntPtr hwndTab, IntPtr hwndInsertBefore) => getTaskbarList4().SetTabOrder(hwndTab, hwndInsertBefore);

    /// <summary>
    /// Informs the taskbar that a tab or document window has been made the active window.
    /// </summary>
    /// <param name="hwndTab">Handle of the active tab window. This handle must already be registered through <see cref="RegisterTab(IntPtr, IntPtr)"/>. This value can be <see cref="IntPtr.Zero"/> if no tab is active.</param>
    /// <param name="hwndMDI">Handle of the application's main window. This value tells the taskbar which group the thumbnail is a member of.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetTabActive(IntPtr hwndTab, IntPtr hwndMDI) => getTaskbarList4().SetTabActive(hwndTab, hwndMDI);

    /// <summary>
    /// Adds a thumbnail toolbar with a specified set of buttons to the thumbnail image of a window in a taskbar button flyout.
    /// </summary>
    /// <param name="windowHandle">The handle of the window whose thumbnail representation will receive the toolbar. This handle must belong to the calling process.</param>
    /// <param name="buttonCounts">The number of buttons defined in the array pointed to by <paramref name="buttonProperties"/>. The maximum number of buttons allowed is 7.</param>
    /// <param name="buttonProperties">An array of <see cref="THUMBBUTTON"/> structures. Each <see cref="THUMBBUTTON"/> defines an individual button to be added to the toolbar. Buttons cannot be added or deleted later, so this must be the full defined set. Buttons also cannot be reordered, so their order in the array, which is the order in which they are displayed left to right, will be their permanent order.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    [CLSCompliant(false)]
    public static void ThumbBarAddButtons(IntPtr windowHandle, uint buttonCounts, THUMBBUTTON[] buttonProperties) => getTaskbarList4().ThumbBarAddButtons(windowHandle, buttonCounts, buttonProperties);

    /// <summary>
    /// Shows, enables, disables, or hides buttons in a thumbnail toolbar as required by the window's current state. A thumbnail toolbar is a toolbar embedded in a thumbnail image of a window in a taskbar button flyout.
    /// </summary>
    /// <param name="windowHandle">The handle of the window whose thumbnail representation contains the toolbar.</param>
    /// <param name="buttonCounts">The number of buttons defined in the array pointed to by <paramref name="buttonProperties"/>. The maximum number of buttons allowed is 7. This array contains only structures that represent existing buttons that are being updated.</param>
    /// <param name="buttonProperties">An array of <see cref="THUMBBUTTON"/> structures. Each <see cref="THUMBBUTTON"/> defines an individual button. If the button already exists (the iId value is already defined), then that existing button is updated with the information provided in the structure.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    [CLSCompliant(false)]
    public static void ThumbBarUpdateButtons(IntPtr windowHandle, uint buttonCounts, THUMBBUTTON[] buttonProperties) => getTaskbarList4().ThumbBarUpdateButtons(windowHandle, buttonCounts, buttonProperties);

    /// <summary>
    /// Specifies an image list that contains button images for a toolbar embedded in a thumbnail image of a window in a taskbar button flyout.
    /// </summary>
    /// <param name="windowHandle">The handle of the window whose thumbnail representation contains the toolbar to be updated. This handle must belong to the calling process.</param>
    /// <param name="imageListHandle">The handle of the image list that contains all button images to be used in the toolbar.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void ThumbBarSetImageList(IntPtr windowHandle, IntPtr imageListHandle) => getTaskbarList4().ThumbBarSetImageList(windowHandle, imageListHandle);

    /// <summary>
    /// Applies an overlay to a taskbar button to indicate application status or a notification to the user.
    /// </summary>
    /// <param name="windowHandle">The handle of the window whose associated taskbar button receives the overlay. This handle must belong to a calling process associated with the button's application and must be a valid HWND or the call is ignored.</param>
    /// <param name="iconHandle">The handle of an icon to use as the overlay. This should be a small icon, measuring 16x16 pixels at 96 dpi. If an overlay icon is already applied to the taskbar button, that existing overlay is replaced.</param>
    /// <param name="description">A string that provides an alt text version of the information conveyed by the overlay, for accessibility purposes.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetOverlayIcon(IntPtr windowHandle, IntPtr iconHandle, string description) => getTaskbarList4().SetOverlayIcon(windowHandle, iconHandle, description);

    /// <summary>
    /// Specifies or updates the text of the tooltip that is displayed when the mouse pointer rests on an individual preview thumbnail in a taskbar button flyout.
    /// </summary>
    /// <param name="windowHandle">The handle to the window whose thumbnail displays the tooltip. This handle must belong to the calling process.</param>
    /// <param name="tip">The text to be displayed in the tooltip.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetThumbnailTooltip(IntPtr windowHandle, string tip) => getTaskbarList4().SetThumbnailTooltip(windowHandle, tip);

    /// <summary>
    /// Selects a portion of a window's client area to display as that window's thumbnail in the taskbar.
    /// </summary>
    /// <param name="windowHandle">The handle to a window represented in the taskbar.</param>
    /// <param name="rectangle">A RECT structure that specifies a selection within the window's client area, relative to the upper-left corner of that client area.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetThumbnailClip(IntPtr windowHandle, in RECT rectangle) => getTaskbarList4().SetThumbnailClip(windowHandle, in rectangle);

    /// <summary>
    /// Allows a tab to specify whether the main application frame window or the tab window should be used as a thumbnail or in the peek feature under certain circumstances.
    /// </summary>
    /// <param name="hwndTab">The handle of the tab window that is to have properties set. This handle must already be registered through <see cref="RegisterTab(IntPtr, IntPtr)"/>.</param>
    /// <param name="stpFlags">One or more members of the <see cref="STPFLAG"/> enumeration that specify the displayed thumbnail and peek image source of the tab thumbnail.</param>
    /// <exception cref="NotSupportedException">If the operating system is less than Windows 7</exception>
    public static void SetTabProperties(IntPtr hwndTab, STPFLAG stpFlags) => getTaskbarList4().SetTabProperties(hwndTab, stpFlags);

    private static ITaskbarList4 getTaskbarList4() {
        if (!win7orGreater) {
            throw new NotSupportedException("It is not supported on this operating system.");
        }

        taskbarList4 ??= (ITaskbarList4)taskbarList;

        return taskbarList4;
    }
}
