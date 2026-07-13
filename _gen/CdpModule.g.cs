#nullable enable
#pragma warning disable CS0612

namespace Selenium.WebDriver.BiDi.Cdp;

partial class CdpModule
{
#pragma warning disable BIDICDP001
    private Console.ConsoleDomain? _console;

    /// <summary>
    /// This domain is deprecated - use Runtime or Log instead.
    /// </summary>
    [global::System.Obsolete]
    public Console.ConsoleDomain Console => _console ?? global::System.Threading.Interlocked.CompareExchange(ref _console, new(this), null) ?? _console;

    private Debugger.DebuggerDomain? _debugger;

    /// <summary>
    /// Debugger domain exposes JavaScript debugging capabilities. It allows setting and removing
    /// breakpoints, stepping through execution, exploring stack traces, etc.
    /// </summary>
    public Debugger.DebuggerDomain Debugger => _debugger ?? global::System.Threading.Interlocked.CompareExchange(ref _debugger, new(this), null) ?? _debugger;

    private HeapProfiler.HeapProfilerDomain? _heapProfiler;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public HeapProfiler.HeapProfilerDomain HeapProfiler => _heapProfiler ?? global::System.Threading.Interlocked.CompareExchange(ref _heapProfiler, new(this), null) ?? _heapProfiler;

    private Profiler.ProfilerDomain? _profiler;

    /// <summary>
    /// </summary>
    public Profiler.ProfilerDomain Profiler => _profiler ?? global::System.Threading.Interlocked.CompareExchange(ref _profiler, new(this), null) ?? _profiler;

    private Runtime.RuntimeDomain? _runtime;

    /// <summary>
    /// Runtime domain exposes JavaScript runtime by means of remote evaluation and mirror objects.
    /// Evaluation results are returned as mirror object that expose object type, string representation
    /// and unique identifier that can be used for further object reference. Original objects are
    /// maintained in memory unless they are either explicitly released or are released along with the
    /// other objects in their object group.
    /// </summary>
    public Runtime.RuntimeDomain Runtime => _runtime ?? global::System.Threading.Interlocked.CompareExchange(ref _runtime, new(this), null) ?? _runtime;

    private Schema.SchemaDomain? _schema;

    /// <summary>
    /// This domain is deprecated.
    /// </summary>
    [global::System.Obsolete]
    public Schema.SchemaDomain Schema => _schema ?? global::System.Threading.Interlocked.CompareExchange(ref _schema, new(this), null) ?? _schema;

    private Accessibility.AccessibilityDomain? _accessibility;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Accessibility.AccessibilityDomain Accessibility => _accessibility ?? global::System.Threading.Interlocked.CompareExchange(ref _accessibility, new(this), null) ?? _accessibility;

    private Ads.AdsDomain? _ads;

    /// <summary>
    /// A domain for ad-related metrics and data.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Ads.AdsDomain Ads => _ads ?? global::System.Threading.Interlocked.CompareExchange(ref _ads, new(this), null) ?? _ads;

    private Animation.AnimationDomain? _animation;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Animation.AnimationDomain Animation => _animation ?? global::System.Threading.Interlocked.CompareExchange(ref _animation, new(this), null) ?? _animation;

    private Audits.AuditsDomain? _audits;

    /// <summary>
    /// Audits domain allows investigation of page violations and possible improvements.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Audits.AuditsDomain Audits => _audits ?? global::System.Threading.Interlocked.CompareExchange(ref _audits, new(this), null) ?? _audits;

    private Autofill.AutofillDomain? _autofill;

    /// <summary>
    /// Defines commands and events for Autofill.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Autofill.AutofillDomain Autofill => _autofill ?? global::System.Threading.Interlocked.CompareExchange(ref _autofill, new(this), null) ?? _autofill;

    private BackgroundService.BackgroundServiceDomain? _backgroundService;

