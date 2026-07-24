#nullable enable
#pragma warning disable CS0612

namespace Selenium.WebDriver.BiDi.Cdp;

partial class CdpModule
{
#pragma warning disable BIDICDP001
    private Accessibility.IAccessibility? _accessibility;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Accessibility.IAccessibility Accessibility => _accessibility ?? global::System.Threading.Interlocked.CompareExchange(ref _accessibility, new Accessibility.AccessibilityDomain(this), null) ?? _accessibility;

    private Ads.IAds? _ads;

    /// <summary>
    /// A domain for ad-related metrics and data.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Ads.IAds Ads => _ads ?? global::System.Threading.Interlocked.CompareExchange(ref _ads, new Ads.AdsDomain(this), null) ?? _ads;

    private Animation.IAnimation? _animation;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Animation.IAnimation Animation => _animation ?? global::System.Threading.Interlocked.CompareExchange(ref _animation, new Animation.AnimationDomain(this), null) ?? _animation;

    private Audits.IAudits? _audits;

    /// <summary>
    /// Audits domain allows investigation of page violations and possible improvements.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Audits.IAudits Audits => _audits ?? global::System.Threading.Interlocked.CompareExchange(ref _audits, new Audits.AuditsDomain(this), null) ?? _audits;

    private Autofill.IAutofill? _autofill;

    /// <summary>
    /// Defines commands and events for Autofill.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Autofill.IAutofill Autofill => _autofill ?? global::System.Threading.Interlocked.CompareExchange(ref _autofill, new Autofill.AutofillDomain(this), null) ?? _autofill;

    private BackgroundService.IBackgroundService? _backgroundService;

    /// <summary>
    /// Defines events for background web platform features.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public BackgroundService.IBackgroundService BackgroundService => _backgroundService ?? global::System.Threading.Interlocked.CompareExchange(ref _backgroundService, new BackgroundService.BackgroundServiceDomain(this), null) ?? _backgroundService;

    private BluetoothEmulation.IBluetoothEmulation? _bluetoothEmulation;

    /// <summary>
    /// This domain allows configuring virtual Bluetooth devices to test
    /// the web-bluetooth API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public BluetoothEmulation.IBluetoothEmulation BluetoothEmulation => _bluetoothEmulation ?? global::System.Threading.Interlocked.CompareExchange(ref _bluetoothEmulation, new BluetoothEmulation.BluetoothEmulationDomain(this), null) ?? _bluetoothEmulation;

    private Browser.IBrowser? _browser;

    /// <summary>
    /// The Browser domain defines methods and events for browser managing.
    /// </summary>
    public Browser.IBrowser Browser => _browser ?? global::System.Threading.Interlocked.CompareExchange(ref _browser, new Browser.BrowserDomain(this), null) ?? _browser;

    private CSS.ICSS? _cSS;

    /// <summary>
    /// This domain exposes CSS read/write operations. All CSS objects (stylesheets, rules, and styles)
    /// have an associated <b>id</b> used in subsequent operations on the related object. Each object type has
    /// a specific <b>id</b> structure, and those are not interchangeable between objects of different kinds.
    /// CSS objects can be loaded using the <b>get*ForNode()</b> calls (which accept a DOM node id). A client
    /// can also keep track of stylesheets via the <b>styleSheetAdded</b>/<b>styleSheetRemoved</b> events and
    /// subsequently load the required stylesheet contents using the <b>getStyleSheet[Text]()</b> methods.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CSS.ICSS CSS => _cSS ?? global::System.Threading.Interlocked.CompareExchange(ref _cSS, new CSS.CSSDomain(this), null) ?? _cSS;

    private CacheStorage.ICacheStorage? _cacheStorage;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CacheStorage.ICacheStorage CacheStorage => _cacheStorage ?? global::System.Threading.Interlocked.CompareExchange(ref _cacheStorage, new CacheStorage.CacheStorageDomain(this), null) ?? _cacheStorage;

    private Cast.ICast? _cast;

    /// <summary>
    /// A domain for interacting with Cast, Presentation API, and Remote Playback API
    /// functionalities.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Cast.ICast Cast => _cast ?? global::System.Threading.Interlocked.CompareExchange(ref _cast, new Cast.CastDomain(this), null) ?? _cast;

