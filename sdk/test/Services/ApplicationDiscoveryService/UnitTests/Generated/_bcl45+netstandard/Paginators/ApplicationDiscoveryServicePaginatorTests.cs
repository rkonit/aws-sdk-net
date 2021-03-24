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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */

using Amazon.ApplicationDiscoveryService;
using Amazon.ApplicationDiscoveryService.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class ApplicationDiscoveryServicePaginatorTests
    {
        private static Mock<AmazonApplicationDiscoveryServiceClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonApplicationDiscoveryServiceClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationDiscoveryService")]
        public void DescribeContinuousExportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeContinuousExportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeContinuousExportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeContinuousExportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeContinuousExports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeContinuousExports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationDiscoveryService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeContinuousExportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeContinuousExportsRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeContinuousExportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeContinuousExports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeContinuousExports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationDiscoveryService")]
        public void DescribeImportTasksTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImportTasksRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<DescribeImportTasksResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<DescribeImportTasksResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.DescribeImportTasks(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.DescribeImportTasks(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("ApplicationDiscoveryService")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void DescribeImportTasksTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<DescribeImportTasksRequest>();

            var response = InstantiateClassGenerator.Execute<DescribeImportTasksResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.DescribeImportTasks(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.DescribeImportTasks(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}