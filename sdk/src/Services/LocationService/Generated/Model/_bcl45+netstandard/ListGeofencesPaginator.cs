/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Base class for ListGeofences paginators.
    /// </summary>
    internal sealed partial class ListGeofencesPaginator : IPaginator<ListGeofencesResponse>, IListGeofencesPaginator
    {
        private readonly IAmazonLocationService _client;
        private readonly ListGeofencesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListGeofencesResponse> Responses => new PaginatedResponse<ListGeofencesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Entries
        /// </summary>
        public IPaginatedEnumerable<ListGeofenceResponseEntry> Entries => 
            new PaginatedResultKeyResponse<ListGeofencesResponse, ListGeofenceResponseEntry>(this, (i) => i.Entries);

        internal ListGeofencesPaginator(IAmazonLocationService client, ListGeofencesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListGeofencesResponse> IPaginator<ListGeofencesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListGeofencesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListGeofences(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListGeofencesResponse> IPaginator<ListGeofencesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListGeofencesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListGeofencesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}