    private CrashReportContext.ICrashReportContext? _crashReportContext;

    /// <summary>
    /// This domain exposes the current state of the CrashReportContext API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public CrashReportContext.ICrashReportContext CrashReportContext => _crashReportContext ?? global::System.Threading.Interlocked.CompareExchange(ref _crashReportContext, new CrashReportContext.CrashReportContextDomain(this), null) ?? _crashReportContext;

    private DOM.IDOM? _dOM;

    /// <summary>
    /// This domain exposes DOM read/write operations. Each DOM Node is represented with its mirror object
    /// that has an <b>id</b>. This <b>id</b> can be used to get additional information on the Node, resolve it into
    /// the JavaScript object wrapper, etc. It is important that client receives DOM events only for the
    /// nodes that are known to the client. Backend keeps track of the nodes that were sent to the client
    /// and never sends the same node twice. It is client's responsibility to collect information about
    /// the nodes that were sent to the client. Note that <b>iframe</b> owner elements will return
    /// corresponding document elements as their child nodes.
    /// </summary>
    public DOM.IDOM DOM => _dOM ?? global::System.Threading.Interlocked.CompareExchange(ref _dOM, new DOM.DOMDomain(this), null) ?? _dOM;

    private DOMDebugger.IDOMDebugger? _dOMDebugger;

    /// <summary>
    /// DOM debugging allows setting breakpoints on particular DOM operations and events. JavaScript
    /// execution will stop on these operations as if there was a regular breakpoint set.
    /// </summary>
    public DOMDebugger.IDOMDebugger DOMDebugger => _dOMDebugger ?? global::System.Threading.Interlocked.CompareExchange(ref _dOMDebugger, new DOMDebugger.DOMDebuggerDomain(this), null) ?? _dOMDebugger;

    private DOMSnapshot.IDOMSnapshot? _dOMSnapshot;

    /// <summary>
    /// This domain facilitates obtaining document snapshots with DOM, layout, and style information.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DOMSnapshot.IDOMSnapshot DOMSnapshot => _dOMSnapshot ?? global::System.Threading.Interlocked.CompareExchange(ref _dOMSnapshot, new DOMSnapshot.DOMSnapshotDomain(this), null) ?? _dOMSnapshot;

    private DOMStorage.IDOMStorage? _dOMStorage;

    /// <summary>
    /// Query and modify DOM storage.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DOMStorage.IDOMStorage DOMStorage => _dOMStorage ?? global::System.Threading.Interlocked.CompareExchange(ref _dOMStorage, new DOMStorage.DOMStorageDomain(this), null) ?? _dOMStorage;

    private DeviceAccess.IDeviceAccess? _deviceAccess;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DeviceAccess.IDeviceAccess DeviceAccess => _deviceAccess ?? global::System.Threading.Interlocked.CompareExchange(ref _deviceAccess, new DeviceAccess.DeviceAccessDomain(this), null) ?? _deviceAccess;

    private DeviceOrientation.IDeviceOrientation? _deviceOrientation;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DeviceOrientation.IDeviceOrientation DeviceOrientation => _deviceOrientation ?? global::System.Threading.Interlocked.CompareExchange(ref _deviceOrientation, new DeviceOrientation.DeviceOrientationDomain(this), null) ?? _deviceOrientation;

    private DigitalCredentials.IDigitalCredentials? _digitalCredentials;

    /// <summary>
    /// This domain allows interacting with the Digital Credentials API for automation.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public DigitalCredentials.IDigitalCredentials DigitalCredentials => _digitalCredentials ?? global::System.Threading.Interlocked.CompareExchange(ref _digitalCredentials, new DigitalCredentials.DigitalCredentialsDomain(this), null) ?? _digitalCredentials;

    private Emulation.IEmulation? _emulation;

    /// <summary>
    /// This domain emulates different environments for the page.
    /// </summary>
    public Emulation.IEmulation Emulation => _emulation ?? global::System.Threading.Interlocked.CompareExchange(ref _emulation, new Emulation.EmulationDomain(this), null) ?? _emulation;

    private EventBreakpoints.IEventBreakpoints? _eventBreakpoints;

