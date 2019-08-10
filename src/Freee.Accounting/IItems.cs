// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Items operations.
    /// </summary>
    public partial interface IItems
    {
        /// <summary>
        /// 品目一覧の取得
        /// </summary>
        /// <remarks>
        /// 指定した事業所の品目一覧を取得する
        /// </remarks>
        /// <param name='companyId'>
        /// 事業所ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ItemsIndexResponse>> ListWithHttpMessagesAsync(int companyId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// 品目の作成
        /// </summary>
        /// <remarks>
        /// 指定した事業所の品目を作成する
        /// </remarks>
        /// <param name='parameters'>
        /// 品目の作成
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ItemsCreateResponse>> CreateWithHttpMessagesAsync(CreateItemParams parameters = default(CreateItemParams), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}