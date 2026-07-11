namespace Selenium.WebDriver.BiDi.Cdp;

partial class CdpModule
{
    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Accessibility.AccessibilityDomain Accessibility => new(this);

    /// <summary>
    /// A domain for ad-related metrics and data.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Ads.AdsDomain Ads => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Animation.AnimationDomain Animation => new(this);

    /// <summary>
    /// Audits domain allows investigation of page violations and possible improvements.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Audits.AuditsDomain Audits => new(this);

    /// <summary>
    /// Defines commands and events for Autofill.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Autofill.AutofillDomain Autofill => new(this);

    /// <summary>
    /// Defines events for background web platform features.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public BackgroundService.BackgroundServiceDomain BackgroundService => new(this);

    /// <summary>
    /// This domain allows configuring virtual Bluetooth devices to test
    /// the web-bluetooth API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public BluetoothEmulation.BluetoothEmulationDomain BluetoothEmulation => new(this);

    /// <summary>
    /// The Browser domain defines methods and events for browser managing.
    /// </summary>
    public Browser.BrowserDomain Browser => new(this);

    /// <summary>
    /// This domain exposes CSS read/write operations. All CSS objects (stylesheets, rules, and styles)
    /// have an associated <b>id</b> used in subsequent operations on the related object. Each object type has
    /// a specific <b>id</b> structure, and those are not interchangeable between objects of different kinds.
    /// CSS objects can be loaded using the <b>get*ForNode()</b> calls (which accept a DOM node id). A client
    /// can also keep track of stylesheets via the <b>styleSheetAdded</b>/<b>styleSheetRemoved</b> events and
    /// subsequently load the required stylesheet contents using the <b>getStyleSheet[Text]()</b> methods.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CSS.CSSDomain CSS => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CacheStorage.CacheStorageDomain CacheStorage => new(this);

    /// <summary>
    /// A domain for interacting with Cast, Presentation API, and Remote Playback API
    /// functionalities.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Cast.CastDomain Cast => new(this);

    /// <summary>
    /// This domain exposes the current state of the CrashReportContext API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CrashReportContext.CrashReportContextDomain CrashReportContext => new(this);

    /// <summary>
    /// This domain exposes DOM read/write operations. Each DOM Node is represented with its mirror object
    /// that has an <b>id</b>. This <b>id</b> can be used to get additional information on the Node, resolve it into
    /// the JavaScript object wrapper, etc. It is important that client receives DOM events only for the
    /// nodes that are known to the client. Backend keeps track of the nodes that were sent to the client
    /// and never sends the same node twice. It is client's responsibility to collect information about
    /// the nodes that were sent to the client. Note that <b>iframe</b> owner elements will return
    /// corresponding document elements as their child nodes.
    /// </summary>
    public DOM.DOMDomain DOM => new(this);

    /// <summary>
    /// DOM debugging allows setting breakpoints on particular DOM operations and events. JavaScript
    /// execution will stop on these operations as if there was a regular breakpoint set.
    /// </summary>
    public DOMDebugger.DOMDebuggerDomain DOMDebugger => new(this);

    /// <summary>
    /// This domain facilitates obtaining document snapshots with DOM, layout, and style information.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DOMSnapshot.DOMSnapshotDomain DOMSnapshot => new(this);

    /// <summary>
    /// Query and modify DOM storage.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DOMStorage.DOMStorageDomain DOMStorage => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DeviceAccess.DeviceAccessDomain DeviceAccess => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DeviceOrientation.DeviceOrientationDomain DeviceOrientation => new(this);

    /// <summary>
    /// This domain allows interacting with the Digital Credentials API for automation.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DigitalCredentials.DigitalCredentialsDomain DigitalCredentials => new(this);

    /// <summary>
    /// This domain emulates different environments for the page.
    /// </summary>
    public Emulation.EmulationDomain Emulation => new(this);

    /// <summary>
    /// EventBreakpoints permits setting JavaScript breakpoints on operations and events
    /// occurring in native code invoked from JavaScript. Once breakpoint is hit, it is
    /// reported through Debugger domain, similarly to regular breakpoints being hit.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public EventBreakpoints.EventBreakpointsDomain EventBreakpoints => new(this);

    /// <summary>
    /// Defines commands and events for browser extensions.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Extensions.ExtensionsDomain Extensions => new(this);

    /// <summary>
    /// This domain allows interacting with the FedCM dialog.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public FedCm.FedCmDomain FedCm => new(this);

