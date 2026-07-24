#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Debugger;

/// <summary>
/// Debugger domain exposes JavaScript debugging capabilities. It allows setting and removing
/// breakpoints, stepping through execution, exploring stack traces, etc.
/// </summary>
public sealed class DebuggerDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static DebuggerJsonSerializerContext JsonContext = DebuggerJsonSerializerContext.Default;

    /// <summary>
    /// Continues execution until specific location is reached.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetCallFrames</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="location">
    /// Location to continue to.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ContinueToLocationCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ContinueToLocationResult"/>.
    /// </returns>
    public async Task<ContinueToLocationResult> ContinueToLocationAsync(Location location, ContinueToLocationCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ContinueToLocationCommandParameters(Location: location, TargetCallFrames: options?.TargetCallFrames);
        return await ExecuteCommandAsync(ContinueToLocationCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ContinueToLocationCommandParameters, ContinueToLocationResult> ContinueToLocationCommand = new("Debugger.continueToLocation", JsonContext.ContinueToLocationCommandParameters, JsonContext.ContinueToLocationResult);

    /// <summary>
    /// Disables debugger for given page.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="DisableCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisableResult"/>.
    /// </returns>
    public async Task<DisableResult> DisableAsync(DisableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Debugger.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables debugger for the given page. Clients should not assume that the debugging has been
    /// enabled until the result for this command is received.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>MaxScriptsCacheSize</b> - The maximum size in bytes of collected scripts (not referenced by other heap objects) the debugger can hold. Puts no limit if parameter is omitted.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="EnableCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    public async Task<EnableResult> EnableAsync(EnableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(MaxScriptsCacheSize: options?.MaxScriptsCacheSize);
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Debugger.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Evaluates expression on a given call frame.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>ObjectGroup</b> - String object group name to put result into (allows rapid releasing resulting object handles using <b>releaseObjectGroup</b>).</description></item>
    /// <item><description><b>IncludeCommandLineAPI</b> - Specifies whether command line API should be available to the evaluated expression, defaults to false.</description></item>
    /// <item><description><b>Silent</b> - In silent mode exceptions thrown during evaluation are not reported and do not pause execution. Overrides <b>setPauseOnException</b> state.</description></item>
    /// <item><description><b>ReturnByValue</b> - Whether the result is expected to be a JSON object that should be sent by value.</description></item>
    /// <item><description><b>GeneratePreview</b> - Whether preview should be generated for the result.</description></item>
    /// <item><description><b>ThrowOnSideEffect</b> - Whether to throw an exception if side effect cannot be ruled out during evaluation.</description></item>
    /// <item><description><b>Timeout</b> - Terminate execution after timing out (number of milliseconds).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="callFrameId">
    /// Call frame identifier to evaluate on.
    /// </param>
    /// <param name="expression">
    /// Expression to evaluate.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="EvaluateOnCallFrameCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EvaluateOnCallFrameResult"/>.
    /// </returns>
    public async Task<EvaluateOnCallFrameResult> EvaluateOnCallFrameAsync(CallFrameId callFrameId, string expression, EvaluateOnCallFrameCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new EvaluateOnCallFrameCommandParameters(CallFrameId: callFrameId, Expression: expression, ObjectGroup: options?.ObjectGroup, IncludeCommandLineAPI: options?.IncludeCommandLineAPI, Silent: options?.Silent, ReturnByValue: options?.ReturnByValue, GeneratePreview: options?.GeneratePreview, ThrowOnSideEffect: options?.ThrowOnSideEffect, Timeout: options?.Timeout);
        return await ExecuteCommandAsync(EvaluateOnCallFrameCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EvaluateOnCallFrameCommandParameters, EvaluateOnCallFrameResult> EvaluateOnCallFrameCommand = new("Debugger.evaluateOnCallFrame", JsonContext.EvaluateOnCallFrameCommandParameters, JsonContext.EvaluateOnCallFrameResult);

    /// <summary>
    /// Returns possible locations for breakpoint. scriptId in start and end range locations should be
    /// the same.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>End</b> - End of range to search possible breakpoint locations in (excluding). When not specified, end of scripts is used as end of range.</description></item>
    /// <item><description><b>RestrictToFunction</b> - Only consider locations which are in the same (non-nested) function as start.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="start">
    /// Start of range to search possible breakpoint locations in.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetPossibleBreakpointsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPossibleBreakpointsResult"/>.
    /// </returns>
    public async Task<GetPossibleBreakpointsResult> GetPossibleBreakpointsAsync(Location start, GetPossibleBreakpointsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetPossibleBreakpointsCommandParameters(Start: start, End: options?.End, RestrictToFunction: options?.RestrictToFunction);
        return await ExecuteCommandAsync(GetPossibleBreakpointsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetPossibleBreakpointsCommandParameters, GetPossibleBreakpointsResult> GetPossibleBreakpointsCommand = new("Debugger.getPossibleBreakpoints", JsonContext.GetPossibleBreakpointsCommandParameters, JsonContext.GetPossibleBreakpointsResult);

    /// <summary>
    /// Returns source for the script with given id.
    /// </summary>
    /// <param name="scriptId">
    /// Id of the script to get source for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetScriptSourceCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetScriptSourceResult"/>.
    /// </returns>
    public async Task<GetScriptSourceResult> GetScriptSourceAsync(Runtime.ScriptId scriptId, GetScriptSourceCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetScriptSourceCommandParameters(ScriptId: scriptId);
        return await ExecuteCommandAsync(GetScriptSourceCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetScriptSourceCommandParameters, GetScriptSourceResult> GetScriptSourceCommand = new("Debugger.getScriptSource", JsonContext.GetScriptSourceCommandParameters, JsonContext.GetScriptSourceResult);

    /// <summary>
    /// </summary>
    /// <param name="scriptId">
    /// Id of the script to disassemble
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DisassembleWasmModuleCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisassembleWasmModuleResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<DisassembleWasmModuleResult> DisassembleWasmModuleAsync(Runtime.ScriptId scriptId, DisassembleWasmModuleCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisassembleWasmModuleCommandParameters(ScriptId: scriptId);
        return await ExecuteCommandAsync(DisassembleWasmModuleCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisassembleWasmModuleCommandParameters, DisassembleWasmModuleResult> DisassembleWasmModuleCommand = new("Debugger.disassembleWasmModule", JsonContext.DisassembleWasmModuleCommandParameters, JsonContext.DisassembleWasmModuleResult);

    /// <summary>
    /// Disassemble the next chunk of lines for the module corresponding to the
    /// stream. If disassembly is complete, this API will invalidate the streamId
    /// and return an empty chunk. Any subsequent calls for the now invalid stream
    /// will return errors.
    /// </summary>
    /// <param name="streamId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="NextWasmDisassemblyChunkCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="NextWasmDisassemblyChunkResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<NextWasmDisassemblyChunkResult> NextWasmDisassemblyChunkAsync(string streamId, NextWasmDisassemblyChunkCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new NextWasmDisassemblyChunkCommandParameters(StreamId: streamId);
        return await ExecuteCommandAsync(NextWasmDisassemblyChunkCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<NextWasmDisassemblyChunkCommandParameters, NextWasmDisassemblyChunkResult> NextWasmDisassemblyChunkCommand = new("Debugger.nextWasmDisassemblyChunk", JsonContext.NextWasmDisassemblyChunkCommandParameters, JsonContext.NextWasmDisassemblyChunkResult);

    /// <summary>
    /// This command is deprecated. Use getScriptSource instead.
    /// </summary>
    /// <param name="scriptId">
    /// Id of the Wasm script to get source for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetWasmBytecodeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetWasmBytecodeResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<GetWasmBytecodeResult> GetWasmBytecodeAsync(Runtime.ScriptId scriptId, GetWasmBytecodeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetWasmBytecodeCommandParameters(ScriptId: scriptId);
        return await ExecuteCommandAsync(GetWasmBytecodeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetWasmBytecodeCommandParameters, GetWasmBytecodeResult> GetWasmBytecodeCommand = new("Debugger.getWasmBytecode", JsonContext.GetWasmBytecodeCommandParameters, JsonContext.GetWasmBytecodeResult);

    /// <summary>
    /// Returns stack trace with given <b>stackTraceId</b>.
    /// </summary>
    /// <param name="stackTraceId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetStackTraceCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStackTraceResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetStackTraceResult> GetStackTraceAsync(Runtime.StackTraceId stackTraceId, GetStackTraceCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetStackTraceCommandParameters(StackTraceId: stackTraceId);
        return await ExecuteCommandAsync(GetStackTraceCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetStackTraceCommandParameters, GetStackTraceResult> GetStackTraceCommand = new("Debugger.getStackTrace", JsonContext.GetStackTraceCommandParameters, JsonContext.GetStackTraceResult);

    /// <summary>
    /// Stops on the next JavaScript statement.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="PauseCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PauseResult"/>.
    /// </returns>
    public async Task<PauseResult> PauseAsync(PauseCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new PauseCommandParameters();
        return await ExecuteCommandAsync(PauseCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PauseCommandParameters, PauseResult> PauseCommand = new("Debugger.pause", JsonContext.PauseCommandParameters, JsonContext.PauseResult);

    /// <summary>
    /// </summary>
    /// <param name="parentStackTraceId">
    /// Debugger will pause when async call with given stack trace is started.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="PauseOnAsyncCallCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PauseOnAsyncCallResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<PauseOnAsyncCallResult> PauseOnAsyncCallAsync(Runtime.StackTraceId parentStackTraceId, PauseOnAsyncCallCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new PauseOnAsyncCallCommandParameters(ParentStackTraceId: parentStackTraceId);
        return await ExecuteCommandAsync(PauseOnAsyncCallCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PauseOnAsyncCallCommandParameters, PauseOnAsyncCallResult> PauseOnAsyncCallCommand = new("Debugger.pauseOnAsyncCall", JsonContext.PauseOnAsyncCallCommandParameters, JsonContext.PauseOnAsyncCallResult);

    /// <summary>
    /// Removes JavaScript breakpoint.
    /// </summary>
    /// <param name="breakpointId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RemoveBreakpointCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveBreakpointResult"/>.
    /// </returns>
    public async Task<RemoveBreakpointResult> RemoveBreakpointAsync(BreakpointId breakpointId, RemoveBreakpointCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveBreakpointCommandParameters(BreakpointId: breakpointId);
        return await ExecuteCommandAsync(RemoveBreakpointCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveBreakpointCommandParameters, RemoveBreakpointResult> RemoveBreakpointCommand = new("Debugger.removeBreakpoint", JsonContext.RemoveBreakpointCommandParameters, JsonContext.RemoveBreakpointResult);

    /// <summary>
    /// Restarts particular call frame from the beginning. The old, deprecated
    /// behavior of <b>restartFrame</b> is to stay paused and allow further CDP commands
    /// after a restart was scheduled. This can cause problems with restarting, so
    /// we now continue execution immediatly after it has been scheduled until we
    /// reach the beginning of the restarted frame.
    /// 
    /// To stay back-wards compatible, <b>restartFrame</b> now expects a <b>mode</b>
    /// parameter to be present. If the <b>mode</b> parameter is missing, <b>restartFrame</b>
    /// errors out.
    /// 
    /// The various return values are deprecated and <b>callFrames</b> is always empty.
    /// Use the call frames from the <b>Debugger#paused</b> events instead, that fires
    /// once V8 pauses at the beginning of the restarted function.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Mode</b> - The <b>mode</b> parameter must be present and set to 'StepInto', otherwise <b>restartFrame</b> will error out.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="callFrameId">
    /// Call frame identifier to evaluate on.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RestartFrameCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RestartFrameResult"/>.
    /// </returns>
    public async Task<RestartFrameResult> RestartFrameAsync(CallFrameId callFrameId, RestartFrameCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RestartFrameCommandParameters(CallFrameId: callFrameId, Mode: options?.Mode);
        return await ExecuteCommandAsync(RestartFrameCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RestartFrameCommandParameters, RestartFrameResult> RestartFrameCommand = new("Debugger.restartFrame", JsonContext.RestartFrameCommandParameters, JsonContext.RestartFrameResult);

    /// <summary>
    /// Resumes JavaScript execution.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>TerminateOnResume</b> - Set to true to terminate execution upon resuming execution. In contrast to Runtime.terminateExecution, this will allows to execute further JavaScript (i.e. via evaluation) until execution of the paused code is actually resumed, at which point termination is triggered. If execution is currently not paused, this parameter has no effect.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="ResumeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResumeResult"/>.
    /// </returns>
    public async Task<ResumeResult> ResumeAsync(ResumeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResumeCommandParameters(TerminateOnResume: options?.TerminateOnResume);
        return await ExecuteCommandAsync(ResumeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResumeCommandParameters, ResumeResult> ResumeCommand = new("Debugger.resume", JsonContext.ResumeCommandParameters, JsonContext.ResumeResult);

    /// <summary>
    /// Searches for given string in script content.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>CaseSensitive</b> - If true, search is case sensitive.</description></item>
    /// <item><description><b>IsRegex</b> - If true, treats string parameter as regex.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="scriptId">
    /// Id of the script to search in.
    /// </param>
    /// <param name="query">
    /// String to search for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SearchInContentCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SearchInContentResult"/>.
    /// </returns>
    public async Task<SearchInContentResult> SearchInContentAsync(Runtime.ScriptId scriptId, string query, SearchInContentCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SearchInContentCommandParameters(ScriptId: scriptId, Query: query, CaseSensitive: options?.CaseSensitive, IsRegex: options?.IsRegex);
        return await ExecuteCommandAsync(SearchInContentCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SearchInContentCommandParameters, SearchInContentResult> SearchInContentCommand = new("Debugger.searchInContent", JsonContext.SearchInContentCommandParameters, JsonContext.SearchInContentResult);

    /// <summary>
    /// Enables or disables async call stacks tracking.
    /// </summary>
    /// <param name="maxDepth">
    /// Maximum depth of async call stacks. Setting to <b>0</b> will effectively disable collecting async
    /// call stacks (default).
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetAsyncCallStackDepthCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAsyncCallStackDepthResult"/>.
    /// </returns>
    public async Task<SetAsyncCallStackDepthResult> SetAsyncCallStackDepthAsync(long maxDepth, SetAsyncCallStackDepthCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAsyncCallStackDepthCommandParameters(MaxDepth: maxDepth);
        return await ExecuteCommandAsync(SetAsyncCallStackDepthCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAsyncCallStackDepthCommandParameters, SetAsyncCallStackDepthResult> SetAsyncCallStackDepthCommand = new("Debugger.setAsyncCallStackDepth", JsonContext.SetAsyncCallStackDepthCommandParameters, JsonContext.SetAsyncCallStackDepthResult);

    /// <summary>
    /// Replace previous blackbox execution contexts with passed ones. Forces backend to skip
    /// stepping/pausing in scripts in these execution contexts. VM will try to leave blackboxed script by
    /// performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
    /// </summary>
    /// <param name="uniqueIds">
    /// Array of execution context unique ids for the debugger to ignore.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBlackboxExecutionContextsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBlackboxExecutionContextsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetBlackboxExecutionContextsResult> SetBlackboxExecutionContextsAsync(ImmutableArray<string> uniqueIds, SetBlackboxExecutionContextsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBlackboxExecutionContextsCommandParameters(UniqueIds: uniqueIds);
        return await ExecuteCommandAsync(SetBlackboxExecutionContextsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBlackboxExecutionContextsCommandParameters, SetBlackboxExecutionContextsResult> SetBlackboxExecutionContextsCommand = new("Debugger.setBlackboxExecutionContexts", JsonContext.SetBlackboxExecutionContextsCommandParameters, JsonContext.SetBlackboxExecutionContextsResult);

    /// <summary>
    /// Replace previous blackbox patterns with passed ones. Forces backend to skip stepping/pausing in
    /// scripts with url matching one of the patterns. VM will try to leave blackboxed script by
    /// performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SkipAnonymous</b> - If true, also ignore scripts with no source url.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="patterns">
    /// Array of regexps that will be used to check script url for blackbox state.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBlackboxPatternsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBlackboxPatternsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetBlackboxPatternsResult> SetBlackboxPatternsAsync(ImmutableArray<string> patterns, SetBlackboxPatternsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBlackboxPatternsCommandParameters(Patterns: patterns, SkipAnonymous: options?.SkipAnonymous);
        return await ExecuteCommandAsync(SetBlackboxPatternsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBlackboxPatternsCommandParameters, SetBlackboxPatternsResult> SetBlackboxPatternsCommand = new("Debugger.setBlackboxPatterns", JsonContext.SetBlackboxPatternsCommandParameters, JsonContext.SetBlackboxPatternsResult);

    /// <summary>
    /// Makes backend skip steps in the script in blackboxed ranges. VM will try leave blacklisted
    /// scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
    /// Positions array contains positions where blackbox state is changed. First interval isn't
    /// blackboxed. Array should be sorted.
    /// </summary>
    /// <param name="scriptId">
    /// Id of the script.
    /// </param>
    /// <param name="positions">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBlackboxedRangesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBlackboxedRangesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetBlackboxedRangesResult> SetBlackboxedRangesAsync(Runtime.ScriptId scriptId, ImmutableArray<ScriptPosition> positions, SetBlackboxedRangesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBlackboxedRangesCommandParameters(ScriptId: scriptId, Positions: positions);
        return await ExecuteCommandAsync(SetBlackboxedRangesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBlackboxedRangesCommandParameters, SetBlackboxedRangesResult> SetBlackboxedRangesCommand = new("Debugger.setBlackboxedRanges", JsonContext.SetBlackboxedRangesCommandParameters, JsonContext.SetBlackboxedRangesResult);

    /// <summary>
    /// Sets JavaScript breakpoint at a given location.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Condition</b> - Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="location">
    /// Location to set breakpoint in.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBreakpointCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBreakpointResult"/>.
    /// </returns>
    public async Task<SetBreakpointResult> SetBreakpointAsync(Location location, SetBreakpointCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBreakpointCommandParameters(Location: location, Condition: options?.Condition);
        return await ExecuteCommandAsync(SetBreakpointCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBreakpointCommandParameters, SetBreakpointResult> SetBreakpointCommand = new("Debugger.setBreakpoint", JsonContext.SetBreakpointCommandParameters, JsonContext.SetBreakpointResult);

    /// <summary>
    /// Sets instrumentation breakpoint.
    /// </summary>
    /// <param name="instrumentation">
    /// Instrumentation name.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetInstrumentationBreakpointCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetInstrumentationBreakpointResult"/>.
    /// </returns>
    public async Task<SetInstrumentationBreakpointResult> SetInstrumentationBreakpointAsync(string instrumentation, SetInstrumentationBreakpointCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetInstrumentationBreakpointCommandParameters(Instrumentation: instrumentation);
        return await ExecuteCommandAsync(SetInstrumentationBreakpointCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetInstrumentationBreakpointCommandParameters, SetInstrumentationBreakpointResult> SetInstrumentationBreakpointCommand = new("Debugger.setInstrumentationBreakpoint", JsonContext.SetInstrumentationBreakpointCommandParameters, JsonContext.SetInstrumentationBreakpointResult);

    /// <summary>
    /// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this
    /// command is issued, all existing parsed scripts will have breakpoints resolved and returned in
    /// <b>locations</b> property. Further matching script parsing will result in subsequent
    /// <b>breakpointResolved</b> events issued. This logical breakpoint will survive page reloads.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Url</b> - URL of the resources to set breakpoint on.</description></item>
    /// <item><description><b>UrlRegex</b> - Regex pattern for the URLs of the resources to set breakpoints on. Either <b>url</b> or <b>urlRegex</b> must be specified.</description></item>
    /// <item><description><b>ScriptHash</b> - Script hash of the resources to set breakpoint on.</description></item>
    /// <item><description><b>ColumnNumber</b> - Offset in the line to set breakpoint at.</description></item>
    /// <item><description><b>Condition</b> - Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="lineNumber">
    /// Line number to set breakpoint at.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBreakpointByUrlCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBreakpointByUrlResult"/>.
    /// </returns>
    public async Task<SetBreakpointByUrlResult> SetBreakpointByUrlAsync(long lineNumber, SetBreakpointByUrlCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBreakpointByUrlCommandParameters(LineNumber: lineNumber, Url: options?.Url, UrlRegex: options?.UrlRegex, ScriptHash: options?.ScriptHash, ColumnNumber: options?.ColumnNumber, Condition: options?.Condition);
        return await ExecuteCommandAsync(SetBreakpointByUrlCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBreakpointByUrlCommandParameters, SetBreakpointByUrlResult> SetBreakpointByUrlCommand = new("Debugger.setBreakpointByUrl", JsonContext.SetBreakpointByUrlCommandParameters, JsonContext.SetBreakpointByUrlResult);

    /// <summary>
    /// Sets JavaScript breakpoint before each call to the given function.
    /// If another function was created from the same source as a given one,
    /// calling it will also trigger the breakpoint.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Condition</b> - Expression to use as a breakpoint condition. When specified, debugger will stop on the breakpoint if this expression evaluates to true.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="objectId">
    /// Function object id.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBreakpointOnFunctionCallCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBreakpointOnFunctionCallResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetBreakpointOnFunctionCallResult> SetBreakpointOnFunctionCallAsync(Runtime.RemoteObjectId objectId, SetBreakpointOnFunctionCallCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBreakpointOnFunctionCallCommandParameters(ObjectId: objectId, Condition: options?.Condition);
        return await ExecuteCommandAsync(SetBreakpointOnFunctionCallCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBreakpointOnFunctionCallCommandParameters, SetBreakpointOnFunctionCallResult> SetBreakpointOnFunctionCallCommand = new("Debugger.setBreakpointOnFunctionCall", JsonContext.SetBreakpointOnFunctionCallCommandParameters, JsonContext.SetBreakpointOnFunctionCallResult);

    /// <summary>
    /// Activates / deactivates all breakpoints on the page.
    /// </summary>
    /// <param name="active">
    /// New value for breakpoints active state.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBreakpointsActiveCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBreakpointsActiveResult"/>.
    /// </returns>
    public async Task<SetBreakpointsActiveResult> SetBreakpointsActiveAsync(bool active, SetBreakpointsActiveCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBreakpointsActiveCommandParameters(Active: active);
        return await ExecuteCommandAsync(SetBreakpointsActiveCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBreakpointsActiveCommandParameters, SetBreakpointsActiveResult> SetBreakpointsActiveCommand = new("Debugger.setBreakpointsActive", JsonContext.SetBreakpointsActiveCommandParameters, JsonContext.SetBreakpointsActiveResult);

    /// <summary>
    /// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions,
    /// or caught exceptions, no exceptions. Initial pause on exceptions state is <b>none</b>.
    /// </summary>
    /// <param name="state">
    /// Pause on exceptions mode.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetPauseOnExceptionsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPauseOnExceptionsResult"/>.
    /// </returns>
    public async Task<SetPauseOnExceptionsResult> SetPauseOnExceptionsAsync(string state, SetPauseOnExceptionsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPauseOnExceptionsCommandParameters(State: state);
        return await ExecuteCommandAsync(SetPauseOnExceptionsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPauseOnExceptionsCommandParameters, SetPauseOnExceptionsResult> SetPauseOnExceptionsCommand = new("Debugger.setPauseOnExceptions", JsonContext.SetPauseOnExceptionsCommandParameters, JsonContext.SetPauseOnExceptionsResult);

    /// <summary>
    /// Changes return value in top frame. Available only at return break position.
    /// </summary>
    /// <param name="newValue">
    /// New return value.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetReturnValueCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetReturnValueResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetReturnValueResult> SetReturnValueAsync(Runtime.CallArgument newValue, SetReturnValueCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetReturnValueCommandParameters(NewValue: newValue);
        return await ExecuteCommandAsync(SetReturnValueCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetReturnValueCommandParameters, SetReturnValueResult> SetReturnValueCommand = new("Debugger.setReturnValue", JsonContext.SetReturnValueCommandParameters, JsonContext.SetReturnValueResult);

    /// <summary>
    /// Edits JavaScript source live.
    /// 
    /// In general, functions that are currently on the stack can not be edited with
    /// a single exception: If the edited function is the top-most stack frame and
    /// that is the only activation of that function on the stack. In this case
    /// the live edit will be successful and a <b>Debugger.restartFrame</b> for the
    /// top-most function is automatically triggered.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>DryRun</b> - If true the change will not actually be applied. Dry run may be used to get result description without actually modifying the code.</description></item>
    /// <item><description><b>AllowTopFrameEditing</b> - If true, then <b>scriptSource</b> is allowed to change the function on top of the stack as long as the top-most stack frame is the only activation of that function.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="scriptId">
    /// Id of the script to edit.
    /// </param>
    /// <param name="scriptSource">
    /// New content of the script.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetScriptSourceCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetScriptSourceResult"/>.
    /// </returns>
    public async Task<SetScriptSourceResult> SetScriptSourceAsync(Runtime.ScriptId scriptId, string scriptSource, SetScriptSourceCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetScriptSourceCommandParameters(ScriptId: scriptId, ScriptSource: scriptSource, DryRun: options?.DryRun, AllowTopFrameEditing: options?.AllowTopFrameEditing);
        return await ExecuteCommandAsync(SetScriptSourceCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetScriptSourceCommandParameters, SetScriptSourceResult> SetScriptSourceCommand = new("Debugger.setScriptSource", JsonContext.SetScriptSourceCommandParameters, JsonContext.SetScriptSourceResult);

    /// <summary>
    /// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
    /// </summary>
    /// <param name="skip">
    /// New value for skip pauses state.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetSkipAllPausesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSkipAllPausesResult"/>.
    /// </returns>
    public async Task<SetSkipAllPausesResult> SetSkipAllPausesAsync(bool skip, SetSkipAllPausesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSkipAllPausesCommandParameters(Skip: skip);
        return await ExecuteCommandAsync(SetSkipAllPausesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSkipAllPausesCommandParameters, SetSkipAllPausesResult> SetSkipAllPausesCommand = new("Debugger.setSkipAllPauses", JsonContext.SetSkipAllPausesCommandParameters, JsonContext.SetSkipAllPausesResult);

    /// <summary>
    /// Changes value of variable in a callframe. Object-based scopes are not supported and must be
    /// mutated manually.
    /// </summary>
    /// <param name="scopeNumber">
    /// 0-based number of scope as was listed in scope chain. Only 'local', 'closure' and 'catch'
    /// scope types are allowed. Other scopes could be manipulated manually.
    /// </param>
    /// <param name="variableName">
    /// Variable name.
    /// </param>
    /// <param name="newValue">
    /// New variable value.
    /// </param>
    /// <param name="callFrameId">
    /// Id of callframe that holds variable.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetVariableValueCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetVariableValueResult"/>.
    /// </returns>
    public async Task<SetVariableValueResult> SetVariableValueAsync(long scopeNumber, string variableName, Runtime.CallArgument newValue, CallFrameId callFrameId, SetVariableValueCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetVariableValueCommandParameters(ScopeNumber: scopeNumber, VariableName: variableName, NewValue: newValue, CallFrameId: callFrameId);
        return await ExecuteCommandAsync(SetVariableValueCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetVariableValueCommandParameters, SetVariableValueResult> SetVariableValueCommand = new("Debugger.setVariableValue", JsonContext.SetVariableValueCommandParameters, JsonContext.SetVariableValueResult);

    /// <summary>
    /// Steps into the function call.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BreakOnAsyncCall</b> - Debugger will pause on the execution of the first async task which was scheduled before next pause.</description></item>
    /// <item><description><b>SkipList</b> - The skipList specifies location ranges that should be skipped on step into.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="StepIntoCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StepIntoResult"/>.
    /// </returns>
    public async Task<StepIntoResult> StepIntoAsync(StepIntoCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StepIntoCommandParameters(BreakOnAsyncCall: options?.BreakOnAsyncCall, SkipList: options?.SkipList);
        return await ExecuteCommandAsync(StepIntoCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StepIntoCommandParameters, StepIntoResult> StepIntoCommand = new("Debugger.stepInto", JsonContext.StepIntoCommandParameters, JsonContext.StepIntoResult);

    /// <summary>
    /// Steps out of the function call.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StepOutCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StepOutResult"/>.
    /// </returns>
    public async Task<StepOutResult> StepOutAsync(StepOutCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StepOutCommandParameters();
        return await ExecuteCommandAsync(StepOutCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StepOutCommandParameters, StepOutResult> StepOutCommand = new("Debugger.stepOut", JsonContext.StepOutCommandParameters, JsonContext.StepOutResult);

    /// <summary>
    /// Steps over the statement.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SkipList</b> - The skipList specifies location ranges that should be skipped on step over.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="StepOverCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StepOverResult"/>.
    /// </returns>
    public async Task<StepOverResult> StepOverAsync(StepOverCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StepOverCommandParameters(SkipList: options?.SkipList);
        return await ExecuteCommandAsync(StepOverCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StepOverCommandParameters, StepOverResult> StepOverCommand = new("Debugger.stepOver", JsonContext.StepOverCommandParameters, JsonContext.StepOverResult);

    /// <summary>
    /// Fired when breakpoint is resolved to an actual script and location.
    /// Deprecated in favor of <b>resolvedBreakpoints</b> in the <b>scriptParsed</b> event.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="BreakpointResolvedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BreakpointId</b> - Breakpoint unique identifier.</description></item>
    /// <item><description><b>Location</b> - Actual breakpoint location.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Obsolete]
    public IEventSource<BreakpointResolvedEventArgs> BreakpointResolved => CreateCdpEventSource(DebuggerDomainEvent.BreakpointResolved);
    /// <summary>
    /// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PausedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>CallFrames</b> - Call stack the virtual machine stopped on.</description></item>
    /// <item><description><b>Reason</b> - Pause reason.</description></item>
    /// <item><description><b>Data</b> - Object containing break-specific auxiliary properties.</description></item>
    /// <item><description><b>HitBreakpoints</b> - Hit breakpoints IDs</description></item>
    /// <item><description><b>AsyncStackTrace</b> - Async stack trace, if any.</description></item>
    /// <item><description><b>AsyncStackTraceId</b> - Async stack trace, if any.</description></item>
    /// <item><description><b>AsyncCallStackTraceId</b> - Never present, will be removed.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<PausedEventArgs> Paused => CreateCdpEventSource(DebuggerDomainEvent.Paused);
    /// <summary>
    /// Fired when the virtual machine resumed execution.
    /// </summary>
    public IEventSource<ResumedEventArgs> Resumed => CreateCdpEventSource(DebuggerDomainEvent.Resumed);
    /// <summary>
    /// Fired when virtual machine fails to parse the script.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ScriptFailedToParseEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ScriptId</b> - Identifier of the script parsed.</description></item>
    /// <item><description><b>Url</b> - URL or name of the script parsed (if any).</description></item>
    /// <item><description><b>StartLine</b> - Line offset of the script within the resource with given URL (for script tags).</description></item>
    /// <item><description><b>StartColumn</b> - Column offset of the script within the resource with given URL.</description></item>
    /// <item><description><b>EndLine</b> - Last line of the script.</description></item>
    /// <item><description><b>EndColumn</b> - Length of the last line of the script.</description></item>
    /// <item><description><b>ExecutionContextId</b> - Specifies script creation context.</description></item>
    /// <item><description><b>Hash</b> - Content hash of the script, SHA-256.</description></item>
    /// <item><description><b>BuildId</b> - For Wasm modules, the content of the <b>build_id</b> custom section. For JavaScript the <b>debugId</b> magic comment.</description></item>
    /// <item><description><b>ExecutionContextAuxData</b> - Embedder-specific auxiliary data likely matching {isDefault: boolean, type: 'default'|'isolated'|'worker', frameId: string}</description></item>
    /// <item><description><b>SourceMapURL</b> - URL of source map associated with script (if any).</description></item>
    /// <item><description><b>HasSourceURL</b> - True, if this script has sourceURL.</description></item>
    /// <item><description><b>IsModule</b> - True, if this script is ES6 module.</description></item>
    /// <item><description><b>Length</b> - This script length.</description></item>
    /// <item><description><b>StackTrace</b> - JavaScript top stack frame of where the script parsed event was triggered if available.</description></item>
    /// <item><description><b>CodeOffset</b> - If the scriptLanguage is WebAssembly, the code section offset in the module.</description></item>
    /// <item><description><b>ScriptLanguage</b> - The language of the script.</description></item>
    /// <item><description><b>EmbedderName</b> - The name the embedder supplied for this script.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ScriptFailedToParseEventArgs> ScriptFailedToParse => CreateCdpEventSource(DebuggerDomainEvent.ScriptFailedToParse);
    /// <summary>
    /// Fired when virtual machine parses script. This event is also fired for all known and uncollected
    /// scripts upon enabling debugger.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ScriptParsedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ScriptId</b> - Identifier of the script parsed.</description></item>
    /// <item><description><b>Url</b> - URL or name of the script parsed (if any).</description></item>
    /// <item><description><b>StartLine</b> - Line offset of the script within the resource with given URL (for script tags).</description></item>
    /// <item><description><b>StartColumn</b> - Column offset of the script within the resource with given URL.</description></item>
    /// <item><description><b>EndLine</b> - Last line of the script.</description></item>
    /// <item><description><b>EndColumn</b> - Length of the last line of the script.</description></item>
    /// <item><description><b>ExecutionContextId</b> - Specifies script creation context.</description></item>
    /// <item><description><b>Hash</b> - Content hash of the script, SHA-256.</description></item>
    /// <item><description><b>BuildId</b> - For Wasm modules, the content of the <b>build_id</b> custom section. For JavaScript the <b>debugId</b> magic comment.</description></item>
    /// <item><description><b>ExecutionContextAuxData</b> - Embedder-specific auxiliary data likely matching {isDefault: boolean, type: 'default'|'isolated'|'worker', frameId: string}</description></item>
    /// <item><description><b>IsLiveEdit</b> - True, if this script is generated as a result of the live edit operation.</description></item>
    /// <item><description><b>SourceMapURL</b> - URL of source map associated with script (if any).</description></item>
    /// <item><description><b>HasSourceURL</b> - True, if this script has sourceURL.</description></item>
    /// <item><description><b>IsModule</b> - True, if this script is ES6 module.</description></item>
    /// <item><description><b>Length</b> - This script length.</description></item>
    /// <item><description><b>StackTrace</b> - JavaScript top stack frame of where the script parsed event was triggered if available.</description></item>
    /// <item><description><b>CodeOffset</b> - If the scriptLanguage is WebAssembly, the code section offset in the module.</description></item>
    /// <item><description><b>ScriptLanguage</b> - The language of the script.</description></item>
    /// <item><description><b>DebugSymbols</b> - If the scriptLanguage is WebAssembly, the source of debug symbols for the module.</description></item>
    /// <item><description><b>EmbedderName</b> - The name the embedder supplied for this script.</description></item>
    /// <item><description><b>ResolvedBreakpoints</b> - The list of set breakpoints in this script if calls to <b>setBreakpointByUrl</b> matches this script's URL or hash. Clients that use this list can ignore the <b>breakpointResolved</b> event. They are equivalent.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ScriptParsedEventArgs> ScriptParsed => CreateCdpEventSource(DebuggerDomainEvent.ScriptParsed);
}

internal sealed record ContinueToLocationCommandParameters(Location Location, string? TargetCallFrames) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.ContinueToLocationAsync"/>.
/// </summary>
public sealed record ContinueToLocationCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public string? TargetCallFrames { get; init; }
}

/// <summary>
/// </summary>
public sealed record ContinueToLocationResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters(double? MaxScriptsCacheSize) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The maximum size in bytes of collected scripts (not referenced by other heap objects)
    /// the debugger can hold. Puts no limit if parameter is omitted.
    /// </summary>
    public double? MaxScriptsCacheSize { get; init; }
}

/// <summary>
/// </summary>
/// <param name="DebuggerId">
/// Unique identifier of the debugger.
/// </param>
public sealed record EnableResult(Runtime.UniqueDebuggerId DebuggerId) : EmptyResult;


internal sealed record EvaluateOnCallFrameCommandParameters(CallFrameId CallFrameId, string Expression, string? ObjectGroup, bool? IncludeCommandLineAPI, bool? Silent, bool? ReturnByValue, bool? GeneratePreview, bool? ThrowOnSideEffect, Runtime.TimeDelta? Timeout) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.EvaluateOnCallFrameAsync"/>.
/// </summary>
public sealed record EvaluateOnCallFrameCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// String object group name to put result into (allows rapid releasing resulting object handles
    /// using <b>releaseObjectGroup</b>).
    /// </summary>
    public string? ObjectGroup { get; init; }

    /// <summary>
    /// Specifies whether command line API should be available to the evaluated expression, defaults
    /// to false.
    /// </summary>
    public bool? IncludeCommandLineAPI { get; init; }

    /// <summary>
    /// In silent mode exceptions thrown during evaluation are not reported and do not pause
    /// execution. Overrides <b>setPauseOnException</b> state.
    /// </summary>
    public bool? Silent { get; init; }

    /// <summary>
    /// Whether the result is expected to be a JSON object that should be sent by value.
    /// </summary>
    public bool? ReturnByValue { get; init; }

    /// <summary>
    /// Whether preview should be generated for the result.
    /// </summary>
    public bool? GeneratePreview { get; init; }

    /// <summary>
    /// Whether to throw an exception if side effect cannot be ruled out during evaluation.
    /// </summary>
    public bool? ThrowOnSideEffect { get; init; }

    /// <summary>
    /// Terminate execution after timing out (number of milliseconds).
    /// </summary>
    public new Runtime.TimeDelta? Timeout { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Result">
/// Object wrapper for the evaluation result.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details.
/// </param>
public sealed record EvaluateOnCallFrameResult(Runtime.RemoteObject Result, Runtime.ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record GetPossibleBreakpointsCommandParameters(Location Start, Location? End, bool? RestrictToFunction) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.GetPossibleBreakpointsAsync"/>.
/// </summary>
public sealed record GetPossibleBreakpointsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// End of range to search possible breakpoint locations in (excluding). When not specified, end
    /// of scripts is used as end of range.
    /// </summary>
    public Location? End { get; init; }

    /// <summary>
    /// Only consider locations which are in the same (non-nested) function as start.
    /// </summary>
    public bool? RestrictToFunction { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Locations">
/// List of the possible breakpoint locations.
/// </param>
public sealed record GetPossibleBreakpointsResult(ImmutableArray<BreakLocation> Locations) : EmptyResult;


internal sealed record GetScriptSourceCommandParameters(Runtime.ScriptId ScriptId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.GetScriptSourceAsync"/>.
/// </summary>
public sealed record GetScriptSourceCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="ScriptSource">
/// Script source (empty in case of Wasm bytecode).
/// </param>
/// <param name="Bytecode">
/// Wasm bytecode. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record GetScriptSourceResult(string ScriptSource, string? Bytecode) : EmptyResult;


internal sealed record DisassembleWasmModuleCommandParameters(Runtime.ScriptId ScriptId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.DisassembleWasmModuleAsync"/>.
/// </summary>
public sealed record DisassembleWasmModuleCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="StreamId">
/// For large modules, return a stream from which additional chunks of
/// disassembly can be read successively.
/// </param>
/// <param name="TotalNumberOfLines">
/// The total number of lines in the disassembly text.
/// </param>
/// <param name="FunctionBodyOffsets">
/// The offsets of all function bodies, in the format [start1, end1,
/// start2, end2, ...] where all ends are exclusive.
/// </param>
/// <param name="Chunk">
/// The first chunk of disassembly.
/// </param>
public sealed record DisassembleWasmModuleResult(string? StreamId, long TotalNumberOfLines, ImmutableArray<long> FunctionBodyOffsets, WasmDisassemblyChunk Chunk) : EmptyResult;


internal sealed record NextWasmDisassemblyChunkCommandParameters(string StreamId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.NextWasmDisassemblyChunkAsync"/>.
/// </summary>
public sealed record NextWasmDisassemblyChunkCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Chunk">
/// The next chunk of disassembly.
/// </param>
public sealed record NextWasmDisassemblyChunkResult(WasmDisassemblyChunk Chunk) : EmptyResult;


internal sealed record GetWasmBytecodeCommandParameters(Runtime.ScriptId ScriptId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.GetWasmBytecodeAsync"/>.
/// </summary>
public sealed record GetWasmBytecodeCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Bytecode">
/// Script source. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record GetWasmBytecodeResult(string Bytecode) : EmptyResult;


internal sealed record GetStackTraceCommandParameters(Runtime.StackTraceId StackTraceId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.GetStackTraceAsync"/>.
/// </summary>
public sealed record GetStackTraceCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="StackTrace">
/// </param>
public sealed record GetStackTraceResult(Runtime.StackTrace StackTrace) : EmptyResult;


internal sealed record PauseCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.PauseAsync"/>.
/// </summary>
public sealed record PauseCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record PauseResult() : EmptyResult;


internal sealed record PauseOnAsyncCallCommandParameters(Runtime.StackTraceId ParentStackTraceId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.PauseOnAsyncCallAsync"/>.
/// </summary>
public sealed record PauseOnAsyncCallCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record PauseOnAsyncCallResult() : EmptyResult;


internal sealed record RemoveBreakpointCommandParameters(BreakpointId BreakpointId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.RemoveBreakpointAsync"/>.
/// </summary>
public sealed record RemoveBreakpointCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record RemoveBreakpointResult() : EmptyResult;


internal sealed record RestartFrameCommandParameters(CallFrameId CallFrameId, string? Mode) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.RestartFrameAsync"/>.
/// </summary>
public sealed record RestartFrameCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The <b>mode</b> parameter must be present and set to 'StepInto', otherwise
    /// <b>restartFrame</b> will error out.
    /// </summary>
    public string? Mode { get; init; }
}

/// <summary>
/// </summary>
/// <param name="CallFrames">
/// New stack trace.
/// </param>
/// <param name="AsyncStackTrace">
/// Async stack trace, if any.
/// </param>
/// <param name="AsyncStackTraceId">
/// Async stack trace, if any.
/// </param>
public sealed record RestartFrameResult(ImmutableArray<CallFrame> CallFrames, Runtime.StackTrace? AsyncStackTrace, Runtime.StackTraceId? AsyncStackTraceId) : EmptyResult;


internal sealed record ResumeCommandParameters(bool? TerminateOnResume) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.ResumeAsync"/>.
/// </summary>
public sealed record ResumeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Set to true to terminate execution upon resuming execution. In contrast
    /// to Runtime.terminateExecution, this will allows to execute further
    /// JavaScript (i.e. via evaluation) until execution of the paused code
    /// is actually resumed, at which point termination is triggered.
    /// If execution is currently not paused, this parameter has no effect.
    /// </summary>
    public bool? TerminateOnResume { get; init; }
}

/// <summary>
/// </summary>
public sealed record ResumeResult() : EmptyResult;


internal sealed record SearchInContentCommandParameters(Runtime.ScriptId ScriptId, string Query, bool? CaseSensitive, bool? IsRegex) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SearchInContentAsync"/>.
/// </summary>
public sealed record SearchInContentCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true, search is case sensitive.
    /// </summary>
    public bool? CaseSensitive { get; init; }

    /// <summary>
    /// If true, treats string parameter as regex.
    /// </summary>
    public bool? IsRegex { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Result">
/// List of search matches.
/// </param>
public sealed record SearchInContentResult(ImmutableArray<SearchMatch> Result) : EmptyResult;


internal sealed record SetAsyncCallStackDepthCommandParameters(long MaxDepth) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetAsyncCallStackDepthAsync"/>.
/// </summary>
public sealed record SetAsyncCallStackDepthCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetAsyncCallStackDepthResult() : EmptyResult;


internal sealed record SetBlackboxExecutionContextsCommandParameters(ImmutableArray<string> UniqueIds) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetBlackboxExecutionContextsAsync"/>.
/// </summary>
public sealed record SetBlackboxExecutionContextsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetBlackboxExecutionContextsResult() : EmptyResult;


internal sealed record SetBlackboxPatternsCommandParameters(ImmutableArray<string> Patterns, bool? SkipAnonymous) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetBlackboxPatternsAsync"/>.
/// </summary>
public sealed record SetBlackboxPatternsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true, also ignore scripts with no source url.
    /// </summary>
    public bool? SkipAnonymous { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetBlackboxPatternsResult() : EmptyResult;


internal sealed record SetBlackboxedRangesCommandParameters(Runtime.ScriptId ScriptId, ImmutableArray<ScriptPosition> Positions) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetBlackboxedRangesAsync"/>.
/// </summary>
public sealed record SetBlackboxedRangesCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetBlackboxedRangesResult() : EmptyResult;


internal sealed record SetBreakpointCommandParameters(Location Location, string? Condition) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetBreakpointAsync"/>.
/// </summary>
public sealed record SetBreakpointCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Expression to use as a breakpoint condition. When specified, debugger will only stop on the
    /// breakpoint if this expression evaluates to true.
    /// </summary>
    public string? Condition { get; init; }
}

/// <summary>
/// </summary>
/// <param name="BreakpointId">
/// Id of the created breakpoint for further reference.
/// </param>
/// <param name="ActualLocation">
/// Location this breakpoint resolved into.
/// </param>
public sealed record SetBreakpointResult(BreakpointId BreakpointId, Location ActualLocation) : EmptyResult;


internal sealed record SetInstrumentationBreakpointCommandParameters(string Instrumentation) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetInstrumentationBreakpointAsync"/>.
/// </summary>
public sealed record SetInstrumentationBreakpointCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="BreakpointId">
/// Id of the created breakpoint for further reference.
/// </param>
public sealed record SetInstrumentationBreakpointResult(BreakpointId BreakpointId) : EmptyResult;


internal sealed record SetBreakpointByUrlCommandParameters(long LineNumber, string? Url, string? UrlRegex, string? ScriptHash, long? ColumnNumber, string? Condition) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetBreakpointByUrlAsync"/>.
/// </summary>
public sealed record SetBreakpointByUrlCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// URL of the resources to set breakpoint on.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// Regex pattern for the URLs of the resources to set breakpoints on. Either <b>url</b> or
    /// <b>urlRegex</b> must be specified.
    /// </summary>
    public string? UrlRegex { get; init; }

    /// <summary>
    /// Script hash of the resources to set breakpoint on.
    /// </summary>
    public string? ScriptHash { get; init; }

    /// <summary>
    /// Offset in the line to set breakpoint at.
    /// </summary>
    public long? ColumnNumber { get; init; }

    /// <summary>
    /// Expression to use as a breakpoint condition. When specified, debugger will only stop on the
    /// breakpoint if this expression evaluates to true.
    /// </summary>
    public string? Condition { get; init; }
}

/// <summary>
/// </summary>
/// <param name="BreakpointId">
/// Id of the created breakpoint for further reference.
/// </param>
/// <param name="Locations">
/// List of the locations this breakpoint resolved into upon addition.
/// </param>
public sealed record SetBreakpointByUrlResult(BreakpointId BreakpointId, ImmutableArray<Location> Locations) : EmptyResult;


internal sealed record SetBreakpointOnFunctionCallCommandParameters(Runtime.RemoteObjectId ObjectId, string? Condition) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetBreakpointOnFunctionCallAsync"/>.
/// </summary>
public sealed record SetBreakpointOnFunctionCallCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Expression to use as a breakpoint condition. When specified, debugger will
    /// stop on the breakpoint if this expression evaluates to true.
    /// </summary>
    public string? Condition { get; init; }
}

/// <summary>
/// </summary>
/// <param name="BreakpointId">
/// Id of the created breakpoint for further reference.
/// </param>
public sealed record SetBreakpointOnFunctionCallResult(BreakpointId BreakpointId) : EmptyResult;


internal sealed record SetBreakpointsActiveCommandParameters(bool Active) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetBreakpointsActiveAsync"/>.
/// </summary>
public sealed record SetBreakpointsActiveCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetBreakpointsActiveResult() : EmptyResult;


internal sealed record SetPauseOnExceptionsCommandParameters(string State) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetPauseOnExceptionsAsync"/>.
/// </summary>
public sealed record SetPauseOnExceptionsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetPauseOnExceptionsResult() : EmptyResult;


internal sealed record SetReturnValueCommandParameters(Runtime.CallArgument NewValue) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetReturnValueAsync"/>.
/// </summary>
public sealed record SetReturnValueCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetReturnValueResult() : EmptyResult;


internal sealed record SetScriptSourceCommandParameters(Runtime.ScriptId ScriptId, string ScriptSource, bool? DryRun, bool? AllowTopFrameEditing) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetScriptSourceAsync"/>.
/// </summary>
public sealed record SetScriptSourceCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true the change will not actually be applied. Dry run may be used to get result
    /// description without actually modifying the code.
    /// </summary>
    public bool? DryRun { get; init; }

    /// <summary>
    /// If true, then <b>scriptSource</b> is allowed to change the function on top of the stack
    /// as long as the top-most stack frame is the only activation of that function.
    /// </summary>
    public bool? AllowTopFrameEditing { get; init; }
}

/// <summary>
/// </summary>
/// <param name="CallFrames">
/// New stack trace in case editing has happened while VM was stopped.
/// </param>
/// <param name="StackChanged">
/// Whether current call stack  was modified after applying the changes.
/// </param>
/// <param name="AsyncStackTrace">
/// Async stack trace, if any.
/// </param>
/// <param name="AsyncStackTraceId">
/// Async stack trace, if any.
/// </param>
/// <param name="Status">
/// Whether the operation was successful or not. Only <b>Ok</b> denotes a
/// successful live edit while the other enum variants denote why
/// the live edit failed.
/// </param>
/// <param name="ExceptionDetails">
/// Exception details if any. Only present when <b>status</b> is <b>CompileError</b>.
/// </param>
public sealed record SetScriptSourceResult(ImmutableArray<CallFrame>? CallFrames, bool? StackChanged, Runtime.StackTrace? AsyncStackTrace, Runtime.StackTraceId? AsyncStackTraceId, string Status, Runtime.ExceptionDetails? ExceptionDetails) : EmptyResult;


internal sealed record SetSkipAllPausesCommandParameters(bool Skip) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetSkipAllPausesAsync"/>.
/// </summary>
public sealed record SetSkipAllPausesCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetSkipAllPausesResult() : EmptyResult;


internal sealed record SetVariableValueCommandParameters(long ScopeNumber, string VariableName, Runtime.CallArgument NewValue, CallFrameId CallFrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.SetVariableValueAsync"/>.
/// </summary>
public sealed record SetVariableValueCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetVariableValueResult() : EmptyResult;


internal sealed record StepIntoCommandParameters(bool? BreakOnAsyncCall, ImmutableArray<LocationRange>? SkipList) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.StepIntoAsync"/>.
/// </summary>
public sealed record StepIntoCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Debugger will pause on the execution of the first async task which was scheduled
    /// before next pause.
    /// </summary>
    public bool? BreakOnAsyncCall { get; init; }

    /// <summary>
    /// The skipList specifies location ranges that should be skipped on step into.
    /// </summary>
    public ImmutableArray<LocationRange>? SkipList { get; init; }
}

/// <summary>
/// </summary>
public sealed record StepIntoResult() : EmptyResult;


internal sealed record StepOutCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.StepOutAsync"/>.
/// </summary>
public sealed record StepOutCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StepOutResult() : EmptyResult;


internal sealed record StepOverCommandParameters(ImmutableArray<LocationRange>? SkipList) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DebuggerDomain.StepOverAsync"/>.
/// </summary>
public sealed record StepOverCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The skipList specifies location ranges that should be skipped on step over.
    /// </summary>
    public ImmutableArray<LocationRange>? SkipList { get; init; }
}

/// <summary>
/// </summary>
public sealed record StepOverResult() : EmptyResult;


/// <summary>
/// Fired when breakpoint is resolved to an actual script and location.
/// Deprecated in favor of <b>resolvedBreakpoints</b> in the <b>scriptParsed</b> event.
/// </summary>
/// <param name="BreakpointId">
/// Breakpoint unique identifier.
/// </param>
/// <param name="Location">
/// Actual breakpoint location.
/// </param>
public sealed record BreakpointResolvedEventArgs(BreakpointId BreakpointId, Location Location) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
/// </summary>
/// <param name="CallFrames">
/// Call stack the virtual machine stopped on.
/// </param>
/// <param name="Reason">
/// Pause reason.
/// </param>
/// <param name="Data">
/// Object containing break-specific auxiliary properties.
/// </param>
/// <param name="HitBreakpoints">
/// Hit breakpoints IDs
/// </param>
/// <param name="AsyncStackTrace">
/// Async stack trace, if any.
/// </param>
/// <param name="AsyncStackTraceId">
/// Async stack trace, if any.
/// </param>
/// <param name="AsyncCallStackTraceId">
/// Never present, will be removed.
/// </param>
public sealed record PausedEventArgs(ImmutableArray<CallFrame> CallFrames, string Reason, global::System.Text.Json.JsonElement? Data = null, ImmutableArray<string>? HitBreakpoints = null, Runtime.StackTrace? AsyncStackTrace = null, Runtime.StackTraceId? AsyncStackTraceId = null, Runtime.StackTraceId? AsyncCallStackTraceId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when the virtual machine resumed execution.
/// </summary>
public sealed record ResumedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when virtual machine fails to parse the script.
/// </summary>
/// <param name="ScriptId">
/// Identifier of the script parsed.
/// </param>
/// <param name="Url">
/// URL or name of the script parsed (if any).
/// </param>
/// <param name="StartLine">
/// Line offset of the script within the resource with given URL (for script tags).
/// </param>
/// <param name="StartColumn">
/// Column offset of the script within the resource with given URL.
/// </param>
/// <param name="EndLine">
/// Last line of the script.
/// </param>
/// <param name="EndColumn">
/// Length of the last line of the script.
/// </param>
/// <param name="ExecutionContextId">
/// Specifies script creation context.
/// </param>
/// <param name="Hash">
/// Content hash of the script, SHA-256.
/// </param>
/// <param name="BuildId">
/// For Wasm modules, the content of the <b>build_id</b> custom section. For JavaScript the <b>debugId</b> magic comment.
/// </param>
/// <param name="ExecutionContextAuxData">
/// Embedder-specific auxiliary data likely matching {isDefault: boolean, type: 'default'|'isolated'|'worker', frameId: string}
/// </param>
/// <param name="SourceMapURL">
/// URL of source map associated with script (if any).
/// </param>
/// <param name="HasSourceURL">
/// True, if this script has sourceURL.
/// </param>
/// <param name="IsModule">
/// True, if this script is ES6 module.
/// </param>
/// <param name="Length">
/// This script length.
/// </param>
/// <param name="StackTrace">
/// JavaScript top stack frame of where the script parsed event was triggered if available.
/// </param>
/// <param name="CodeOffset">
/// If the scriptLanguage is WebAssembly, the code section offset in the module.
/// </param>
/// <param name="ScriptLanguage">
/// The language of the script.
/// </param>
/// <param name="EmbedderName">
/// The name the embedder supplied for this script.
/// </param>
public sealed record ScriptFailedToParseEventArgs(Runtime.ScriptId ScriptId, string Url, long StartLine, long StartColumn, long EndLine, long EndColumn, Runtime.ExecutionContextId ExecutionContextId, string Hash, string BuildId, global::System.Text.Json.JsonElement? ExecutionContextAuxData = null, string? SourceMapURL = null, bool? HasSourceURL = null, bool? IsModule = null, long? Length = null, Runtime.StackTrace? StackTrace = null, long? CodeOffset = null, Debugger.ScriptLanguage? ScriptLanguage = null, string? EmbedderName = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when virtual machine parses script. This event is also fired for all known and uncollected
/// scripts upon enabling debugger.
/// </summary>
/// <param name="ScriptId">
/// Identifier of the script parsed.
/// </param>
/// <param name="Url">
/// URL or name of the script parsed (if any).
/// </param>
/// <param name="StartLine">
/// Line offset of the script within the resource with given URL (for script tags).
/// </param>
/// <param name="StartColumn">
/// Column offset of the script within the resource with given URL.
/// </param>
/// <param name="EndLine">
/// Last line of the script.
/// </param>
/// <param name="EndColumn">
/// Length of the last line of the script.
/// </param>
/// <param name="ExecutionContextId">
/// Specifies script creation context.
/// </param>
/// <param name="Hash">
/// Content hash of the script, SHA-256.
/// </param>
/// <param name="BuildId">
/// For Wasm modules, the content of the <b>build_id</b> custom section. For JavaScript the <b>debugId</b> magic comment.
/// </param>
/// <param name="ExecutionContextAuxData">
/// Embedder-specific auxiliary data likely matching {isDefault: boolean, type: 'default'|'isolated'|'worker', frameId: string}
/// </param>
/// <param name="IsLiveEdit">
/// True, if this script is generated as a result of the live edit operation.
/// </param>
/// <param name="SourceMapURL">
/// URL of source map associated with script (if any).
/// </param>
/// <param name="HasSourceURL">
/// True, if this script has sourceURL.
/// </param>
/// <param name="IsModule">
/// True, if this script is ES6 module.
/// </param>
/// <param name="Length">
/// This script length.
/// </param>
/// <param name="StackTrace">
/// JavaScript top stack frame of where the script parsed event was triggered if available.
/// </param>
/// <param name="CodeOffset">
/// If the scriptLanguage is WebAssembly, the code section offset in the module.
/// </param>
/// <param name="ScriptLanguage">
/// The language of the script.
/// </param>
/// <param name="DebugSymbols">
/// If the scriptLanguage is WebAssembly, the source of debug symbols for the module.
/// </param>
/// <param name="EmbedderName">
/// The name the embedder supplied for this script.
/// </param>
/// <param name="ResolvedBreakpoints">
/// The list of set breakpoints in this script if calls to <b>setBreakpointByUrl</b>
/// matches this script's URL or hash. Clients that use this list can ignore the
/// <b>breakpointResolved</b> event. They are equivalent.
/// </param>
public sealed record ScriptParsedEventArgs(Runtime.ScriptId ScriptId, string Url, long StartLine, long StartColumn, long EndLine, long EndColumn, Runtime.ExecutionContextId ExecutionContextId, string Hash, string BuildId, global::System.Text.Json.JsonElement? ExecutionContextAuxData = null, bool? IsLiveEdit = null, string? SourceMapURL = null, bool? HasSourceURL = null, bool? IsModule = null, long? Length = null, Runtime.StackTrace? StackTrace = null, long? CodeOffset = null, Debugger.ScriptLanguage? ScriptLanguage = null, ImmutableArray<Debugger.DebugSymbols>? DebugSymbols = null, string? EmbedderName = null, ImmutableArray<ResolvedBreakpoint>? ResolvedBreakpoints = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Breakpoint identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<BreakpointId>))]
public record BreakpointId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Call frame identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<CallFrameId>))]
public record CallFrameId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Location in the source code.
/// </summary>
/// <param name="ScriptId">
/// Script identifier as reported in the <b>Debugger.scriptParsed</b>.
/// </param>
/// <param name="LineNumber">
/// Line number in the script (0-based).
/// </param>
public sealed record Location(Runtime.ScriptId ScriptId, long LineNumber)
{
    /// <summary>
    /// Column number in the script (0-based).
    /// </summary>
    public long? ColumnNumber { get; init; }
}

/// <summary>
/// Location in the source code.
/// </summary>
/// <param name="LineNumber">
/// </param>
/// <param name="ColumnNumber">
/// </param>
public sealed record ScriptPosition(long LineNumber, long ColumnNumber)
{
}

/// <summary>
/// Location range within one script.
/// </summary>
/// <param name="ScriptId">
/// </param>
/// <param name="Start">
/// </param>
/// <param name="End">
/// </param>
public sealed record LocationRange(Runtime.ScriptId ScriptId, ScriptPosition Start, ScriptPosition End)
{
}

/// <summary>
/// JavaScript call frame. Array of call frames form the call stack.
/// </summary>
/// <param name="CallFrameId">
/// Call frame identifier. This identifier is only valid while the virtual machine is paused.
/// </param>
/// <param name="FunctionName">
/// Name of the JavaScript function called on this call frame.
/// </param>
/// <param name="Location">
/// Location in the source code.
/// </param>
/// <param name="Url">
/// JavaScript script name or url.
/// Deprecated in favor of using the <b>location.scriptId</b> to resolve the URL via a previously
/// sent <b>Debugger.scriptParsed</b> event.
/// </param>
/// <param name="ScopeChain">
/// Scope chain for this call frame.
/// </param>
/// <param name="This">
/// <b>this</b> object for this call frame.
/// </param>
public sealed record CallFrame(CallFrameId CallFrameId, string FunctionName, Location Location, string Url, ImmutableArray<Scope> ScopeChain, Runtime.RemoteObject This)
{
    /// <summary>
    /// Location in the source code.
    /// </summary>
    public Location? FunctionLocation { get; init; }

    /// <summary>
    /// The value being returned, if the function is at return point.
    /// </summary>
    public Runtime.RemoteObject? ReturnValue { get; init; }

    /// <summary>
    /// Valid only while the VM is paused and indicates whether this frame
    /// can be restarted or not. Note that a <b>true</b> value here does not
    /// guarantee that Debugger#restartFrame with this CallFrameId will be
    /// successful, but it is very likely.
    /// </summary>
    public bool? CanBeRestarted { get; init; }
}

/// <summary>
/// Scope description.
/// </summary>
/// <param name="Type">
/// Scope type.
/// </param>
/// <param name="Object">
/// Object representing the scope. For <b>global</b> and <b>with</b> scopes it represents the actual
/// object; for the rest of the scopes, it is artificial transient object enumerating scope
/// variables as its properties.
/// </param>
public sealed record Scope(string Type, Runtime.RemoteObject Object)
{
    /// <summary>
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Location in the source code where scope starts
    /// </summary>
    public Location? StartLocation { get; init; }

    /// <summary>
    /// Location in the source code where scope ends
    /// </summary>
    public Location? EndLocation { get; init; }
}

/// <summary>
/// Search match for resource.
/// </summary>
/// <param name="LineNumber">
/// Line number in resource content.
/// </param>
/// <param name="LineContent">
/// Line with match content.
/// </param>
public sealed record SearchMatch(double LineNumber, string LineContent)
{
}

/// <summary>
/// </summary>
/// <param name="ScriptId">
/// Script identifier as reported in the <b>Debugger.scriptParsed</b>.
/// </param>
/// <param name="LineNumber">
/// Line number in the script (0-based).
/// </param>
public sealed record BreakLocation(Runtime.ScriptId ScriptId, long LineNumber)
{
    /// <summary>
    /// Column number in the script (0-based).
    /// </summary>
    public long? ColumnNumber { get; init; }

    /// <summary>
    /// </summary>
    public string? Type { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Lines">
/// The next chunk of disassembled lines.
/// </param>
/// <param name="BytecodeOffsets">
/// The bytecode offsets describing the start of each line.
/// </param>
public sealed record WasmDisassemblyChunk(ImmutableArray<string> Lines, ImmutableArray<long> BytecodeOffsets)
{
}

/// <summary>
/// Enum of possible script languages.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ScriptLanguage>))]
public enum ScriptLanguage
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JavaScript")]
    JavaScript,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebAssembly")]
    WebAssembly,
}

/// <summary>
/// Debug symbols available for a wasm script.
/// </summary>
/// <param name="Type">
/// Type of the debug symbols.
/// </param>
public sealed record DebugSymbols(string Type)
{
    /// <summary>
    /// URL of the external symbol source.
    /// </summary>
    public string? ExternalURL { get; init; }
}

/// <summary>
/// </summary>
/// <param name="BreakpointId">
/// Breakpoint unique identifier.
/// </param>
/// <param name="Location">
/// Actual breakpoint location.
/// </param>
public sealed record ResolvedBreakpoint(BreakpointId BreakpointId, Location Location)
{
}

[JsonSerializable(typeof(ContinueToLocationCommandParameters), TypeInfoPropertyName = "ContinueToLocationCommandParameters")]
[JsonSerializable(typeof(ContinueToLocationResult), TypeInfoPropertyName = "ContinueToLocationResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(EvaluateOnCallFrameCommandParameters), TypeInfoPropertyName = "EvaluateOnCallFrameCommandParameters")]
[JsonSerializable(typeof(EvaluateOnCallFrameResult), TypeInfoPropertyName = "EvaluateOnCallFrameResult")]
[JsonSerializable(typeof(GetPossibleBreakpointsCommandParameters), TypeInfoPropertyName = "GetPossibleBreakpointsCommandParameters")]
[JsonSerializable(typeof(GetPossibleBreakpointsResult), TypeInfoPropertyName = "GetPossibleBreakpointsResult")]
[JsonSerializable(typeof(GetScriptSourceCommandParameters), TypeInfoPropertyName = "GetScriptSourceCommandParameters")]
[JsonSerializable(typeof(GetScriptSourceResult), TypeInfoPropertyName = "GetScriptSourceResult")]
[JsonSerializable(typeof(DisassembleWasmModuleCommandParameters), TypeInfoPropertyName = "DisassembleWasmModuleCommandParameters")]
[JsonSerializable(typeof(DisassembleWasmModuleResult), TypeInfoPropertyName = "DisassembleWasmModuleResult")]
[JsonSerializable(typeof(NextWasmDisassemblyChunkCommandParameters), TypeInfoPropertyName = "NextWasmDisassemblyChunkCommandParameters")]
[JsonSerializable(typeof(NextWasmDisassemblyChunkResult), TypeInfoPropertyName = "NextWasmDisassemblyChunkResult")]
[JsonSerializable(typeof(GetWasmBytecodeCommandParameters), TypeInfoPropertyName = "GetWasmBytecodeCommandParameters")]
[JsonSerializable(typeof(GetWasmBytecodeResult), TypeInfoPropertyName = "GetWasmBytecodeResult")]
[JsonSerializable(typeof(GetStackTraceCommandParameters), TypeInfoPropertyName = "GetStackTraceCommandParameters")]
[JsonSerializable(typeof(GetStackTraceResult), TypeInfoPropertyName = "GetStackTraceResult")]
[JsonSerializable(typeof(PauseCommandParameters), TypeInfoPropertyName = "PauseCommandParameters")]
[JsonSerializable(typeof(PauseResult), TypeInfoPropertyName = "PauseResult")]
[JsonSerializable(typeof(PauseOnAsyncCallCommandParameters), TypeInfoPropertyName = "PauseOnAsyncCallCommandParameters")]
[JsonSerializable(typeof(PauseOnAsyncCallResult), TypeInfoPropertyName = "PauseOnAsyncCallResult")]
[JsonSerializable(typeof(RemoveBreakpointCommandParameters), TypeInfoPropertyName = "RemoveBreakpointCommandParameters")]
[JsonSerializable(typeof(RemoveBreakpointResult), TypeInfoPropertyName = "RemoveBreakpointResult")]
[JsonSerializable(typeof(RestartFrameCommandParameters), TypeInfoPropertyName = "RestartFrameCommandParameters")]
[JsonSerializable(typeof(RestartFrameResult), TypeInfoPropertyName = "RestartFrameResult")]
[JsonSerializable(typeof(ResumeCommandParameters), TypeInfoPropertyName = "ResumeCommandParameters")]
[JsonSerializable(typeof(ResumeResult), TypeInfoPropertyName = "ResumeResult")]
[JsonSerializable(typeof(SearchInContentCommandParameters), TypeInfoPropertyName = "SearchInContentCommandParameters")]
[JsonSerializable(typeof(SearchInContentResult), TypeInfoPropertyName = "SearchInContentResult")]
[JsonSerializable(typeof(SetAsyncCallStackDepthCommandParameters), TypeInfoPropertyName = "SetAsyncCallStackDepthCommandParameters")]
[JsonSerializable(typeof(SetAsyncCallStackDepthResult), TypeInfoPropertyName = "SetAsyncCallStackDepthResult")]
[JsonSerializable(typeof(SetBlackboxExecutionContextsCommandParameters), TypeInfoPropertyName = "SetBlackboxExecutionContextsCommandParameters")]
[JsonSerializable(typeof(SetBlackboxExecutionContextsResult), TypeInfoPropertyName = "SetBlackboxExecutionContextsResult")]
[JsonSerializable(typeof(SetBlackboxPatternsCommandParameters), TypeInfoPropertyName = "SetBlackboxPatternsCommandParameters")]
[JsonSerializable(typeof(SetBlackboxPatternsResult), TypeInfoPropertyName = "SetBlackboxPatternsResult")]
[JsonSerializable(typeof(SetBlackboxedRangesCommandParameters), TypeInfoPropertyName = "SetBlackboxedRangesCommandParameters")]
[JsonSerializable(typeof(SetBlackboxedRangesResult), TypeInfoPropertyName = "SetBlackboxedRangesResult")]
[JsonSerializable(typeof(SetBreakpointCommandParameters), TypeInfoPropertyName = "SetBreakpointCommandParameters")]
[JsonSerializable(typeof(SetBreakpointResult), TypeInfoPropertyName = "SetBreakpointResult")]
[JsonSerializable(typeof(SetInstrumentationBreakpointCommandParameters), TypeInfoPropertyName = "SetInstrumentationBreakpointCommandParameters")]
[JsonSerializable(typeof(SetInstrumentationBreakpointResult), TypeInfoPropertyName = "SetInstrumentationBreakpointResult")]
[JsonSerializable(typeof(SetBreakpointByUrlCommandParameters), TypeInfoPropertyName = "SetBreakpointByUrlCommandParameters")]
[JsonSerializable(typeof(SetBreakpointByUrlResult), TypeInfoPropertyName = "SetBreakpointByUrlResult")]
[JsonSerializable(typeof(SetBreakpointOnFunctionCallCommandParameters), TypeInfoPropertyName = "SetBreakpointOnFunctionCallCommandParameters")]
[JsonSerializable(typeof(SetBreakpointOnFunctionCallResult), TypeInfoPropertyName = "SetBreakpointOnFunctionCallResult")]
[JsonSerializable(typeof(SetBreakpointsActiveCommandParameters), TypeInfoPropertyName = "SetBreakpointsActiveCommandParameters")]
[JsonSerializable(typeof(SetBreakpointsActiveResult), TypeInfoPropertyName = "SetBreakpointsActiveResult")]
[JsonSerializable(typeof(SetPauseOnExceptionsCommandParameters), TypeInfoPropertyName = "SetPauseOnExceptionsCommandParameters")]
[JsonSerializable(typeof(SetPauseOnExceptionsResult), TypeInfoPropertyName = "SetPauseOnExceptionsResult")]
[JsonSerializable(typeof(SetReturnValueCommandParameters), TypeInfoPropertyName = "SetReturnValueCommandParameters")]
[JsonSerializable(typeof(SetReturnValueResult), TypeInfoPropertyName = "SetReturnValueResult")]
[JsonSerializable(typeof(SetScriptSourceCommandParameters), TypeInfoPropertyName = "SetScriptSourceCommandParameters")]
[JsonSerializable(typeof(SetScriptSourceResult), TypeInfoPropertyName = "SetScriptSourceResult")]
[JsonSerializable(typeof(SetSkipAllPausesCommandParameters), TypeInfoPropertyName = "SetSkipAllPausesCommandParameters")]
[JsonSerializable(typeof(SetSkipAllPausesResult), TypeInfoPropertyName = "SetSkipAllPausesResult")]
[JsonSerializable(typeof(SetVariableValueCommandParameters), TypeInfoPropertyName = "SetVariableValueCommandParameters")]
[JsonSerializable(typeof(SetVariableValueResult), TypeInfoPropertyName = "SetVariableValueResult")]
[JsonSerializable(typeof(StepIntoCommandParameters), TypeInfoPropertyName = "StepIntoCommandParameters")]
[JsonSerializable(typeof(StepIntoResult), TypeInfoPropertyName = "StepIntoResult")]
[JsonSerializable(typeof(StepOutCommandParameters), TypeInfoPropertyName = "StepOutCommandParameters")]
[JsonSerializable(typeof(StepOutResult), TypeInfoPropertyName = "StepOutResult")]
[JsonSerializable(typeof(StepOverCommandParameters), TypeInfoPropertyName = "StepOverCommandParameters")]
[JsonSerializable(typeof(StepOverResult), TypeInfoPropertyName = "StepOverResult")]
[JsonSerializable(typeof(CdpEventArgs<BreakpointResolvedEventArgs>), TypeInfoPropertyName = "BreakpointResolvedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PausedEventArgs>), TypeInfoPropertyName = "PausedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ResumedEventArgs>), TypeInfoPropertyName = "ResumedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ScriptFailedToParseEventArgs>), TypeInfoPropertyName = "ScriptFailedToParseCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ScriptParsedEventArgs>), TypeInfoPropertyName = "ScriptParsedCdpEventArgs")]
[JsonSerializable(typeof(BreakpointId), TypeInfoPropertyName = "DebuggerBreakpointId")]
[JsonSerializable(typeof(CallFrameId), TypeInfoPropertyName = "DebuggerCallFrameId")]
[JsonSerializable(typeof(Location), TypeInfoPropertyName = "DebuggerLocation")]
[JsonSerializable(typeof(ScriptPosition), TypeInfoPropertyName = "DebuggerScriptPosition")]
[JsonSerializable(typeof(LocationRange), TypeInfoPropertyName = "DebuggerLocationRange")]
[JsonSerializable(typeof(CallFrame), TypeInfoPropertyName = "DebuggerCallFrame")]
[JsonSerializable(typeof(Scope), TypeInfoPropertyName = "DebuggerScope")]
[JsonSerializable(typeof(SearchMatch), TypeInfoPropertyName = "DebuggerSearchMatch")]
[JsonSerializable(typeof(BreakLocation), TypeInfoPropertyName = "DebuggerBreakLocation")]
[JsonSerializable(typeof(WasmDisassemblyChunk), TypeInfoPropertyName = "DebuggerWasmDisassemblyChunk")]
[JsonSerializable(typeof(ScriptLanguage), TypeInfoPropertyName = "DebuggerScriptLanguage")]
[JsonSerializable(typeof(DebugSymbols), TypeInfoPropertyName = "DebuggerDebugSymbols")]
[JsonSerializable(typeof(ResolvedBreakpoint), TypeInfoPropertyName = "DebuggerResolvedBreakpoint")]
[JsonSerializable(typeof(ImmutableArray<BreakLocation>), TypeInfoPropertyName = "ImmutableArrayDebuggerBreakLocation")]
[JsonSerializable(typeof(ImmutableArray<CallFrame>), TypeInfoPropertyName = "ImmutableArrayDebuggerCallFrame")]
[JsonSerializable(typeof(ImmutableArray<SearchMatch>), TypeInfoPropertyName = "ImmutableArrayDebuggerSearchMatch")]
[JsonSerializable(typeof(ImmutableArray<ScriptPosition>), TypeInfoPropertyName = "ImmutableArrayDebuggerScriptPosition")]
[JsonSerializable(typeof(ImmutableArray<Location>), TypeInfoPropertyName = "ImmutableArrayDebuggerLocation")]
[JsonSerializable(typeof(ImmutableArray<LocationRange>), TypeInfoPropertyName = "ImmutableArrayDebuggerLocationRange")]
[JsonSerializable(typeof(ImmutableArray<Debugger.DebugSymbols>), TypeInfoPropertyName = "ImmutableArrayDebuggerDebugSymbols")]
[JsonSerializable(typeof(ImmutableArray<ResolvedBreakpoint>), TypeInfoPropertyName = "ImmutableArrayDebuggerResolvedBreakpoint")]
[JsonSerializable(typeof(ImmutableArray<Scope>), TypeInfoPropertyName = "ImmutableArrayDebuggerScope")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DebuggerJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="DebuggerDomain"/>.
/// </summary>
public static class DebuggerDomainEvent
{
    /// <summary>
    /// Fired when breakpoint is resolved to an actual script and location.
    /// Deprecated in favor of <b>resolvedBreakpoints</b> in the <b>scriptParsed</b> event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<BreakpointResolvedEventArgs>> BreakpointResolved { get; } =
        EventDescriptor<CdpEventArgs<BreakpointResolvedEventArgs>>.Create(
            "goog:cdp.Debugger.breakpointResolved",
            DebuggerJsonSerializerContext.Default.BreakpointResolvedCdpEventArgs);

    /// <summary>
    /// Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PausedEventArgs>> Paused { get; } =
        EventDescriptor<CdpEventArgs<PausedEventArgs>>.Create(
            "goog:cdp.Debugger.paused",
            DebuggerJsonSerializerContext.Default.PausedCdpEventArgs);

    /// <summary>
    /// Fired when the virtual machine resumed execution.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ResumedEventArgs>> Resumed { get; } =
        EventDescriptor<CdpEventArgs<ResumedEventArgs>>.Create(
            "goog:cdp.Debugger.resumed",
            DebuggerJsonSerializerContext.Default.ResumedCdpEventArgs);

    /// <summary>
    /// Fired when virtual machine fails to parse the script.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScriptFailedToParseEventArgs>> ScriptFailedToParse { get; } =
        EventDescriptor<CdpEventArgs<ScriptFailedToParseEventArgs>>.Create(
            "goog:cdp.Debugger.scriptFailedToParse",
            DebuggerJsonSerializerContext.Default.ScriptFailedToParseCdpEventArgs);

    /// <summary>
    /// Fired when virtual machine parses script. This event is also fired for all known and uncollected
    /// scripts upon enabling debugger.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScriptParsedEventArgs>> ScriptParsed { get; } =
        EventDescriptor<CdpEventArgs<ScriptParsedEventArgs>>.Create(
            "goog:cdp.Debugger.scriptParsed",
            DebuggerJsonSerializerContext.Default.ScriptParsedCdpEventArgs);

}
