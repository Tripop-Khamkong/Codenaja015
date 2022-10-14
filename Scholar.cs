namespace ExamCode
{
    class Scholar : Person
    {
        private string ScholarID;
        private bool AdminQuestion;
        private string EmailScholar;
        private string PasswordScholar;

        public Scholar(string gender, string firstname, string lastname, string ScholarID, int age, string allergy, string religion, string EmailScholar, string PasswordScholar)
        : base(gender, firstname, lastname, age, allergy, religion)
        {
            this.ScholarID = ScholarID;
            this.EmailScholar = EmailScholar;
            this.PasswordScholar = PasswordScholar;
        }
        public string GetScholarID()
        {
            return this.ScholarID;
        }
        public string GetEmailScholar()
        {
            return this.EmailScholar;
        }
        public string GetPasswordScholar()
        {
            return this.PasswordScholar;
        }
    }
}
