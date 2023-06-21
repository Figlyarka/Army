namespace Army
{
    public class CommandStaff : Serviceman
    {
        public string DivisionName { get; set; }
        public string Post { get; set; }

        public CommandStaff(string name, string surname, int numMillitaryTicket, string divisionName, string post) : base(name, surname, numMillitaryTicket)
        {
            DivisionName = divisionName;
            Post = post;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" Название подразделения: {DivisionName}. Должность: {Post}.";
        }
    }
}

