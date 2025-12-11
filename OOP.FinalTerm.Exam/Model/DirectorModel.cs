namespace OOP.FinalTerm.Exam.Model
{
    //TODO: Students will implement the DirectorModel class with properties as per requirements
    //Inherit PersonModel
    //PersonModel must be created first if not already present
    public class DirectorModel : PersonModel
    {
        public string Genres { get; set; } = string.Empty;
        public int TotalMoviesCreated { get; set; }
    }
}