    /// <summary>
    /// Defines events for background web platform features.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public BackgroundService.BackgroundServiceDomain BackgroundService => _backgroundService ?? global::System.Threading.Interlocked.CompareExchange(ref _backgroundService, new(this), null) ?? _backgroundService;

    private BluetoothEmulation.BluetoothEmulationDomain? _bluetoothEmulation;

    /// <summary>
    /// This domain allows configuring virtual Bluetooth devices to test
    /// the web-bluetooth API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public BluetoothEmulation.BluetoothEmulationDomain BluetoothEmulation => _bluetoothEmulation ?? global::System.Threading.Interlocked.CompareExchange(ref _bluetoothEmulation, new(this), null) ?? _bluetoothEmulation;

    private Browser.BrowserDomain? _browser;

    /// <summary>
    /// The Browser domain defines methods and events for browser managing.
    /// </summary>
    public Browser.BrowserDomain Browser => _browser ?? global::System.Threading.Interlocked.CompareExchange(ref _browser, new(this), null) ?? _browser;

    private CSS.CSSDomain? _cSS;

    /// <summary>
    /// This domain exposes CSS read/write operations. All CSS objects (stylesheets, rules, and styles)
    /// have an associated <b>id</b> used in subsequent operations on the related object. Each object type has
    /// a specific <b>id</b> structure, and those are not interchangeable between objects of different kinds.
    /// CSS objects can be loaded using the <b>get*ForNode()</b> calls (which accept a DOM node id). A client
    /// can also keep track of stylesheets via the <b>styleSheetAdded</b>/<b>styleSheetRemoved</b> events and
    /// subsequently load the required stylesheet contents using the <b>getStyleSheet[Text]()</b> methods.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CSS.CSSDomain CSS => _cSS ?? global::System.Threading.Interlocked.CompareExchange(ref _cSS, new(this), null) ?? _cSS;

    private CacheStorage.CacheStorageDomain? _cacheStorage;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CacheStorage.CacheStorageDomain CacheStorage => _cacheStorage ?? global::System.Threading.Interlocked.CompareExchange(ref _cacheStorage, new(this), null) ?? _cacheStorage;

    private Cast.CastDomain? _cast;

    /// <summary>
    /// A domain for interacting with Cast, Presentation API, and Remote Playback API
    /// functionalities.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Cast.CastDomain Cast => _cast ?? global::System.Threading.Interlocked.CompareExchange(ref _cast, new(this), null) ?? _cast;

    private CrashReportContext.CrashReportContextDomain? _crashReportContext;

    /// <summary>
    /// This domain exposes the current state of the CrashReportContext API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CrashReportContext.CrashReportContextDomain CrashReportContext => _crashReportContext ?? global::System.Threading.Interlocked.CompareExchange(ref _crashReportContext, new(this), null) ?? _crashReportContext;

    private DOM.DOMDomain? _dOM;

    /// <summary>
    /// This domain exposes DOM read/write operations. Each DOM Node is represented with its mirror object
    /// that has an <b>id</b>. This <b>id</b> can be used to get additional information on the Node, resolve it into
    /// the JavaScript object wrapper, etc. It is important that client receives DOM events only for the
    /// nodes that are known to the client. Backend keeps track of the nodes that were sent to the client
    /// and never sends the same node twice. It is client's responsibility to collect information about
    /// the nodes that were sent to the client. Note that <b>iframe</b> owner elements will return
    /// corresponding document elements as their child nodes.
    /// </summary>
    public DOM.DOMDomain DOM => _dOM ?? global::System.Threading.Interlocked.CompareExchange(ref _dOM, new(this), null) ?? _dOM;

    private DOMDebugger.DOMDebuggerDomain? _dOMDebugger;

    /// <summary>
    /// DOM debugging allows setting breakpoints on particular DOM operations and events. JavaScript
    /// execution will stop on these operations as if there was a regular breakpoint set.
    /// </summary>
    public DOMDebugger.DOMDebuggerDomain DOMDebugger => _dOMDebugger ?? global::System.Threading.Interlocked.CompareExchange(ref _dOMDebugger, new(this), null) ?? _dOMDebugger;

