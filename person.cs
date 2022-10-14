namespace ExamCode
{
    public abstract class Person
    {
        private string gender;
        private string firstname;
        private string lastname;
        private int age;
        private string allergy;
        private string religion;

        public Person(string gender, string firstname, string lastname, int age, string allergy, string religion)
        {
            this.gender = gender;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.allergy = allergy;
            this.religion = religion;
        }
        public string GetGender()
        {
            return this.gender;
        }
        public string GetFirstName()
        {
            return this.firstname;
        }
        public string GetLastName()
        {
            return this.lastname;
        }
        public int GetAge()
        {
            return this.age;
        }
        public string GetAllergy()
        {
            return this.allergy;
        }
        public string GetReligion()
        {
            return this.religion;
        }
    }
}
