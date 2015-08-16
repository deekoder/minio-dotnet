﻿/*
 * Minio .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2015 Minio, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Minio.Errors
{
    [Serializable]
    [XmlRoot(ElementName="Error", Namespace = "")]
     public class ErrorResponse
     {
         public string Code { get; set; }
         public string Message { get; set; }
         public string RequestID { get; set; }
         public string HostID { get; set; }
         public string Resource { get; set; }
        
        // not an attribute, we fix it up later
         public string XAmzID2 { get; set; }
    }
}