namespace Bluehill.TaskbarMethods;

/// <summary>
/// Used by <see cref="THUMBBUTTON"/> to control specific states and behaviors of the button.
/// </summary>
public enum THUMBBUTTONFLAGS {
    /// <summary>
    /// The button is active and available to the user.
    /// </summary>
    Enabled = 0,

    /// <summary>
    /// The button is disabled. It is present, but has a visual state that indicates that it will not respond to user action.
    /// </summary>
    Disabled = 0x1,

    /// <summary>
    /// When the button is clicked, the taskbar button's flyout closes immediately.
    /// </summary>
    DismissOnClick = 0x2,

    /// <summary>
    /// Do not draw a button border, use only the image.
    /// </summary>
    NoBackground = 0x4,

    /// <summary>
    /// The button is not shown to the user.
    /// </summary>
    Hidden = 0x8,

    /// <summary>
    /// The button is enabled but not interactive; no pressed button state is drawn. This value is intended for instances where the button is used in a notification.
    /// </summary>
    NonInteractive = 0x10
}
