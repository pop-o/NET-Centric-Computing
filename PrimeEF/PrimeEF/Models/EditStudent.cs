namespace PrimeEF.Models
{
    //this model is responsible for setting the data for update
    public class EditStudent
    {
        public Guid Id { get; set; }//auto id generation with primary key

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public string Faculty { get; set; }
    }
}
