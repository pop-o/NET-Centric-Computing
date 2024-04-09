namespace PrimeEF.Models
{
    //this model class stores the data sent from form and return the data when required
    public class AddStudent
    {
        public Guid Id { get; set; }//auto id generation with primary key

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public string Faculty { get; set; }
    }
}
