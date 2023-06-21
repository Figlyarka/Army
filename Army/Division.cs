using System.Collections;


namespace Army
{
    //Класс "Подразделение" из задания 14.
    public class Division : IEnumerable<Serviceman>
    {
        public string Name { get; set; }
        public int UnitNumber { get; set; }

        List<Serviceman> ListOfMilitaryPersonnel;
    
        public int  numberOfMilitaryPersonnel
        {
            get => ListOfMilitaryPersonnel.Count;
        }

        public Division(string name, IEnumerable<Serviceman> sequence )
        {
            Name = name;
        
            var listT = new List<Serviceman>();

            foreach (var serviceman in sequence)
            {
                if (UnitNumber == serviceman.NumMillitaryUnit)
                {
                    listT.Add(serviceman);
                }
            }
        
        
            listT.AsEnumerable();
            ListOfMilitaryPersonnel = new List<Serviceman>(listT.Distinct());
        }
    
        public IEnumerator<Serviceman> GetEnumerator() => ListOfMilitaryPersonnel.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    
}