    private DOMSnapshot.DOMSnapshotDomain? _dOMSnapshot;

    /// <summary>
    /// This domain facilitates obtaining document snapshots with DOM, layout, and style information.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DOMSnapshot.DOMSnapshotDomain DOMSnapshot => _dOMSnapshot ?? global::System.Threading.Interlocked.CompareExchange(ref _dOMSnapshot, new(this), null) ?? _dOMSnapshot;

    private DOMStorage.DOMStorageDomain? _dOMStorage;

    /// <summary>
    /// Query and modify DOM storage.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DOMStorage.DOMStorageDomain DOMStorage => _dOMStorage ?? global::System.Threading.Interlocked.CompareExchange(ref _dOMStorage, new(this), null) ?? _dOMStorage;

    private DeviceAccess.DeviceAccessDomain? _deviceAccess;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DeviceAccess.DeviceAccessDomain DeviceAccess => _deviceAccess ?? global::System.Threading.Interlocked.CompareExchange(ref _deviceAccess, new(this), null) ?? _deviceAccess;

    private DeviceOrientation.DeviceOrientationDomain? _deviceOrientation;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DeviceOrientation.DeviceOrientationDomain DeviceOrientation => _deviceOrientation ?? global::System.Threading.Interlocked.CompareExchange(ref _deviceOrientation, new(this), null) ?? _deviceOrientation;

    private DigitalCredentials.DigitalCredentialsDomain? _digitalCredentials;

    /// <summary>
    /// This domain allows interacting with the Digital Credentials API for automation.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DigitalCredentials.DigitalCredentialsDomain DigitalCredentials => _digitalCredentials ?? global::System.Threading.Interlocked.CompareExchange(ref _digitalCredentials, new(this), null) ?? _digitalCredentials;

    private Emulation.EmulationDomain? _emulation;

    /// <summary>
    /// This domain emulates different environments for the page.
    /// </summary>
    public Emulation.EmulationDomain Emulation => _emulation ?? global::System.Threading.Interlocked.CompareExchange(ref _emulation, new(this), null) ?? _emulation;

    private EventBreakpoints.EventBreakpointsDomain? _eventBreakpoints;

    /// <summary>
    /// EventBreakpoints permits setting JavaScript breakpoints on operations and events
    /// occurring in native code invoked from JavaScript. Once breakpoint is hit, it is
    /// reported through Debugger domain, similarly to regular breakpoints being hit.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public EventBreakpoints.EventBreakpointsDomain EventBreakpoints => _eventBreakpoints ?? global::System.Threading.Interlocked.CompareExchange(ref _eventBreakpoints, new(this), null) ?? _eventBreakpoints;

    private Extensions.ExtensionsDomain? _extensions;

    /// <summary>
    /// Defines commands and events for browser extensions.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Extensions.ExtensionsDomain Extensions => _extensions ?? global::System.Threading.Interlocked.CompareExchange(ref _extensions, new(this), null) ?? _extensions;

    private FedCm.FedCmDomain? _fedCm;

    /// <summary>
    /// This domain allows interacting with the FedCM dialog.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public FedCm.FedCmDomain FedCm => _fedCm ?? global::System.Threading.Interlocked.CompareExchange(ref _fedCm, new(this), null) ?? _fedCm;

    private Fetch.FetchDomain? _fetch;

    /// <summary>
    /// A domain for letting clients substitute browser's network layer with client code.
    /// </summary>
    public Fetch.FetchDomain Fetch => _fetch ?? global::System.Threading.Interlocked.CompareExchange(ref _fetch, new(this), null) ?? _fetch;

    private FileSystem.FileSystemDomain? _fileSystem;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public FileSystem.FileSystemDomain FileSystem => _fileSystem ?? global::System.Threading.Interlocked.CompareExchange(ref _fileSystem, new(this), null) ?? _fileSystem;

