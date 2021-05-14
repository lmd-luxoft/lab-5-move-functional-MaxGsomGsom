﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;

namespace MovieRental
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void NameFilmShouldBeCorrect()
        {
            Movie movie = new NewReleaseMovie("Rio2");
            Assert.AreEqual("Rio2", movie.title);
        }
        [Test]
        public void TypeFilmShouldBeCorrect()
        {

            Movie movie = new NewReleaseMovie("Rio2");
            Assert.AreEqual(MovieType.NEW_RELEASE, movie.type);
        }
        [Test]
        public void RentalShouldBeCorrectMovie()
        {
            Movie movie = new RegularMovie("Angry Birds");
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(movie, rental.movie);
        }
        [Test]
        public void RentalShouldBeCorrectDayRented()
        {

            Movie movie = new RegularMovie("Angry Birds");
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(20, rental.daysRental);
        }
        [Test]
        public void CustomerShouldBeCorrectName()
        {
            Customer customer = new Customer("Bug");
            Assert.AreEqual("Bug", customer.name);
        }
        [Test]
        public void CustomerCreateCorrectStatement()
        {

            Customer customer = new Customer("Bug");

            Movie movie1 = new ChildrenMovie("Angry Birds");
            Rental rental1 = new Rental(movie1, 2);
            customer.addRental(rental1);

            Movie movie2 = new NewReleaseMovie("StarWar");
            Rental rental2 = new Rental(movie2, 10);
            customer.addRental(rental2);

            Movie movie3 = new RegularMovie("Hatico");
            Rental rental3 = new Rental(movie3, 4);
            customer.addRental(rental3);

            string actual = customer.statement();
            Assert.AreEqual("учет аренды для Bug\n\tAngry Birds\t15\n\tStarWar\t30\n\tHatico\t32\nСумма задолженности составляет 77\nВы заработали 4 очков за активность", actual);
        }
    }
}
