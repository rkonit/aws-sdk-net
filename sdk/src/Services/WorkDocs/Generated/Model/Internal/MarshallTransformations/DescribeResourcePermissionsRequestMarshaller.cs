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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeResourcePermissions Request Marshaller
    /// </summary>       
    public class DescribeResourcePermissionsRequestMarshaller : IMarshaller<IRequest, DescribeResourcePermissionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeResourcePermissionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeResourcePermissionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetResourceId())
                throw new AmazonWorkDocsException("Request object does not have required field ResourceId set");
            request.AddPathResource("{ResourceId}", StringUtils.FromString(publicRequest.ResourceId));
            
            if (publicRequest.IsSetLimit())
                request.Parameters.Add("limit", StringUtils.FromInt(publicRequest.Limit));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("marker", StringUtils.FromString(publicRequest.Marker));
            
            if (publicRequest.IsSetPrincipalId())
                request.Parameters.Add("principalId", StringUtils.FromString(publicRequest.PrincipalId));
            request.ResourcePath = "/api/v1/resources/{ResourceId}/permissions";
        
            if(publicRequest.IsSetAuthenticationToken())
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            request.UseQueryString = true;

            return request;
        }
        private static DescribeResourcePermissionsRequestMarshaller _instance = new DescribeResourcePermissionsRequestMarshaller();        

        internal static DescribeResourcePermissionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeResourcePermissionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}