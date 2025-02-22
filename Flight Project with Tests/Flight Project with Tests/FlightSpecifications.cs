using Domain;
using FluentAssertions;

namespace Flight_Project_with_Tests
{
    public class FlightSpecifications
    {
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(6, 3, 3)]
        [InlineData(10, 6, 4)]
        [InlineData(12, 8, 4)]
        public void Booking_reduces_the_number_of_seats(int seatCapacity, int numberOfSeats, int remainingNumberOfSeats)
        {
            // Given
            var flight = new Flight(seatCapacity: seatCapacity);
            // When
            flight.Book("jannick@tutorialeu.com", numberOfSeats);
            // Then
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        /*
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {           
            var flight = new Flight(seatCapacity: 3);            
            flight.Book("example@test.com", 1);           
            flight.RemainingNumberOfSeats.Should().Be(2);
        }
        */

        [Fact]
        public void Avoid_overbooking()
        {
            // Given
            var flight = new Flight(seatCapacity: 3);
            // When
            var error = flight.Book("example@test.com", 4);
            // Then
            error.Should().BeOfType<OverbookingError>();
        }

        [Fact]
        public void Books_flights_successfully()
        {
            var flight = new Flight(seatCapacity: 3);
            var error = flight.Book("example@test.com", 1);
            error.Should().BeNull();
        }

        [Fact]
        public void Remembers_bookings()
        {
            var flight = new Flight(seatCapacity: 150);
            flight.Book(passengerEmail: "example@test.com", numberOfSeats: 4);
            flight.BookingList.Should().ContainEquivalentOf(new Booking("example@test.com", 4));
        }

        [Theory]
        [InlineData(3, 1, 1, 3)]
        [InlineData(4, 2, 2, 4)]
        [InlineData(7, 5, 4, 6)]
        public void Canceling_bookings_frees_up_the_seats(
        int initialCapacity,
        int numberOfSeatsToBook,
        int numberOfSeatsToCancel,
        int remainingNumberOfSeats
        )
        {
            // Given
            var flight = new Flight(initialCapacity);
            flight.Book(passengerEmail: "example@test.com", numberOfSeats: numberOfSeatsToBook);
            // When
            flight.CancelBooking(passengerEmail: "example@test.com", numberOfSeats: numberOfSeatsToCancel);
            // Then
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }

        [Fact]
        public void Doesnt_cancel_bookings_for_passengers_who_have_not_booked()
        {
            var flight = new Flight(3);
            var error = flight.CancelBooking(passengerEmail: "example@test.com", numberOfSeats: 2);
            error.Should().BeOfType<BookingNotFoundError>();
        }

        [Fact]
        public void Returns_null_when_successfully_cancels_a_booking()
        {
            var flight = new Flight(3);
            flight.Book(passengerEmail: "example@test.com", numberOfSeats: 1);
            var error = flight.CancelBooking(passengerEmail: "example@test.com", numberOfSeats: 1);
            error.Should().BeNull();
        }
    }
}