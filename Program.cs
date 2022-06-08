namespace CSharpFundamental2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>{
                new Member{
                    FirstName = "Toan",
                    LastName = "Ngo Huu",
                    Gender = "Male",
                    DateOfBirth = new DateTime(2001, 12, 11),
                    PhoneNumber = "0968204019",
                    BirthPlace = "Ha Nam",
                    IsGraduated = true
                },
                new Member{
                    FirstName = "Tuan",
                    LastName = "Nguyen Van",
                    Gender = "Male",
                    DateOfBirth = new DateTime(1996, 10, 11),
                    PhoneNumber = "0968204019",
                    BirthPlace = "Ha Noi",
                    IsGraduated = false
                },
                new Member{
                    FirstName = "Nhung",
                    LastName = "Nguyen Thi",
                    Gender = "Female",
                    DateOfBirth = new DateTime(2000, 02, 21),
                    PhoneNumber = "0968204019",
                    BirthPlace = "Ha Noi",
                    IsGraduated = true
                }
            };

            Console.WriteLine("Cau 1");
            var maleMember = members.Where(m => m.Gender == "Male").ToList();
            maleMember.ForEach(m => Console.WriteLine(m.Info));

            Console.WriteLine("Cau 2");
            var maxAge = members.Max(m => m.Age);
            var oldestMember2 = members.Where(x => x.Age == maxAge).Take(1);
            if (oldestMember2.Any())
            {
                foreach (Member item in oldestMember2)
                {
                    Console.WriteLine(item.Info);
                }
            }

            Console.WriteLine("Cau 3");
            var fullNames = members.Select(m => m.FullName).ToList();
            fullNames.ForEach(m => Console.WriteLine(m));

            Console.WriteLine("Cau 4");
            Console.WriteLine("Age same 2000");
            var ageSame2000 = members.FindAll(m => m.DateOfBirth.Year == 2000);
            foreach (var member in ageSame2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Age less 2000");
            var ageLess2000 = members.FindAll(m => m.DateOfBirth.Year < 2000);
            foreach (var member in ageLess2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Age more 2000");
            var ageMore2000 = members.FindAll(m => m.DateOfBirth.Year > 2000);
            foreach (var member in ageMore2000)
            {
                Console.WriteLine(member.Info);
            }

            Console.WriteLine("Cau 5");
            var personHaNoiFirst = (from s in members
                                    where !string.IsNullOrEmpty(s.BirthPlace) &&
                                    s.BirthPlace.ToLower().Equals("ha noi")
                                    select s).FirstOrDefault();

            if (personHaNoiFirst != null)
            {
                Console.WriteLine(personHaNoiFirst.Info);
            }
        }
    }
}