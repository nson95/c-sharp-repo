namespace ch12_classes_demo
{
    // to define properties : public string Code { get; set; }
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string ageRating { get; set; }
        public string Director { get; set; }

        public Movie()
        {
        }
        public Movie(int Id, string Title, int Year, string ageRating, string Director)
        {
            this.Id = Id;
            this.Title = Title;
            this.Year = Year; 
            this.ageRating = ageRating;
            this.Director = Director;
        }
        //public string ToString()
        //{
        //    string reStr = "";
        //    return $"Movie{Id}: {Title}, {Year}, {ageRating}, {Director}";

        //}
        public override string ToString()
        {
            return $"Movie{Id}: {Title}, {Year}, {ageRating}, {Director}";
        }
    }
}
