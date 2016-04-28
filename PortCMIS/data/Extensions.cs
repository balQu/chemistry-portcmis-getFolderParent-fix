﻿/*
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements. See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership. The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License. You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing,
* software distributed under the License is distributed on an
* "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
* Kind, either express or implied. See the License for the
* specific language governing permissions and limitations
* under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortCMIS.Data.Extensions
{
    /// <summary>
    /// An extension element.
    /// </summary>
    public interface ICmisExtensionElement
    {
        /// <value>
        /// Extension name.
        /// </value>
        string Name { get; }

        /// <value>
        /// Extension name space.
        /// </value>
        string Namespace { get; }

        /// <value>
        /// Extension value.
        /// </value>
        string Value { get; }

        /// <value>
        /// Extension attributes.
        /// </value>
        IDictionary<string, string> Attributes { get; }

        /// <value>
        /// Extension children.
        /// </value>
        IList<ICmisExtensionElement> Children { get; }
    }

    /// <summary>
    /// Simple ICmisExtensionElement implementation.
    /// </summary>
    public class CmisExtensionElement : ICmisExtensionElement
    {
        /// <inheritdoc/>
        public string Name { get; set; }

        /// <inheritdoc/>
        public string Namespace { get; set; }

        /// <inheritdoc/>
        public string Value { get; set; }

        /// <inheritdoc/>
        public IDictionary<string, string> Attributes { get; set; }

        /// <inheritdoc/>
        public IList<ICmisExtensionElement> Children { get; set; }
    }

    /// <summary>
    /// Holder of a list of extensions.
    /// </summary>
    public interface IExtensionsData
    {
        /// <value>
        /// List of extensions.
        /// </value>
        IList<ICmisExtensionElement> Extensions { get; set; }
    }

    /// <summary>
    /// Simple IExtensionsData implementation.
    /// </summary>
    public class ExtensionsData : IExtensionsData
    {
        /// <inheritdoc/>
        public IList<ICmisExtensionElement> Extensions { get; set; }
    }
}