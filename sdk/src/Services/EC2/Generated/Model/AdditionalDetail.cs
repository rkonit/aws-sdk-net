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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an additional detail for a path analysis.
    /// </summary>
    public partial class AdditionalDetail
    {
        private string _additionalDetailType;
        private AnalysisComponent _component;

        /// <summary>
        /// Gets and sets the property AdditionalDetailType. 
        /// <para>
        /// The information type.
        /// </para>
        /// </summary>
        public string AdditionalDetailType
        {
            get { return this._additionalDetailType; }
            set { this._additionalDetailType = value; }
        }

        // Check to see if AdditionalDetailType property is set
        internal bool IsSetAdditionalDetailType()
        {
            return this._additionalDetailType != null;
        }

        /// <summary>
        /// Gets and sets the property Component. 
        /// <para>
        /// The path component.
        /// </para>
        /// </summary>
        public AnalysisComponent Component
        {
            get { return this._component; }
            set { this._component = value; }
        }

        // Check to see if Component property is set
        internal bool IsSetComponent()
        {
            return this._component != null;
        }

    }
}