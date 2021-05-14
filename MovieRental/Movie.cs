namespace MovieRental
{
    public abstract class Movie
    {
        public string title { get; }
        public MovieType type { get; }

        protected Movie(string title, MovieType type)
        {
            this.title = title;
            this.type = type;
        }

        public override string ToString()
        {
            return title;
        }

        public abstract int getPrice(int daysRental);

        public virtual int getBonusPoints(int daysRental) => 0;
    }
}