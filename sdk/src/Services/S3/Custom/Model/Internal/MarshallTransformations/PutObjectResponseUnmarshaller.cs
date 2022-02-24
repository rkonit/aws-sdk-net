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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for PutObject operation
    /// </summary>
    public class PutObjectResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            PutObjectResponse response = new PutObjectResponse();
            
            UnmarshallResult(context,response);                        
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,PutObjectResponse response)
        {
            

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("x-amz-expiration"))
                response.Expiration = new Expiration(responseData.GetHeaderValue("x-amz-expiration"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-customer-algorithm"))
                response.ServerSideEncryptionCustomerMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-customer-key-MD5"))
                response.ServerSideEncryptionCustomerProvidedKeyMD5 = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-customer-key-MD5"));
            if (responseData.IsHeaderPresent("ETag"))
                response.ETag = S3Transforms.ToString(responseData.GetHeaderValue("ETag"));
            if (responseData.IsHeaderPresent("x-amz-version-id"))
                response.VersionId = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-version-id"));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader))
                response.ServerSideEncryptionKeyManagementServiceKeyId = S3Transforms.ToString(responseData.GetHeaderValue(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-context"))
                response.ServerSideEncryptionKeyManagementServiceEncryptionContext = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-context"));
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderRequestCharged))
                response.RequestCharged = RequestCharged.FindValue(responseData.GetHeaderValue(S3Constants.AmzHeaderRequestCharged));
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderBucketKeyEnabled))
                response.BucketKeyEnabled = S3Transforms.ToBool(responseData.GetHeaderValue(S3Constants.AmzHeaderBucketKeyEnabled));
            if (responseData.IsHeaderPresent("x-amz-checksum-crc32"))
                response.ChecksumCRC32 = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-checksum-crc32"));
            if (responseData.IsHeaderPresent("x-amz-checksum-crc32c"))
                response.ChecksumCRC32C = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-checksum-crc32c"));
            if (responseData.IsHeaderPresent("x-amz-checksum-sha1"))
                response.ChecksumSHA1 = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-checksum-sha1"));
            if (responseData.IsHeaderPresent("x-amz-checksum-sha256"))
                response.ChecksumSHA256 = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-checksum-sha256"));

            return;
        }

        private static PutObjectResponseUnmarshaller _instance;

        public static PutObjectResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutObjectResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
