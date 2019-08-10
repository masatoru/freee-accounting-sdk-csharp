// <auto-generated>
// Copyright (c) freee K.K. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license
// information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
//
// </auto-generated>

namespace Freee.Accounting.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class JournalsEnqueueJournalsResponseJournals
    {
        /// <summary>
        /// Initializes a new instance of the
        /// JournalsEnqueueJournalsResponseJournals class.
        /// </summary>
        public JournalsEnqueueJournalsResponseJournals()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// JournalsEnqueueJournalsResponseJournals class.
        /// </summary>
        /// <param name="id">受け付けID</param>
        /// <param name="companyId">事業所ID</param>
        /// <param name="messages">受け付けメッセージ</param>
        /// <param name="downloadType">ダウンロード形式. Possible values include:
        /// 'csv', 'generic', 'pdf'</param>
        /// <param name="startDate">取得開始日 (yyyy-mm-dd)</param>
        /// <param name="endDate">取得終了日 (yyyy-mm-dd)</param>
        /// <param name="statusUrl">ステータス確認用URL</param>
        public JournalsEnqueueJournalsResponseJournals(int id, int companyId, string messages = default(string), string downloadType = default(string), string startDate = default(string), string endDate = default(string), IList<string> visibleTags = default(IList<string>), string statusUrl = default(string))
        {
            Id = id;
            Messages = messages;
            CompanyId = companyId;
            DownloadType = downloadType;
            StartDate = startDate;
            EndDate = endDate;
            VisibleTags = visibleTags;
            StatusUrl = statusUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 受け付けID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 受け付けメッセージ
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public string Messages { get; set; }

        /// <summary>
        /// Gets or sets 事業所ID
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Gets or sets ダウンロード形式. Possible values include: 'csv', 'generic',
        /// 'pdf'
        /// </summary>
        [JsonProperty(PropertyName = "download_type")]
        public string DownloadType { get; set; }

        /// <summary>
        /// Gets or sets 取得開始日 (yyyy-mm-dd)
        /// </summary>
        [JsonProperty(PropertyName = "start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or sets 取得終了日 (yyyy-mm-dd)
        /// </summary>
        [JsonProperty(PropertyName = "end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visible_tags")]
        public IList<string> VisibleTags { get; set; }

        /// <summary>
        /// Gets or sets ステータス確認用URL
        /// </summary>
        [JsonProperty(PropertyName = "status_url")]
        public string StatusUrl { get; set; }

    }
}