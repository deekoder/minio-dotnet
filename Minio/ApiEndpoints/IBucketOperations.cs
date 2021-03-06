﻿/*
 * Minio .NET Library for Amazon S3 Compatible Cloud Storage, (C) 2017 Minio, Inc.
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
using System.Threading.Tasks;
using Minio.DataModel;
using System.Threading;

namespace Minio
{
    public interface IBucketOperations
    {
        /// <summary>
        /// Create a private bucket with the given name.
        /// </summary>
        /// <param name="bucketName">Name of the new bucket</param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
        /// <returns>Task</returns>
        Task MakeBucketAsync(string bucketName, string location = "us-east-1", CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all objects in a bucket
        /// </summary>
        /// <param name="bucketName">Bucket to list objects from</param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
        /// <returns>Task with an iterator lazily populated with objects</returns>
        Task<ListAllMyBucketsResult> ListBucketsAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns true if the specified bucketName exists, otherwise returns false.
        /// </summary>
        /// <param name="bucketName">Bucket to test existence of</param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
        /// <returns>Task that returns true if exists and user has access</returns>
        Task<bool> BucketExistsAsync(string bucketName, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove a bucket
        /// </summary>
        /// <param name="bucketName">Name of bucket to remove</param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
        /// <returns>Task</returns>
        Task RemoveBucketAsync(string bucketName, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all objects non-recursively in a bucket with a given prefix, optionally emulating a directory
        /// </summary>
        /// <param name="bucketName">Bucket to list objects from</param>
        /// <param name="prefix">Filters all objects not beginning with a given prefix</param>
        /// <param name="recursive">Set to false to emulate a directory</param>
        /// <returns>An observable of items that client can subscribe to</returns>
        IObservable<Item> ListObjectsAsync(string bucketName, string prefix = null, bool recursive = true, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get bucket policy at given objectPrefix
        /// </summary>
        /// <param name="bucketName">Bucket name.</param>
        /// <param name="objectPrefix">Name of the object prefix</param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
        /// <returns>Returns Task<PolicyType> </PolicyType> </returns>
        Task<PolicyType> GetPolicyAsync(String bucketName, String objectPrefix, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Sets the current bucket policy
        /// </summary>
        /// <param name="bucketName">Bucket Name</param>
        /// <param name="objectPrefix">Name of the object prefix.</param>
        /// <param name="policyType">Desired Policy type change </param>
        /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
        /// <returns> Returns Task that sets the current bucket policy</returns>
        Task SetPolicyAsync(String bucketName, String objectPrefix, PolicyType policyType, CancellationToken cancellationToken = default(CancellationToken));

    }
}