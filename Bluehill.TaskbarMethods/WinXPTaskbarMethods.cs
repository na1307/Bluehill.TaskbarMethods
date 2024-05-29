namespace Bluehill.TaskbarMethods;

/// <summary>
/// Includes taskbar methods supported starting from Windows XP.
/// </summary>
public class WinXPTaskbarMethods : TaskbarMethods {
    private static readonly bool winXporGreater = Environment.OSVersion.Version >= new Version(5, 1);
    private static ITaskbarList2? taskbarList2 = null;

    private protected WinXPTaskbarMethods() { }

    /// <summary>
    /// Marks a window as full-screen.
    /// </summary>
    /// <param name="windowHandle">The handle of the window to be marked.</param>
    /// <param name="fullscreen">A Boolean value marking the desired full-screen status of the window.</param>
    /// <remarks>
    /// <para>Setting the value of <paramref name="fullscreen"/> to <see langword="true"/>, the Shell treats this window as a full-screen window, and the taskbar is moved to the bottom of the z-order when this window is active.</para>
    /// <para>Setting the value of <paramref name="fullscreen"/> to <see langword="false"/> removes the full-screen marking, but does not cause the Shell to treat the window as though it were definitely not full-screen.</para>
    /// <para>With a <see langword="false"/> <paramref name="fullscreen"/> value, the Shell depends on its automatic detection facility to specify how the window should be treated, possibly still flagging the window as full-screen.</para>
    /// </remarks>
    /// <exception cref="PlatformNotSupportedException">If the operating system is less than Windows XP</exception>
    public static void MarkFullscreenWindow(IntPtr windowHandle, bool fullscreen) => getTaskbarList2().MarkFullscreenWindow(windowHandle, fullscreen);

    private static ITaskbarList2 getTaskbarList2() {
        if (!winXporGreater) {
            throw new PlatformNotSupportedException("It is not supported on this operating system.");
        }

        taskbarList2 ??= (ITaskbarList2)taskbarList;

        return taskbarList2;
    }
}
