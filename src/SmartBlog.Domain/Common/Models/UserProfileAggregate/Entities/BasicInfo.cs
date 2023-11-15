namespace SmartBlog.Domain.Common.Models.UserProfileAggregate.Entities
{
    public sealed class BasicInfo
    {
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
        public string EmailAddress { get; private set; }
        public string Phone {  get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string CurrencyCity { get; private set; }

        public static BasicInfo CreateInfo(string firstName, string lastName,
                                            string emailAddress, string phone, DateTime dateOfBirth, string currencyCity)
        {
            return new BasicInfo { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress,
                Phone = phone, DateOfBirth = dateOfBirth, CurrencyCity = currencyCity };
        }
    }
}
