using System.Text.Json.Serialization;

namespace Ali.Store.API.Models.Partials
{
    public class BizData
    {
        [JsonPropertyName("patternId")]
        public int? PatternId { get; set; }

        [JsonPropertyName("logisticsComposeThreshold")]
        public string LogisticsComposeThreshold { get; set; }

        [JsonPropertyName("discount")]
        public double? Discount { get; set; }

        [JsonPropertyName("tracking")]
        public string Tracking { get; set; }

        [JsonPropertyName("workDayOneFourBeforeCutTime")]
        public string WorkDayOneFourBeforeCutTime { get; set; }

        [JsonPropertyName("delayCompensationTime")]
        public string DelayCompensationTime { get; set; }

        [JsonPropertyName("displayTomorrow")]
        public string DisplayTomorrow { get; set; }

        [JsonPropertyName("itemScene")]
        public string ItemScene { get; set; }

        [JsonPropertyName("shipToCode")]
        public string ShipToCode { get; set; }

        [JsonPropertyName("thresholdOverZero")]
        public string ThresholdOverZero { get; set; }

        [JsonPropertyName("delayCompensationOriginalCurrency")]
        public string DelayCompensationOriginalCurrency { get; set; }

        [JsonPropertyName("delayCompensationOriginalAmount")]
        public int? DelayCompensationOriginalAmount { get; set; }

        [JsonPropertyName("shipFrom")]
        public string ShipFrom { get; set; }

        [JsonPropertyName("deliveryDayMax")]
        public int? DeliveryDayMax { get; set; }

        [JsonPropertyName("displayEtaMinDate")]
        public string DisplayEtaMinDate { get; set; }

        [JsonPropertyName("guaranteedDeliveryTime")]
        public int? GuaranteedDeliveryTime { get; set; }

        [JsonPropertyName("etaVersionDisplayType")]
        public string EtaVersionDisplayType { get; set; }

        [JsonPropertyName("freightCommitDay")]
        public string FreightCommitDay { get; set; }

        [JsonPropertyName("etaTraceId")]
        public string EtaTraceId { get; set; }

        [JsonPropertyName("delayCompensationAmountDisplay")]
        public string DelayCompensationAmountDisplay { get; set; }

        [JsonPropertyName("etaVersionStrategyId")]
        public int? EtaVersionStrategyId { get; set; }

        [JsonPropertyName("workDayOneFiveBeforeCutTime")]
        public string WorkDayOneFiveBeforeCutTime { get; set; }

        [JsonPropertyName("delayCompensationType")]
        public string DelayCompensationType { get; set; }

        [JsonPropertyName("itemId")]
        public long? ItemId { get; set; }

        [JsonPropertyName("solutionBusinessType")]
        public string SolutionBusinessType { get; set; }

        [JsonPropertyName("etaVersionSceneId")]
        public int? EtaVersionSceneId { get; set; }

        [JsonPropertyName("displayAmount")]
        public double? DisplayAmount { get; set; }

        [JsonPropertyName("shippingFee")]
        public string ShippingFee { get; set; }

        [JsonPropertyName("displayEtaMaxDate")]
        public string DisplayEtaMaxDate { get; set; }

        [JsonPropertyName("deliveryDayMin")]
        public int? DeliveryDayMin { get; set; }

        [JsonPropertyName("delayCompensationMode")]
        public string DelayCompensationMode { get; set; }

        [JsonPropertyName("warehouseType")]
        public string WarehouseType { get; set; }

        [JsonPropertyName("solutionId")]
        public int? SolutionId { get; set; }

        [JsonPropertyName("deliveryOptionCode")]
        public string DeliveryOptionCode { get; set; }

        [JsonPropertyName("leadTimeSort")]
        public List<int?> LeadTimeSort { get; set; }

        [JsonPropertyName("deliveryProviderName")]
        public string DeliveryProviderName { get; set; }

        [JsonPropertyName("subWarehouseType")]
        public string SubWarehouseType { get; set; }

        [JsonPropertyName("utParams")]
        public string UtParams { get; set; }

        [JsonPropertyName("warehouseCode")]
        public string WarehouseCode { get; set; }

        [JsonPropertyName("existEtaMinTime")]
        public string ExistEtaMinTime { get; set; }

        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        [JsonPropertyName("itemShipFromType")]
        public string ItemShipFromType { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonPropertyName("formattedAmount")]
        public string FormattedAmount { get; set; }

        [JsonPropertyName("passiveDelayCompensationDelayDisplay")]
        public string PassiveDelayCompensationDelayDisplay { get; set; }

        [JsonPropertyName("choiceFreeShipping")]
        public string ChoiceFreeShipping { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("leadTimeType")]
        public string LeadTimeType { get; set; }

        [JsonPropertyName("existEtaMaxTime")]
        public string ExistEtaMaxTime { get; set; }

        [JsonPropertyName("solutionBusinessXDays")]
        public int? SolutionBusinessXDays { get; set; }

        [JsonPropertyName("guaranteedDeliveryTimeProviderName")]
        public string GuaranteedDeliveryTimeProviderName { get; set; }

        [JsonPropertyName("showXDayDeliveryTips")]
        public string ShowXDayDeliveryTips { get; set; }

        [JsonPropertyName("shipFromCode")]
        public string ShipFromCode { get; set; }

        [JsonPropertyName("displayCurrency")]
        public string DisplayCurrency { get; set; }

        [JsonPropertyName("deliveryProviderCode")]
        public string DeliveryProviderCode { get; set; }

        [JsonPropertyName("shipTo")]
        public string ShipTo { get; set; }
    }
}
