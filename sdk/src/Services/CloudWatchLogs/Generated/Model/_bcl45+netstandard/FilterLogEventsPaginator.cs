#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Base class for FilterLogEvents paginators.
    /// </summary>
    internal sealed partial class FilterLogEventsPaginator : IPaginator<FilterLogEventsResponse>, IFilterLogEventsPaginator
    {
        private readonly IAmazonCloudWatchLogs client;
        private readonly FilterLogEventsRequest request;
        private int isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<FilterLogEventsResponse> Responses => new PaginatedResponse<FilterLogEventsResponse>(this);
        /// <summary>
        /// Enumerable containing all of the Events
        /// </summary>
        public IPaginatedEnumerable<FilteredLogEvent> Events => 
            new PaginatedResultKeyResponse<FilterLogEventsResponse, FilteredLogEvent>(this, (i) => i.Events);

        /// <summary>
        /// Enumerable containing all of the SearchedLogStreams
        /// </summary>
        public IPaginatedEnumerable<SearchedLogStream> SearchedLogStreams => 
            new PaginatedResultKeyResponse<FilterLogEventsResponse, SearchedLogStream>(this, (i) => i.SearchedLogStreams);

        internal FilterLogEventsPaginator(IAmazonCloudWatchLogs client, FilterLogEventsRequest request)
        {
            this.client = client;
            this.request = request;
        }
#if BCL
        IEnumerable<FilterLogEventsResponse> IPaginator<FilterLogEventsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            FilterLogEventsResponse response;
            do
            {
                request.NextToken = nextToken;
                response = client.FilterLogEvents(request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<FilterLogEventsResponse> IPaginator<FilterLogEventsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            FilterLogEventsResponse response;
            do
            {
                request.NextToken = nextToken;
                response = await client.FilterLogEventsAsync(request).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (nextToken != null);
        }
#endif
    }
}
#endif