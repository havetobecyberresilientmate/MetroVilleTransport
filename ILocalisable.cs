namespace MetrovilleTransport
{
    public interface ILocalisable
    {
        double Latitude { get; }
        double Longitude { get; }
        void ActualiserPosition(double lat, double lon);
    }
}
