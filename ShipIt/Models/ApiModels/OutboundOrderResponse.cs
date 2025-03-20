namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponse: Response
    {
        public int NumberOfTrucks { get; set; }
        public OutboundOrderResponse(int numberOfTrucks)
        {
            NumberOfTrucks = numberOfTrucks;
            Success = true;
        }
        public OutboundOrderResponse() { }
    }
}