namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SessionLineItemOptions : INestedOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("images")]
        public List<string> Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to this line item. This is only allowed in subscription mode.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}