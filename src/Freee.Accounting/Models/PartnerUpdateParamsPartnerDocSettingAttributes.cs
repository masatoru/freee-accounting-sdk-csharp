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
    using System.Linq;

    public partial class PartnerUpdateParamsPartnerDocSettingAttributes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PartnerUpdateParamsPartnerDocSettingAttributes class.
        /// </summary>
        public PartnerUpdateParamsPartnerDocSettingAttributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PartnerUpdateParamsPartnerDocSettingAttributes class.
        /// </summary>
        /// <param
        /// name="sendingMethod">請求書送付方法(mail:メール、posting:郵送、mail_and_posting:メールと郵送)</param>
        public PartnerUpdateParamsPartnerDocSettingAttributes(string sendingMethod = default(string))
        {
            SendingMethod = sendingMethod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets 請求書送付方法(mail:メール、posting:郵送、mail_and_posting:メールと郵送)
        /// </summary>
        [JsonProperty(PropertyName = "sending_method")]
        public string SendingMethod { get; set; }

    }
}