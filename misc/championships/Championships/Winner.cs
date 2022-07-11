namespace Championships
{
    public class Winner
    {
        public string Id { get; set; }
        private int Year { get; set; }
        private string Name { get; set; }
        private string SuccessorId { get; set; }

        public Winner(string id, int year, string name, string successorId)
        {
            this.Id = id;
            this.Year = year;
            this.Name = name;
            this.SuccessorId = successorId;
        }
        public Winner(string id, int year, string name)
        {
            this.Id = id;
            this.Year = year;
            this.Name = name;
        }
    }
}