    /// <summary>
    /// A domain for letting clients substitute browser's network layer with client code.
    /// </summary>
    public Fetch.FetchDomain Fetch => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public FileSystem.FileSystemDomain FileSystem => new(this);

    /// <summary>
    /// This domain provides experimental commands only supported in headless mode.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public HeadlessExperimental.HeadlessExperimentalDomain HeadlessExperimental => new(this);

    /// <summary>
    /// Input/Output operations for streams produced by DevTools.
    /// </summary>
    public IO.IODomain IO => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IndexedDB.IndexedDBDomain IndexedDB => new(this);

    /// <summary>
    /// </summary>
    public Input.InputDomain Input => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Inspector.InspectorDomain Inspector => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public LayerTree.LayerTreeDomain LayerTree => new(this);

    /// <summary>
    /// Provides access to log entries.
    /// </summary>
    public Log.LogDomain Log => new(this);

    /// <summary>
    /// This domain allows detailed inspection of media elements.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Media.MediaDomain Media => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Memory.MemoryDomain Memory => new(this);

    /// <summary>
    /// Network domain allows tracking network activities of the page. It exposes information about http,
    /// file, data and other requests and responses, their headers, bodies, timing, etc.
    /// </summary>
    public Network.NetworkDomain Network => new(this);

    /// <summary>
    /// This domain provides various functionality related to drawing atop the inspected page.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Overlay.OverlayDomain Overlay => new(this);

    /// <summary>
    /// This domain allows interacting with the browser to control PWAs.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public PWA.PWADomain PWA => new(this);

    /// <summary>
    /// Actions and events related to the inspected page belong to the page domain.
    /// </summary>
    public Page.PageDomain Page => new(this);

    /// <summary>
    /// </summary>
    public Performance.PerformanceDomain Performance => new(this);

    /// <summary>
    /// Reporting of performance timeline events, as specified in
    /// https://w3c.github.io/performance-timeline/#dom-performanceobserver.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public PerformanceTimeline.PerformanceTimelineDomain PerformanceTimeline => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Preload.PreloadDomain Preload => new(this);

    /// <summary>
    /// </summary>
    public Security.SecurityDomain Security => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public ServiceWorker.ServiceWorkerDomain ServiceWorker => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public SmartCardEmulation.SmartCardEmulationDomain SmartCardEmulation => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Storage.StorageDomain Storage => new(this);

    /// <summary>
    /// The SystemInfo domain defines methods and events for querying low-level system information.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public SystemInfo.SystemInfoDomain SystemInfo => new(this);

    /// <summary>
    /// Supports additional targets discovery and allows to attach to them.
    /// </summary>
    public Target.TargetDomain Target => new(this);

    /// <summary>
    /// The Tethering domain defines methods and events for browser port binding.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Tethering.TetheringDomain Tethering => new(this);

    /// <summary>
    /// </summary>
    public Tracing.TracingDomain Tracing => new(this);

    /// <summary>
    /// This domain allows inspection of Web Audio API.
    /// https://webaudio.github.io/web-audio-api/
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebAudio.WebAudioDomain WebAudio => new(this);

    /// <summary>
    /// This domain allows configuring virtual authenticators to test the WebAuthn
    /// API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebAuthn.WebAuthnDomain WebAuthn => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebMCP.WebMCPDomain WebMCP => new(this);

    /// <summary>
    /// This domain is deprecated - use Runtime or Log instead.
    /// </summary>
    [global::System.Obsolete]
    public Console.ConsoleDomain Console => new(this);

    /// <summary>
    /// Debugger domain exposes JavaScript debugging capabilities. It allows setting and removing
    /// breakpoints, stepping through execution, exploring stack traces, etc.
    /// </summary>
    public Debugger.DebuggerDomain Debugger => new(this);

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public HeapProfiler.HeapProfilerDomain HeapProfiler => new(this);

    /// <summary>
    /// </summary>
    public Profiler.ProfilerDomain Profiler => new(this);

    /// <summary>
    /// Runtime domain exposes JavaScript runtime by means of remote evaluation and mirror objects.
    /// Evaluation results are returned as mirror object that expose object type, string representation
    /// and unique identifier that can be used for further object reference. Original objects are
    /// maintained in memory unless they are either explicitly released or are released along with the
    /// other objects in their object group.
    /// </summary>
    public Runtime.RuntimeDomain Runtime => new(this);

    /// <summary>
    /// This domain is deprecated.
    /// </summary>
    [global::System.Obsolete]
    public Schema.SchemaDomain Schema => new(this);

}
