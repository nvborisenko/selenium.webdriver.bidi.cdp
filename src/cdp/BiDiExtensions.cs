using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

/// <summary>
/// Provides extension methods for accessing CDP functionality through BiDi.
/// </summary>
public static class BiDiExtensions
{
    extension(IBiDi bidi)
    {
        /// <summary>
        /// Gets the <see cref="CdpModule"/> associated with this BiDi instance.
        /// </summary>
        /// <returns>The <see cref="CdpModule"/> for issuing CDP commands.</returns>
        public CdpModule AsCdp()
        {
            return bidi.AsModule<CdpModule>();
        }
    }

    extension(OpenQA.Selenium.BiDi.BrowsingContext.BrowsingContext context)
    {
        /// <summary>
        /// Gets a <see cref="CdpModule"/> bound to the CDP session for this browsing context.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
        /// <returns>The <see cref="CdpModule"/> with an active CDP session for the given context.</returns>
        public async Task<CdpModule> AsCdpAsync(CancellationToken cancellationToken = default)
        {
            var cdp = context.BiDi.AsModule<CdpModule>();

            var sessionResult = await cdp.GetSessionAsync(context, cancellationToken: cancellationToken).ConfigureAwait(false);
            cdp.Session = sessionResult.Session;
            return cdp;
        }
    }
}
