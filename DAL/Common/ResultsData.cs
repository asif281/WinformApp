namespace BAL.Common
{
    public class ResultsData
    {
        public List<WhereRow> data { get; set; }
    }

    public class WhereRow
    {
        public string name { get; set; }
        public string email { get; set; }
        public string phone_extension { get; set; }
        public string where_current_location { get; set; }
        public string where_returning_to_work { get; set; }
        public string where_status { get; set; }
        public ServiceObject primary_service { get; set; }
    }

    public class ServiceObject
    {
        public string name { get; set; }
    }
}