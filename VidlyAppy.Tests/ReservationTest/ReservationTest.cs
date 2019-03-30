using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using VidlyAppy.Models;
using NUnit.Framework;

namespace VidlyAppy.Tests.ReservationTest
{
    [TestFixture]
    class ReservationTest
    {


        [Test]
        public void CanBecancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBecancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBecancelledBy_SameUserCancelling_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation
            {
                MadeBy = user
            };

            //Act
            var result = reservation.CanBecancelledBy(user);

            //Assert
            Assert.That(result == true);
        }

        [Test]
        public void CanBecancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation
            {
                MadeBy = new User()
            };

            //Act
            var result = reservation.CanBecancelledBy(user);

            //Assert
            Assert.That(result, Is.True);
        }
    }   
}
