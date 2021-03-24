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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeArtifact.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeArtifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePackageVersionsStatus Request Marshaller
    /// </summary>       
    public class UpdatePackageVersionsStatusRequestMarshaller : IMarshaller<IRequest, UpdatePackageVersionsStatusRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePackageVersionsStatusRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePackageVersionsStatusRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeArtifact");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-22";            
            request.HttpMethod = "POST";

            
            if (publicRequest.IsSetDomain())
                request.Parameters.Add("domain", StringUtils.FromString(publicRequest.Domain));
            
            if (publicRequest.IsSetDomainOwner())
                request.Parameters.Add("domain-owner", StringUtils.FromString(publicRequest.DomainOwner));
            
            if (publicRequest.IsSetFormat())
                request.Parameters.Add("format", StringUtils.FromString(publicRequest.Format));
            
            if (publicRequest.IsSetNamespace())
                request.Parameters.Add("namespace", StringUtils.FromString(publicRequest.Namespace));
            
            if (publicRequest.IsSetPackage())
                request.Parameters.Add("package", StringUtils.FromString(publicRequest.Package));
            
            if (publicRequest.IsSetRepository())
                request.Parameters.Add("repository", StringUtils.FromString(publicRequest.Repository));
            request.ResourcePath = "/v1/package/versions/update_status";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetExpectedStatus())
                {
                    context.Writer.WritePropertyName("expectedStatus");
                    context.Writer.Write(publicRequest.ExpectedStatus);
                }

                if(publicRequest.IsSetTargetStatus())
                {
                    context.Writer.WritePropertyName("targetStatus");
                    context.Writer.Write(publicRequest.TargetStatus);
                }

                if(publicRequest.IsSetVersionRevisions())
                {
                    context.Writer.WritePropertyName("versionRevisions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestVersionRevisionsKvp in publicRequest.VersionRevisions)
                    {
                        context.Writer.WritePropertyName(publicRequestVersionRevisionsKvp.Key);
                        var publicRequestVersionRevisionsValue = publicRequestVersionRevisionsKvp.Value;

                            context.Writer.Write(publicRequestVersionRevisionsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVersions())
                {
                    context.Writer.WritePropertyName("versions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVersionsListValue in publicRequest.Versions)
                    {
                            context.Writer.Write(publicRequestVersionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdatePackageVersionsStatusRequestMarshaller _instance = new UpdatePackageVersionsStatusRequestMarshaller();        

        internal static UpdatePackageVersionsStatusRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePackageVersionsStatusRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}