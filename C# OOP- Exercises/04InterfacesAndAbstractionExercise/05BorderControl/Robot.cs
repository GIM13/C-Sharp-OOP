namespace _05BorderControl
{
    public class Robot : ISubjects
    {
        public Robot(string model, long id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }

        public long Id { get; }
    }
}
