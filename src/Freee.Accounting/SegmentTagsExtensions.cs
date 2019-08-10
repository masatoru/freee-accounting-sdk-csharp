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
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SegmentTags.
    /// </summary>
    public static partial class SegmentTagsExtensions
    {
            /// <summary>
            /// セグメントタグ一覧の取得
            /// </summary>
            /// <remarks>
            /// 指定した事業所のセグメントタグ一覧を取得する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='segmentId'>
            /// セグメントID
            /// </param>
            /// <param name='offset'>
            /// 取得レコードのオフセット (デフォルト: 0)
            /// </param>
            /// <param name='limit'>
            /// 取得レコードの件数 (デフォルト: 20, 最大: 500)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SegmentTagsIndexResponse> ListAsync(this ISegmentTags operations, int companyId, int segmentId, int? offset = default(int?), int? limit = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(companyId, segmentId, offset, limit, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// セグメントの作成
            /// </summary>
            /// <remarks>
            /// 指定した事業所のセグメントタグを作成する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// セグメントタグの作成
            /// </param>
            /// <param name='segmentId'>
            /// セグメントID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SegmentTagsResponse> CreateAsync(this ISegmentTags operations, SegmentTagParams parameters, int segmentId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(parameters, segmentId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// セグメントタグの更新
            /// </summary>
            /// <remarks>
            /// 指定した事業所のセグメントタグを更新する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// セグメントタグの作成
            /// </param>
            /// <param name='segmentId'>
            /// セグメントID
            /// </param>
            /// <param name='id'>
            /// セグメントタグID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SegmentTagsResponse> UpdateAsync(this ISegmentTags operations, SegmentTagParams parameters, int segmentId, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(parameters, segmentId, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// セグメントタグの削除
            /// </summary>
            /// <remarks>
            /// 指定した事業所のセグメントタグを削除する
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='segmentId'>
            /// セグメントID
            /// </param>
            /// <param name='id'>
            /// セグメントタグID
            /// </param>
            /// <param name='companyId'>
            /// 事業所ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DestroySegmentsTagAsync(this ISegmentTags operations, int segmentId, int id, int companyId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DestroySegmentsTagWithHttpMessagesAsync(segmentId, id, companyId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}