    private HeadlessExperimental.HeadlessExperimentalDomain? _headlessExperimental;

    /// <summary>
    /// This domain provides experimental commands only supported in headless mode.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public HeadlessExperimental.HeadlessExperimentalDomain HeadlessExperimental => _headlessExperimental ?? global::System.Threading.Interlocked.CompareExchange(ref _headlessExperimental, new(this), null) ?? _headlessExperimental;

    private IO.IODomain? _iO;

    /// <summary>
    /// Input/Output operations for streams produced by DevTools.
    /// </summary>
    public IO.IODomain IO => _iO ?? global::System.Threading.Interlocked.CompareExchange(ref _iO, new(this), null) ?? _iO;

    private IndexedDB.IndexedDBDomain? _indexedDB;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IndexedDB.IndexedDBDomain IndexedDB => _indexedDB ?? global::System.Threading.Interlocked.CompareExchange(ref _indexedDB, new(this), null) ?? _indexedDB;

    private Input.InputDomain? _input;

    /// <summary>
    /// </summary>
    public Input.InputDomain Input => _input ?? global::System.Threading.Interlocked.CompareExchange(ref _input, new(this), null) ?? _input;

    private Inspector.InspectorDomain? _inspector;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Inspector.InspectorDomain Inspector => _inspector ?? global::System.Threading.Interlocked.CompareExchange(ref _inspector, new(this), null) ?? _inspector;

    private LayerTree.LayerTreeDomain? _layerTree;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public LayerTree.LayerTreeDomain LayerTree => _layerTree ?? global::System.Threading.Interlocked.CompareExchange(ref _layerTree, new(this), null) ?? _layerTree;

    private Log.LogDomain? _log;

    /// <summary>
    /// Provides access to log entries.
    /// </summary>
    public Log.LogDomain Log => _log ?? global::System.Threading.Interlocked.CompareExchange(ref _log, new(this), null) ?? _log;

    private Media.MediaDomain? _media;

    /// <summary>
    /// This domain allows detailed inspection of media elements.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Media.MediaDomain Media => _media ?? global::System.Threading.Interlocked.CompareExchange(ref _media, new(this), null) ?? _media;

    private Memory.MemoryDomain? _memory;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Memory.MemoryDomain Memory => _memory ?? global::System.Threading.Interlocked.CompareExchange(ref _memory, new(this), null) ?? _memory;

    private Network.NetworkDomain? _network;

    /// <summary>
    /// Network domain allows tracking network activities of the page. It exposes information about http,
    /// file, data and other requests and responses, their headers, bodies, timing, etc.
    /// </summary>
    public Network.NetworkDomain Network => _network ?? global::System.Threading.Interlocked.CompareExchange(ref _network, new(this), null) ?? _network;

    private Overlay.OverlayDomain? _overlay;

    /// <summary>
    /// This domain provides various functionality related to drawing atop the inspected page.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Overlay.OverlayDomain Overlay => _overlay ?? global::System.Threading.Interlocked.CompareExchange(ref _overlay, new(this), null) ?? _overlay;

    private PWA.PWADomain? _pWA;

    /// <summary>
    /// This domain allows interacting with the browser to control PWAs.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public PWA.PWADomain PWA => _pWA ?? global::System.Threading.Interlocked.CompareExchange(ref _pWA, new(this), null) ?? _pWA;

    private Page.PageDomain? _page;

    /// <summary>
    /// Actions and events related to the inspected page belong to the page domain.
    /// </summary>
    public Page.PageDomain Page => _page ?? global::System.Threading.Interlocked.CompareExchange(ref _page, new(this), null) ?? _page;

    private Performance.PerformanceDomain? _performance;

    /// <summary>
    /// </summary>
    public Performance.PerformanceDomain Performance => _performance ?? global::System.Threading.Interlocked.CompareExchange(ref _performance, new(this), null) ?? _performance;

    private PerformanceTimeline.PerformanceTimelineDomain? _performanceTimeline;

