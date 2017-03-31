﻿using System;
#if FEATURE_SERIALIZABLE
using System.Runtime.Serialization;
#endif

namespace Lucene.Net.Spatial.Queries
{
    /*
     * Licensed to the Apache Software Foundation (ASF) under one or more
     * contributor license agreements.  See the NOTICE file distributed with
     * this work for additional information regarding copyright ownership.
     * The ASF licenses this file to You under the Apache License, Version 2.0
     * (the "License"); you may not use this file except in compliance with
     * the License.  You may obtain a copy of the License at
     *
     *     http://www.apache.org/licenses/LICENSE-2.0
     *
     * Unless required by applicable law or agreed to in writing, software
     * distributed under the License is distributed on an "AS IS" BASIS,
     * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
     * See the License for the specific language governing permissions and
     * limitations under the License.
     */

    /// <summary>
    /// Exception thrown when the <see cref="SpatialStrategy"/> cannot implement the requested operation.
    /// 
    /// @lucene.experimental
    /// </summary>
#if FEATURE_SERIALIZABLE
    [Serializable]
#endif
    public class UnsupportedSpatialOperation : NotSupportedException
    {
        public UnsupportedSpatialOperation(SpatialOperation op)
            : base(op.Name)
        {
        }

        // For testing
        internal UnsupportedSpatialOperation(string message)
            : base(message)
        {
        }

#if FEATURE_SERIALIZABLE
        /// <summary>
        /// Initializes a new instance of this class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        public UnsupportedSpatialOperation(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
