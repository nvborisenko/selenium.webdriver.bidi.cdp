#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Emulation;

/// <summary>
/// This domain emulates different environments for the page.
/// </summary>
public sealed class EmulationDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static EmulationJsonSerializerContext JsonContext = EmulationJsonSerializerContext.Default;

    /// <summary>
    /// Tells whether emulation is supported.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CanEmulateResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<CanEmulateResult> CanEmulateAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CanEmulateCommandParameters();
        return await ExecuteCommandAsync(CanEmulateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CanEmulateCommandParameters, CanEmulateResult> CanEmulateCommand = new("Emulation.canEmulate", JsonContext.CanEmulateCommandParameters, JsonContext.CanEmulateResult);

    /// <summary>
    /// Clears the overridden device metrics.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDeviceMetricsOverrideResult"/>.
    /// </returns>
    public async Task<ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceMetricsOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDeviceMetricsOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDeviceMetricsOverrideCommandParameters, ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideCommand = new("Emulation.clearDeviceMetricsOverride", JsonContext.ClearDeviceMetricsOverrideCommandParameters, JsonContext.ClearDeviceMetricsOverrideResult);

    /// <summary>
    /// Clears the overridden Geolocation Position and Error.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearGeolocationOverrideResult"/>.
    /// </returns>
    public async Task<ClearGeolocationOverrideResult> ClearGeolocationOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearGeolocationOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearGeolocationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearGeolocationOverrideCommandParameters, ClearGeolocationOverrideResult> ClearGeolocationOverrideCommand = new("Emulation.clearGeolocationOverride", JsonContext.ClearGeolocationOverrideCommandParameters, JsonContext.ClearGeolocationOverrideResult);

    /// <summary>
    /// Requests that page scale factor is reset to initial values.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResetPageScaleFactorResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ResetPageScaleFactorResult> ResetPageScaleFactorAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResetPageScaleFactorCommandParameters();
        return await ExecuteCommandAsync(ResetPageScaleFactorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResetPageScaleFactorCommandParameters, ResetPageScaleFactorResult> ResetPageScaleFactorCommand = new("Emulation.resetPageScaleFactor", JsonContext.ResetPageScaleFactorCommandParameters, JsonContext.ResetPageScaleFactorResult);

    /// <summary>
    /// Enables or disables simulating a focused and active page.
    /// </summary>
    /// <param name="enabled">
    /// Whether to enable to disable focus emulation.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetFocusEmulationEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetFocusEmulationEnabledResult> SetFocusEmulationEnabledAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetFocusEmulationEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetFocusEmulationEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetFocusEmulationEnabledCommandParameters, SetFocusEmulationEnabledResult> SetFocusEmulationEnabledCommand = new("Emulation.setFocusEmulationEnabled", JsonContext.SetFocusEmulationEnabledCommandParameters, JsonContext.SetFocusEmulationEnabledResult);

    /// <summary>
    /// Automatically render all web contents using a dark theme.
    /// </summary>
    /// <param name="enabled">
    /// Whether to enable or disable automatic dark mode.
    /// If not specified, any existing override will be cleared.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAutoDarkModeOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetAutoDarkModeOverrideResult> SetAutoDarkModeOverrideAsync(bool? enabled = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAutoDarkModeOverrideCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetAutoDarkModeOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAutoDarkModeOverrideCommandParameters, SetAutoDarkModeOverrideResult> SetAutoDarkModeOverrideCommand = new("Emulation.setAutoDarkModeOverride", JsonContext.SetAutoDarkModeOverrideCommandParameters, JsonContext.SetAutoDarkModeOverrideResult);

    /// <summary>
    /// Enables CPU throttling to emulate slow CPUs.
    /// </summary>
    /// <param name="rate">
    /// Throttling rate as a slowdown factor (1 is no throttle, 2 is 2x slowdown, etc).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCPUThrottlingRateResult"/>.
    /// </returns>
    public async Task<SetCPUThrottlingRateResult> SetCPUThrottlingRateAsync(double rate, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCPUThrottlingRateCommandParameters(Rate: rate);
        return await ExecuteCommandAsync(SetCPUThrottlingRateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCPUThrottlingRateCommandParameters, SetCPUThrottlingRateResult> SetCPUThrottlingRateCommand = new("Emulation.setCPUThrottlingRate", JsonContext.SetCPUThrottlingRateCommandParameters, JsonContext.SetCPUThrottlingRateResult);

    /// <summary>
    /// Sets or clears an override of the default background color of the frame. This override is used
    /// if the content does not specify one.
    /// </summary>
    /// <param name="color">
    /// RGBA of the default background color. If not specified, any existing override will be
    /// cleared.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDefaultBackgroundColorOverrideResult"/>.
    /// </returns>
    public async Task<SetDefaultBackgroundColorOverrideResult> SetDefaultBackgroundColorOverrideAsync(DOM.RGBA? color = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDefaultBackgroundColorOverrideCommandParameters(Color: color);
        return await ExecuteCommandAsync(SetDefaultBackgroundColorOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDefaultBackgroundColorOverrideCommandParameters, SetDefaultBackgroundColorOverrideResult> SetDefaultBackgroundColorOverrideCommand = new("Emulation.setDefaultBackgroundColorOverride", JsonContext.SetDefaultBackgroundColorOverrideCommandParameters, JsonContext.SetDefaultBackgroundColorOverrideResult);

    /// <summary>
    /// Overrides the values for env(safe-area-inset-*) and env(safe-area-max-inset-*). Unset values will cause the
    /// respective variables to be undefined, even if previously overridden.
    /// </summary>
    /// <param name="insets">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSafeAreaInsetsOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetSafeAreaInsetsOverrideResult> SetSafeAreaInsetsOverrideAsync(SafeAreaInsets insets, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSafeAreaInsetsOverrideCommandParameters(Insets: insets);
        return await ExecuteCommandAsync(SetSafeAreaInsetsOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSafeAreaInsetsOverrideCommandParameters, SetSafeAreaInsetsOverrideResult> SetSafeAreaInsetsOverrideCommand = new("Emulation.setSafeAreaInsetsOverride", JsonContext.SetSafeAreaInsetsOverrideCommandParameters, JsonContext.SetSafeAreaInsetsOverrideResult);

    /// <summary>
    /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
    /// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
    /// query results).
    /// </summary>
    /// <param name="width">
    /// Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
    /// </param>
    /// <param name="height">
    /// Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
    /// </param>
    /// <param name="deviceScaleFactor">
    /// Overriding device scale factor value. 0 disables the override.
    /// </param>
    /// <param name="mobile">
    /// Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text
    /// autosizing and more.
    /// </param>
    /// <param name="scale">
    /// Scale to apply to resulting view image.
    /// </param>
    /// <param name="screenWidth">
    /// Overriding screen width value in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="screenHeight">
    /// Overriding screen height value in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="positionX">
    /// Overriding view X position on screen in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="positionY">
    /// Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="dontSetVisibleSize">
    /// Do not set visible view size, rely upon explicit setVisibleSize call.
    /// </param>
    /// <param name="screenOrientation">
    /// Screen orientation override.
    /// </param>
    /// <param name="viewport">
    /// If set, the visible area of the page will be overridden to this viewport. This viewport
    /// change is not observed by the page, e.g. viewport-relative elements do not change positions.
    /// </param>
    /// <param name="displayFeature">
    /// If set, the display feature of a multi-segment screen. If not set, multi-segment support
    /// is turned-off.
    /// Deprecated, use Emulation.setDisplayFeaturesOverride.
    /// </param>
    /// <param name="devicePosture">
    /// If set, the posture of a foldable device. If not set the posture is set
    /// to continuous.
    /// Deprecated, use Emulation.setDevicePostureOverride.
    /// </param>
    /// <param name="scrollbarType">
    /// Scrollbar type. Default: <b>default</b>.
    /// </param>
    /// <param name="screenOrientationLockEmulation">
    /// If set to true, enables screen orientation lock emulation, which
    /// intercepts screen.orientation.lock() calls from the page and reports
    /// orientation changes via screenOrientationLockChanged events. This is
    /// useful for emulating mobile device orientation lock behavior in
    /// responsive design mode.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDeviceMetricsOverrideResult"/>.
    /// </returns>
    public async Task<SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideAsync(long width, long height, double deviceScaleFactor, bool mobile, double? scale = default, long? screenWidth = default, long? screenHeight = default, long? positionX = default, long? positionY = default, bool? dontSetVisibleSize = default, ScreenOrientation? screenOrientation = default, Page.Viewport? viewport = default, DisplayFeature? displayFeature = default, DevicePosture? devicePosture = default, string? scrollbarType = default, bool? screenOrientationLockEmulation = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceMetricsOverrideCommandParameters(Width: width, Height: height, DeviceScaleFactor: deviceScaleFactor, Mobile: mobile, Scale: scale, ScreenWidth: screenWidth, ScreenHeight: screenHeight, PositionX: positionX, PositionY: positionY, DontSetVisibleSize: dontSetVisibleSize, ScreenOrientation: screenOrientation, Viewport: viewport, DisplayFeature: displayFeature, DevicePosture: devicePosture, ScrollbarType: scrollbarType, ScreenOrientationLockEmulation: screenOrientationLockEmulation);
        return await ExecuteCommandAsync(SetDeviceMetricsOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDeviceMetricsOverrideCommandParameters, SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideCommand = new("Emulation.setDeviceMetricsOverride", JsonContext.SetDeviceMetricsOverrideCommandParameters, JsonContext.SetDeviceMetricsOverrideResult);

    /// <summary>
    /// Start reporting the given posture value to the Device Posture API.
    /// This override can also be set in setDeviceMetricsOverride().
    /// </summary>
    /// <param name="posture">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDevicePostureOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetDevicePostureOverrideResult> SetDevicePostureOverrideAsync(DevicePosture posture, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDevicePostureOverrideCommandParameters(Posture: posture);
        return await ExecuteCommandAsync(SetDevicePostureOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDevicePostureOverrideCommandParameters, SetDevicePostureOverrideResult> SetDevicePostureOverrideCommand = new("Emulation.setDevicePostureOverride", JsonContext.SetDevicePostureOverrideCommandParameters, JsonContext.SetDevicePostureOverrideResult);

    /// <summary>
    /// Clears a device posture override set with either setDeviceMetricsOverride()
    /// or setDevicePostureOverride() and starts using posture information from the
    /// platform again.
    /// Does nothing if no override is set.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDevicePostureOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ClearDevicePostureOverrideResult> ClearDevicePostureOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDevicePostureOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDevicePostureOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDevicePostureOverrideCommandParameters, ClearDevicePostureOverrideResult> ClearDevicePostureOverrideCommand = new("Emulation.clearDevicePostureOverride", JsonContext.ClearDevicePostureOverrideCommandParameters, JsonContext.ClearDevicePostureOverrideResult);

    /// <summary>
    /// Start using the given display features to pupulate the Viewport Segments API.
    /// This override can also be set in setDeviceMetricsOverride().
    /// </summary>
    /// <param name="features">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDisplayFeaturesOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetDisplayFeaturesOverrideResult> SetDisplayFeaturesOverrideAsync(ImmutableArray<DisplayFeature> features, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDisplayFeaturesOverrideCommandParameters(Features: features);
        return await ExecuteCommandAsync(SetDisplayFeaturesOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDisplayFeaturesOverrideCommandParameters, SetDisplayFeaturesOverrideResult> SetDisplayFeaturesOverrideCommand = new("Emulation.setDisplayFeaturesOverride", JsonContext.SetDisplayFeaturesOverrideCommandParameters, JsonContext.SetDisplayFeaturesOverrideResult);

    /// <summary>
    /// Clears the display features override set with either setDeviceMetricsOverride()
    /// or setDisplayFeaturesOverride() and starts using display features from the
    /// platform again.
    /// Does nothing if no override is set.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDisplayFeaturesOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ClearDisplayFeaturesOverrideResult> ClearDisplayFeaturesOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDisplayFeaturesOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDisplayFeaturesOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDisplayFeaturesOverrideCommandParameters, ClearDisplayFeaturesOverrideResult> ClearDisplayFeaturesOverrideCommand = new("Emulation.clearDisplayFeaturesOverride", JsonContext.ClearDisplayFeaturesOverrideCommandParameters, JsonContext.ClearDisplayFeaturesOverrideResult);

    /// <summary>
    /// </summary>
    /// <param name="hidden">
    /// Whether scrollbars should be always hidden.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetScrollbarsHiddenResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetScrollbarsHiddenResult> SetScrollbarsHiddenAsync(bool hidden, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetScrollbarsHiddenCommandParameters(Hidden: hidden);
        return await ExecuteCommandAsync(SetScrollbarsHiddenCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetScrollbarsHiddenCommandParameters, SetScrollbarsHiddenResult> SetScrollbarsHiddenCommand = new("Emulation.setScrollbarsHidden", JsonContext.SetScrollbarsHiddenCommandParameters, JsonContext.SetScrollbarsHiddenResult);

    /// <summary>
    /// </summary>
    /// <param name="disabled">
    /// Whether document.coookie API should be disabled.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDocumentCookieDisabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetDocumentCookieDisabledResult> SetDocumentCookieDisabledAsync(bool disabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDocumentCookieDisabledCommandParameters(Disabled: disabled);
        return await ExecuteCommandAsync(SetDocumentCookieDisabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDocumentCookieDisabledCommandParameters, SetDocumentCookieDisabledResult> SetDocumentCookieDisabledCommand = new("Emulation.setDocumentCookieDisabled", JsonContext.SetDocumentCookieDisabledCommandParameters, JsonContext.SetDocumentCookieDisabledResult);

    /// <summary>
    /// </summary>
    /// <param name="enabled">
    /// Whether touch emulation based on mouse input should be enabled.
    /// </param>
    /// <param name="configuration">
    /// Touch/gesture events configuration. Default: current platform.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetEmitTouchEventsForMouseResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetEmitTouchEventsForMouseResult> SetEmitTouchEventsForMouseAsync(bool enabled, string? configuration = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetEmitTouchEventsForMouseCommandParameters(Enabled: enabled, Configuration: configuration);
        return await ExecuteCommandAsync(SetEmitTouchEventsForMouseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetEmitTouchEventsForMouseCommandParameters, SetEmitTouchEventsForMouseResult> SetEmitTouchEventsForMouseCommand = new("Emulation.setEmitTouchEventsForMouse", JsonContext.SetEmitTouchEventsForMouseCommandParameters, JsonContext.SetEmitTouchEventsForMouseResult);

    /// <summary>
    /// Emulates the given media type or media feature for CSS media queries.
    /// </summary>
    /// <param name="media">
    /// Media type to emulate. Empty string disables the override.
    /// </param>
    /// <param name="features">
    /// Media features to emulate.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetEmulatedMediaResult"/>.
    /// </returns>
    public async Task<SetEmulatedMediaResult> SetEmulatedMediaAsync(string? media = default, ImmutableArray<MediaFeature>? features = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetEmulatedMediaCommandParameters(Media: media, Features: features);
        return await ExecuteCommandAsync(SetEmulatedMediaCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetEmulatedMediaCommandParameters, SetEmulatedMediaResult> SetEmulatedMediaCommand = new("Emulation.setEmulatedMedia", JsonContext.SetEmulatedMediaCommandParameters, JsonContext.SetEmulatedMediaResult);

    /// <summary>
    /// Emulates the given vision deficiency.
    /// </summary>
    /// <param name="type">
    /// Vision deficiency to emulate. Order: best-effort emulations come first, followed by any
    /// physiologically accurate emulations for medically recognized color vision deficiencies.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetEmulatedVisionDeficiencyResult"/>.
    /// </returns>
    public async Task<SetEmulatedVisionDeficiencyResult> SetEmulatedVisionDeficiencyAsync(string type, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetEmulatedVisionDeficiencyCommandParameters(Type: type);
        return await ExecuteCommandAsync(SetEmulatedVisionDeficiencyCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetEmulatedVisionDeficiencyCommandParameters, SetEmulatedVisionDeficiencyResult> SetEmulatedVisionDeficiencyCommand = new("Emulation.setEmulatedVisionDeficiency", JsonContext.SetEmulatedVisionDeficiencyCommandParameters, JsonContext.SetEmulatedVisionDeficiencyResult);

    /// <summary>
    /// Emulates the given OS text scale.
    /// </summary>
    /// <param name="scale">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetEmulatedOSTextScaleResult"/>.
    /// </returns>
    public async Task<SetEmulatedOSTextScaleResult> SetEmulatedOSTextScaleAsync(double? scale = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetEmulatedOSTextScaleCommandParameters(Scale: scale);
        return await ExecuteCommandAsync(SetEmulatedOSTextScaleCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetEmulatedOSTextScaleCommandParameters, SetEmulatedOSTextScaleResult> SetEmulatedOSTextScaleCommand = new("Emulation.setEmulatedOSTextScale", JsonContext.SetEmulatedOSTextScaleCommandParameters, JsonContext.SetEmulatedOSTextScaleResult);

    /// <summary>
    /// Overrides the Geolocation Position or Error. Omitting latitude, longitude or
    /// accuracy emulates position unavailable.
    /// </summary>
    /// <param name="latitude">
    /// Mock latitude
    /// </param>
    /// <param name="longitude">
    /// Mock longitude
    /// </param>
    /// <param name="accuracy">
    /// Mock accuracy
    /// </param>
    /// <param name="altitude">
    /// Mock altitude
    /// </param>
    /// <param name="altitudeAccuracy">
    /// Mock altitudeAccuracy
    /// </param>
    /// <param name="heading">
    /// Mock heading
    /// </param>
    /// <param name="speed">
    /// Mock speed
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetGeolocationOverrideResult"/>.
    /// </returns>
    public async Task<SetGeolocationOverrideResult> SetGeolocationOverrideAsync(double? latitude = default, double? longitude = default, double? accuracy = default, double? altitude = default, double? altitudeAccuracy = default, double? heading = default, double? speed = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetGeolocationOverrideCommandParameters(Latitude: latitude, Longitude: longitude, Accuracy: accuracy, Altitude: altitude, AltitudeAccuracy: altitudeAccuracy, Heading: heading, Speed: speed);
        return await ExecuteCommandAsync(SetGeolocationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetGeolocationOverrideCommandParameters, SetGeolocationOverrideResult> SetGeolocationOverrideCommand = new("Emulation.setGeolocationOverride", JsonContext.SetGeolocationOverrideCommandParameters, JsonContext.SetGeolocationOverrideResult);

    /// <summary>
    /// </summary>
    /// <param name="type">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetOverriddenSensorInformationResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetOverriddenSensorInformationResult> GetOverriddenSensorInformationAsync(SensorType type, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetOverriddenSensorInformationCommandParameters(Type: type);
        return await ExecuteCommandAsync(GetOverriddenSensorInformationCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetOverriddenSensorInformationCommandParameters, GetOverriddenSensorInformationResult> GetOverriddenSensorInformationCommand = new("Emulation.getOverriddenSensorInformation", JsonContext.GetOverriddenSensorInformationCommandParameters, JsonContext.GetOverriddenSensorInformationResult);

    /// <summary>
    /// Overrides a platform sensor of a given type. If |enabled| is true, calls to
    /// Sensor.start() will use a virtual sensor as backend rather than fetching
    /// data from a real hardware sensor. Otherwise, existing virtual
    /// sensor-backend Sensor objects will fire an error event and new calls to
    /// Sensor.start() will attempt to use a real sensor instead.
    /// </summary>
    /// <param name="enabled">
    /// </param>
    /// <param name="type">
    /// </param>
    /// <param name="metadata">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSensorOverrideEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetSensorOverrideEnabledResult> SetSensorOverrideEnabledAsync(bool enabled, SensorType type, SensorMetadata? metadata = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSensorOverrideEnabledCommandParameters(Enabled: enabled, Type: type, Metadata: metadata);
        return await ExecuteCommandAsync(SetSensorOverrideEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSensorOverrideEnabledCommandParameters, SetSensorOverrideEnabledResult> SetSensorOverrideEnabledCommand = new("Emulation.setSensorOverrideEnabled", JsonContext.SetSensorOverrideEnabledCommandParameters, JsonContext.SetSensorOverrideEnabledResult);

    /// <summary>
    /// Updates the sensor readings reported by a sensor type previously overridden
    /// by setSensorOverrideEnabled.
    /// </summary>
    /// <param name="type">
    /// </param>
    /// <param name="reading">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSensorOverrideReadingsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetSensorOverrideReadingsResult> SetSensorOverrideReadingsAsync(SensorType type, SensorReading reading, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSensorOverrideReadingsCommandParameters(Type: type, Reading: reading);
        return await ExecuteCommandAsync(SetSensorOverrideReadingsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSensorOverrideReadingsCommandParameters, SetSensorOverrideReadingsResult> SetSensorOverrideReadingsCommand = new("Emulation.setSensorOverrideReadings", JsonContext.SetSensorOverrideReadingsCommandParameters, JsonContext.SetSensorOverrideReadingsResult);

    /// <summary>
    /// Overrides a pressure source of a given type, as used by the Compute
    /// Pressure API, so that updates to PressureObserver.observe() are provided
    /// via setPressureStateOverride instead of being retrieved from
    /// platform-provided telemetry data.
    /// </summary>
    /// <param name="enabled">
    /// </param>
    /// <param name="source">
    /// </param>
    /// <param name="metadata">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPressureSourceOverrideEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPressureSourceOverrideEnabledResult> SetPressureSourceOverrideEnabledAsync(bool enabled, PressureSource source, PressureMetadata? metadata = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPressureSourceOverrideEnabledCommandParameters(Enabled: enabled, Source: source, Metadata: metadata);
        return await ExecuteCommandAsync(SetPressureSourceOverrideEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPressureSourceOverrideEnabledCommandParameters, SetPressureSourceOverrideEnabledResult> SetPressureSourceOverrideEnabledCommand = new("Emulation.setPressureSourceOverrideEnabled", JsonContext.SetPressureSourceOverrideEnabledCommandParameters, JsonContext.SetPressureSourceOverrideEnabledResult);

    /// <summary>
    /// Provides a given pressure state that will be processed and eventually be
    /// delivered to PressureObserver users. |source| must have been previously
    /// overridden by setPressureSourceOverrideEnabled.
    /// </summary>
    /// <param name="source">
    /// </param>
    /// <param name="state">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPressureStateOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPressureStateOverrideResult> SetPressureStateOverrideAsync(PressureSource source, PressureState state, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPressureStateOverrideCommandParameters(Source: source, State: state);
        return await ExecuteCommandAsync(SetPressureStateOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPressureStateOverrideCommandParameters, SetPressureStateOverrideResult> SetPressureStateOverrideCommand = new("Emulation.setPressureStateOverride", JsonContext.SetPressureStateOverrideCommandParameters, JsonContext.SetPressureStateOverrideResult);

    /// <summary>
    /// Overrides the Idle state.
    /// </summary>
    /// <param name="isUserActive">
    /// Mock isUserActive
    /// </param>
    /// <param name="isScreenUnlocked">
    /// Mock isScreenUnlocked
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetIdleOverrideResult"/>.
    /// </returns>
    public async Task<SetIdleOverrideResult> SetIdleOverrideAsync(bool isUserActive, bool isScreenUnlocked, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetIdleOverrideCommandParameters(IsUserActive: isUserActive, IsScreenUnlocked: isScreenUnlocked);
        return await ExecuteCommandAsync(SetIdleOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetIdleOverrideCommandParameters, SetIdleOverrideResult> SetIdleOverrideCommand = new("Emulation.setIdleOverride", JsonContext.SetIdleOverrideCommandParameters, JsonContext.SetIdleOverrideResult);

    /// <summary>
    /// Clears Idle state overrides.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearIdleOverrideResult"/>.
    /// </returns>
    public async Task<ClearIdleOverrideResult> ClearIdleOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearIdleOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearIdleOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearIdleOverrideCommandParameters, ClearIdleOverrideResult> ClearIdleOverrideCommand = new("Emulation.clearIdleOverride", JsonContext.ClearIdleOverrideCommandParameters, JsonContext.ClearIdleOverrideResult);

    /// <summary>
    /// Overrides value returned by the javascript navigator object.
    /// </summary>
    /// <param name="platform">
    /// The platform navigator.platform should return.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetNavigatorOverridesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetNavigatorOverridesResult> SetNavigatorOverridesAsync(string platform, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetNavigatorOverridesCommandParameters(Platform: platform);
        return await ExecuteCommandAsync(SetNavigatorOverridesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetNavigatorOverridesCommandParameters, SetNavigatorOverridesResult> SetNavigatorOverridesCommand = new("Emulation.setNavigatorOverrides", JsonContext.SetNavigatorOverridesCommandParameters, JsonContext.SetNavigatorOverridesResult);

    /// <summary>
    /// Sets a specified page scale factor.
    /// </summary>
    /// <param name="pageScaleFactor">
    /// Page scale factor.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPageScaleFactorResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPageScaleFactorResult> SetPageScaleFactorAsync(double pageScaleFactor, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPageScaleFactorCommandParameters(PageScaleFactor: pageScaleFactor);
        return await ExecuteCommandAsync(SetPageScaleFactorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPageScaleFactorCommandParameters, SetPageScaleFactorResult> SetPageScaleFactorCommand = new("Emulation.setPageScaleFactor", JsonContext.SetPageScaleFactorCommandParameters, JsonContext.SetPageScaleFactorResult);

    /// <summary>
    /// Switches script execution in the page.
    /// </summary>
    /// <param name="value">
    /// Whether script execution should be disabled in the page.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetScriptExecutionDisabledResult"/>.
    /// </returns>
    public async Task<SetScriptExecutionDisabledResult> SetScriptExecutionDisabledAsync(bool value, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetScriptExecutionDisabledCommandParameters(Value: value);
        return await ExecuteCommandAsync(SetScriptExecutionDisabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetScriptExecutionDisabledCommandParameters, SetScriptExecutionDisabledResult> SetScriptExecutionDisabledCommand = new("Emulation.setScriptExecutionDisabled", JsonContext.SetScriptExecutionDisabledCommandParameters, JsonContext.SetScriptExecutionDisabledResult);

    /// <summary>
    /// Enables touch on platforms which do not support them.
    /// </summary>
    /// <param name="enabled">
    /// Whether the touch event emulation should be enabled.
    /// </param>
    /// <param name="maxTouchPoints">
    /// Maximum touch points supported. Defaults to one.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetTouchEmulationEnabledResult"/>.
    /// </returns>
    public async Task<SetTouchEmulationEnabledResult> SetTouchEmulationEnabledAsync(bool enabled, long? maxTouchPoints = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetTouchEmulationEnabledCommandParameters(Enabled: enabled, MaxTouchPoints: maxTouchPoints);
        return await ExecuteCommandAsync(SetTouchEmulationEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetTouchEmulationEnabledCommandParameters, SetTouchEmulationEnabledResult> SetTouchEmulationEnabledCommand = new("Emulation.setTouchEmulationEnabled", JsonContext.SetTouchEmulationEnabledCommandParameters, JsonContext.SetTouchEmulationEnabledResult);

    /// <summary>
    /// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets
    /// the current virtual time policy.  Note this supersedes any previous time budget.
    /// </summary>
    /// <param name="policy">
    /// </param>
    /// <param name="budget">
    /// If set, after this many virtual milliseconds have elapsed virtual time will be paused and a
    /// virtualTimeBudgetExpired event is sent.
    /// </param>
    /// <param name="maxVirtualTimeTaskStarvationCount">
    /// If set this specifies the maximum number of tasks that can be run before virtual is forced
    /// forwards to prevent deadlock.
    /// </param>
    /// <param name="initialVirtualTime">
    /// If set, base::Time::Now will be overridden to initially return this value.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetVirtualTimePolicyResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetVirtualTimePolicyResult> SetVirtualTimePolicyAsync(VirtualTimePolicy policy, double? budget = default, long? maxVirtualTimeTaskStarvationCount = default, Network.TimeSinceEpoch? initialVirtualTime = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetVirtualTimePolicyCommandParameters(Policy: policy, Budget: budget, MaxVirtualTimeTaskStarvationCount: maxVirtualTimeTaskStarvationCount, InitialVirtualTime: initialVirtualTime);
        return await ExecuteCommandAsync(SetVirtualTimePolicyCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetVirtualTimePolicyCommandParameters, SetVirtualTimePolicyResult> SetVirtualTimePolicyCommand = new("Emulation.setVirtualTimePolicy", JsonContext.SetVirtualTimePolicyCommandParameters, JsonContext.SetVirtualTimePolicyResult);

    /// <summary>
    /// Overrides default host system locale with the specified one.
    /// </summary>
    /// <param name="locale">
    /// ICU style C locale (e.g. "en_US"). If not specified or empty, disables the override and
    /// restores default host system locale.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetLocaleOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetLocaleOverrideResult> SetLocaleOverrideAsync(string? locale = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetLocaleOverrideCommandParameters(Locale: locale);
        return await ExecuteCommandAsync(SetLocaleOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetLocaleOverrideCommandParameters, SetLocaleOverrideResult> SetLocaleOverrideCommand = new("Emulation.setLocaleOverride", JsonContext.SetLocaleOverrideCommandParameters, JsonContext.SetLocaleOverrideResult);

    /// <summary>
    /// Overrides default host system timezone with the specified one.
    /// </summary>
    /// <param name="timezoneId">
    /// The timezone identifier. List of supported timezones:
    /// https://source.chromium.org/chromium/chromium/deps/icu.git/+/faee8bc70570192d82d2978a71e2a615788597d1:source/data/misc/metaZones.txt
    /// If empty, disables the override and restores default host system timezone.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetTimezoneOverrideResult"/>.
    /// </returns>
    public async Task<SetTimezoneOverrideResult> SetTimezoneOverrideAsync(string timezoneId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetTimezoneOverrideCommandParameters(TimezoneId: timezoneId);
        return await ExecuteCommandAsync(SetTimezoneOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetTimezoneOverrideCommandParameters, SetTimezoneOverrideResult> SetTimezoneOverrideCommand = new("Emulation.setTimezoneOverride", JsonContext.SetTimezoneOverrideCommandParameters, JsonContext.SetTimezoneOverrideResult);

    /// <summary>
    /// Resizes the frame/viewport of the page. Note that this does not affect the frame's container
    /// (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported
    /// on Android.
    /// </summary>
    /// <param name="width">
    /// Frame width (DIP).
    /// </param>
    /// <param name="height">
    /// Frame height (DIP).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetVisibleSizeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetVisibleSizeResult> SetVisibleSizeAsync(long width, long height, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetVisibleSizeCommandParameters(Width: width, Height: height);
        return await ExecuteCommandAsync(SetVisibleSizeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetVisibleSizeCommandParameters, SetVisibleSizeResult> SetVisibleSizeCommand = new("Emulation.setVisibleSize", JsonContext.SetVisibleSizeCommandParameters, JsonContext.SetVisibleSizeResult);

    /// <summary>
    /// </summary>
    /// <param name="imageTypes">
    /// Image types to disable.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDisabledImageTypesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetDisabledImageTypesResult> SetDisabledImageTypesAsync(ImmutableArray<DisabledImageType> imageTypes, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDisabledImageTypesCommandParameters(ImageTypes: imageTypes);
        return await ExecuteCommandAsync(SetDisabledImageTypesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDisabledImageTypesCommandParameters, SetDisabledImageTypesResult> SetDisabledImageTypesCommand = new("Emulation.setDisabledImageTypes", JsonContext.SetDisabledImageTypesCommandParameters, JsonContext.SetDisabledImageTypesResult);

    /// <summary>
    /// Override the value of navigator.connection.saveData
    /// </summary>
    /// <param name="dataSaverEnabled">
    /// Override value. Omitting the parameter disables the override.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDataSaverOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetDataSaverOverrideResult> SetDataSaverOverrideAsync(bool? dataSaverEnabled = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDataSaverOverrideCommandParameters(DataSaverEnabled: dataSaverEnabled);
        return await ExecuteCommandAsync(SetDataSaverOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDataSaverOverrideCommandParameters, SetDataSaverOverrideResult> SetDataSaverOverrideCommand = new("Emulation.setDataSaverOverride", JsonContext.SetDataSaverOverrideCommandParameters, JsonContext.SetDataSaverOverrideResult);

    /// <summary>
    /// </summary>
    /// <param name="hardwareConcurrency">
    /// Hardware concurrency to report
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetHardwareConcurrencyOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetHardwareConcurrencyOverrideResult> SetHardwareConcurrencyOverrideAsync(long hardwareConcurrency, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetHardwareConcurrencyOverrideCommandParameters(HardwareConcurrency: hardwareConcurrency);
        return await ExecuteCommandAsync(SetHardwareConcurrencyOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetHardwareConcurrencyOverrideCommandParameters, SetHardwareConcurrencyOverrideResult> SetHardwareConcurrencyOverrideCommand = new("Emulation.setHardwareConcurrencyOverride", JsonContext.SetHardwareConcurrencyOverrideCommandParameters, JsonContext.SetHardwareConcurrencyOverrideResult);

    /// <summary>
    /// Allows overriding user agent with the given string.
    /// <b>userAgentMetadata</b> must be set for Client Hint headers to be sent.
    /// </summary>
    /// <param name="userAgent">
    /// User agent to use.
    /// </param>
    /// <param name="acceptLanguage">
    /// Browser language to emulate.
    /// </param>
    /// <param name="platform">
    /// The platform navigator.platform should return.
    /// </param>
    /// <param name="userAgentMetadata">
    /// To be sent in Sec-CH-UA-* headers and returned in navigator.userAgentData
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetUserAgentOverrideResult"/>.
    /// </returns>
    public async Task<SetUserAgentOverrideResult> SetUserAgentOverrideAsync(string userAgent, string? acceptLanguage = default, string? platform = default, UserAgentMetadata? userAgentMetadata = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetUserAgentOverrideCommandParameters(UserAgent: userAgent, AcceptLanguage: acceptLanguage, Platform: platform, UserAgentMetadata: userAgentMetadata);
        return await ExecuteCommandAsync(SetUserAgentOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetUserAgentOverrideCommandParameters, SetUserAgentOverrideResult> SetUserAgentOverrideCommand = new("Emulation.setUserAgentOverride", JsonContext.SetUserAgentOverrideCommandParameters, JsonContext.SetUserAgentOverrideResult);

    /// <summary>
    /// Allows overriding the automation flag.
    /// </summary>
    /// <param name="enabled">
    /// Whether the override should be enabled.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAutomationOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetAutomationOverrideResult> SetAutomationOverrideAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAutomationOverrideCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetAutomationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAutomationOverrideCommandParameters, SetAutomationOverrideResult> SetAutomationOverrideCommand = new("Emulation.setAutomationOverride", JsonContext.SetAutomationOverrideCommandParameters, JsonContext.SetAutomationOverrideResult);

    /// <summary>
    /// Allows overriding the difference between the small and large viewport sizes, which determine the
    /// value of the <b>svh</b> and <b>lvh</b> unit, respectively. Only supported for top-level frames.
    /// </summary>
    /// <param name="difference">
    /// This will cause an element of size 100svh to be <b>difference</b> pixels smaller than an element
    /// of size 100lvh.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSmallViewportHeightDifferenceOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetSmallViewportHeightDifferenceOverrideResult> SetSmallViewportHeightDifferenceOverrideAsync(long difference, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSmallViewportHeightDifferenceOverrideCommandParameters(Difference: difference);
        return await ExecuteCommandAsync(SetSmallViewportHeightDifferenceOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSmallViewportHeightDifferenceOverrideCommandParameters, SetSmallViewportHeightDifferenceOverrideResult> SetSmallViewportHeightDifferenceOverrideCommand = new("Emulation.setSmallViewportHeightDifferenceOverride", JsonContext.SetSmallViewportHeightDifferenceOverrideCommandParameters, JsonContext.SetSmallViewportHeightDifferenceOverrideResult);

    /// <summary>
    /// Returns device's screen configuration. In headful mode, the physical screens configuration is returned,
    /// whereas in headless mode, a virtual headless screen configuration is provided instead.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetScreenInfosResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetScreenInfosResult> GetScreenInfosAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetScreenInfosCommandParameters();
        return await ExecuteCommandAsync(GetScreenInfosCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetScreenInfosCommandParameters, GetScreenInfosResult> GetScreenInfosCommand = new("Emulation.getScreenInfos", JsonContext.GetScreenInfosCommandParameters, JsonContext.GetScreenInfosResult);

    /// <summary>
    /// Add a new screen to the device. Only supported in headless mode.
    /// </summary>
    /// <param name="left">
    /// Offset of the left edge of the screen in pixels.
    /// </param>
    /// <param name="top">
    /// Offset of the top edge of the screen in pixels.
    /// </param>
    /// <param name="width">
    /// The width of the screen in pixels.
    /// </param>
    /// <param name="height">
    /// The height of the screen in pixels.
    /// </param>
    /// <param name="workAreaInsets">
    /// Specifies the screen's work area. Default is entire screen.
    /// </param>
    /// <param name="devicePixelRatio">
    /// Specifies the screen's device pixel ratio. Default is 1.
    /// </param>
    /// <param name="rotation">
    /// Specifies the screen's rotation angle. Available values are 0, 90, 180 and 270. Default is 0.
    /// </param>
    /// <param name="colorDepth">
    /// Specifies the screen's color depth in bits. Default is 24.
    /// </param>
    /// <param name="label">
    /// Specifies the descriptive label for the screen. Default is none.
    /// </param>
    /// <param name="isInternal">
    /// Indicates whether the screen is internal to the device or external, attached to the device. Default is false.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddScreenResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AddScreenResult> AddScreenAsync(long left, long top, long width, long height, WorkAreaInsets? workAreaInsets = default, double? devicePixelRatio = default, long? rotation = default, long? colorDepth = default, string? label = default, bool? isInternal = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddScreenCommandParameters(Left: left, Top: top, Width: width, Height: height, WorkAreaInsets: workAreaInsets, DevicePixelRatio: devicePixelRatio, Rotation: rotation, ColorDepth: colorDepth, Label: label, IsInternal: isInternal);
        return await ExecuteCommandAsync(AddScreenCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddScreenCommandParameters, AddScreenResult> AddScreenCommand = new("Emulation.addScreen", JsonContext.AddScreenCommandParameters, JsonContext.AddScreenResult);

    /// <summary>
    /// Updates specified screen parameters. Only supported in headless mode.
    /// </summary>
    /// <param name="screenId">
    /// Target screen identifier.
    /// </param>
    /// <param name="left">
    /// Offset of the left edge of the screen in pixels.
    /// </param>
    /// <param name="top">
    /// Offset of the top edge of the screen in pixels.
    /// </param>
    /// <param name="width">
    /// The width of the screen in pixels.
    /// </param>
    /// <param name="height">
    /// The height of the screen in pixels.
    /// </param>
    /// <param name="workAreaInsets">
    /// Specifies the screen's work area.
    /// </param>
    /// <param name="devicePixelRatio">
    /// Specifies the screen's device pixel ratio.
    /// </param>
    /// <param name="rotation">
    /// Specifies the screen's rotation angle. Available values are 0, 90, 180 and 270.
    /// </param>
    /// <param name="colorDepth">
    /// Specifies the screen's color depth in bits.
    /// </param>
    /// <param name="label">
    /// Specifies the descriptive label for the screen.
    /// </param>
    /// <param name="isInternal">
    /// Indicates whether the screen is internal to the device or external, attached to the device. Default is false.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UpdateScreenResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<UpdateScreenResult> UpdateScreenAsync(ScreenId screenId, long? left = default, long? top = default, long? width = default, long? height = default, WorkAreaInsets? workAreaInsets = default, double? devicePixelRatio = default, long? rotation = default, long? colorDepth = default, string? label = default, bool? isInternal = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new UpdateScreenCommandParameters(ScreenId: screenId, Left: left, Top: top, Width: width, Height: height, WorkAreaInsets: workAreaInsets, DevicePixelRatio: devicePixelRatio, Rotation: rotation, ColorDepth: colorDepth, Label: label, IsInternal: isInternal);
        return await ExecuteCommandAsync(UpdateScreenCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UpdateScreenCommandParameters, UpdateScreenResult> UpdateScreenCommand = new("Emulation.updateScreen", JsonContext.UpdateScreenCommandParameters, JsonContext.UpdateScreenResult);

    /// <summary>
    /// Remove screen from the device. Only supported in headless mode.
    /// </summary>
    /// <param name="screenId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveScreenResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<RemoveScreenResult> RemoveScreenAsync(ScreenId screenId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveScreenCommandParameters(ScreenId: screenId);
        return await ExecuteCommandAsync(RemoveScreenCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveScreenCommandParameters, RemoveScreenResult> RemoveScreenCommand = new("Emulation.removeScreen", JsonContext.RemoveScreenCommandParameters, JsonContext.RemoveScreenResult);

    /// <summary>
    /// Set primary screen. Only supported in headless mode.
    /// Note that this changes the coordinate system origin to the top-left
    /// of the new primary screen, updating the bounds and work areas
    /// of all existing screens accordingly.
    /// </summary>
    /// <param name="screenId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPrimaryScreenResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPrimaryScreenResult> SetPrimaryScreenAsync(ScreenId screenId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPrimaryScreenCommandParameters(ScreenId: screenId);
        return await ExecuteCommandAsync(SetPrimaryScreenCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPrimaryScreenCommandParameters, SetPrimaryScreenResult> SetPrimaryScreenCommand = new("Emulation.setPrimaryScreen", JsonContext.SetPrimaryScreenCommandParameters, JsonContext.SetPrimaryScreenResult);

    /// <summary>
    /// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<VirtualTimeBudgetExpiredEventArgs> VirtualTimeBudgetExpired => CreateCdpEventSource(EmulationDomainEvent.VirtualTimeBudgetExpired);
    /// <summary>
    /// Fired when a page calls screen.orientation.lock() or screen.orientation.unlock()
    /// while device emulation is enabled. This allows the DevTools frontend to update the
    /// emulated device orientation accordingly.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ScreenOrientationLockChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Locked</b> - Whether the screen orientation is currently locked.</description></item>
    /// <item><description><b>Orientation</b> - The orientation lock type requested by the page. Only set when locked is true.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ScreenOrientationLockChangedEventArgs> ScreenOrientationLockChanged => CreateCdpEventSource(EmulationDomainEvent.ScreenOrientationLockChanged);
}

internal sealed record CanEmulateCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// True if emulation is supported.
/// </param>
public sealed record CanEmulateResult(bool Result) : EmptyResult;


internal sealed record ClearDeviceMetricsOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record ClearGeolocationOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearGeolocationOverrideResult() : EmptyResult;


internal sealed record ResetPageScaleFactorCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ResetPageScaleFactorResult() : EmptyResult;


internal sealed record SetFocusEmulationEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetFocusEmulationEnabledResult() : EmptyResult;


internal sealed record SetAutoDarkModeOverrideCommandParameters(bool? Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAutoDarkModeOverrideResult() : EmptyResult;


internal sealed record SetCPUThrottlingRateCommandParameters(double Rate) : Parameters;

/// <summary>
/// </summary>
public sealed record SetCPUThrottlingRateResult() : EmptyResult;


internal sealed record SetDefaultBackgroundColorOverrideCommandParameters(DOM.RGBA? Color) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDefaultBackgroundColorOverrideResult() : EmptyResult;


internal sealed record SetSafeAreaInsetsOverrideCommandParameters(SafeAreaInsets Insets) : Parameters;

/// <summary>
/// </summary>
public sealed record SetSafeAreaInsetsOverrideResult() : EmptyResult;


internal sealed record SetDeviceMetricsOverrideCommandParameters(long Width, long Height, double DeviceScaleFactor, bool Mobile, double? Scale, long? ScreenWidth, long? ScreenHeight, long? PositionX, long? PositionY, bool? DontSetVisibleSize, ScreenOrientation? ScreenOrientation, Page.Viewport? Viewport, DisplayFeature? DisplayFeature, DevicePosture? DevicePosture, string? ScrollbarType, bool? ScreenOrientationLockEmulation) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record SetDevicePostureOverrideCommandParameters(DevicePosture Posture) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDevicePostureOverrideResult() : EmptyResult;


internal sealed record ClearDevicePostureOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearDevicePostureOverrideResult() : EmptyResult;


internal sealed record SetDisplayFeaturesOverrideCommandParameters(ImmutableArray<DisplayFeature> Features) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDisplayFeaturesOverrideResult() : EmptyResult;


internal sealed record ClearDisplayFeaturesOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearDisplayFeaturesOverrideResult() : EmptyResult;


internal sealed record SetScrollbarsHiddenCommandParameters(bool Hidden) : Parameters;

/// <summary>
/// </summary>
public sealed record SetScrollbarsHiddenResult() : EmptyResult;


internal sealed record SetDocumentCookieDisabledCommandParameters(bool Disabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDocumentCookieDisabledResult() : EmptyResult;


internal sealed record SetEmitTouchEventsForMouseCommandParameters(bool Enabled, string? Configuration) : Parameters;

/// <summary>
/// </summary>
public sealed record SetEmitTouchEventsForMouseResult() : EmptyResult;


internal sealed record SetEmulatedMediaCommandParameters(string? Media, ImmutableArray<MediaFeature>? Features) : Parameters;

/// <summary>
/// </summary>
public sealed record SetEmulatedMediaResult() : EmptyResult;


internal sealed record SetEmulatedVisionDeficiencyCommandParameters(string Type) : Parameters;

/// <summary>
/// </summary>
public sealed record SetEmulatedVisionDeficiencyResult() : EmptyResult;


internal sealed record SetEmulatedOSTextScaleCommandParameters(double? Scale) : Parameters;

/// <summary>
/// </summary>
public sealed record SetEmulatedOSTextScaleResult() : EmptyResult;


internal sealed record SetGeolocationOverrideCommandParameters(double? Latitude, double? Longitude, double? Accuracy, double? Altitude, double? AltitudeAccuracy, double? Heading, double? Speed) : Parameters;

/// <summary>
/// </summary>
public sealed record SetGeolocationOverrideResult() : EmptyResult;


internal sealed record GetOverriddenSensorInformationCommandParameters(SensorType Type) : Parameters;

/// <summary>
/// </summary>
/// <param name="RequestedSamplingFrequency">
/// </param>
public sealed record GetOverriddenSensorInformationResult(double RequestedSamplingFrequency) : EmptyResult;


internal sealed record SetSensorOverrideEnabledCommandParameters(bool Enabled, SensorType Type, SensorMetadata? Metadata) : Parameters;

/// <summary>
/// </summary>
public sealed record SetSensorOverrideEnabledResult() : EmptyResult;


internal sealed record SetSensorOverrideReadingsCommandParameters(SensorType Type, SensorReading Reading) : Parameters;

/// <summary>
/// </summary>
public sealed record SetSensorOverrideReadingsResult() : EmptyResult;


internal sealed record SetPressureSourceOverrideEnabledCommandParameters(bool Enabled, PressureSource Source, PressureMetadata? Metadata) : Parameters;

/// <summary>
/// </summary>
public sealed record SetPressureSourceOverrideEnabledResult() : EmptyResult;


internal sealed record SetPressureStateOverrideCommandParameters(PressureSource Source, PressureState State) : Parameters;

/// <summary>
/// </summary>
public sealed record SetPressureStateOverrideResult() : EmptyResult;


internal sealed record SetIdleOverrideCommandParameters(bool IsUserActive, bool IsScreenUnlocked) : Parameters;

/// <summary>
/// </summary>
public sealed record SetIdleOverrideResult() : EmptyResult;


internal sealed record ClearIdleOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearIdleOverrideResult() : EmptyResult;


internal sealed record SetNavigatorOverridesCommandParameters(string Platform) : Parameters;

/// <summary>
/// </summary>
public sealed record SetNavigatorOverridesResult() : EmptyResult;


internal sealed record SetPageScaleFactorCommandParameters(double PageScaleFactor) : Parameters;

/// <summary>
/// </summary>
public sealed record SetPageScaleFactorResult() : EmptyResult;


internal sealed record SetScriptExecutionDisabledCommandParameters(bool Value) : Parameters;

/// <summary>
/// </summary>
public sealed record SetScriptExecutionDisabledResult() : EmptyResult;


internal sealed record SetTouchEmulationEnabledCommandParameters(bool Enabled, long? MaxTouchPoints) : Parameters;

/// <summary>
/// </summary>
public sealed record SetTouchEmulationEnabledResult() : EmptyResult;


internal sealed record SetVirtualTimePolicyCommandParameters(VirtualTimePolicy Policy, double? Budget, long? MaxVirtualTimeTaskStarvationCount, Network.TimeSinceEpoch? InitialVirtualTime) : Parameters;

/// <summary>
/// </summary>
/// <param name="VirtualTimeTicksBase">
/// Absolute timestamp at which virtual time was first enabled (up time in milliseconds).
/// </param>
public sealed record SetVirtualTimePolicyResult(double VirtualTimeTicksBase) : EmptyResult;


internal sealed record SetLocaleOverrideCommandParameters(string? Locale) : Parameters;

/// <summary>
/// </summary>
public sealed record SetLocaleOverrideResult() : EmptyResult;


internal sealed record SetTimezoneOverrideCommandParameters(string TimezoneId) : Parameters;

/// <summary>
/// </summary>
public sealed record SetTimezoneOverrideResult() : EmptyResult;


internal sealed record SetVisibleSizeCommandParameters(long Width, long Height) : Parameters;

/// <summary>
/// </summary>
public sealed record SetVisibleSizeResult() : EmptyResult;


internal sealed record SetDisabledImageTypesCommandParameters(ImmutableArray<DisabledImageType> ImageTypes) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDisabledImageTypesResult() : EmptyResult;


internal sealed record SetDataSaverOverrideCommandParameters(bool? DataSaverEnabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDataSaverOverrideResult() : EmptyResult;


internal sealed record SetHardwareConcurrencyOverrideCommandParameters(long HardwareConcurrency) : Parameters;

/// <summary>
/// </summary>
public sealed record SetHardwareConcurrencyOverrideResult() : EmptyResult;


internal sealed record SetUserAgentOverrideCommandParameters(string UserAgent, string? AcceptLanguage, string? Platform, UserAgentMetadata? UserAgentMetadata) : Parameters;

/// <summary>
/// </summary>
public sealed record SetUserAgentOverrideResult() : EmptyResult;


internal sealed record SetAutomationOverrideCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAutomationOverrideResult() : EmptyResult;


internal sealed record SetSmallViewportHeightDifferenceOverrideCommandParameters(long Difference) : Parameters;

/// <summary>
/// </summary>
public sealed record SetSmallViewportHeightDifferenceOverrideResult() : EmptyResult;


internal sealed record GetScreenInfosCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="ScreenInfos">
/// </param>
public sealed record GetScreenInfosResult(ImmutableArray<ScreenInfo> ScreenInfos) : EmptyResult;


internal sealed record AddScreenCommandParameters(long Left, long Top, long Width, long Height, WorkAreaInsets? WorkAreaInsets, double? DevicePixelRatio, long? Rotation, long? ColorDepth, string? Label, bool? IsInternal) : Parameters;

/// <summary>
/// </summary>
/// <param name="ScreenInfo">
/// </param>
public sealed record AddScreenResult(ScreenInfo ScreenInfo) : EmptyResult;


internal sealed record UpdateScreenCommandParameters(ScreenId ScreenId, long? Left, long? Top, long? Width, long? Height, WorkAreaInsets? WorkAreaInsets, double? DevicePixelRatio, long? Rotation, long? ColorDepth, string? Label, bool? IsInternal) : Parameters;

/// <summary>
/// </summary>
/// <param name="ScreenInfo">
/// </param>
public sealed record UpdateScreenResult(ScreenInfo ScreenInfo) : EmptyResult;


internal sealed record RemoveScreenCommandParameters(ScreenId ScreenId) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveScreenResult() : EmptyResult;


internal sealed record SetPrimaryScreenCommandParameters(ScreenId ScreenId) : Parameters;

/// <summary>
/// </summary>
public sealed record SetPrimaryScreenResult() : EmptyResult;


/// <summary>
/// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
/// </summary>
public sealed record VirtualTimeBudgetExpiredEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a page calls screen.orientation.lock() or screen.orientation.unlock()
/// while device emulation is enabled. This allows the DevTools frontend to update the
/// emulated device orientation accordingly.
/// </summary>
/// <param name="Locked">
/// Whether the screen orientation is currently locked.
/// </param>
/// <param name="Orientation">
/// The orientation lock type requested by the page. Only set when locked is true.
/// </param>
public sealed record ScreenOrientationLockChangedEventArgs(bool Locked, ScreenOrientation? Orientation = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
public sealed record SafeAreaInsets()
{
    /// <summary>
    /// Overrides safe-area-inset-top.
    /// </summary>
    public long? Top { get; init; }

    /// <summary>
    /// Overrides safe-area-max-inset-top.
    /// </summary>
    public long? TopMax { get; init; }

    /// <summary>
    /// Overrides safe-area-inset-left.
    /// </summary>
    public long? Left { get; init; }

    /// <summary>
    /// Overrides safe-area-max-inset-left.
    /// </summary>
    public long? LeftMax { get; init; }

    /// <summary>
    /// Overrides safe-area-inset-bottom.
    /// </summary>
    public long? Bottom { get; init; }

    /// <summary>
    /// Overrides safe-area-max-inset-bottom.
    /// </summary>
    public long? BottomMax { get; init; }

    /// <summary>
    /// Overrides safe-area-inset-right.
    /// </summary>
    public long? Right { get; init; }

    /// <summary>
    /// Overrides safe-area-max-inset-right.
    /// </summary>
    public long? RightMax { get; init; }
}

/// <summary>
/// Screen orientation.
/// </summary>
/// <param name="Type">
/// Orientation type.
/// </param>
/// <param name="Angle">
/// Orientation angle.
/// </param>
public sealed record ScreenOrientation(string Type, long Angle)
{
}

/// <summary>
/// </summary>
/// <param name="Orientation">
/// Orientation of a display feature in relation to screen
/// </param>
/// <param name="Offset">
/// The offset from the screen origin in either the x (for vertical
/// orientation) or y (for horizontal orientation) direction.
/// </param>
/// <param name="MaskLength">
/// A display feature may mask content such that it is not physically
/// displayed - this length along with the offset describes this area.
/// A display feature that only splits content will have a 0 mask_length.
/// </param>
public sealed record DisplayFeature(string Orientation, long Offset, long MaskLength)
{
}

/// <summary>
/// </summary>
/// <param name="Type">
/// Current posture of the device
/// </param>
public sealed record DevicePosture(string Type)
{
}

/// <summary>
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="Value">
/// </param>
public sealed record MediaFeature(string Name, string Value)
{
}

/// <summary>
/// advance: If the scheduler runs out of immediate work, the virtual time base may fast forward to
/// allow the next delayed task (if any) to run; pause: The virtual time base may not advance;
/// pauseIfNetworkFetchesPending: The virtual time base may not advance if there are any pending
/// resource fetches.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<VirtualTimePolicy>))]
public enum VirtualTimePolicy
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("advance")]
    Advance,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pause")]
    Pause,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pauseIfNetworkFetchesPending")]
    PauseIfNetworkFetchesPending,
}

/// <summary>
/// Used to specify User Agent Client Hints to emulate. See https://wicg.github.io/ua-client-hints
/// </summary>
/// <param name="Brand">
/// </param>
/// <param name="Version">
/// </param>
public sealed record UserAgentBrandVersion(string Brand, string Version)
{
}

/// <summary>
/// Used to specify User Agent Client Hints to emulate. See https://wicg.github.io/ua-client-hints
/// Missing optional values will be filled in by the target with what it would normally use.
/// </summary>
/// <param name="Platform">
/// </param>
/// <param name="PlatformVersion">
/// </param>
/// <param name="Architecture">
/// </param>
/// <param name="Model">
/// </param>
/// <param name="Mobile">
/// </param>
public sealed record UserAgentMetadata(string Platform, string PlatformVersion, string Architecture, string Model, bool Mobile)
{
    /// <summary>
    /// Brands appearing in Sec-CH-UA.
    /// </summary>
    public ImmutableArray<UserAgentBrandVersion>? Brands { get; init; }

    /// <summary>
    /// Brands appearing in Sec-CH-UA-Full-Version-List.
    /// </summary>
    public ImmutableArray<UserAgentBrandVersion>? FullVersionList { get; init; }

    /// <summary>
    /// </summary>
    [global::System.Obsolete]
    public string? FullVersion { get; init; }

    /// <summary>
    /// </summary>
    public string? Bitness { get; init; }

    /// <summary>
    /// </summary>
    public bool? Wow64 { get; init; }

    /// <summary>
    /// Used to specify User Agent form-factor values.
    /// See https://wicg.github.io/ua-client-hints/#sec-ch-ua-form-factors
    /// </summary>
    public ImmutableArray<string>? FormFactors { get; init; }
}

/// <summary>
/// Used to specify sensor types to emulate.
/// See https://w3c.github.io/sensors/#automation for more information.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SensorType>))]
public enum SensorType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("absolute-orientation")]
    AbsoluteOrientation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("accelerometer")]
    Accelerometer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ambient-light")]
    AmbientLight,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gravity")]
    Gravity,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gyroscope")]
    Gyroscope,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("linear-acceleration")]
    LinearAcceleration,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("magnetometer")]
    Magnetometer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("relative-orientation")]
    RelativeOrientation,
}

/// <summary>
/// </summary>
public sealed record SensorMetadata()
{
    /// <summary>
    /// </summary>
    public bool? Available { get; init; }

    /// <summary>
    /// </summary>
    public double? MinimumFrequency { get; init; }

    /// <summary>
    /// </summary>
    public double? MaximumFrequency { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Value">
/// </param>
public sealed record SensorReadingSingle(double Value)
{
}

/// <summary>
/// </summary>
/// <param name="X">
/// </param>
/// <param name="Y">
/// </param>
/// <param name="Z">
/// </param>
public sealed record SensorReadingXYZ(double X, double Y, double Z)
{
}

/// <summary>
/// </summary>
/// <param name="X">
/// </param>
/// <param name="Y">
/// </param>
/// <param name="Z">
/// </param>
/// <param name="W">
/// </param>
public sealed record SensorReadingQuaternion(double X, double Y, double Z, double W)
{
}

/// <summary>
/// </summary>
public sealed record SensorReading()
{
    /// <summary>
    /// </summary>
    public SensorReadingSingle? Single { get; init; }

    /// <summary>
    /// </summary>
    public SensorReadingXYZ? Xyz { get; init; }

    /// <summary>
    /// </summary>
    public SensorReadingQuaternion? Quaternion { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PressureSource>))]
public enum PressureSource
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cpu")]
    Cpu,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PressureState>))]
public enum PressureState
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("nominal")]
    Nominal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fair")]
    Fair,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("serious")]
    Serious,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("critical")]
    Critical,
}

/// <summary>
/// </summary>
public sealed record PressureMetadata()
{
    /// <summary>
    /// </summary>
    public bool? Available { get; init; }
}

/// <summary>
/// </summary>
public sealed record WorkAreaInsets()
{
    /// <summary>
    /// Work area top inset in pixels. Default is 0;
    /// </summary>
    public long? Top { get; init; }

    /// <summary>
    /// Work area left inset in pixels. Default is 0;
    /// </summary>
    public long? Left { get; init; }

    /// <summary>
    /// Work area bottom inset in pixels. Default is 0;
    /// </summary>
    public long? Bottom { get; init; }

    /// <summary>
    /// Work area right inset in pixels. Default is 0;
    /// </summary>
    public long? Right { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<ScreenId>))]
public record ScreenId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Screen information similar to the one returned by window.getScreenDetails() method,
/// see https://w3c.github.io/window-management/#screendetailed.
/// </summary>
/// <param name="Left">
/// Offset of the left edge of the screen.
/// </param>
/// <param name="Top">
/// Offset of the top edge of the screen.
/// </param>
/// <param name="Width">
/// Width of the screen.
/// </param>
/// <param name="Height">
/// Height of the screen.
/// </param>
/// <param name="AvailLeft">
/// Offset of the left edge of the available screen area.
/// </param>
/// <param name="AvailTop">
/// Offset of the top edge of the available screen area.
/// </param>
/// <param name="AvailWidth">
/// Width of the available screen area.
/// </param>
/// <param name="AvailHeight">
/// Height of the available screen area.
/// </param>
/// <param name="DevicePixelRatio">
/// Specifies the screen's device pixel ratio.
/// </param>
/// <param name="Orientation">
/// Specifies the screen's orientation.
/// </param>
/// <param name="ColorDepth">
/// Specifies the screen's color depth in bits.
/// </param>
/// <param name="IsExtended">
/// Indicates whether the device has multiple screens.
/// </param>
/// <param name="IsInternal">
/// Indicates whether the screen is internal to the device or external, attached to the device.
/// </param>
/// <param name="IsPrimary">
/// Indicates whether the screen is set as the the operating system primary screen.
/// </param>
/// <param name="Label">
/// Specifies the descriptive label for the screen.
/// </param>
/// <param name="Id">
/// Specifies the unique identifier of the screen.
/// </param>
public sealed record ScreenInfo(long Left, long Top, long Width, long Height, long AvailLeft, long AvailTop, long AvailWidth, long AvailHeight, double DevicePixelRatio, ScreenOrientation Orientation, long ColorDepth, bool IsExtended, bool IsInternal, bool IsPrimary, string Label, ScreenId Id)
{
}

/// <summary>
/// Enum of image types that can be disabled.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DisabledImageType>))]
public enum DisabledImageType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("avif")]
    Avif,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("jxl")]
    Jxl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webp")]
    Webp,
}

[JsonSerializable(typeof(CanEmulateCommandParameters), TypeInfoPropertyName = "CanEmulateCommandParameters")]
[JsonSerializable(typeof(CanEmulateResult), TypeInfoPropertyName = "CanEmulateResult")]
[JsonSerializable(typeof(ClearDeviceMetricsOverrideCommandParameters), TypeInfoPropertyName = "ClearDeviceMetricsOverrideCommandParameters")]
[JsonSerializable(typeof(ClearDeviceMetricsOverrideResult), TypeInfoPropertyName = "ClearDeviceMetricsOverrideResult")]
[JsonSerializable(typeof(ClearGeolocationOverrideCommandParameters), TypeInfoPropertyName = "ClearGeolocationOverrideCommandParameters")]
[JsonSerializable(typeof(ClearGeolocationOverrideResult), TypeInfoPropertyName = "ClearGeolocationOverrideResult")]
[JsonSerializable(typeof(ResetPageScaleFactorCommandParameters), TypeInfoPropertyName = "ResetPageScaleFactorCommandParameters")]
[JsonSerializable(typeof(ResetPageScaleFactorResult), TypeInfoPropertyName = "ResetPageScaleFactorResult")]
[JsonSerializable(typeof(SetFocusEmulationEnabledCommandParameters), TypeInfoPropertyName = "SetFocusEmulationEnabledCommandParameters")]
[JsonSerializable(typeof(SetFocusEmulationEnabledResult), TypeInfoPropertyName = "SetFocusEmulationEnabledResult")]
[JsonSerializable(typeof(SetAutoDarkModeOverrideCommandParameters), TypeInfoPropertyName = "SetAutoDarkModeOverrideCommandParameters")]
[JsonSerializable(typeof(SetAutoDarkModeOverrideResult), TypeInfoPropertyName = "SetAutoDarkModeOverrideResult")]
[JsonSerializable(typeof(SetCPUThrottlingRateCommandParameters), TypeInfoPropertyName = "SetCPUThrottlingRateCommandParameters")]
[JsonSerializable(typeof(SetCPUThrottlingRateResult), TypeInfoPropertyName = "SetCPUThrottlingRateResult")]
[JsonSerializable(typeof(SetDefaultBackgroundColorOverrideCommandParameters), TypeInfoPropertyName = "SetDefaultBackgroundColorOverrideCommandParameters")]
[JsonSerializable(typeof(SetDefaultBackgroundColorOverrideResult), TypeInfoPropertyName = "SetDefaultBackgroundColorOverrideResult")]
[JsonSerializable(typeof(SetSafeAreaInsetsOverrideCommandParameters), TypeInfoPropertyName = "SetSafeAreaInsetsOverrideCommandParameters")]
[JsonSerializable(typeof(SetSafeAreaInsetsOverrideResult), TypeInfoPropertyName = "SetSafeAreaInsetsOverrideResult")]
[JsonSerializable(typeof(SetDeviceMetricsOverrideCommandParameters), TypeInfoPropertyName = "SetDeviceMetricsOverrideCommandParameters")]
[JsonSerializable(typeof(SetDeviceMetricsOverrideResult), TypeInfoPropertyName = "SetDeviceMetricsOverrideResult")]
[JsonSerializable(typeof(SetDevicePostureOverrideCommandParameters), TypeInfoPropertyName = "SetDevicePostureOverrideCommandParameters")]
[JsonSerializable(typeof(SetDevicePostureOverrideResult), TypeInfoPropertyName = "SetDevicePostureOverrideResult")]
[JsonSerializable(typeof(ClearDevicePostureOverrideCommandParameters), TypeInfoPropertyName = "ClearDevicePostureOverrideCommandParameters")]
[JsonSerializable(typeof(ClearDevicePostureOverrideResult), TypeInfoPropertyName = "ClearDevicePostureOverrideResult")]
[JsonSerializable(typeof(SetDisplayFeaturesOverrideCommandParameters), TypeInfoPropertyName = "SetDisplayFeaturesOverrideCommandParameters")]
[JsonSerializable(typeof(SetDisplayFeaturesOverrideResult), TypeInfoPropertyName = "SetDisplayFeaturesOverrideResult")]
[JsonSerializable(typeof(ClearDisplayFeaturesOverrideCommandParameters), TypeInfoPropertyName = "ClearDisplayFeaturesOverrideCommandParameters")]
[JsonSerializable(typeof(ClearDisplayFeaturesOverrideResult), TypeInfoPropertyName = "ClearDisplayFeaturesOverrideResult")]
[JsonSerializable(typeof(SetScrollbarsHiddenCommandParameters), TypeInfoPropertyName = "SetScrollbarsHiddenCommandParameters")]
[JsonSerializable(typeof(SetScrollbarsHiddenResult), TypeInfoPropertyName = "SetScrollbarsHiddenResult")]
[JsonSerializable(typeof(SetDocumentCookieDisabledCommandParameters), TypeInfoPropertyName = "SetDocumentCookieDisabledCommandParameters")]
[JsonSerializable(typeof(SetDocumentCookieDisabledResult), TypeInfoPropertyName = "SetDocumentCookieDisabledResult")]
[JsonSerializable(typeof(SetEmitTouchEventsForMouseCommandParameters), TypeInfoPropertyName = "SetEmitTouchEventsForMouseCommandParameters")]
[JsonSerializable(typeof(SetEmitTouchEventsForMouseResult), TypeInfoPropertyName = "SetEmitTouchEventsForMouseResult")]
[JsonSerializable(typeof(SetEmulatedMediaCommandParameters), TypeInfoPropertyName = "SetEmulatedMediaCommandParameters")]
[JsonSerializable(typeof(SetEmulatedMediaResult), TypeInfoPropertyName = "SetEmulatedMediaResult")]
[JsonSerializable(typeof(SetEmulatedVisionDeficiencyCommandParameters), TypeInfoPropertyName = "SetEmulatedVisionDeficiencyCommandParameters")]
[JsonSerializable(typeof(SetEmulatedVisionDeficiencyResult), TypeInfoPropertyName = "SetEmulatedVisionDeficiencyResult")]
[JsonSerializable(typeof(SetEmulatedOSTextScaleCommandParameters), TypeInfoPropertyName = "SetEmulatedOSTextScaleCommandParameters")]
[JsonSerializable(typeof(SetEmulatedOSTextScaleResult), TypeInfoPropertyName = "SetEmulatedOSTextScaleResult")]
[JsonSerializable(typeof(SetGeolocationOverrideCommandParameters), TypeInfoPropertyName = "SetGeolocationOverrideCommandParameters")]
[JsonSerializable(typeof(SetGeolocationOverrideResult), TypeInfoPropertyName = "SetGeolocationOverrideResult")]
[JsonSerializable(typeof(GetOverriddenSensorInformationCommandParameters), TypeInfoPropertyName = "GetOverriddenSensorInformationCommandParameters")]
[JsonSerializable(typeof(GetOverriddenSensorInformationResult), TypeInfoPropertyName = "GetOverriddenSensorInformationResult")]
[JsonSerializable(typeof(SetSensorOverrideEnabledCommandParameters), TypeInfoPropertyName = "SetSensorOverrideEnabledCommandParameters")]
[JsonSerializable(typeof(SetSensorOverrideEnabledResult), TypeInfoPropertyName = "SetSensorOverrideEnabledResult")]
[JsonSerializable(typeof(SetSensorOverrideReadingsCommandParameters), TypeInfoPropertyName = "SetSensorOverrideReadingsCommandParameters")]
[JsonSerializable(typeof(SetSensorOverrideReadingsResult), TypeInfoPropertyName = "SetSensorOverrideReadingsResult")]
[JsonSerializable(typeof(SetPressureSourceOverrideEnabledCommandParameters), TypeInfoPropertyName = "SetPressureSourceOverrideEnabledCommandParameters")]
[JsonSerializable(typeof(SetPressureSourceOverrideEnabledResult), TypeInfoPropertyName = "SetPressureSourceOverrideEnabledResult")]
[JsonSerializable(typeof(SetPressureStateOverrideCommandParameters), TypeInfoPropertyName = "SetPressureStateOverrideCommandParameters")]
[JsonSerializable(typeof(SetPressureStateOverrideResult), TypeInfoPropertyName = "SetPressureStateOverrideResult")]
[JsonSerializable(typeof(SetIdleOverrideCommandParameters), TypeInfoPropertyName = "SetIdleOverrideCommandParameters")]
[JsonSerializable(typeof(SetIdleOverrideResult), TypeInfoPropertyName = "SetIdleOverrideResult")]
[JsonSerializable(typeof(ClearIdleOverrideCommandParameters), TypeInfoPropertyName = "ClearIdleOverrideCommandParameters")]
[JsonSerializable(typeof(ClearIdleOverrideResult), TypeInfoPropertyName = "ClearIdleOverrideResult")]
[JsonSerializable(typeof(SetNavigatorOverridesCommandParameters), TypeInfoPropertyName = "SetNavigatorOverridesCommandParameters")]
[JsonSerializable(typeof(SetNavigatorOverridesResult), TypeInfoPropertyName = "SetNavigatorOverridesResult")]
[JsonSerializable(typeof(SetPageScaleFactorCommandParameters), TypeInfoPropertyName = "SetPageScaleFactorCommandParameters")]
[JsonSerializable(typeof(SetPageScaleFactorResult), TypeInfoPropertyName = "SetPageScaleFactorResult")]
[JsonSerializable(typeof(SetScriptExecutionDisabledCommandParameters), TypeInfoPropertyName = "SetScriptExecutionDisabledCommandParameters")]
[JsonSerializable(typeof(SetScriptExecutionDisabledResult), TypeInfoPropertyName = "SetScriptExecutionDisabledResult")]
[JsonSerializable(typeof(SetTouchEmulationEnabledCommandParameters), TypeInfoPropertyName = "SetTouchEmulationEnabledCommandParameters")]
[JsonSerializable(typeof(SetTouchEmulationEnabledResult), TypeInfoPropertyName = "SetTouchEmulationEnabledResult")]
[JsonSerializable(typeof(SetVirtualTimePolicyCommandParameters), TypeInfoPropertyName = "SetVirtualTimePolicyCommandParameters")]
[JsonSerializable(typeof(SetVirtualTimePolicyResult), TypeInfoPropertyName = "SetVirtualTimePolicyResult")]
[JsonSerializable(typeof(SetLocaleOverrideCommandParameters), TypeInfoPropertyName = "SetLocaleOverrideCommandParameters")]
[JsonSerializable(typeof(SetLocaleOverrideResult), TypeInfoPropertyName = "SetLocaleOverrideResult")]
[JsonSerializable(typeof(SetTimezoneOverrideCommandParameters), TypeInfoPropertyName = "SetTimezoneOverrideCommandParameters")]
[JsonSerializable(typeof(SetTimezoneOverrideResult), TypeInfoPropertyName = "SetTimezoneOverrideResult")]
[JsonSerializable(typeof(SetVisibleSizeCommandParameters), TypeInfoPropertyName = "SetVisibleSizeCommandParameters")]
[JsonSerializable(typeof(SetVisibleSizeResult), TypeInfoPropertyName = "SetVisibleSizeResult")]
[JsonSerializable(typeof(SetDisabledImageTypesCommandParameters), TypeInfoPropertyName = "SetDisabledImageTypesCommandParameters")]
[JsonSerializable(typeof(SetDisabledImageTypesResult), TypeInfoPropertyName = "SetDisabledImageTypesResult")]
[JsonSerializable(typeof(SetDataSaverOverrideCommandParameters), TypeInfoPropertyName = "SetDataSaverOverrideCommandParameters")]
[JsonSerializable(typeof(SetDataSaverOverrideResult), TypeInfoPropertyName = "SetDataSaverOverrideResult")]
[JsonSerializable(typeof(SetHardwareConcurrencyOverrideCommandParameters), TypeInfoPropertyName = "SetHardwareConcurrencyOverrideCommandParameters")]
[JsonSerializable(typeof(SetHardwareConcurrencyOverrideResult), TypeInfoPropertyName = "SetHardwareConcurrencyOverrideResult")]
[JsonSerializable(typeof(SetUserAgentOverrideCommandParameters), TypeInfoPropertyName = "SetUserAgentOverrideCommandParameters")]
[JsonSerializable(typeof(SetUserAgentOverrideResult), TypeInfoPropertyName = "SetUserAgentOverrideResult")]
[JsonSerializable(typeof(SetAutomationOverrideCommandParameters), TypeInfoPropertyName = "SetAutomationOverrideCommandParameters")]
[JsonSerializable(typeof(SetAutomationOverrideResult), TypeInfoPropertyName = "SetAutomationOverrideResult")]
[JsonSerializable(typeof(SetSmallViewportHeightDifferenceOverrideCommandParameters), TypeInfoPropertyName = "SetSmallViewportHeightDifferenceOverrideCommandParameters")]
[JsonSerializable(typeof(SetSmallViewportHeightDifferenceOverrideResult), TypeInfoPropertyName = "SetSmallViewportHeightDifferenceOverrideResult")]
[JsonSerializable(typeof(GetScreenInfosCommandParameters), TypeInfoPropertyName = "GetScreenInfosCommandParameters")]
[JsonSerializable(typeof(GetScreenInfosResult), TypeInfoPropertyName = "GetScreenInfosResult")]
[JsonSerializable(typeof(AddScreenCommandParameters), TypeInfoPropertyName = "AddScreenCommandParameters")]
[JsonSerializable(typeof(AddScreenResult), TypeInfoPropertyName = "AddScreenResult")]
[JsonSerializable(typeof(UpdateScreenCommandParameters), TypeInfoPropertyName = "UpdateScreenCommandParameters")]
[JsonSerializable(typeof(UpdateScreenResult), TypeInfoPropertyName = "UpdateScreenResult")]
[JsonSerializable(typeof(RemoveScreenCommandParameters), TypeInfoPropertyName = "RemoveScreenCommandParameters")]
[JsonSerializable(typeof(RemoveScreenResult), TypeInfoPropertyName = "RemoveScreenResult")]
[JsonSerializable(typeof(SetPrimaryScreenCommandParameters), TypeInfoPropertyName = "SetPrimaryScreenCommandParameters")]
[JsonSerializable(typeof(SetPrimaryScreenResult), TypeInfoPropertyName = "SetPrimaryScreenResult")]
[JsonSerializable(typeof(CdpEventArgs<VirtualTimeBudgetExpiredEventArgs>), TypeInfoPropertyName = "VirtualTimeBudgetExpiredCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ScreenOrientationLockChangedEventArgs>), TypeInfoPropertyName = "ScreenOrientationLockChangedCdpEventArgs")]
[JsonSerializable(typeof(SafeAreaInsets), TypeInfoPropertyName = "EmulationSafeAreaInsets")]
[JsonSerializable(typeof(ScreenOrientation), TypeInfoPropertyName = "EmulationScreenOrientation")]
[JsonSerializable(typeof(DisplayFeature), TypeInfoPropertyName = "EmulationDisplayFeature")]
[JsonSerializable(typeof(DevicePosture), TypeInfoPropertyName = "EmulationDevicePosture")]
[JsonSerializable(typeof(MediaFeature), TypeInfoPropertyName = "EmulationMediaFeature")]
[JsonSerializable(typeof(VirtualTimePolicy), TypeInfoPropertyName = "EmulationVirtualTimePolicy")]
[JsonSerializable(typeof(UserAgentBrandVersion), TypeInfoPropertyName = "EmulationUserAgentBrandVersion")]
[JsonSerializable(typeof(UserAgentMetadata), TypeInfoPropertyName = "EmulationUserAgentMetadata")]
[JsonSerializable(typeof(SensorType), TypeInfoPropertyName = "EmulationSensorType")]
[JsonSerializable(typeof(SensorMetadata), TypeInfoPropertyName = "EmulationSensorMetadata")]
[JsonSerializable(typeof(SensorReadingSingle), TypeInfoPropertyName = "EmulationSensorReadingSingle")]
[JsonSerializable(typeof(SensorReadingXYZ), TypeInfoPropertyName = "EmulationSensorReadingXYZ")]
[JsonSerializable(typeof(SensorReadingQuaternion), TypeInfoPropertyName = "EmulationSensorReadingQuaternion")]
[JsonSerializable(typeof(SensorReading), TypeInfoPropertyName = "EmulationSensorReading")]
[JsonSerializable(typeof(PressureSource), TypeInfoPropertyName = "EmulationPressureSource")]
[JsonSerializable(typeof(PressureState), TypeInfoPropertyName = "EmulationPressureState")]
[JsonSerializable(typeof(PressureMetadata), TypeInfoPropertyName = "EmulationPressureMetadata")]
[JsonSerializable(typeof(WorkAreaInsets), TypeInfoPropertyName = "EmulationWorkAreaInsets")]
[JsonSerializable(typeof(ScreenId), TypeInfoPropertyName = "EmulationScreenId")]
[JsonSerializable(typeof(ScreenInfo), TypeInfoPropertyName = "EmulationScreenInfo")]
[JsonSerializable(typeof(DisabledImageType), TypeInfoPropertyName = "EmulationDisabledImageType")]
[JsonSerializable(typeof(ImmutableArray<DisplayFeature>), TypeInfoPropertyName = "ImmutableArrayEmulationDisplayFeature")]
[JsonSerializable(typeof(ImmutableArray<MediaFeature>), TypeInfoPropertyName = "ImmutableArrayEmulationMediaFeature")]
[JsonSerializable(typeof(ImmutableArray<DisabledImageType>), TypeInfoPropertyName = "ImmutableArrayEmulationDisabledImageType")]
[JsonSerializable(typeof(ImmutableArray<ScreenInfo>), TypeInfoPropertyName = "ImmutableArrayEmulationScreenInfo")]
[JsonSerializable(typeof(ImmutableArray<UserAgentBrandVersion>), TypeInfoPropertyName = "ImmutableArrayEmulationUserAgentBrandVersion")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class EmulationJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="EmulationDomain"/>.
/// </summary>
public static class EmulationDomainEvent
{
    /// <summary>
    /// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<VirtualTimeBudgetExpiredEventArgs>> VirtualTimeBudgetExpired { get; } =
        EventDescriptor<CdpEventArgs<VirtualTimeBudgetExpiredEventArgs>>.Create(
            "goog:cdp.Emulation.virtualTimeBudgetExpired",
            EmulationJsonSerializerContext.Default.VirtualTimeBudgetExpiredCdpEventArgs);

    /// <summary>
    /// Fired when a page calls screen.orientation.lock() or screen.orientation.unlock()
    /// while device emulation is enabled. This allows the DevTools frontend to update the
    /// emulated device orientation accordingly.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScreenOrientationLockChangedEventArgs>> ScreenOrientationLockChanged { get; } =
        EventDescriptor<CdpEventArgs<ScreenOrientationLockChangedEventArgs>>.Create(
            "goog:cdp.Emulation.screenOrientationLockChanged",
            EmulationJsonSerializerContext.Default.ScreenOrientationLockChangedCdpEventArgs);

}
