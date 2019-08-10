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

    public partial class ManualJournal
    {
        /// <summary>
        /// Initializes a new instance of the ManualJournal class.
        /// </summary>
        public ManualJournal()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManualJournal class.
        /// </summary>
        /// <param name="id">振替伝票ID</param>
        /// <param name="companyId">事業所ID</param>
        /// <param name="issueDate">発生日 (yyyy-mm-dd)</param>
        /// <param name="adjustment">決算整理仕訳フラグ（falseまたは未指定の場合: 日常仕訳）</param>
        /// <param name="txnNumber">仕訳番号</param>
        /// <param name="details">貸借行一覧（配列）: 貸借合わせて100行まで登録できます。</param>
        public ManualJournal(int id, int companyId, string issueDate, bool adjustment, string txnNumber, IList<ManualJournalDetailsItem> details)
        {
            Id = id;
            CompanyId = companyId;
            IssueDate = issueDate;
            Adjustment = adjustment;
            TxnNumber = txnNumber;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 振替伝票ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets 事業所ID
        /// </summary>
        [JsonProperty(PropertyName = "company_id")]
        public int CompanyId { get; set; }

        /// <summary>
        /// Gets or sets 発生日 (yyyy-mm-dd)
        /// </summary>
        [JsonProperty(PropertyName = "issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// Gets or sets 決算整理仕訳フラグ（falseまたは未指定の場合: 日常仕訳）
        /// </summary>
        [JsonProperty(PropertyName = "adjustment")]
        public bool Adjustment { get; set; }

        /// <summary>
        /// Gets or sets 仕訳番号
        /// </summary>
        [JsonProperty(PropertyName = "txn_number")]
        public string TxnNumber { get; set; }

        /// <summary>
        /// Gets or sets 貸借行一覧（配列）: 貸借合わせて100行まで登録できます。
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ManualJournalDetailsItem> Details { get; set; }

    }
}