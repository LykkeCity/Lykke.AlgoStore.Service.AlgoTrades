// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.AlgoStore.Service.AlgoTrades.Client.AutorestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AlgoTradesAPI.
    /// </summary>
    public static partial class AlgoTradesAPIExtensions
    {
            /// <summary>
            /// Returns Algo Instance trades
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='maxNumberToFetch'>
            /// </param>
            /// <param name='instanceId'>
            /// </param>
            /// <param name='tradedAssetId'>
            /// </param>
            public static object GetAlgoInstanceTrades(this IAlgoTradesAPI operations, int maxNumberToFetch, string instanceId = default(string), string tradedAssetId = default(string))
            {
                return operations.GetAlgoInstanceTradesAsync(maxNumberToFetch, instanceId, tradedAssetId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns Algo Instance trades
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='maxNumberToFetch'>
            /// </param>
            /// <param name='instanceId'>
            /// </param>
            /// <param name='tradedAssetId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAlgoInstanceTradesAsync(this IAlgoTradesAPI operations, int maxNumberToFetch, string instanceId = default(string), string tradedAssetId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAlgoInstanceTradesWithHttpMessagesAsync(maxNumberToFetch, instanceId, tradedAssetId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns Algo Instance trades
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fromMoment'>
            /// </param>
            /// <param name='toMoment'>
            /// </param>
            /// <param name='instanceId'>
            /// </param>
            /// <param name='tradedAssetId'>
            /// </param>
            public static object GetAlgoInstanceTradesByPeriod(this IAlgoTradesAPI operations, System.DateTime fromMoment, System.DateTime toMoment, string instanceId = default(string), string tradedAssetId = default(string))
            {
                return operations.GetAlgoInstanceTradesByPeriodAsync(fromMoment, toMoment, instanceId, tradedAssetId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns Algo Instance trades
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fromMoment'>
            /// </param>
            /// <param name='toMoment'>
            /// </param>
            /// <param name='instanceId'>
            /// </param>
            /// <param name='tradedAssetId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAlgoInstanceTradesByPeriodAsync(this IAlgoTradesAPI operations, System.DateTime fromMoment, System.DateTime toMoment, string instanceId = default(string), string tradedAssetId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAlgoInstanceTradesByPeriodWithHttpMessagesAsync(fromMoment, toMoment, instanceId, tradedAssetId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Checks service is alive
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static object IsAlive(this IAlgoTradesAPI operations)
            {
                return operations.IsAliveAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks service is alive
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> IsAliveAsync(this IAlgoTradesAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.IsAliveWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
