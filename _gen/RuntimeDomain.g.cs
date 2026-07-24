#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Runtime;

/// <summary>
/// Runtime domain exposes JavaScript runtime by means of remote evaluation and mirror objects.
/// Evaluation results are returned as mirror object that expose object type, string representation
/// and unique identifier that can be used for further object reference. Original objects are
/// maintained in memory unless they are either explicitly released or are released along with the
/// other objects in their object group.
/// </summary>
public sealed class RuntimeDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static RuntimeJsonSerializerContext JsonContext = RuntimeJsonSerializerContext.Default;

    /// <summary>
    /// Add handler to promise with given promise object id.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ReturnByValue</b> - Whether the result is expected to be a JSON object that should be sent by value.</description></item>
    /// <item><description><b>GeneratePreview</b> - Whether preview should be generated for the result.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="promiseObjectId">
    /// Identifier of the promise.
    /// </param>
    /// <param name="returnByValue">
    /// Whether the result is expected to be a JSON object that should be sent by value.
    /// </param>
    /// <param name="generatePreview">
    /// Whether preview should be generated for the result.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AwaitPromiseResult"/>.
    /// </returns>
    public async Task<AwaitPromiseResult> AwaitPromiseAsync(RemoteObjectId promiseObjectId, bool? returnByValue = default, bool? generatePreview = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AwaitPromiseCommandParameters(PromiseObjectId: promiseObjectId, ReturnByValue: returnByValue, GeneratePreview: generatePreview);
        return await ExecuteCommandAsync(AwaitPromiseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AwaitPromiseCommandParameters, AwaitPromiseResult> AwaitPromiseCommand = new("Runtime.awaitPromise", JsonContext.AwaitPromiseCommandParameters, JsonContext.AwaitPromiseResult);

    /// <summary>
    /// Calls function with given declaration on the given object. Object group of the result is
    /// inherited from the target object.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ObjectId</b> - Identifier of the object to call function on. Either objectId or executionContextId should be specified.</description></item>
    /// <item><description><b>Arguments</b> - Call arguments. All call arguments must belong to the same JavaScript world as the target object.</description></item>
    /// <item><description><b>Silent</b> - In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides <b>setPauseOnException</b> state.</description></item>
    /// <item><description><b>ReturnByValue</b> - Whether the result is expected to be a JSON object which should be sent by value. Can be overriden by <b>serializationOptions</b>.</description></item>
    /// <item><description><b>GeneratePreview</b> - Whether preview should be generated for the result.</description></item>
    /// <item><description><b>UserGesture</b> - Whether execution should be treated as initiated by user in the UI.</description></item>
    /// <item><description><b>AwaitPromise</b> - Whether execution should <b>await</b> for resulting value and return once awaited promise is resolved.</description></item>
    /// <item><description><b>ExecutionContextId</b> - Specifies execution context which global object will be used to call function on. Either executionContextId or objectId should be specified.</description></item>
    /// <item><description><b>ObjectGroup</b> - Symbolic group name that can be used to release multiple objects. If objectGroup is not specified and objectId is, objectGroup will be inherited from object.</description></item>
    /// <item><description><b>ThrowOnSideEffect</b> - Whether to throw an exception if side effect cannot be ruled out during evaluation.</description></item>
    /// <item><description><b>UniqueContextId</b> - An alternative way to specify the execution context to call function on. Compared to contextId that may be reused across processes, this is guaranteed to be system-unique, so it can be used to prevent accidental function call in context different than intended (e.g. as a result of navigation across process boundaries). This is mutually exclusive with <b>executionContextId</b>.</description></item>
    /// <item><description><b>SerializationOptions</b> - Specifies the result serialization. If provided, overrides <b>generatePreview</b> and <b>returnByValue</b>.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="functionDeclaration">
    /// Declaration of the function to call.
    /// </param>
    /// <param name="objectId">
    /// Identifier of the object to call function on. Either objectId or executionContextId should
    /// be specified.
    /// </param>
    /// <param name="arguments">
    /// Call arguments. All call arguments must belong to the same JavaScript world as the target
    /// object.
    /// </param>
    /// <param name="silent">
    /// In silent mode exceptions thrown during evaluation are not reported and do not pause
    /// execution. Overrides <b>setPauseOnException</b> state.
    /// </param>
    /// <param name="returnByValue">
    /// Whether the result is expected to be a JSON object which should be sent by value.
    /// Can be overriden by <b>serializationOptions</b>.
    /// </param>
    /// <param name="generatePreview">
    /// Whether preview should be generated for the result.
    /// </param>
    /// <param name="userGesture">
    /// Whether execution should be treated as initiated by user in the UI.
    /// </param>
    /// <param name="awaitPromise">
    /// Whether execution should <b>await</b> for resulting value and return once awaited promise is
    /// resolved.
    /// </param>
    /// <param name="executionContextId">
    /// Specifies execution context which global object will be used to call function on. Either
    /// executionContextId or objectId should be specified.
    /// </param>
    /// <param name="objectGroup">
    /// Symbolic group name that can be used to release multiple objects. If objectGroup is not
    /// specified and objectId is, objectGroup will be inherited from object.
    /// </param>
    /// <param name="throwOnSideEffect">
    /// Whether to throw an exception if side effect cannot be ruled out during evaluation.
    /// </param>
    /// <param name="uniqueContextId">
    /// An alternative way to specify the execution context to call function on.
    /// Compared to contextId that may be reused across processes, this is guaranteed to be
    /// system-unique, so it can be used to prevent accidental function call
    /// in context different than intended (e.g. as a result of navigation across process
    /// boundaries).
    /// This is mutually exclusive with <b>executionContextId</b>.
    /// </param>
    /// <param name="serializationOptions">
    /// Specifies the result serialization. If provided, overrides
    /// <b>generatePreview</b> and <b>returnByValue</b>.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CallFunctionOnResult"/>.
    /// </returns>
    public async Task<CallFunctionOnResult> CallFunctionOnAsync(string functionDeclaration, RemoteObjectId? objectId = default, ImmutableArray<CallArgument>? arguments = default, bool? silent = default, bool? returnByValue = default, bool? generatePreview = default, bool? userGesture = default, bool? awaitPromise = default, ExecutionContextId? executionContextId = default, string? objectGroup = default, bool? throwOnSideEffect = default, string? uniqueContextId = default, SerializationOptions? serializationOptions = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CallFunctionOnCommandParameters(FunctionDeclaration: functionDeclaration, ObjectId: objectId, Arguments: arguments, Silent: silent, ReturnByValue: returnByValue, GeneratePreview: generatePreview, UserGesture: userGesture, AwaitPromise: awaitPromise, ExecutionContextId: executionContextId, ObjectGroup: objectGroup, ThrowOnSideEffect: throwOnSideEffect, UniqueContextId: uniqueContextId, SerializationOptions: serializationOptions);
        return await ExecuteCommandAsync(CallFunctionOnCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CallFunctionOnCommandParameters, CallFunctionOnResult> CallFunctionOnCommand = new("Runtime.callFunctionOn", JsonContext.CallFunctionOnCommandParameters, JsonContext.CallFunctionOnResult);

    /// <summary>
    /// Compiles expression.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ExecutionContextId</b> - Specifies in which execution context to perform script run. If the parameter is omitted the evaluation will be performed in the context of the inspected page.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="expression">
    /// Expression to compile.
    /// </param>
    /// <param name="sourceURL">
    /// Source url to be set for the script.
    /// </param>
    /// <param name="persistScript">
    /// Specifies whether the compiled script should be persisted.
    /// </param>
    /// <param name="executionContextId">
    /// Specifies in which execution context to perform script run. If the parameter is omitted the
    /// evaluation will be performed in the context of the inspected page.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CompileScriptResult"/>.
    /// </returns>
    public async Task<CompileScriptResult> CompileScriptAsync(string expression, string sourceURL, bool persistScript, ExecutionContextId? executionContextId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CompileScriptCommandParameters(Expression: expression, SourceURL: sourceURL, PersistScript: persistScript, ExecutionContextId: executionContextId);
        return await ExecuteCommandAsync(CompileScriptCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CompileScriptCommandParameters, CompileScriptResult> CompileScriptCommand = new("Runtime.compileScript", JsonContext.CompileScriptCommandParameters, JsonContext.CompileScriptResult);

    /// <summary>
    /// Disables reporting of execution contexts creation.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisableResult"/>.
    /// </returns>
    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Runtime.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Discards collected exceptions and console API calls.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DiscardConsoleEntriesResult"/>.
    /// </returns>
    public async Task<DiscardConsoleEntriesResult> DiscardConsoleEntriesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DiscardConsoleEntriesCommandParameters();
        return await ExecuteCommandAsync(DiscardConsoleEntriesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DiscardConsoleEntriesCommandParameters, DiscardConsoleEntriesResult> DiscardConsoleEntriesCommand = new("Runtime.discardConsoleEntries", JsonContext.DiscardConsoleEntriesCommandParameters, JsonContext.DiscardConsoleEntriesResult);

    /// <summary>
    /// Enables reporting of execution contexts creation by means of <b>executionContextCreated</b> event.
    /// When the reporting gets enabled the event will be sent immediately for each existing execution
    /// context.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Runtime.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Evaluates expression on global object.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ObjectGroup</b> - Symbolic group name that can be used to release multiple objects.</description></item>
    /// <item><description><b>IncludeCommandLineAPI</b> - Determines whether Command Line API should be available during the evaluation.</description></item>
    /// <item><description><b>Silent</b> - In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides <b>setPauseOnException</b> state.</description></item>
    /// <item><description><b>ContextId</b> - Specifies in which execution context to perform evaluation. If the parameter is omitted the evaluation will be performed in the context of the inspected page. This is mutually exclusive with <b>uniqueContextId</b>, which offers an alternative way to identify the execution context that is more reliable in a multi-process environment.</description></item>
    /// <item><description><b>ReturnByValue</b> - Whether the result is expected to be a JSON object that should be sent by value.</description></item>
    /// <item><description><b>GeneratePreview</b> - Whether preview should be generated for the result.</description></item>
    /// <item><description><b>UserGesture</b> - Whether execution should be treated as initiated by user in the UI.</description></item>
    /// <item><description><b>AwaitPromise</b> - Whether execution should <b>await</b> for resulting value and return once awaited promise is resolved.</description></item>
    /// <item><description><b>ThrowOnSideEffect</b> - Whether to throw an exception if side effect cannot be ruled out during evaluation. This implies <b>disableBreaks</b> below.</description></item>
    /// <item><description><b>Timeout</b> - Terminate execution after timing out (number of milliseconds).</description></item>
    /// <item><description><b>DisableBreaks</b> - Disable breakpoints during execution.</description></item>
    /// <item><description><b>ReplMode</b> - Setting this flag to true enables <b>let</b> re-declaration and top-level <b>await</b>. Note that <b>let</b> variables can only be re-declared if they originate from <b>replMode</b> themselves.</description></item>
    /// <item><description><b>AllowUnsafeEvalBlockedByCSP</b> - The Content Security Policy (CSP) for the target might block 'unsafe-eval' which includes eval(), Function(), setTimeout() and setInterval() when called with non-callable arguments. This flag bypasses CSP for this evaluation and allows unsafe-eval. Defaults to true.</description></item>
    /// <item><description><b>UniqueContextId</b> - An alternative way to specify the execution context to evaluate in. Compared to contextId that may be reused across processes, this is guaranteed to be system-unique, so it can be used to prevent accidental evaluation of the expression in context different than intended (e.g. as a result of navigation across process boundaries). This is mutually exclusive with <b>contextId</b>.</description></item>
    /// <item><description><b>SerializationOptions</b> - Specifies the result serialization. If provided, overrides <b>generatePreview</b> and <b>returnByValue</b>.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="expression">
    /// Expression to evaluate.
    /// </param>
    /// <param name="objectGroup">
    /// Symbolic group name that can be used to release multiple objects.
    /// </param>
    /// <param name="includeCommandLineAPI">
    /// Determines whether Command Line API should be available during the evaluation.
    /// </param>
    /// <param name="silent">
    /// In silent mode exceptions thrown during evaluation are not reported and do not pause
    /// execution. Overrides <b>setPauseOnException</b> state.
    /// </param>
    /// <param name="contextId">
    /// Specifies in which execution context to perform evaluation. If the parameter is omitted the
    /// evaluation will be performed in the context of the inspected page.
    /// This is mutually exclusive with <b>uniqueContextId</b>, which offers an
    /// alternative way to identify the execution context that is more reliable
    /// in a multi-process environment.
    /// </param>
    /// <param name="returnByValue">
    /// Whether the result is expected to be a JSON object that should be sent by value.
    /// </param>
    /// <param name="generatePreview">
    /// Whether preview should be generated for the result.
    /// </param>
    /// <param name="userGesture">
    /// Whether execution should be treated as initiated by user in the UI.
    /// </param>
    /// <param name="awaitPromise">
    /// Whether execution should <b>await</b> for resulting value and return once awaited promise is
    /// resolved.
    /// </param>
    /// <param name="throwOnSideEffect">
    /// Whether to throw an exception if side effect cannot be ruled out during evaluation.
    /// This implies <b>disableBreaks</b> below.
    /// </param>
    /// <param name="timeout">
    /// Terminate execution after timing out (number of milliseconds).
    /// </param>
    /// <param name="disableBreaks">
    /// Disable breakpoints during execution.
    /// </param>
    /// <param name="replMode">
    /// Setting this flag to true enables <b>let</b> re-declaration and top-level <b>await</b>.
    /// Note that <b>let</b> variables can only be re-declared if they originate from
    /// <b>replMode</b> themselves.
    /// </param>
    /// <param name="allowUnsafeEvalBlockedByCSP">
    /// The Content Security Policy (CSP) for the target might block 'unsafe-eval'
    /// which includes eval(), Function(), setTimeout() and setInterval()
    /// when called with non-callable arguments. This flag bypasses CSP for this
    /// evaluation and allows unsafe-eval. Defaults to true.
    /// </param>
    /// <param name="uniqueContextId">
    /// An alternative way to specify the execution context to evaluate in.
    /// Compared to contextId that may be reused across processes, this is guaranteed to be
    /// system-unique, so it can be used to prevent accidental evaluation of the expression
    /// in context different than intended (e.g. as a result of navigation across process
    /// boundaries).
    /// This is mutually exclusive with <b>contextId</b>.
    /// </param>
    /// <param name="serializationOptions">
    /// Specifies the result serialization. If provided, overrides
    /// <b>generatePreview</b> and <b>returnByValue</b>.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EvaluateResult"/>.
    /// </returns>
    public async Task<EvaluateResult> EvaluateAsync(string expression, string? objectGroup = default, bool? includeCommandLineAPI = default, bool? silent = default, ExecutionContextId? contextId = default, bool? returnByValue = default, bool? generatePreview = default, bool? userGesture = default, bool? awaitPromise = default, bool? throwOnSideEffect = default, TimeDelta? timeout = default, bool? disableBreaks = default, bool? replMode = default, bool? allowUnsafeEvalBlockedByCSP = default, string? uniqueContextId = default, SerializationOptions? serializationOptions = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EvaluateCommandParameters(Expression: expression, ObjectGroup: objectGroup, IncludeCommandLineAPI: includeCommandLineAPI, Silent: silent, ContextId: contextId, ReturnByValue: returnByValue, GeneratePreview: generatePreview, UserGesture: userGesture, AwaitPromise: awaitPromise, ThrowOnSideEffect: throwOnSideEffect, Timeout: timeout, DisableBreaks: disableBreaks, ReplMode: replMode, AllowUnsafeEvalBlockedByCSP: allowUnsafeEvalBlockedByCSP, UniqueContextId: uniqueContextId, SerializationOptions: serializationOptions);
        return await ExecuteCommandAsync(EvaluateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EvaluateCommandParameters, EvaluateResult> EvaluateCommand = new("Runtime.evaluate", JsonContext.EvaluateCommandParameters, JsonContext.EvaluateResult);

    /// <summary>
    /// Returns the isolate id.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetIsolateIdResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetIsolateIdResult> GetIsolateIdAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetIsolateIdCommandParameters();
        return await ExecuteCommandAsync(GetIsolateIdCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetIsolateIdCommandParameters, GetIsolateIdResult> GetIsolateIdCommand = new("Runtime.getIsolateId", JsonContext.GetIsolateIdCommandParameters, JsonContext.GetIsolateIdResult);

    /// <summary>
    /// Returns the JavaScript heap usage.
    /// It is the total usage of the corresponding isolate not scoped to a particular Runtime.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetHeapUsageResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetHeapUsageResult> GetHeapUsageAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetHeapUsageCommandParameters();
        return await ExecuteCommandAsync(GetHeapUsageCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetHeapUsageCommandParameters, GetHeapUsageResult> GetHeapUsageCommand = new("Runtime.getHeapUsage", JsonContext.GetHeapUsageCommandParameters, JsonContext.GetHeapUsageResult);

    /// <summary>
    /// Returns properties of a given object. Object group of the result is inherited from the target
    /// object.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>OwnProperties</b> - If true, returns properties belonging only to the element itself, not to its prototype chain.</description></item>
    /// <item><description><b>AccessorPropertiesOnly</b> - If true, returns accessor properties (with getter/setter) only; internal properties are not returned either.</description></item>
    /// <item><description><b>GeneratePreview</b> - Whether preview should be generated for the results.</description></item>
    /// <item><description><b>NonIndexedPropertiesOnly</b> - If true, returns non-indexed properties only.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="objectId">
    /// Identifier of the object to return properties for.
    /// </param>
    /// <param name="ownProperties">
    /// If true, returns properties belonging only to the element itself, not to its prototype
    /// chain.
    /// </param>
    /// <param name="accessorPropertiesOnly">
    /// If true, returns accessor properties (with getter/setter) only; internal properties are not
    /// returned either.
    /// </param>
    /// <param name="generatePreview">
    /// Whether preview should be generated for the results.
    /// </param>
    /// <param name="nonIndexedPropertiesOnly">
    /// If true, returns non-indexed properties only.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPropertiesResult"/>.
    /// </returns>
    public async Task<GetPropertiesResult> GetPropertiesAsync(RemoteObjectId objectId, bool? ownProperties = default, bool? accessorPropertiesOnly = default, bool? generatePreview = default, bool? nonIndexedPropertiesOnly = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetPropertiesCommandParameters(ObjectId: objectId, OwnProperties: ownProperties, AccessorPropertiesOnly: accessorPropertiesOnly, GeneratePreview: generatePreview, NonIndexedPropertiesOnly: nonIndexedPropertiesOnly);
        return await ExecuteCommandAsync(GetPropertiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetPropertiesCommandParameters, GetPropertiesResult> GetPropertiesCommand = new("Runtime.getProperties", JsonContext.GetPropertiesCommandParameters, JsonContext.GetPropertiesResult);

    /// <summary>
    /// Returns all let, const and class variables from global scope.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ExecutionContextId</b> - Specifies in which execution context to lookup global scope variables.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="executionContextId">
    /// Specifies in which execution context to lookup global scope variables.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GlobalLexicalScopeNamesResult"/>.
    /// </returns>
    public async Task<GlobalLexicalScopeNamesResult> GlobalLexicalScopeNamesAsync(ExecutionContextId? executionContextId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GlobalLexicalScopeNamesCommandParameters(ExecutionContextId: executionContextId);
        return await ExecuteCommandAsync(GlobalLexicalScopeNamesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GlobalLexicalScopeNamesCommandParameters, GlobalLexicalScopeNamesResult> GlobalLexicalScopeNamesCommand = new("Runtime.globalLexicalScopeNames", JsonContext.GlobalLexicalScopeNamesCommandParameters, JsonContext.GlobalLexicalScopeNamesResult);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ObjectGroup</b> - Symbolic group name that can be used to release the results.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="prototypeObjectId">
    /// Identifier of the prototype to return objects for.
    /// </param>
    /// <param name="objectGroup">
    /// Symbolic group name that can be used to release the results.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="QueryObjectsResult"/>.
    /// </returns>
    public async Task<QueryObjectsResult> QueryObjectsAsync(RemoteObjectId prototypeObjectId, string? objectGroup = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new QueryObjectsCommandParameters(PrototypeObjectId: prototypeObjectId, ObjectGroup: objectGroup);
        return await ExecuteCommandAsync(QueryObjectsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<QueryObjectsCommandParameters, QueryObjectsResult> QueryObjectsCommand = new("Runtime.queryObjects", JsonContext.QueryObjectsCommandParameters, JsonContext.QueryObjectsResult);

    /// <summary>
    /// Releases remote object with given id.
    /// </summary>
    /// <param name="objectId">
    /// Identifier of the object to release.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReleaseObjectResult"/>.
    /// </returns>
    public async Task<ReleaseObjectResult> ReleaseObjectAsync(RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReleaseObjectCommandParameters(ObjectId: objectId);
        return await ExecuteCommandAsync(ReleaseObjectCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReleaseObjectCommandParameters, ReleaseObjectResult> ReleaseObjectCommand = new("Runtime.releaseObject", JsonContext.ReleaseObjectCommandParameters, JsonContext.ReleaseObjectResult);

    /// <summary>
    /// Releases all remote objects that belong to a given group.
    /// </summary>
    /// <param name="objectGroup">
    /// Symbolic object group name.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReleaseObjectGroupResult"/>.
    /// </returns>
    public async Task<ReleaseObjectGroupResult> ReleaseObjectGroupAsync(string objectGroup, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReleaseObjectGroupCommandParameters(ObjectGroup: objectGroup);
        return await ExecuteCommandAsync(ReleaseObjectGroupCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReleaseObjectGroupCommandParameters, ReleaseObjectGroupResult> ReleaseObjectGroupCommand = new("Runtime.releaseObjectGroup", JsonContext.ReleaseObjectGroupCommandParameters, JsonContext.ReleaseObjectGroupResult);

    /// <summary>
    /// Tells inspected instance to run if it was waiting for debugger to attach.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RunIfWaitingForDebuggerResult"/>.
    /// </returns>
    public async Task<RunIfWaitingForDebuggerResult> RunIfWaitingForDebuggerAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RunIfWaitingForDebuggerCommandParameters();
        return await ExecuteCommandAsync(RunIfWaitingForDebuggerCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RunIfWaitingForDebuggerCommandParameters, RunIfWaitingForDebuggerResult> RunIfWaitingForDebuggerCommand = new("Runtime.runIfWaitingForDebugger", JsonContext.RunIfWaitingForDebuggerCommandParameters, JsonContext.RunIfWaitingForDebuggerResult);

    /// <summary>
    /// Runs script with given id in a given context.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ExecutionContextId</b> - Specifies in which execution context to perform script run. If the parameter is omitted the evaluation will be performed in the context of the inspected page.</description></item>
    /// <item><description><b>ObjectGroup</b> - Symbolic group name that can be used to release multiple objects.</description></item>
    /// <item><description><b>Silent</b> - In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides <b>setPauseOnException</b> state.</description></item>
    /// <item><description><b>IncludeCommandLineAPI</b> - Determines whether Command Line API should be available during the evaluation.</description></item>
    /// <item><description><b>ReturnByValue</b> - Whether the result is expected to be a JSON object which should be sent by value.</description></item>
    /// <item><description><b>GeneratePreview</b> - Whether preview should be generated for the result.</description></item>
    /// <item><description><b>AwaitPromise</b> - Whether execution should <b>await</b> for resulting value and return once awaited promise is resolved.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="scriptId">
    /// Id of the script to run.
    /// </param>
    /// <param name="executionContextId">
    /// Specifies in which execution context to perform script run. If the parameter is omitted the
    /// evaluation will be performed in the context of the inspected page.
    /// </param>
    /// <param name="objectGroup">
    /// Symbolic group name that can be used to release multiple objects.
    /// </param>
    /// <param name="silent">
    /// In silent mode exceptions thrown during evaluation are not reported and do not pause
    /// execution. Overrides <b>setPauseOnException</b> state.
    /// </param>
    /// <param name="includeCommandLineAPI">
    /// Determines whether Command Line API should be available during the evaluation.
    /// </param>
    /// <param name="returnByValue">
    /// Whether the result is expected to be a JSON object which should be sent by value.
    /// </param>
    /// <param name="generatePreview">
    /// Whether preview should be generated for the result.
    /// </param>
    /// <param name="awaitPromise">
    /// Whether execution should <b>await</b> for resulting value and return once awaited promise is
    /// resolved.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RunScriptResult"/>.
    /// </returns>
    public async Task<RunScriptResult> RunScriptAsync(ScriptId scriptId, ExecutionContextId? executionContextId = default, string? objectGroup = default, bool? silent = default, bool? includeCommandLineAPI = default, bool? returnByValue = default, bool? generatePreview = default, bool? awaitPromise = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RunScriptCommandParameters(ScriptId: scriptId, ExecutionContextId: executionContextId, ObjectGroup: objectGroup, Silent: silent, IncludeCommandLineAPI: includeCommandLineAPI, ReturnByValue: returnByValue, GeneratePreview: generatePreview, AwaitPromise: awaitPromise);
        return await ExecuteCommandAsync(RunScriptCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RunScriptCommandParameters, RunScriptResult> RunScriptCommand = new("Runtime.runScript", JsonContext.RunScriptCommandParameters, JsonContext.RunScriptResult);

    /// <summary>
    /// Enables or disables async call stacks tracking.
    /// </summary>
    /// <param name="maxDepth">
    /// Maximum depth of async call stacks. Setting to <b>0</b> will effectively disable collecting async
    /// call stacks (default).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAsyncCallStackDepthResult"/>.
    /// </returns>
    public async Task<SetAsyncCallStackDepthResult> SetAsyncCallStackDepthAsync(long maxDepth, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAsyncCallStackDepthCommandParameters(MaxDepth: maxDepth);
        return await ExecuteCommandAsync(SetAsyncCallStackDepthCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAsyncCallStackDepthCommandParameters, SetAsyncCallStackDepthResult> SetAsyncCallStackDepthCommand = new("Runtime.setAsyncCallStackDepth", JsonContext.SetAsyncCallStackDepthCommandParameters, JsonContext.SetAsyncCallStackDepthResult);

    /// <summary>
    /// </summary>
    /// <param name="enabled">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCustomObjectFormatterEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetCustomObjectFormatterEnabledResult> SetCustomObjectFormatterEnabledAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCustomObjectFormatterEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetCustomObjectFormatterEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCustomObjectFormatterEnabledCommandParameters, SetCustomObjectFormatterEnabledResult> SetCustomObjectFormatterEnabledCommand = new("Runtime.setCustomObjectFormatterEnabled", JsonContext.SetCustomObjectFormatterEnabledCommandParameters, JsonContext.SetCustomObjectFormatterEnabledResult);

    /// <summary>
    /// </summary>
    /// <param name="size">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetMaxCallStackSizeToCaptureResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetMaxCallStackSizeToCaptureResult> SetMaxCallStackSizeToCaptureAsync(long size, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetMaxCallStackSizeToCaptureCommandParameters(Size: size);
        return await ExecuteCommandAsync(SetMaxCallStackSizeToCaptureCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetMaxCallStackSizeToCaptureCommandParameters, SetMaxCallStackSizeToCaptureResult> SetMaxCallStackSizeToCaptureCommand = new("Runtime.setMaxCallStackSizeToCapture", JsonContext.SetMaxCallStackSizeToCaptureCommandParameters, JsonContext.SetMaxCallStackSizeToCaptureResult);

    /// <summary>
    /// Terminate current or next JavaScript execution.
    /// Will cancel the termination when the outer-most script execution ends.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TerminateExecutionResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<TerminateExecutionResult> TerminateExecutionAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TerminateExecutionCommandParameters();
        return await ExecuteCommandAsync(TerminateExecutionCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TerminateExecutionCommandParameters, TerminateExecutionResult> TerminateExecutionCommand = new("Runtime.terminateExecution", JsonContext.TerminateExecutionCommandParameters, JsonContext.TerminateExecutionResult);

    /// <summary>
    /// If executionContextId is empty, adds binding with the given name on the
    /// global objects of all inspected contexts, including those created later,
    /// bindings survive reloads.
    /// Binding function takes exactly one argument, this argument should be string,
    /// in case of any other input, function throws an exception.
    /// Each binding function call produces Runtime.bindingCalled notification.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ExecutionContextId</b> - If specified, the binding would only be exposed to the specified execution context. If omitted and <b>executionContextName</b> is not set, the binding is exposed to all execution contexts of the target. This parameter is mutually exclusive with <b>executionContextName</b>. Deprecated in favor of <b>executionContextName</b> due to an unclear use case and bugs in implementation (crbug.com/1169639). <b>executionContextId</b> will be removed in the future.</description></item>
    /// <item><description><b>ExecutionContextName</b> - If specified, the binding is exposed to the executionContext with matching name, even for contexts created after the binding is added. See also <b>ExecutionContext.name</b> and <b>worldName</b> parameter to <b>Page.addScriptToEvaluateOnNewDocument</b>. This parameter is mutually exclusive with <b>executionContextId</b>.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="name">
    /// </param>
    /// <param name="executionContextId">
    /// If specified, the binding would only be exposed to the specified
    /// execution context. If omitted and <b>executionContextName</b> is not set,
    /// the binding is exposed to all execution contexts of the target.
    /// This parameter is mutually exclusive with <b>executionContextName</b>.
    /// Deprecated in favor of <b>executionContextName</b> due to an unclear use case
    /// and bugs in implementation (crbug.com/1169639). <b>executionContextId</b> will be
    /// removed in the future.
    /// </param>
    /// <param name="executionContextName">
    /// If specified, the binding is exposed to the executionContext with
    /// matching name, even for contexts created after the binding is added.
    /// See also <b>ExecutionContext.name</b> and <b>worldName</b> parameter to
    /// <b>Page.addScriptToEvaluateOnNewDocument</b>.
    /// This parameter is mutually exclusive with <b>executionContextId</b>.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddBindingResult"/>.
    /// </returns>
    public async Task<AddBindingResult> AddBindingAsync(string name, ExecutionContextId? executionContextId = default, string? executionContextName = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddBindingCommandParameters(Name: name, ExecutionContextId: executionContextId, ExecutionContextName: executionContextName);
        return await ExecuteCommandAsync(AddBindingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddBindingCommandParameters, AddBindingResult> AddBindingCommand = new("Runtime.addBinding", JsonContext.AddBindingCommandParameters, JsonContext.AddBindingResult);

    /// <summary>
    /// This method does not remove binding function from global object but
    /// unsubscribes current runtime agent from Runtime.bindingCalled notifications.
    /// </summary>
    /// <param name="name">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveBindingResult"/>.
    /// </returns>
    public async Task<RemoveBindingResult> RemoveBindingAsync(string name, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveBindingCommandParameters(Name: name);
        return await ExecuteCommandAsync(RemoveBindingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveBindingCommandParameters, RemoveBindingResult> RemoveBindingCommand = new("Runtime.removeBinding", JsonContext.RemoveBindingCommandParameters, JsonContext.RemoveBindingResult);

    /// <summary>
    /// This method tries to lookup and populate exception details for a
    /// JavaScript Error object.
    /// Note that the stackTrace portion of the resulting exceptionDetails will
    /// only be populated if the Runtime domain was enabled at the time when the
    /// Error was thrown.
    /// </summary>
    /// <param name="errorObjectId">
    /// The error object for which to resolve the exception details.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetExceptionDetailsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetExceptionDetailsResult> GetExceptionDetailsAsync(RemoteObjectId errorObjectId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetExceptionDetailsCommandParameters(ErrorObjectId: errorObjectId);
        return await ExecuteCommandAsync(GetExceptionDetailsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetExceptionDetailsCommandParameters, GetExceptionDetailsResult> GetExceptionDetailsCommand = new("Runtime.getExceptionDetails", JsonContext.GetExceptionDetailsCommandParameters, JsonContext.GetExceptionDetailsResult);

    /// <summary>
    /// Notification is issued every time when binding is called.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="BindingCalledEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Name</b></description></item>
    /// <item><description><b>Payload</b></description></item>
    /// <item><description><b>ExecutionContextId</b> - Identifier of the context where the call was made.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<BindingCalledEventArgs> BindingCalled => CreateCdpEventSource(RuntimeDomainEvent.BindingCalled);
    /// <summary>
    /// Issued when console API was called.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ConsoleAPICalledEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Type</b> - Type of the call.</description></item>
    /// <item><description><b>Args</b> - Call arguments.</description></item>
    /// <item><description><b>ExecutionContextId</b> - Identifier of the context where the call was made.</description></item>
    /// <item><description><b>Timestamp</b> - Call timestamp.</description></item>
    /// <item><description><b>StackTrace</b> - Stack trace captured when the call was made. The async stack chain is automatically reported for the following call types: <b>assert</b>, <b>error</b>, <b>trace</b>, <b>warning</b>. For other types the async call chain can be retrieved using <b>Debugger.getStackTrace</b> and <b>stackTrace.parentId</b> field.</description></item>
    /// <item><description><b>Context</b> - Console context descriptor for calls on non-default console context (not console.*): 'anonymous#unique-logger-id' for call on unnamed context, 'name#unique-logger-id' for call on named context.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ConsoleAPICalledEventArgs> ConsoleAPICalled => CreateCdpEventSource(RuntimeDomainEvent.ConsoleAPICalled);
    /// <summary>
    /// Issued when unhandled exception was revoked.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ExceptionRevokedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Reason</b> - Reason describing why exception was revoked.</description></item>
    /// <item><description><b>ExceptionId</b> - The id of revoked exception, as reported in <b>exceptionThrown</b>.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ExceptionRevokedEventArgs> ExceptionRevoked => CreateCdpEventSource(RuntimeDomainEvent.ExceptionRevoked);
    /// <summary>
    /// Issued when exception was thrown and unhandled.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ExceptionThrownEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Timestamp</b> - Timestamp of the exception.</description></item>
    /// <item><description><b>ExceptionDetails</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ExceptionThrownEventArgs> ExceptionThrown => CreateCdpEventSource(RuntimeDomainEvent.ExceptionThrown);
    /// <summary>
    /// Issued when new execution context is created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ExecutionContextCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Context</b> - A newly created execution context.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ExecutionContextCreatedEventArgs> ExecutionContextCreated => CreateCdpEventSource(RuntimeDomainEvent.ExecutionContextCreated);
    /// <summary>
    /// Issued when execution context is destroyed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ExecutionContextDestroyedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ExecutionContextId</b> - Id of the destroyed context</description></item>
    /// <item><description><b>ExecutionContextUniqueId</b> - Unique Id of the destroyed context</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ExecutionContextDestroyedEventArgs> ExecutionContextDestroyed => CreateCdpEventSource(RuntimeDomainEvent.ExecutionContextDestroyed);
    /// <summary>
    /// Issued when all executionContexts were cleared in browser
    /// </summary>
    public IEventSource<ExecutionContextsClearedEventArgs> ExecutionContextsCleared => CreateCdpEventSource(RuntimeDomainEvent.ExecutionContextsCleared);
    /// <summary>
    /// Issued when object should be inspected (for example, as a result of inspect() command line API
    /// call).
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="InspectRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Object</b></description></item>
    /// <item><description><b>Hints</b></description></item>
    /// <item><description><b>ExecutionContextId</b> - Identifier of the context where the call was made.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<InspectRequestedEventArgs> InspectRequested => CreateCdpEventSource(RuntimeDomainEvent.InspectRequested);
}

internal sealed record AwaitPromiseCommandParameters(RemoteObjectId PromiseObjectId, bool? ReturnByValue, bool? GeneratePreview) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// Promise result. Will contain rejected value if promise was rejected.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details if stack strace is available.
/// </param>
public sealed record AwaitPromiseResult(RemoteObject Result, ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record CallFunctionOnCommandParameters(string FunctionDeclaration, RemoteObjectId? ObjectId, ImmutableArray<CallArgument>? Arguments, bool? Silent, bool? ReturnByValue, bool? GeneratePreview, bool? UserGesture, bool? AwaitPromise, ExecutionContextId? ExecutionContextId, string? ObjectGroup, bool? ThrowOnSideEffect, string? UniqueContextId, SerializationOptions? SerializationOptions) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// Call result.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details.
/// </param>
public sealed record CallFunctionOnResult(RemoteObject Result, ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record CompileScriptCommandParameters(string Expression, string SourceURL, bool PersistScript, ExecutionContextId? ExecutionContextId) : Parameters;

/// <summary>
/// </summary>
/// <param name="ScriptId">
/// Id of the script.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details.
/// </param>
public sealed record CompileScriptResult(ScriptId? ScriptId, ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record DiscardConsoleEntriesCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DiscardConsoleEntriesResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record EvaluateCommandParameters(string Expression, string? ObjectGroup, bool? IncludeCommandLineAPI, bool? Silent, ExecutionContextId? ContextId, bool? ReturnByValue, bool? GeneratePreview, bool? UserGesture, bool? AwaitPromise, bool? ThrowOnSideEffect, TimeDelta? Timeout, bool? DisableBreaks, bool? ReplMode, bool? AllowUnsafeEvalBlockedByCSP, string? UniqueContextId, SerializationOptions? SerializationOptions) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// Evaluation result.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details.
/// </param>
public sealed record EvaluateResult(RemoteObject Result, ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record GetIsolateIdCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Id">
/// The isolate id.
/// </param>
public sealed record GetIsolateIdResult(string Id) : EmptyResult;


internal sealed record GetHeapUsageCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="UsedSize">
/// Used JavaScript heap size in bytes.
/// </param>
/// <param name="TotalSize">
/// Allocated JavaScript heap size in bytes.
/// </param>
/// <param name="EmbedderHeapUsedSize">
/// Used size in bytes in the embedder's garbage-collected heap.
/// </param>
/// <param name="BackingStorageSize">
/// Size in bytes of backing storage for array buffers and external strings.
/// </param>
public sealed record GetHeapUsageResult(double UsedSize, double TotalSize, double EmbedderHeapUsedSize, double BackingStorageSize) : EmptyResult;


internal sealed record GetPropertiesCommandParameters(RemoteObjectId ObjectId, bool? OwnProperties, bool? AccessorPropertiesOnly, bool? GeneratePreview, bool? NonIndexedPropertiesOnly) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// Object properties.
/// </param>
/// <param name="InternalProperties">
/// Internal object properties (only of the element itself).
/// </param>
/// <param name="PrivateProperties">
/// Object private properties.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details.
/// </param>
public sealed record GetPropertiesResult(ImmutableArray<PropertyDescriptor> Result, ImmutableArray<InternalPropertyDescriptor>? InternalProperties, ImmutableArray<PrivatePropertyDescriptor>? PrivateProperties, ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record GlobalLexicalScopeNamesCommandParameters(ExecutionContextId? ExecutionContextId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Names">
/// </param>
public sealed record GlobalLexicalScopeNamesResult(ImmutableArray<string> Names) : EmptyResult;


internal sealed record QueryObjectsCommandParameters(RemoteObjectId PrototypeObjectId, string? ObjectGroup) : Parameters;

/// <summary>
/// </summary>
/// <param name="Objects">
/// Array with objects.
/// </param>
public sealed record QueryObjectsResult(RemoteObject Objects) : EmptyResult;


internal sealed record ReleaseObjectCommandParameters(RemoteObjectId ObjectId) : Parameters;

/// <summary>
/// </summary>
public sealed record ReleaseObjectResult() : EmptyResult;


internal sealed record ReleaseObjectGroupCommandParameters(string ObjectGroup) : Parameters;

/// <summary>
/// </summary>
public sealed record ReleaseObjectGroupResult() : EmptyResult;


internal sealed record RunIfWaitingForDebuggerCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record RunIfWaitingForDebuggerResult() : EmptyResult;


internal sealed record RunScriptCommandParameters(ScriptId ScriptId, ExecutionContextId? ExecutionContextId, string? ObjectGroup, bool? Silent, bool? IncludeCommandLineAPI, bool? ReturnByValue, bool? GeneratePreview, bool? AwaitPromise) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// Run result.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details.
/// </param>
public sealed record RunScriptResult(RemoteObject Result, ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record SetAsyncCallStackDepthCommandParameters(long MaxDepth) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAsyncCallStackDepthResult() : EmptyResult;


internal sealed record SetCustomObjectFormatterEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetCustomObjectFormatterEnabledResult() : EmptyResult;


internal sealed record SetMaxCallStackSizeToCaptureCommandParameters(long Size) : Parameters;

/// <summary>
/// </summary>
public sealed record SetMaxCallStackSizeToCaptureResult() : EmptyResult;


internal sealed record TerminateExecutionCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record TerminateExecutionResult() : EmptyResult;


internal sealed record AddBindingCommandParameters(string Name, ExecutionContextId? ExecutionContextId, string? ExecutionContextName) : Parameters;

/// <summary>
/// </summary>
public sealed record AddBindingResult() : EmptyResult;


internal sealed record RemoveBindingCommandParameters(string Name) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveBindingResult() : EmptyResult;


internal sealed record GetExceptionDetailsCommandParameters(RemoteObjectId ErrorObjectId) : Parameters;

/// <summary>
/// </summary>
/// <param name="ExceptionDetails">
/// </param>
public sealed record GetExceptionDetailsResult(ExceptionDetails? ExceptionDetails) : EmptyResult;


/// <summary>
/// Notification is issued every time when binding is called.
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="Payload">
/// </param>
/// <param name="ExecutionContextId">
/// Identifier of the context where the call was made.
/// </param>
public sealed record BindingCalledEventArgs(string Name, string Payload, ExecutionContextId ExecutionContextId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when console API was called.
/// </summary>
/// <param name="Type">
/// Type of the call.
/// </param>
/// <param name="Args">
/// Call arguments.
/// </param>
/// <param name="ExecutionContextId">
/// Identifier of the context where the call was made.
/// </param>
/// <param name="Timestamp">
/// Call timestamp.
/// </param>
/// <param name="StackTrace">
/// Stack trace captured when the call was made. The async stack chain is automatically reported for
/// the following call types: <b>assert</b>, <b>error</b>, <b>trace</b>, <b>warning</b>. For other types the async call
/// chain can be retrieved using <b>Debugger.getStackTrace</b> and <b>stackTrace.parentId</b> field.
/// </param>
/// <param name="Context">
/// Console context descriptor for calls on non-default console context (not console.*):
/// 'anonymous#unique-logger-id' for call on unnamed context, 'name#unique-logger-id' for call
/// on named context.
/// </param>
public sealed record ConsoleAPICalledEventArgs(string Type, ImmutableArray<RemoteObject> Args, ExecutionContextId ExecutionContextId, Timestamp Timestamp, StackTrace? StackTrace = null, string? Context = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when unhandled exception was revoked.
/// </summary>
/// <param name="Reason">
/// Reason describing why exception was revoked.
/// </param>
/// <param name="ExceptionId">
/// The id of revoked exception, as reported in <b>exceptionThrown</b>.
/// </param>
public sealed record ExceptionRevokedEventArgs(string Reason, long ExceptionId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when exception was thrown and unhandled.
/// </summary>
/// <param name="Timestamp">
/// Timestamp of the exception.
/// </param>
/// <param name="ExceptionDetails">
/// </param>
public sealed record ExceptionThrownEventArgs(Timestamp Timestamp, ExceptionDetails ExceptionDetails) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when new execution context is created.
/// </summary>
/// <param name="Context">
/// A newly created execution context.
/// </param>
public sealed record ExecutionContextCreatedEventArgs(ExecutionContextDescription Context) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when execution context is destroyed.
/// </summary>
/// <param name="ExecutionContextId">
/// Id of the destroyed context
/// </param>
/// <param name="ExecutionContextUniqueId">
/// Unique Id of the destroyed context
/// </param>
public sealed record ExecutionContextDestroyedEventArgs(ExecutionContextId ExecutionContextId, string ExecutionContextUniqueId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when all executionContexts were cleared in browser
/// </summary>
public sealed record ExecutionContextsClearedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when object should be inspected (for example, as a result of inspect() command line API
/// call).
/// </summary>
/// <param name="Object">
/// </param>
/// <param name="Hints">
/// </param>
/// <param name="ExecutionContextId">
/// Identifier of the context where the call was made.
/// </param>
public sealed record InspectRequestedEventArgs(RemoteObject Object, global::System.Text.Json.JsonElement Hints, ExecutionContextId? ExecutionContextId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Unique script identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<ScriptId>))]
public record ScriptId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Represents options for serialization. Overrides <b>generatePreview</b> and <b>returnByValue</b>.
/// </summary>
/// <param name="Serialization">
/// </param>
public sealed record SerializationOptions(string Serialization)
{
    /// <summary>
    /// Deep serialization depth. Default is full depth. Respected only in <b>deep</b> serialization mode.
    /// </summary>
    public long? MaxDepth { get; init; }

    /// <summary>
    /// Embedder-specific parameters. For example if connected to V8 in Chrome these control DOM
    /// serialization via <b>maxNodeDepth: integer</b> and <b>includeShadowTree: "none" | "open" | "all"</b>.
    /// Values can be only of type string or integer.
    /// </summary>
    public global::System.Text.Json.JsonElement? AdditionalParameters { get; init; }
}

/// <summary>
/// Represents deep serialized value.
/// </summary>
/// <param name="Type">
/// </param>
public sealed record DeepSerializedValue(string Type)
{
    /// <summary>
    /// </summary>
    public global::System.Text.Json.JsonElement? Value { get; init; }

    /// <summary>
    /// </summary>
    public string? ObjectId { get; init; }

    /// <summary>
    /// Set if value reference met more then once during serialization. In such
    /// case, value is provided only to one of the serialized values. Unique
    /// per value in the scope of one CDP call.
    /// </summary>
    public long? WeakLocalObjectReference { get; init; }
}

/// <summary>
/// Unique object identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<RemoteObjectId>))]
public record RemoteObjectId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Primitive value which cannot be JSON-stringified. Includes values <b>-0</b>, <b>NaN</b>, <b>Infinity</b>,
/// <b>-Infinity</b>, and bigint literals.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<UnserializableValue>))]
public record UnserializableValue : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Mirror object referencing original JavaScript object.
/// </summary>
/// <param name="Type">
/// Object type.
/// </param>
public sealed record RemoteObject(string Type)
{
    /// <summary>
    /// Object subtype hint. Specified for <b>object</b> type values only.
    /// NOTE: If you change anything here, make sure to also update
    /// <b>subtype</b> in <b>ObjectPreview</b> and <b>PropertyPreview</b> below.
    /// </summary>
    public string? Subtype { get; init; }

    /// <summary>
    /// Object class (constructor) name. Specified for <b>object</b> type values only.
    /// </summary>
    public string? ClassName { get; init; }

    /// <summary>
    /// Remote object value in case of primitive values or JSON values (if it was requested).
    /// </summary>
    public global::System.Text.Json.JsonElement? Value { get; init; }

    /// <summary>
    /// Primitive value which can not be JSON-stringified does not have <b>value</b>, but gets this
    /// property.
    /// </summary>
    public UnserializableValue? UnserializableValue { get; init; }

    /// <summary>
    /// String representation of the object.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Deep serialized value.
    /// </summary>
    public DeepSerializedValue? DeepSerializedValue { get; init; }

    /// <summary>
    /// Unique object identifier (for non-primitive values).
    /// </summary>
    public RemoteObjectId? ObjectId { get; init; }

    /// <summary>
    /// Preview containing abbreviated property values. Specified for <b>object</b> type values only.
    /// </summary>
    public ObjectPreview? Preview { get; init; }

    /// <summary>
    /// </summary>
    public CustomPreview? CustomPreview { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Header">
/// The JSON-stringified result of formatter.header(object, config) call.
/// It contains json ML array that represents RemoteObject.
/// </param>
public sealed record CustomPreview(string Header)
{
    /// <summary>
    /// If formatter returns true as a result of formatter.hasBody call then bodyGetterId will
    /// contain RemoteObjectId for the function that returns result of formatter.body(object, config) call.
    /// The result value is json ML array.
    /// </summary>
    public RemoteObjectId? BodyGetterId { get; init; }
}

/// <summary>
/// Object containing abbreviated remote object value.
/// </summary>
/// <param name="Type">
/// Object type.
/// </param>
/// <param name="Overflow">
/// True iff some of the properties or entries of the original object did not fit.
/// </param>
/// <param name="Properties">
/// List of the properties.
/// </param>
public sealed record ObjectPreview(string Type, bool Overflow, ImmutableArray<PropertyPreview> Properties)
{
    /// <summary>
    /// Object subtype hint. Specified for <b>object</b> type values only.
    /// </summary>
    public string? Subtype { get; init; }

    /// <summary>
    /// String representation of the object.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// List of the entries. Specified for <b>map</b> and <b>set</b> subtype values only.
    /// </summary>
    public ImmutableArray<EntryPreview>? Entries { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Name">
/// Property name.
/// </param>
/// <param name="Type">
/// Object type. Accessor means that the property itself is an accessor property.
/// </param>
public sealed record PropertyPreview(string Name, string Type)
{
    /// <summary>
    /// User-friendly property value string.
    /// </summary>
    public string? Value { get; init; }

    /// <summary>
    /// Nested value preview.
    /// </summary>
    public ObjectPreview? ValuePreview { get; init; }

    /// <summary>
    /// Object subtype hint. Specified for <b>object</b> type values only.
    /// </summary>
    public string? Subtype { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Value">
/// Preview of the value.
/// </param>
public sealed record EntryPreview(ObjectPreview Value)
{
    /// <summary>
    /// Preview of the key. Specified for map-like collection entries.
    /// </summary>
    public ObjectPreview? Key { get; init; }
}

/// <summary>
/// Object property descriptor.
/// </summary>
/// <param name="Name">
/// Property name or symbol description.
/// </param>
/// <param name="Configurable">
/// True if the type of this property descriptor may be changed and if the property may be
/// deleted from the corresponding object.
/// </param>
/// <param name="Enumerable">
/// True if this property shows up during enumeration of the properties on the corresponding
/// object.
/// </param>
public sealed record PropertyDescriptor(string Name, bool Configurable, bool Enumerable)
{
    /// <summary>
    /// The value associated with the property.
    /// </summary>
    public RemoteObject? Value { get; init; }

    /// <summary>
    /// True if the value associated with the property may be changed (data descriptors only).
    /// </summary>
    public bool? Writable { get; init; }

    /// <summary>
    /// A function which serves as a getter for the property, or <b>undefined</b> if there is no getter
    /// (accessor descriptors only).
    /// </summary>
    public RemoteObject? Get { get; init; }

    /// <summary>
    /// A function which serves as a setter for the property, or <b>undefined</b> if there is no setter
    /// (accessor descriptors only).
    /// </summary>
    public RemoteObject? Set { get; init; }

    /// <summary>
    /// True if the result was thrown during the evaluation.
    /// </summary>
    public bool? WasThrown { get; init; }

    /// <summary>
    /// True if the property is owned for the object.
    /// </summary>
    public bool? IsOwn { get; init; }

    /// <summary>
    /// Property symbol object, if the property is of the <b>symbol</b> type.
    /// </summary>
    public RemoteObject? Symbol { get; init; }
}

/// <summary>
/// Object internal property descriptor. This property isn't normally visible in JavaScript code.
/// </summary>
/// <param name="Name">
/// Conventional property name.
/// </param>
public sealed record InternalPropertyDescriptor(string Name)
{
    /// <summary>
    /// The value associated with the property.
    /// </summary>
    public RemoteObject? Value { get; init; }
}

/// <summary>
/// Object private field descriptor.
/// </summary>
/// <param name="Name">
/// Private property name.
/// </param>
public sealed record PrivatePropertyDescriptor(string Name)
{
    /// <summary>
    /// The value associated with the private property.
    /// </summary>
    public RemoteObject? Value { get; init; }

    /// <summary>
    /// A function which serves as a getter for the private property,
    /// or <b>undefined</b> if there is no getter (accessor descriptors only).
    /// </summary>
    public RemoteObject? Get { get; init; }

    /// <summary>
    /// A function which serves as a setter for the private property,
    /// or <b>undefined</b> if there is no setter (accessor descriptors only).
    /// </summary>
    public RemoteObject? Set { get; init; }
}

/// <summary>
/// Represents function call argument. Either remote object id <b>objectId</b>, primitive <b>value</b>,
/// unserializable primitive value or neither of (for undefined) them should be specified.
/// </summary>
public sealed record CallArgument()
{
    /// <summary>
    /// Primitive value or serializable javascript object.
    /// </summary>
    public global::System.Text.Json.JsonElement? Value { get; init; }

    /// <summary>
    /// Primitive value which can not be JSON-stringified.
    /// </summary>
    public UnserializableValue? UnserializableValue { get; init; }

    /// <summary>
    /// Remote object handle.
    /// </summary>
    public RemoteObjectId? ObjectId { get; init; }
}

/// <summary>
/// Id of an execution context.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<ExecutionContextId>))]
public record ExecutionContextId : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Description of an isolated world.
/// </summary>
/// <param name="Id">
/// Unique id of the execution context. It can be used to specify in which execution context
/// script evaluation should be performed.
/// </param>
/// <param name="Origin">
/// Execution context origin.
/// </param>
/// <param name="Name">
/// Human readable name describing given context.
/// </param>
/// <param name="UniqueId">
/// A system-unique execution context identifier. Unlike the id, this is unique across
/// multiple processes, so can be reliably used to identify specific context while backend
/// performs a cross-process navigation.
/// </param>
public sealed record ExecutionContextDescription(ExecutionContextId Id, string Origin, string Name, string UniqueId)
{
    /// <summary>
    /// Embedder-specific auxiliary data likely matching {isDefault: boolean, type: 'default'|'isolated'|'worker', frameId: string}
    /// </summary>
    public global::System.Text.Json.JsonElement? AuxData { get; init; }
}

/// <summary>
/// Detailed information about exception (or error) that was thrown during script compilation or
/// execution.
/// </summary>
/// <param name="ExceptionId">
/// Exception id.
/// </param>
/// <param name="Text">
/// Exception text, which should be used together with exception object when available.
/// </param>
/// <param name="LineNumber">
/// Line number of the exception location (0-based).
/// </param>
/// <param name="ColumnNumber">
/// Column number of the exception location (0-based).
/// </param>
public sealed record ExceptionDetails(long ExceptionId, string Text, long LineNumber, long ColumnNumber)
{
    /// <summary>
    /// Script ID of the exception location.
    /// </summary>
    public ScriptId? ScriptId { get; init; }

    /// <summary>
    /// URL of the exception location, to be used when the script was not reported.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// JavaScript stack trace if available.
    /// </summary>
    public StackTrace? StackTrace { get; init; }

    /// <summary>
    /// Exception object if available.
    /// </summary>
    public RemoteObject? Exception { get; init; }

    /// <summary>
    /// Identifier of the context where exception happened.
    /// </summary>
    public ExecutionContextId? ExecutionContextId { get; init; }

    /// <summary>
    /// Dictionary with entries of meta data that the client associated
    /// with this exception, such as information about associated network
    /// requests, etc.
    /// </summary>
    public global::System.Text.Json.JsonElement? ExceptionMetaData { get; init; }
}

/// <summary>
/// Number of milliseconds since epoch.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<Timestamp>))]
public record Timestamp : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Number of milliseconds.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<TimeDelta>))]
public record TimeDelta : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Stack entry for runtime errors and assertions.
/// </summary>
/// <param name="FunctionName">
/// JavaScript function name.
/// </param>
/// <param name="ScriptId">
/// JavaScript script id.
/// </param>
/// <param name="Url">
/// JavaScript script name or url.
/// </param>
/// <param name="LineNumber">
/// JavaScript script line number (0-based).
/// </param>
/// <param name="ColumnNumber">
/// JavaScript script column number (0-based).
/// </param>
public sealed record CallFrame(string FunctionName, ScriptId ScriptId, string Url, long LineNumber, long ColumnNumber)
{
}

/// <summary>
/// Call frames for assertions or error messages.
/// </summary>
/// <param name="CallFrames">
/// JavaScript function name.
/// </param>
public sealed record StackTrace(ImmutableArray<CallFrame> CallFrames)
{
    /// <summary>
    /// String label of this stack trace. For async traces this may be a name of the function that
    /// initiated the async call.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// Asynchronous JavaScript stack trace that preceded this stack, if available.
    /// </summary>
    public StackTrace? Parent { get; init; }

    /// <summary>
    /// Asynchronous JavaScript stack trace that preceded this stack, if available.
    /// </summary>
    public StackTraceId? ParentId { get; init; }
}

/// <summary>
/// Unique identifier of current debugger.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<UniqueDebuggerId>))]
public record UniqueDebuggerId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// If <b>debuggerId</b> is set stack trace comes from another debugger and can be resolved there. This
/// allows to track cross-debugger calls. See <b>Runtime.StackTrace</b> and <b>Debugger.paused</b> for usages.
/// </summary>
/// <param name="Id">
/// </param>
public sealed record StackTraceId(string Id)
{
    /// <summary>
    /// </summary>
    public UniqueDebuggerId? DebuggerId { get; init; }
}

[JsonSerializable(typeof(AwaitPromiseCommandParameters), TypeInfoPropertyName = "AwaitPromiseCommandParameters")]
[JsonSerializable(typeof(AwaitPromiseResult), TypeInfoPropertyName = "AwaitPromiseResult")]
[JsonSerializable(typeof(CallFunctionOnCommandParameters), TypeInfoPropertyName = "CallFunctionOnCommandParameters")]
[JsonSerializable(typeof(CallFunctionOnResult), TypeInfoPropertyName = "CallFunctionOnResult")]
[JsonSerializable(typeof(CompileScriptCommandParameters), TypeInfoPropertyName = "CompileScriptCommandParameters")]
[JsonSerializable(typeof(CompileScriptResult), TypeInfoPropertyName = "CompileScriptResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(DiscardConsoleEntriesCommandParameters), TypeInfoPropertyName = "DiscardConsoleEntriesCommandParameters")]
[JsonSerializable(typeof(DiscardConsoleEntriesResult), TypeInfoPropertyName = "DiscardConsoleEntriesResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(EvaluateCommandParameters), TypeInfoPropertyName = "EvaluateCommandParameters")]
[JsonSerializable(typeof(EvaluateResult), TypeInfoPropertyName = "EvaluateResult")]
[JsonSerializable(typeof(GetIsolateIdCommandParameters), TypeInfoPropertyName = "GetIsolateIdCommandParameters")]
[JsonSerializable(typeof(GetIsolateIdResult), TypeInfoPropertyName = "GetIsolateIdResult")]
[JsonSerializable(typeof(GetHeapUsageCommandParameters), TypeInfoPropertyName = "GetHeapUsageCommandParameters")]
[JsonSerializable(typeof(GetHeapUsageResult), TypeInfoPropertyName = "GetHeapUsageResult")]
[JsonSerializable(typeof(GetPropertiesCommandParameters), TypeInfoPropertyName = "GetPropertiesCommandParameters")]
[JsonSerializable(typeof(GetPropertiesResult), TypeInfoPropertyName = "GetPropertiesResult")]
[JsonSerializable(typeof(GlobalLexicalScopeNamesCommandParameters), TypeInfoPropertyName = "GlobalLexicalScopeNamesCommandParameters")]
[JsonSerializable(typeof(GlobalLexicalScopeNamesResult), TypeInfoPropertyName = "GlobalLexicalScopeNamesResult")]
[JsonSerializable(typeof(QueryObjectsCommandParameters), TypeInfoPropertyName = "QueryObjectsCommandParameters")]
[JsonSerializable(typeof(QueryObjectsResult), TypeInfoPropertyName = "QueryObjectsResult")]
[JsonSerializable(typeof(ReleaseObjectCommandParameters), TypeInfoPropertyName = "ReleaseObjectCommandParameters")]
[JsonSerializable(typeof(ReleaseObjectResult), TypeInfoPropertyName = "ReleaseObjectResult")]
[JsonSerializable(typeof(ReleaseObjectGroupCommandParameters), TypeInfoPropertyName = "ReleaseObjectGroupCommandParameters")]
[JsonSerializable(typeof(ReleaseObjectGroupResult), TypeInfoPropertyName = "ReleaseObjectGroupResult")]
[JsonSerializable(typeof(RunIfWaitingForDebuggerCommandParameters), TypeInfoPropertyName = "RunIfWaitingForDebuggerCommandParameters")]
[JsonSerializable(typeof(RunIfWaitingForDebuggerResult), TypeInfoPropertyName = "RunIfWaitingForDebuggerResult")]
[JsonSerializable(typeof(RunScriptCommandParameters), TypeInfoPropertyName = "RunScriptCommandParameters")]
[JsonSerializable(typeof(RunScriptResult), TypeInfoPropertyName = "RunScriptResult")]
[JsonSerializable(typeof(SetAsyncCallStackDepthCommandParameters), TypeInfoPropertyName = "SetAsyncCallStackDepthCommandParameters")]
[JsonSerializable(typeof(SetAsyncCallStackDepthResult), TypeInfoPropertyName = "SetAsyncCallStackDepthResult")]
[JsonSerializable(typeof(SetCustomObjectFormatterEnabledCommandParameters), TypeInfoPropertyName = "SetCustomObjectFormatterEnabledCommandParameters")]
[JsonSerializable(typeof(SetCustomObjectFormatterEnabledResult), TypeInfoPropertyName = "SetCustomObjectFormatterEnabledResult")]
[JsonSerializable(typeof(SetMaxCallStackSizeToCaptureCommandParameters), TypeInfoPropertyName = "SetMaxCallStackSizeToCaptureCommandParameters")]
[JsonSerializable(typeof(SetMaxCallStackSizeToCaptureResult), TypeInfoPropertyName = "SetMaxCallStackSizeToCaptureResult")]
[JsonSerializable(typeof(TerminateExecutionCommandParameters), TypeInfoPropertyName = "TerminateExecutionCommandParameters")]
[JsonSerializable(typeof(TerminateExecutionResult), TypeInfoPropertyName = "TerminateExecutionResult")]
[JsonSerializable(typeof(AddBindingCommandParameters), TypeInfoPropertyName = "AddBindingCommandParameters")]
[JsonSerializable(typeof(AddBindingResult), TypeInfoPropertyName = "AddBindingResult")]
[JsonSerializable(typeof(RemoveBindingCommandParameters), TypeInfoPropertyName = "RemoveBindingCommandParameters")]
[JsonSerializable(typeof(RemoveBindingResult), TypeInfoPropertyName = "RemoveBindingResult")]
[JsonSerializable(typeof(GetExceptionDetailsCommandParameters), TypeInfoPropertyName = "GetExceptionDetailsCommandParameters")]
[JsonSerializable(typeof(GetExceptionDetailsResult), TypeInfoPropertyName = "GetExceptionDetailsResult")]
[JsonSerializable(typeof(CdpEventArgs<BindingCalledEventArgs>), TypeInfoPropertyName = "BindingCalledCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ConsoleAPICalledEventArgs>), TypeInfoPropertyName = "ConsoleAPICalledCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ExceptionRevokedEventArgs>), TypeInfoPropertyName = "ExceptionRevokedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ExceptionThrownEventArgs>), TypeInfoPropertyName = "ExceptionThrownCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ExecutionContextCreatedEventArgs>), TypeInfoPropertyName = "ExecutionContextCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ExecutionContextDestroyedEventArgs>), TypeInfoPropertyName = "ExecutionContextDestroyedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ExecutionContextsClearedEventArgs>), TypeInfoPropertyName = "ExecutionContextsClearedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<InspectRequestedEventArgs>), TypeInfoPropertyName = "InspectRequestedCdpEventArgs")]
[JsonSerializable(typeof(ScriptId), TypeInfoPropertyName = "RuntimeScriptId")]
[JsonSerializable(typeof(SerializationOptions), TypeInfoPropertyName = "RuntimeSerializationOptions")]
[JsonSerializable(typeof(DeepSerializedValue), TypeInfoPropertyName = "RuntimeDeepSerializedValue")]
[JsonSerializable(typeof(RemoteObjectId), TypeInfoPropertyName = "RuntimeRemoteObjectId")]
[JsonSerializable(typeof(UnserializableValue), TypeInfoPropertyName = "RuntimeUnserializableValue")]
[JsonSerializable(typeof(RemoteObject), TypeInfoPropertyName = "RuntimeRemoteObject")]
[JsonSerializable(typeof(CustomPreview), TypeInfoPropertyName = "RuntimeCustomPreview")]
[JsonSerializable(typeof(ObjectPreview), TypeInfoPropertyName = "RuntimeObjectPreview")]
[JsonSerializable(typeof(PropertyPreview), TypeInfoPropertyName = "RuntimePropertyPreview")]
[JsonSerializable(typeof(EntryPreview), TypeInfoPropertyName = "RuntimeEntryPreview")]
[JsonSerializable(typeof(PropertyDescriptor), TypeInfoPropertyName = "RuntimePropertyDescriptor")]
[JsonSerializable(typeof(InternalPropertyDescriptor), TypeInfoPropertyName = "RuntimeInternalPropertyDescriptor")]
[JsonSerializable(typeof(PrivatePropertyDescriptor), TypeInfoPropertyName = "RuntimePrivatePropertyDescriptor")]
[JsonSerializable(typeof(CallArgument), TypeInfoPropertyName = "RuntimeCallArgument")]
[JsonSerializable(typeof(ExecutionContextId), TypeInfoPropertyName = "RuntimeExecutionContextId")]
[JsonSerializable(typeof(ExecutionContextDescription), TypeInfoPropertyName = "RuntimeExecutionContextDescription")]
[JsonSerializable(typeof(ExceptionDetails), TypeInfoPropertyName = "RuntimeExceptionDetails")]
[JsonSerializable(typeof(Timestamp), TypeInfoPropertyName = "RuntimeTimestamp")]
[JsonSerializable(typeof(TimeDelta), TypeInfoPropertyName = "RuntimeTimeDelta")]
[JsonSerializable(typeof(CallFrame), TypeInfoPropertyName = "RuntimeCallFrame")]
[JsonSerializable(typeof(StackTrace), TypeInfoPropertyName = "RuntimeStackTrace")]
[JsonSerializable(typeof(UniqueDebuggerId), TypeInfoPropertyName = "RuntimeUniqueDebuggerId")]
[JsonSerializable(typeof(StackTraceId), TypeInfoPropertyName = "RuntimeStackTraceId")]
[JsonSerializable(typeof(ImmutableArray<CallArgument>), TypeInfoPropertyName = "ImmutableArrayRuntimeCallArgument")]
[JsonSerializable(typeof(ImmutableArray<PropertyDescriptor>), TypeInfoPropertyName = "ImmutableArrayRuntimePropertyDescriptor")]
[JsonSerializable(typeof(ImmutableArray<InternalPropertyDescriptor>), TypeInfoPropertyName = "ImmutableArrayRuntimeInternalPropertyDescriptor")]
[JsonSerializable(typeof(ImmutableArray<PrivatePropertyDescriptor>), TypeInfoPropertyName = "ImmutableArrayRuntimePrivatePropertyDescriptor")]
[JsonSerializable(typeof(ImmutableArray<RemoteObject>), TypeInfoPropertyName = "ImmutableArrayRuntimeRemoteObject")]
[JsonSerializable(typeof(ImmutableArray<PropertyPreview>), TypeInfoPropertyName = "ImmutableArrayRuntimePropertyPreview")]
[JsonSerializable(typeof(ImmutableArray<EntryPreview>), TypeInfoPropertyName = "ImmutableArrayRuntimeEntryPreview")]
[JsonSerializable(typeof(ImmutableArray<CallFrame>), TypeInfoPropertyName = "ImmutableArrayRuntimeCallFrame")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class RuntimeJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="RuntimeDomain"/>.
/// </summary>
public static class RuntimeDomainEvent
{
    /// <summary>
    /// Notification is issued every time when binding is called.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<BindingCalledEventArgs>> BindingCalled { get; } =
        EventDescriptor<CdpEventArgs<BindingCalledEventArgs>>.Create(
            "goog:cdp.Runtime.bindingCalled",
            RuntimeJsonSerializerContext.Default.BindingCalledCdpEventArgs);

    /// <summary>
    /// Issued when console API was called.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ConsoleAPICalledEventArgs>> ConsoleAPICalled { get; } =
        EventDescriptor<CdpEventArgs<ConsoleAPICalledEventArgs>>.Create(
            "goog:cdp.Runtime.consoleAPICalled",
            RuntimeJsonSerializerContext.Default.ConsoleAPICalledCdpEventArgs);

    /// <summary>
    /// Issued when unhandled exception was revoked.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ExceptionRevokedEventArgs>> ExceptionRevoked { get; } =
        EventDescriptor<CdpEventArgs<ExceptionRevokedEventArgs>>.Create(
            "goog:cdp.Runtime.exceptionRevoked",
            RuntimeJsonSerializerContext.Default.ExceptionRevokedCdpEventArgs);

    /// <summary>
    /// Issued when exception was thrown and unhandled.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ExceptionThrownEventArgs>> ExceptionThrown { get; } =
        EventDescriptor<CdpEventArgs<ExceptionThrownEventArgs>>.Create(
            "goog:cdp.Runtime.exceptionThrown",
            RuntimeJsonSerializerContext.Default.ExceptionThrownCdpEventArgs);

    /// <summary>
    /// Issued when new execution context is created.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ExecutionContextCreatedEventArgs>> ExecutionContextCreated { get; } =
        EventDescriptor<CdpEventArgs<ExecutionContextCreatedEventArgs>>.Create(
            "goog:cdp.Runtime.executionContextCreated",
            RuntimeJsonSerializerContext.Default.ExecutionContextCreatedCdpEventArgs);

    /// <summary>
    /// Issued when execution context is destroyed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ExecutionContextDestroyedEventArgs>> ExecutionContextDestroyed { get; } =
        EventDescriptor<CdpEventArgs<ExecutionContextDestroyedEventArgs>>.Create(
            "goog:cdp.Runtime.executionContextDestroyed",
            RuntimeJsonSerializerContext.Default.ExecutionContextDestroyedCdpEventArgs);

    /// <summary>
    /// Issued when all executionContexts were cleared in browser
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ExecutionContextsClearedEventArgs>> ExecutionContextsCleared { get; } =
        EventDescriptor<CdpEventArgs<ExecutionContextsClearedEventArgs>>.Create(
            "goog:cdp.Runtime.executionContextsCleared",
            RuntimeJsonSerializerContext.Default.ExecutionContextsClearedCdpEventArgs);

    /// <summary>
    /// Issued when object should be inspected (for example, as a result of inspect() command line API
    /// call).
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InspectRequestedEventArgs>> InspectRequested { get; } =
        EventDescriptor<CdpEventArgs<InspectRequestedEventArgs>>.Create(
            "goog:cdp.Runtime.inspectRequested",
            RuntimeJsonSerializerContext.Default.InspectRequestedCdpEventArgs);

}
