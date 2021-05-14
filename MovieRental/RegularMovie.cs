namespace MovieRental
{
    public sealed class RegularMovie: Movie
    {
        public RegularMovie(string title)
            : base(title, MovieType.REGULAR) { }


        public override int getPrice(int daysRental)
        {
            var thisAmount = 2;
            if(daysRental > 2)
                thisAmount += (daysRental - 2) * 15;

            return thisAmount;
        }
    }
}
