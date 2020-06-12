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
    /// Base class for DescribeMetricFilters paginators.
    /// </summary>
    internal sealed partial class DescribeMetricFiltersPaginator : IPaginator<DescribeMetricFiltersResponse>, IDescribeMetricFiltersPaginator
    {
        private readonly IAmazonCloudWatchLogs client;
        private readonly DescribeMetricFiltersRequest request;
        private int isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeMetricFiltersResponse> Responses => new PaginatedResponse<DescribeMetricFiltersResponse>(this);
        /// <summary>
        /// Enumerable containing all of the MetricFilters
        /// </summary>
        public IPaginatedEnumerable<MetricFilter> MetricFilters => 
            new PaginatedResultKeyResponse<DescribeMetricFiltersResponse, MetricFilter>(this, (i) => i.MetricFilters);

        internal DescribeMetricFiltersPaginator(IAmazonCloudWatchLogs client, DescribeMetricFiltersRequest request)
        {
            this.client = client;
            this.request = request;
        }
#if BCL
        IEnumerable<DescribeMetricFiltersResponse> IPaginator<DescribeMetricFiltersResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            DescribeMetricFiltersResponse response;
            do
            {
                request.NextToken = nextToken;
                response = client.DescribeMetricFilters(request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeMetricFiltersResponse> IPaginator<DescribeMetricFiltersResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            DescribeMetricFiltersResponse response;
            do
            {
                request.NextToken = nextToken;
                response = await client.DescribeMetricFiltersAsync(request).ConfigureAwait(false);
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