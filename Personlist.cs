namespace ExamCode
{
    public class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }
        public void FetchScholarList()
        {
            Console.WriteLine("List Scholar");
            Console.WriteLine("-----------");
            foreach (Person person in this.personList)
            {
                if (person is Scholar)
                {
                    Console.WriteLine("{0} {1} {2}", person.GetGender(), person.GetFirstName(), person.GetLastName());
                }
            }
        }
        public void FetchStudentList()
        {
            Console.WriteLine("List Student");
            Console.WriteLine("-----------");
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("{0} {1} {2}", person.GetGender(), person.GetFirstName(), person.GetLastName());
                }
            }
        }
        public void FetchTeacherList()
        {
            Console.WriteLine("List Teacher");
            Console.WriteLine("-----------");
            foreach (Person person in this.personList)
            {
                if (person is Teacher)
                {
                    Console.WriteLine("{0} {1} {2}", person.GetGender(), person.GetFirstName(), person.GetLastName());
                }
            }
        }
        public int ScholarCount()
        {
            int scholarCount = 0;
            foreach (Person person in this.personList)
            {
                if (person is Scholar)
                {
                    scholarCount++;
                }
            }
            return scholarCount;
        }
        public int StudentCount()
        {
            int StudentCount = 0;
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    StudentCount++;
                }
            }
            return StudentCount;
        }
        public int StudentGrade10Count()
        {
            int StudentGrade10Count = 0;
            foreach (Person person in this.personList)
            {
                if (person is Student student)
                {
                    if (student.GetLevel() == "10")
                    {
                        StudentGrade10Count++;
                    }
                }
            }
            return StudentGrade10Count;
        }
        public int StudentGrade11Count()
        {
            int StudentGrade11Count = 0;
            foreach (Person person in this.personList)
            {
                if (person is Student student)
                {
                    if (student.GetLevel() == "11")
                    {
                        StudentGrade11Count++;
                    }
                }
            }
            return StudentGrade11Count;
        }
        public int StudentGrade12Count()
        {
            int StudentGrade12Count = 0;
            foreach (Person person in this.personList)
            {
                if (person is Student student)
                {
                    if (student.GetLevel() == "12")
                    {
                        StudentGrade12Count++;
                    }
                }
            }
            return StudentGrade12Count;
        }
        public int TeacherCount()
        {
            int TeacherCount = 0;
            foreach (Person person in this.personList)
            {
                if (person is Teacher)
                {
                    TeacherCount++;
                }
            }
            return TeacherCount;
        }

        public void PrintStatistics()
        {
            Console.Clear();
            Console.WriteLine("*************   Statistics   ********************");
            Console.WriteLine("Total number of registered Scholars is : {0}", ScholarCount());
            Console.WriteLine("Total number of registered Students is : {0}", StudentCount());
            Console.WriteLine("Total number of registered Teachers is : {0}", TeacherCount());
            Console.WriteLine("Total number of registered StudentGrade10 is : {0}", StudentGrade10Count());
            Console.WriteLine("Total number of registered StudentGrade11 is : {0}", StudentGrade11Count());
            Console.WriteLine("Total number of registered StudentGrade12 is : {0}", StudentGrade12Count());
            Console.WriteLine("*************************************************");
        }
    }
}