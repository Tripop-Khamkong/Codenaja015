namespace ExamCode
{
    class Teacher : Person
    {
        private string Rank;
        private bool CarQuestion;
        private string CarID;

        private string EmailTeacher;
        private string PasswordTeacher;


        public Teacher(string gender, string firstname, string lastname, int age, string allergy, string religion, string Rank, bool CarQuestion, string InputCarID, string EmailTeacher, string PasswordTeacher)
        : base(gender, firstname, lastname, age, allergy, religion)
        {
            this.Rank = Rank;
            this.CarQuestion = CarQuestion;
            this.CarID = CarID;
            this.EmailTeacher = EmailTeacher;
            this.PasswordTeacher = PasswordTeacher;
        }
        public string GetRank()
        {
            return this.Rank;
        }
        public string GetCarID()
        {
            return this.CarID;
        }
        public string GetEmailTeacher()
        {
            return this.EmailTeacher;
        }
        public string GetPasswordTeacher()
        {
            return this.PasswordTeacher;
        }
    }
}
