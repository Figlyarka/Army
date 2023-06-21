namespace Army
{

    public class Veteran: Serviceman
    {
        public int LengthOfService { get; set; }
        public int PensionAmount { get; set; }

        public Veteran(string name, string surname, int numMillitaryTicket, int lengthOfService, int pensionAmount) : base(name, surname, numMillitaryTicket)
        {
            LengthOfService = lengthOfService;
            PensionAmount = pensionAmount;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" Выслуга лет: {LengthOfService} лет. Размер пенсии: {PensionAmount} руб.";
        }
    }
}

