﻿/*
 * Copyright 2014 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

namespace Splunk.ModularInputs
{
    using System.Xml.Serialization;

    /// <summary>
    /// Enumeration of the valid values for the Endpoint Argument data type.
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// A Boolean value: true or false
        /// </summary>
        [XmlEnum(Name = "boolean")]
        Boolean,

        /// <summary>
        /// A numeric value: regexp = [0-9\.]+
        /// </summary>
        [XmlEnum(Name = "number")]
        Number,

        /// <summary>
        /// A string: virtually everything else
        /// </summary>
        [XmlEnum(Name = "string")]
        String
    }
}
