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
    /// Base class for DescribeSubscriptionFilters paginators.
    /// </summary>
    internal sealed partial class DescribeSubscriptionFiltersPaginator : IPaginator<DescribeSubscriptionFiltersResponse>, IDescribeSubscriptionFiltersPaginator
    {
        private readonly IAmazonCloudWatchLogs client;
        private readonly DescribeSubscriptionFiltersRequest request;
        private int isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeSubscriptionFiltersResponse> Responses => new PaginatedResponse<DescribeSubscriptionFiltersResponse>(this);
        /// <summary>
        /// Enumerable containing all of the SubscriptionFilters
        /// </summary>
        public IPaginatedEnumerable<SubscriptionFilter> SubscriptionFilters => 
            new PaginatedResultKeyResponse<DescribeSubscriptionFiltersResponse, SubscriptionFilter>(this, (i) => i.SubscriptionFilters);

        internal DescribeSubscriptionFiltersPaginator(IAmazonCloudWatchLogs client, DescribeSubscriptionFiltersRequest request)
        {
            this.client = client;
            this.request = request;
        }
#if BCL
        IEnumerable<DescribeSubscriptionFiltersResponse> IPaginator<DescribeSubscriptionFiltersResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            DescribeSubscriptionFiltersResponse response;
            do
            {
                request.NextToken = nextToken;
                response = client.DescribeSubscriptionFilters(request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeSubscriptionFiltersResponse> IPaginator<DescribeSubscriptionFiltersResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            DescribeSubscriptionFiltersResponse response;
            do
            {
                request.NextToken = nextToken;
                response = await client.DescribeSubscriptionFiltersAsync(request).ConfigureAwait(false);
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