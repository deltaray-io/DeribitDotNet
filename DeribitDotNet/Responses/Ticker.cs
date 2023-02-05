using System;
using DeribitDotNet.JsonConverters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DeribitDotNet.Responses
{
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum TickerState
    {
        Open,
        Closed,
    }

    public class Greeks 
    {
        [JsonProperty("delta")]
        public double? Delta;
        
        [JsonProperty("gamma")]
        public double? Gamma;
        
        [JsonProperty("theta")]
        public double? Theta;
        
        [JsonProperty("vega")]
        public double? Vega;
        
        [JsonProperty("rho")]
        public double? Rho;
    }

    public class Ticker
    {
        [JsonProperty("best_bid_amount")]
        public int BestBidQty;

        [JsonProperty("best_bid_price", NullValueHandling = NullValueHandling.Ignore)]
        public double BestBidPrice;

        [JsonProperty("bid_iv")]
        public double? BidIv;
        
        [JsonProperty("best_ask_amount")]
        public int BestAskQty;

        [JsonProperty("best_ask_price", NullValueHandling = NullValueHandling.Ignore)]
        public double BestAskPrice;

        [JsonProperty("ask_iv")]
        public double AskIv;
        
        [JsonProperty("current_funding")]
        public double? FundingRate;

        [JsonProperty("delivery_price")]
        public double? DeliveryPrice;

        [JsonProperty("estimated_delivery_price")]
        public double? EstimatedDeliveryPrice;
        
        [JsonProperty("funding_8h")]
        public double? FundingRate8HAvg;

        [JsonProperty("greeks")]
        public Greeks Greeks;
        
        [JsonProperty("index_price")]
        public double IndexPrice;

        [JsonProperty("instrument_name")]
        public string Instrument;
        
        [JsonProperty("interest_rate")]
        public double InterestRate;
        
        [JsonProperty("interest_value")]
        public double InterestValue;

        [JsonProperty("last_price")]
        public double LastPrice;

        [JsonProperty("mark_price")]
        public double MarkPrice;
        
        [JsonProperty("mark_iv")]
        public double? MarkIv;

        [JsonProperty("max_price")]
        public double MaxBuyPrice;

        [JsonProperty("min_price")]
        public double MinSellPrice;

        [JsonProperty("open_interest")]
        public long OpenInterest;

        [JsonProperty("settlement_price")]
        public double? SettlementPrice;
        
        [JsonProperty("underlying_index")]
        public string UnderlyingIndex;

        [JsonProperty("underlying_price")]
        public double? UnderlyingPrice;
        
        public TickerState State;

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(CountToDateTimeConverter), false)]
        public DateTime DateTime;
        

        public override string ToString() =>
            $"{nameof(BestBidQty)}: {BestBidQty}, {nameof(BestBidPrice)}: {BestBidPrice}, {nameof(BidIv)}: {BidIv}, " +
            $"{nameof(BestAskQty)}: {BestAskQty}, {nameof(BestAskPrice)}: {BestAskPrice}, {nameof(AskIv)}: {AskIv}, " +
            $"{nameof(FundingRate)}: {FundingRate}, {nameof(DeliveryPrice)}: {DeliveryPrice}, " +
            $"{nameof(EstimatedDeliveryPrice)}: {EstimatedDeliveryPrice}, {nameof(FundingRate8HAvg)}: {FundingRate8HAvg}, " +
            $"{nameof(Greeks.Delta)}: {Greeks.Delta}, {nameof(Greeks.Gamma)}: {Greeks.Gamma}, {nameof(Greeks.Theta)}: {Greeks.Theta}, " +
            $"{nameof(Greeks.Vega)}: {Greeks.Vega}, {nameof(Greeks.Rho)}: {Greeks.Rho}, {nameof(IndexPrice)}: {IndexPrice}, " +
            $"{nameof(Instrument)}: {Instrument}, {nameof(InterestRate)}: {InterestRate}, {nameof(InterestValue)}: {InterestValue}, " +
            $"{nameof(LastPrice)}: {LastPrice}, {nameof(MarkPrice)}: {MarkPrice}, {nameof(MarkIv)}: {MarkIv}" +
            $"{nameof(MaxBuyPrice)}: {MaxBuyPrice}, {nameof(MinSellPrice)}: {MinSellPrice}, {nameof(OpenInterest)}: {OpenInterest}, " +
            $"{nameof(SettlementPrice)}: {SettlementPrice}, {nameof(UnderlyingIndex)}: {UnderlyingIndex}, {nameof(UnderlyingPrice)}: {UnderlyingPrice}, " +
            $"{nameof(State)}: {State}, {nameof(DateTime)}: {DateTime}";
    }
}