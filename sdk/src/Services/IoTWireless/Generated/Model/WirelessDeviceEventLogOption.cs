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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// The log options for a wireless device event and can be used to set log levels for
    /// a specific wireless device event.
    /// 
    ///  
    /// <para>
    /// For a LoRaWAN device, possible events for a log messsage are: <code>Join</code>, <code>Rejoin</code>,
    /// <code>Downlink_Data</code>, and <code>Uplink_Data</code>. For a Sidewalk device, possible
    /// events for a log message are <code>Registration</code>, <code>Downlink_Data</code>,
    /// and <code>Uplink_Data</code>.
    /// </para>
    /// </summary>
    public partial class WirelessDeviceEventLogOption
    {
        private WirelessDeviceEvent _event;
        private LogLevel _logLevel;

        /// <summary>
        /// Gets and sets the property Event.
        /// </summary>
        [AWSProperty(Required=true)]
        public WirelessDeviceEvent Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel.
        /// </summary>
        [AWSProperty(Required=true)]
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

    }
}