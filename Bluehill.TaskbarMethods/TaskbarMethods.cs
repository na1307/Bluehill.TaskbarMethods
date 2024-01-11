using System.Runtime.InteropServices;

namespace Bluehill.TaskbarMethods;

/// <summary>
/// Includes taskbar methods supported starting from Internet Explorer 4.0 with Windows Desktop Update.
/// </summary>
public class TaskbarMethods {
    private protected static readonly ITaskbarList taskbarList = (ITaskbarList)new TaskbarList();

    private protected TaskbarMethods() { }

    /// <summary>
    /// Initializes the taskbar list object. This method must be called before any other <see cref="TaskbarMethods"/> methods can be called.
    /// </summary>
    public static void HrInit() => taskbarList.HrInit();

    /// <summary>
    /// Adds an item to the taskbar.
    /// </summary>
    /// <param name="windowHandle">A handle to the window to be added to the taskbar.</param>
    /// <remarks>
    /// <para>Any type of window can be added to the taskbar, but it is recommended that the window at least have the <c>WS_CAPTION</c> style.</para>
    /// <para>Any window added with this method must be removed with the <see cref="DeleteTab(IntPtr)"/> method when the added window is destroyed.</para>
    /// </remarks>
    public static void AddTab(IntPtr windowHandle) => taskbarList.AddTab(windowHandle);

    /// <summary>
    /// Deletes an item from the taskbar.
    /// </summary>
    /// <param name="windowHandle">A handle to the window to be deleted from the taskbar.</param>
    public static void DeleteTab(IntPtr windowHandle) => taskbarList.DeleteTab(windowHandle);

    /// <summary>
    /// Activates an item on the taskbar. The window is not actually activated; the window's item on the taskbar is merely displayed as active.
    /// </summary>
    /// <param name="windowHandle">A handle to the window on the taskbar to be displayed as active.</param>
    public static void ActivateTab(IntPtr windowHandle) => taskbarList.ActivateTab(windowHandle);

    /// <summary>
    /// Marks a taskbar item as active but does not visually activate it.
    /// </summary>
    /// <param name="windowHandle">A handle to the window to be marked as active.</param>
    /// <remarks>
    /// <para><see cref="SetActiveAlt(IntPtr)"/> marks the item associated with <paramref name="windowHandle"/> as the currently active item for the window's process without changing the pressed state of any item.</para>
    /// <para>Any user action that would activate a different tab in that process will activate the tab associated with <paramref name="windowHandle"/> instead.</para>
    /// <para>The active state of the window's item is not guaranteed to be preserved when the process associated with hwnd is not active.</para>
    /// <para>To ensure that a given tab is always active, call <see cref="SetActiveAlt(IntPtr)"/> whenever any of your windows are activated.</para>
    /// <para>Calling <see cref="SetActiveAlt(IntPtr)"/> with a <see cref="IntPtr.Zero"/> <paramref name="windowHandle"/> clears this state.</para>
    /// </remarks>
    public static void SetActiveAlt(IntPtr windowHandle) => taskbarList.SetActiveAlt(windowHandle);

    [ComImport]
    [Guid("56FDF344-FD6D-11d0-958A-006097C9A090")]
    [ClassInterface(ClassInterfaceType.None)]
    private class TaskbarList { }
}
