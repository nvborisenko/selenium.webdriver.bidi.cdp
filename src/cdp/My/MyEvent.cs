using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.My;

/// <summary>
/// Event descriptors for custom CDP events.
/// </summary>
public static class MyEvent
{
    /// <summary>
    /// Descriptor for the <c>goog:cdp.Page.lifecycleEvent</c> event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SomethingHappenedEventArgs>> SomethingHappened { get; } =
        EventDescriptor<CdpEventArgs<SomethingHappenedEventArgs>>.Create(
            "goog:cdp.Page.lifecycleEvent",
            MyJsonSerializerContext.Default.SomethingHappenedCdpEventArgs);
}