    /// <summary>
    /// EventBreakpoints permits setting JavaScript breakpoints on operations and events
    /// occurring in native code invoked from JavaScript. Once breakpoint is hit, it is
    /// reported through Debugger domain, similarly to regular breakpoints being hit.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public EventBreakpoints.IEventBreakpoints EventBreakpoints => _eventBreakpoints ?? global::System.Threading.Interlocked.CompareExchange(ref _eventBreakpoints, new EventBreakpoints.EventBreakpointsDomain(this), null) ?? _eventBreakpoints;

    private Extensions.IExtensions? _extensions;

    /// <summary>
    /// Defines commands and events for browser extensions.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Extensions.IExtensions Extensions => _extensions ?? global::System.Threading.Interlocked.CompareExchange(ref _extensions, new Extensions.ExtensionsDomain(this), null) ?? _extensions;

    private FedCm.IFedCm? _fedCm;

    /// <summary>
    /// This domain allows interacting with the FedCM dialog.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public FedCm.IFedCm FedCm => _fedCm ?? global::System.Threading.Interlocked.CompareExchange(ref _fedCm, new FedCm.FedCmDomain(this), null) ?? _fedCm;

    private Fetch.IFetch? _fetch;

    /// <summary>
    /// A domain for letting clients substitute browser's network layer with client code.
    /// </summary>
    public Fetch.IFetch Fetch => _fetch ?? global::System.Threading.Interlocked.CompareExchange(ref _fetch, new Fetch.FetchDomain(this), null) ?? _fetch;

    private FileSystem.IFileSystem? _fileSystem;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public FileSystem.IFileSystem FileSystem => _fileSystem ?? global::System.Threading.Interlocked.CompareExchange(ref _fileSystem, new FileSystem.FileSystemDomain(this), null) ?? _fileSystem;

    private HeadlessExperimental.IHeadlessExperimental? _headlessExperimental;

    /// <summary>
    /// This domain provides experimental commands only supported in headless mode.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public HeadlessExperimental.IHeadlessExperimental HeadlessExperimental => _headlessExperimental ?? global::System.Threading.Interlocked.CompareExchange(ref _headlessExperimental, new HeadlessExperimental.HeadlessExperimentalDomain(this), null) ?? _headlessExperimental;

    private IO.IIO? _iO;

    /// <summary>
    /// Input/Output operations for streams produced by DevTools.
    /// </summary>
    public IO.IIO IO => _iO ?? global::System.Threading.Interlocked.CompareExchange(ref _iO, new IO.IODomain(this), null) ?? _iO;

    private IndexedDB.IIndexedDB? _indexedDB;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IndexedDB.IIndexedDB IndexedDB => _indexedDB ?? global::System.Threading.Interlocked.CompareExchange(ref _indexedDB, new IndexedDB.IndexedDBDomain(this), null) ?? _indexedDB;

    private Input.IInput? _input;

    /// <summary>
    /// </summary>
    public Input.IInput Input => _input ?? global::System.Threading.Interlocked.CompareExchange(ref _input, new Input.InputDomain(this), null) ?? _input;

    private Inspector.IInspector? _inspector;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Inspector.IInspector Inspector => _inspector ?? global::System.Threading.Interlocked.CompareExchange(ref _inspector, new Inspector.InspectorDomain(this), null) ?? _inspector;

    private LayerTree.ILayerTree? _layerTree;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public LayerTree.ILayerTree LayerTree => _layerTree ?? global::System.Threading.Interlocked.CompareExchange(ref _layerTree, new LayerTree.LayerTreeDomain(this), null) ?? _layerTree;

    private Log.ILog? _log;

    /// <summary>
    /// Provides access to log entries.
    /// </summary>
    public Log.ILog Log => _log ?? global::System.Threading.Interlocked.CompareExchange(ref _log, new Log.LogDomain(this), null) ?? _log;

    private Media.IMedia? _media;

    /// <summary>
    /// This domain allows detailed inspection of media elements.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Media.IMedia Media => _media ?? global::System.Threading.Interlocked.CompareExchange(ref _media, new Media.MediaDomain(this), null) ?? _media;

