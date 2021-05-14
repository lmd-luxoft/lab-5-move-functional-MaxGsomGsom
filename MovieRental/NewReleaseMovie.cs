namespace MovieRental
{
    public sealed class NewReleaseMovie: Movie
    {
        public NewReleaseMovie(string title)
            : base(title, MovieType.NEW_RELEASE) { }

        public override int getPrice(int daysRental)
        {
            return daysRental * 3;
        }

        public override int getBonusPoints(int daysRental)
        {
            return daysRental > 1 ? 1 : 0;
        }
    }
}
