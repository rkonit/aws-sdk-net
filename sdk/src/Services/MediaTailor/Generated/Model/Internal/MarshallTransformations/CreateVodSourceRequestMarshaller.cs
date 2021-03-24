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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVodSource Request Marshaller
    /// </summary>       
    public class CreateVodSourceRequestMarshaller : IMarshaller<IRequest, CreateVodSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVodSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVodSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetSourceLocationName())
                throw new AmazonMediaTailorException("Request object does not have required field SourceLocationName set");
            request.AddPathResource("{sourceLocationName}", StringUtils.FromString(publicRequest.SourceLocationName));
            if (!publicRequest.IsSetVodSourceName())
                throw new AmazonMediaTailorException("Request object does not have required field VodSourceName set");
            request.AddPathResource("{vodSourceName}", StringUtils.FromString(publicRequest.VodSourceName));
            request.ResourcePath = "/sourceLocation/{sourceLocationName}/vodSource/{vodSourceName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetHttpPackageConfigurations())
                {
                    context.Writer.WritePropertyName("HttpPackageConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestHttpPackageConfigurationsListValue in publicRequest.HttpPackageConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = HttpPackageConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestHttpPackageConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateVodSourceRequestMarshaller _instance = new CreateVodSourceRequestMarshaller();        

        internal static CreateVodSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVodSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}