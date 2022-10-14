namespace ExamCode
{
    class Student : Person
    {
        private string Level;

        private string school;

        public Student(string gender, string firstname, string lastname, int age, string allergy, string religion, string level, string school)
        : base(gender, firstname, lastname, age, allergy, religion)
        {
            this.Level = level;
            this.school = school;
        }
        public string GetLevel()
        {
            return this.Level;
        }
        public string GetSchool()
        {
            return this.school;
        }


    }
}
