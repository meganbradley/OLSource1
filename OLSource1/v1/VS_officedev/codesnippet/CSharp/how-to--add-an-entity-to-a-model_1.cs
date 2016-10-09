    public partial class Contact
	{
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public int EmailPromotion { get; set; }
        public bool NameStyle { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

	}