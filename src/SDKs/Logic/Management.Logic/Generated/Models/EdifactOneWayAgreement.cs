// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Edifact one way agreement.
    /// </summary>
    public partial class EdifactOneWayAgreement
    {
        /// <summary>
        /// Initializes a new instance of the EdifactOneWayAgreement class.
        /// </summary>
        public EdifactOneWayAgreement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EdifactOneWayAgreement class.
        /// </summary>
        /// <param name="senderBusinessIdentity">The sender business
        /// identity</param>
        /// <param name="receiverBusinessIdentity">The receiver business
        /// identity</param>
        /// <param name="protocolSettings">The EDIFACT protocol
        /// settings.</param>
        public EdifactOneWayAgreement(BusinessIdentity senderBusinessIdentity, BusinessIdentity receiverBusinessIdentity, EdifactProtocolSettings protocolSettings)
        {
            SenderBusinessIdentity = senderBusinessIdentity;
            ReceiverBusinessIdentity = receiverBusinessIdentity;
            ProtocolSettings = protocolSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sender business identity
        /// </summary>
        [JsonProperty(PropertyName = "senderBusinessIdentity")]
        public BusinessIdentity SenderBusinessIdentity { get; set; }

        /// <summary>
        /// Gets or sets the receiver business identity
        /// </summary>
        [JsonProperty(PropertyName = "receiverBusinessIdentity")]
        public BusinessIdentity ReceiverBusinessIdentity { get; set; }

        /// <summary>
        /// Gets or sets the EDIFACT protocol settings.
        /// </summary>
        [JsonProperty(PropertyName = "protocolSettings")]
        public EdifactProtocolSettings ProtocolSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SenderBusinessIdentity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SenderBusinessIdentity");
            }
            if (ReceiverBusinessIdentity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReceiverBusinessIdentity");
            }
            if (ProtocolSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProtocolSettings");
            }
            if (SenderBusinessIdentity != null)
            {
                SenderBusinessIdentity.Validate();
            }
            if (ReceiverBusinessIdentity != null)
            {
                ReceiverBusinessIdentity.Validate();
            }
            if (ProtocolSettings != null)
            {
                ProtocolSettings.Validate();
            }
        }
    }
}
