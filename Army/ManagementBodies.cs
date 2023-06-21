namespace Army
{

    public class ManagementBodies: Serviceman
    {
        public string CountyName { get; set; }
        public string Post { get; set; }

        public ManagementBodies(string name, string surname, int numMillitaryTicket, string countyName, string post) : base(name, surname, numMillitaryTicket)
        {
            CountyName = countyName;
            Post = post;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" Название округа: {CountyName}. Должность: {Post}." ;
        }
    }
}

