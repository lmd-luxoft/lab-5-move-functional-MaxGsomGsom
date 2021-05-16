using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public sealed class Customer
    {
        private readonly List<Rental> rentals = new List<Rental>();

        public string name { get; }

        public Customer(string name)
        {
            this.name = name;
        }

        public void addRental(Rental rental)
        {
           rentals.Add(rental);
        }

        public string statement()
        {
            var report = new StringBuilder();
            report.Append($"учет аренды для {name}\n");

            int totalAmount = 0, frequentRenterPoints = 0;
            foreach (var item in rentals)
            {
                //добавить очки для активного арендатора
                frequentRenterPoints++;
                frequentRenterPoints += item.getBonusPoints();

                var thisAmount = item.getPrice();
                totalAmount += thisAmount;

                report.Append($"\t{item.movie}\t{thisAmount}\n");
            }

            report.Append($"Сумма задолженности составляет {totalAmount}\n");
            report.Append($"Вы заработали {frequentRenterPoints} очков за активность");
            return report.ToString();
        }
    }
}