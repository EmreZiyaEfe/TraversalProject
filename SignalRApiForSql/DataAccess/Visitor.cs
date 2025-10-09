namespace SignalRApiForSql.DataAccess
{
    public enum ECity
    {
        İstanbul = 1,
        İzmir,
        Ankara,
        Bursa,
        Eskişehir
    }
    public class Visitor
    {
        public int Id { get; set; }
        public ECity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
