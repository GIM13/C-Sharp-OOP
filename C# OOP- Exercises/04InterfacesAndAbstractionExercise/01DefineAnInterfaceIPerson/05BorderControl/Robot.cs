namespace _05BorderControl
{
    public class Robot : ISubjects
    {
        public Robot(string model, long id)
        {
            this.model = model;
            Id = id;
        }

        public string model { get; set; }

        public long Id { get; }
    }
}
