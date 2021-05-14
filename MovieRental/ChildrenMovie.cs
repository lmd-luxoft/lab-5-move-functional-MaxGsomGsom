namespace MovieRental
{
    public sealed class ChildrenMovie: Movie
    {
        public ChildrenMovie(string title)
            : base(title, MovieType.CHILDREN) { }

        public override int getPrice(int daysRental)
        {
            var thisAmount = 15;
            if(daysRental > 3)
                thisAmount += (daysRental - 3) * 15;
            return thisAmount;
        }
    }
}
