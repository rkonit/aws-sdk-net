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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MergePullRequestBySquash Request Marshaller
    /// </summary>       
    public class MergePullRequestBySquashRequestMarshaller : IMarshaller<IRequest, MergePullRequestBySquashRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((MergePullRequestBySquashRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(MergePullRequestBySquashRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCommit");
            string target = "CodeCommit_20150413.MergePullRequestBySquash";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-13";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorName())
                {
                    context.Writer.WritePropertyName("authorName");
                    context.Writer.Write(publicRequest.AuthorName);
                }

                if(publicRequest.IsSetCommitMessage())
                {
                    context.Writer.WritePropertyName("commitMessage");
                    context.Writer.Write(publicRequest.CommitMessage);
                }

                if(publicRequest.IsSetConflictDetailLevel())
                {
                    context.Writer.WritePropertyName("conflictDetailLevel");
                    context.Writer.Write(publicRequest.ConflictDetailLevel);
                }

                if(publicRequest.IsSetConflictResolution())
                {
                    context.Writer.WritePropertyName("conflictResolution");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConflictResolutionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConflictResolution, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConflictResolutionStrategy())
                {
                    context.Writer.WritePropertyName("conflictResolutionStrategy");
                    context.Writer.Write(publicRequest.ConflictResolutionStrategy);
                }

                if(publicRequest.IsSetEmail())
                {
                    context.Writer.WritePropertyName("email");
                    context.Writer.Write(publicRequest.Email);
                }

                if(publicRequest.IsSetKeepEmptyFolders())
                {
                    context.Writer.WritePropertyName("keepEmptyFolders");
                    context.Writer.Write(publicRequest.KeepEmptyFolders);
                }

                if(publicRequest.IsSetPullRequestId())
                {
                    context.Writer.WritePropertyName("pullRequestId");
                    context.Writer.Write(publicRequest.PullRequestId);
                }

                if(publicRequest.IsSetRepositoryName())
                {
                    context.Writer.WritePropertyName("repositoryName");
                    context.Writer.Write(publicRequest.RepositoryName);
                }

                if(publicRequest.IsSetSourceCommitId())
                {
                    context.Writer.WritePropertyName("sourceCommitId");
                    context.Writer.Write(publicRequest.SourceCommitId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static MergePullRequestBySquashRequestMarshaller _instance = new MergePullRequestBySquashRequestMarshaller();        

        internal static MergePullRequestBySquashRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MergePullRequestBySquashRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}