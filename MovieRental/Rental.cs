namespace MovieRental
{
    public sealed class Rental
    {
        public Movie movie { get; }

        public int daysRental { get; }

        public Rental(Movie movie, int daysRental)
        {
            this.movie = movie;
            this.daysRental = daysRental;
        }

        public int getPrice() => movie.getPrice(daysRental);

        public int getBonusPoints() => movie.getBonusPoints(daysRental);
    }
}