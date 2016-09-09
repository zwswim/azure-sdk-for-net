// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.Azure.Management.DataLake.StoreFileSystem.Models
{
    /// <summary>
    /// The data from the file requested.
    /// </summary>
    public partial class FileOpenResponse : AzureOperationResponse
    {
        private byte[] _fileContents;
        
        /// <summary>
        /// Required. Gets or sets the file contents that are being read by the
        /// file handle
        /// </summary>
        public byte[] FileContents
        {
            get { return this._fileContents; }
            set { this._fileContents = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FileOpenResponse class.
        /// </summary>
        public FileOpenResponse()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the FileOpenResponse class with
        /// required arguments.
        /// </summary>
        public FileOpenResponse(byte[] fileContents)
            : this()
        {
            if (fileContents == null)
            {
                throw new ArgumentNullException("fileContents");
            }
            this.FileContents = fileContents;
        }
    }
}