    private Memory.IMemory? _memory;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Memory.IMemory Memory => _memory ?? global::System.Threading.Interlocked.CompareExchange(ref _memory, new Memory.MemoryDomain(this), null) ?? _memory;

    private Network.INetwork? _network;

    /// <summary>
    /// Network domain allows tracking network activities of the page. It exposes information about http,
    /// file, data and other requests and responses, their headers, bodies, timing, etc.
    /// </summary>
    public Network.INetwork Network => _network ?? global::System.Threading.Interlocked.CompareExchange(ref _network, new Network.NetworkDomain(this), null) ?? _network;

    private Overlay.IOverlay? _overlay;

    /// <summary>
    /// This domain provides various functionality related to drawing atop the inspected page.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Overlay.IOverlay Overlay => _overlay ?? global::System.Threading.Interlocked.CompareExchange(ref _overlay, new Overlay.OverlayDomain(this), null) ?? _overlay;

    private PWA.IPWA? _pWA;

    /// <summary>
    /// This domain allows interacting with the browser to control PWAs.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public PWA.IPWA PWA => _pWA ?? global::System.Threading.Interlocked.CompareExchange(ref _pWA, new PWA.PWADomain(this), null) ?? _pWA;

    private Page.IPage? _page;

    /// <summary>
    /// Actions and events related to the inspected page belong to the page domain.
    /// </summary>
    public Page.IPage Page => _page ?? global::System.Threading.Interlocked.CompareExchange(ref _page, new Page.PageDomain(this), null) ?? _page;

    private Performance.IPerformance? _performance;

    /// <summary>
    /// </summary>
    public Performance.IPerformance Performance => _performance ?? global::System.Threading.Interlocked.CompareExchange(ref _performance, new Performance.PerformanceDomain(this), null) ?? _performance;

    private PerformanceTimeline.IPerformanceTimeline? _performanceTimeline;

    /// <summary>
    /// Reporting of performance timeline events, as specified in
    /// https://w3c.github.io/performance-timeline/#dom-performanceobserver.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public PerformanceTimeline.IPerformanceTimeline PerformanceTimeline => _performanceTimeline ?? global::System.Threading.Interlocked.CompareExchange(ref _performanceTimeline, new PerformanceTimeline.PerformanceTimelineDomain(this), null) ?? _performanceTimeline;

    private Preload.IPreload? _preload;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Preload.IPreload Preload => _preload ?? global::System.Threading.Interlocked.CompareExchange(ref _preload, new Preload.PreloadDomain(this), null) ?? _preload;

    private Security.ISecurity? _security;

    /// <summary>
    /// </summary>
    public Security.ISecurity Security => _security ?? global::System.Threading.Interlocked.CompareExchange(ref _security, new Security.SecurityDomain(this), null) ?? _security;

    private ServiceWorker.IServiceWorker? _serviceWorker;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public ServiceWorker.IServiceWorker ServiceWorker => _serviceWorker ?? global::System.Threading.Interlocked.CompareExchange(ref _serviceWorker, new ServiceWorker.ServiceWorkerDomain(this), null) ?? _serviceWorker;

    private SmartCardEmulation.ISmartCardEmulation? _smartCardEmulation;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public SmartCardEmulation.ISmartCardEmulation SmartCardEmulation => _smartCardEmulation ?? global::System.Threading.Interlocked.CompareExchange(ref _smartCardEmulation, new SmartCardEmulation.SmartCardEmulationDomain(this), null) ?? _smartCardEmulation;

    private Storage.IStorage? _storage;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Storage.IStorage Storage => _storage ?? global::System.Threading.Interlocked.CompareExchange(ref _storage, new Storage.StorageDomain(this), null) ?? _storage;

    private SystemInfo.ISystemInfo? _systemInfo;

    /// <summary>
    /// The SystemInfo domain defines methods and events for querying low-level system information.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public SystemInfo.ISystemInfo SystemInfo => _systemInfo ?? global::System.Threading.Interlocked.CompareExchange(ref _systemInfo, new SystemInfo.SystemInfoDomain(this), null) ?? _systemInfo;

    private Target.ITarget? _target;

    /// <summary>
    /// Supports additional targets discovery and allows to attach to them.
    /// </summary>
    public Target.ITarget Target => _target ?? global::System.Threading.Interlocked.CompareExchange(ref _target, new Target.TargetDomain(this), null) ?? _target;

