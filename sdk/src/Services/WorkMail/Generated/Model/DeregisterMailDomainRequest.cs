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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterMailDomain operation.
    /// Removes a domain from Amazon WorkMail, stops email routing to WorkMail, and removes
    /// the authorization allowing WorkMail use. SES keeps the domain because other applications
    /// may use it. You must first remove any email address used by WorkMail entities before
    /// you remove the domain.
    /// </summary>
    public partial class DeregisterMailDomainRequest : AmazonWorkMailRequest
    {
        private string _domainName;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain to deregister in WorkMail and SES. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=209)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The Amazon WorkMail organization for which the domain will be deregistered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}