namespace Log4NetExample
{
    using System;

    public class Student
    {
        private const string ValidationRequirement = "cannot be null, empty or containing only white-space characters";

        private string firstName;

        private string lastName;

        private string specialty;

        public Student(string firstName, string lastName, string specialty)
        {
            

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Specialty = specialty;

            Logger.Log.Info(string.Format("New student - {0} {1}.", this.FirstName, this.LastName));
        }

        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Logger.Log.Error(string.Format("Invalid first name - {0}.", value));
                    throw new ArgumentException(string.Format("Invalid first name - {0}.", ValidationRequirement));
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Logger.Log.Error(string.Format("Invalid last name - {0}.", value));
                    throw new ArgumentException(string.Format("Invalid last name - {0}.", ValidationRequirement));
                }

                this.lastName = value;
            }
        }

        public string Specialty
        {
            get
            {
                return this.specialty;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Logger.Log.Error(string.Format("Invalid specialty - {0}.", value));
                    throw new ArgumentException(string.Format("Invalid specialty - {0}.", ValidationRequirement));
                }

                this.specialty = value;
            }
        }
    }
}