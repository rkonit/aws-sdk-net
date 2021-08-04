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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NonTalkTimeFilter Object
    /// </summary>  
    public class NonTalkTimeFilterUnmarshaller : IUnmarshaller<NonTalkTimeFilter, XmlUnmarshallerContext>, IUnmarshaller<NonTalkTimeFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NonTalkTimeFilter IUnmarshaller<NonTalkTimeFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NonTalkTimeFilter Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NonTalkTimeFilter unmarshalledObject = new NonTalkTimeFilter();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AbsoluteTimeRange", targetDepth))
                {
                    var unmarshaller = AbsoluteTimeRangeUnmarshaller.Instance;
                    unmarshalledObject.AbsoluteTimeRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Negate", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Negate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelativeTimeRange", targetDepth))
                {
                    var unmarshaller = RelativeTimeRangeUnmarshaller.Instance;
                    unmarshalledObject.RelativeTimeRange = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Threshold", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Threshold = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NonTalkTimeFilterUnmarshaller _instance = new NonTalkTimeFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NonTalkTimeFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}