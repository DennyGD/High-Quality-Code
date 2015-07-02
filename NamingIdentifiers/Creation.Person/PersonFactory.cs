namespace Creation.Person
{
    public class PersonFactory
    {
        public void CreatePerson(int personalNumber)
        {
            Person person = new Person();
            person.Age = personalNumber;

            if (personalNumber % 2 == 0)
            {
                person.Name = "Man";
                person.Sex = Sex.Male;
            }
            else
            {
                person.Name = "Woman";
                person.Sex = Sex.Female;
            }
        }
    }
}