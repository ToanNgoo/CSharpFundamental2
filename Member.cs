namespace CSharpFundamental2
{
    public class Member
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string BirthPlace { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        public bool IsGraduated { get; set; }

        public string Info
        {
            get
            {
                return string.Format("First Name:{0}\r\n"
                + "Last Name:{1}\r\n"
                + "Gender:{2}\r\n"
                + "Date Of Birth:{3}\r\n"
                + "Phone Number:{4}\r\n"
                + "Birth Place:{5}\r\n"
                + "Age:{6}\r\n"
                + "Is Graduated:{7}",
                FirstName,
                LastName,
                Gender,
                DateOfBirth,
                PhoneNumber,
                BirthPlace,
                Age,
                IsGraduated);
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}