    private Tethering.ITethering? _tethering;

    /// <summary>
    /// The Tethering domain defines methods and events for browser port binding.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public Tethering.ITethering Tethering => _tethering ?? global::System.Threading.Interlocked.CompareExchange(ref _tethering, new Tethering.TetheringDomain(this), null) ?? _tethering;

    private Tracing.ITracing? _tracing;

    /// <summary>
    /// </summary>
    public Tracing.ITracing Tracing => _tracing ?? global::System.Threading.Interlocked.CompareExchange(ref _tracing, new Tracing.TracingDomain(this), null) ?? _tracing;

    private WebAudio.IWebAudio? _webAudio;

    /// <summary>
    /// This domain allows inspection of Web Audio API.
    /// https://webaudio.github.io/web-audio-api/
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebAudio.IWebAudio WebAudio => _webAudio ?? global::System.Threading.Interlocked.CompareExchange(ref _webAudio, new WebAudio.WebAudioDomain(this), null) ?? _webAudio;

    private WebAuthn.IWebAuthn? _webAuthn;

    /// <summary>
    /// This domain allows configuring virtual authenticators to test the WebAuthn
    /// API.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebAuthn.IWebAuthn WebAuthn => _webAuthn ?? global::System.Threading.Interlocked.CompareExchange(ref _webAuthn, new WebAuthn.WebAuthnDomain(this), null) ?? _webAuthn;

    private WebMCP.IWebMCP? _webMCP;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public WebMCP.IWebMCP WebMCP => _webMCP ?? global::System.Threading.Interlocked.CompareExchange(ref _webMCP, new WebMCP.WebMCPDomain(this), null) ?? _webMCP;

    private Console.IConsole? _console;

    /// <summary>
    /// This domain is deprecated - use Runtime or Log instead.
    /// </summary>
    [global::System.Obsolete]
    public Console.IConsole Console => _console ?? global::System.Threading.Interlocked.CompareExchange(ref _console, new Console.ConsoleDomain(this), null) ?? _console;

    private Debugger.IDebugger? _debugger;

    /// <summary>
    /// Debugger domain exposes JavaScript debugging capabilities. It allows setting and removing
    /// breakpoints, stepping through execution, exploring stack traces, etc.
    /// </summary>
    public Debugger.IDebugger Debugger => _debugger ?? global::System.Threading.Interlocked.CompareExchange(ref _debugger, new Debugger.DebuggerDomain(this), null) ?? _debugger;

    private HeapProfiler.IHeapProfiler? _heapProfiler;

    /// <summary>
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public HeapProfiler.IHeapProfiler HeapProfiler => _heapProfiler ?? global::System.Threading.Interlocked.CompareExchange(ref _heapProfiler, new HeapProfiler.HeapProfilerDomain(this), null) ?? _heapProfiler;

    private Profiler.IProfiler? _profiler;

    /// <summary>
    /// </summary>
    public Profiler.IProfiler Profiler => _profiler ?? global::System.Threading.Interlocked.CompareExchange(ref _profiler, new Profiler.ProfilerDomain(this), null) ?? _profiler;

    private Runtime.IRuntime? _runtime;

    /// <summary>
    /// Runtime domain exposes JavaScript runtime by means of remote evaluation and mirror objects.
    /// Evaluation results are returned as mirror object that expose object type, string representation
    /// and unique identifier that can be used for further object reference. Original objects are
    /// maintained in memory unless they are either explicitly released or are released along with the
    /// other objects in their object group.
    /// </summary>
    public Runtime.IRuntime Runtime => _runtime ?? global::System.Threading.Interlocked.CompareExchange(ref _runtime, new Runtime.RuntimeDomain(this), null) ?? _runtime;

    private Schema.ISchema? _schema;

    /// <summary>
    /// This domain is deprecated.
    /// </summary>
    [global::System.Obsolete]
    public Schema.ISchema Schema => _schema ?? global::System.Threading.Interlocked.CompareExchange(ref _schema, new Schema.SchemaDomain(this), null) ?? _schema;

#pragma warning restore BIDICDP001
#pragma warning restore CS0612
}