    /// <summary>
    /// Reporting of performance timeline events, as specified in
    /// https://w3c.github.io/performance-timeline/#dom-performanceobserver.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public PerformanceTimeline.PerformanceTimelineDomain PerformanceTimeline => _performanceTimeline ?? global::System.Threading.Interlocked.CompareExchange(ref _performanceTimeline, new(this), null) ?? _performanceTimeline;

    private Preload.PreloadDomain? _preload;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Preload.PreloadDomain Preload => _preload ?? global::System.Threading.Interlocked.CompareExchange(ref _preload, new(this), null) ?? _preload;

    private Security.SecurityDomain? _security;

    /// <summary>
    /// </summary>
    public Security.SecurityDomain Security => _security ?? global::System.Threading.Interlocked.CompareExchange(ref _security, new(this), null) ?? _security;

    private ServiceWorker.ServiceWorkerDomain? _serviceWorker;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public ServiceWorker.ServiceWorkerDomain ServiceWorker => _serviceWorker ?? global::System.Threading.Interlocked.CompareExchange(ref _serviceWorker, new(this), null) ?? _serviceWorker;

    private SmartCardEmulation.SmartCardEmulationDomain? _smartCardEmulation;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public SmartCardEmulation.SmartCardEmulationDomain SmartCardEmulation => _smartCardEmulation ?? global::System.Threading.Interlocked.CompareExchange(ref _smartCardEmulation, new(this), null) ?? _smartCardEmulation;

    private Storage.StorageDomain? _storage;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Storage.StorageDomain Storage => _storage ?? global::System.Threading.Interlocked.CompareExchange(ref _storage, new(this), null) ?? _storage;

    private SystemInfo.SystemInfoDomain? _systemInfo;

    /// <summary>
    /// The SystemInfo domain defines methods and events for querying low-level system information.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public SystemInfo.SystemInfoDomain SystemInfo => _systemInfo ?? global::System.Threading.Interlocked.CompareExchange(ref _systemInfo, new(this), null) ?? _systemInfo;

    private Target.TargetDomain? _target;

    /// <summary>
    /// Supports additional targets discovery and allows to attach to them.
    /// </summary>
    public Target.TargetDomain Target => _target ?? global::System.Threading.Interlocked.CompareExchange(ref _target, new(this), null) ?? _target;

    private Tethering.TetheringDomain? _tethering;

    /// <summary>
    /// The Tethering domain defines methods and events for browser port binding.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Tethering.TetheringDomain Tethering => _tethering ?? global::System.Threading.Interlocked.CompareExchange(ref _tethering, new(this), null) ?? _tethering;

    private Tracing.TracingDomain? _tracing;

    /// <summary>
    /// </summary>
    public Tracing.TracingDomain Tracing => _tracing ?? global::System.Threading.Interlocked.CompareExchange(ref _tracing, new(this), null) ?? _tracing;

    private WebAudio.WebAudioDomain? _webAudio;

    /// <summary>
    /// This domain allows inspection of Web Audio API.
    /// https://webaudio.github.io/web-audio-api/
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebAudio.WebAudioDomain WebAudio => _webAudio ?? global::System.Threading.Interlocked.CompareExchange(ref _webAudio, new(this), null) ?? _webAudio;

    private WebAuthn.WebAuthnDomain? _webAuthn;

    /// <summary>
    /// This domain allows configuring virtual authenticators to test the WebAuthn
    /// API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebAuthn.WebAuthnDomain WebAuthn => _webAuthn ?? global::System.Threading.Interlocked.CompareExchange(ref _webAuthn, new(this), null) ?? _webAuthn;

    private WebMCP.WebMCPDomain? _webMCP;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebMCP.WebMCPDomain WebMCP => _webMCP ?? global::System.Threading.Interlocked.CompareExchange(ref _webMCP, new(this), null) ?? _webMCP;

#pragma warning restore BIDICDP001
#pragma warning restore CS0612
}
