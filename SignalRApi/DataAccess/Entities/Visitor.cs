namespace SignalRApi.DataAccess.Entities
{
    public enum ECity
    {
        İstanbul = 1,
        İzmir,
        Ankara,
        Bursa,
        Antalya
    }
    public class Visitor : BaseEntity
    {
        public ECity City { get; set; }
        public int VisitCityCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
