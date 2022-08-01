using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Controllers;
using WebApplication2.Models;
using Moq;

namespace WebApplication2.Tests.Controllers
{
    [TestClass]
    public class CityControllerTest
    {
        private static CityController cityController;
        List<CityDetail> mockSet = CityControllerTest.GetMockData();
        

        [TestMethod]
        public void Get()
        {
            // Arrange
            CityController controller = GetInstance();

            
            // Act
            IEnumerable<CityDetail> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetByCityID()
        {
            // Arrange
            CityController controller = GetInstance();

            // Act
            CityDetail result = controller.Get(1);

            // Assert
            Assert.IsNotNull(result);
        }

        private CityController GetInstance()
        {
            if(cityController == null)
            {
                Uri countryUri = new Uri("https://restcountries.com/v3.1/");
                Uri weatherUri = new Uri("https://api.openweathermap.org/data/2.5/weather?");
                
                cityController = new CityController(countryUri,weatherUri);
            }

            return cityController;

        }

        private static List<CityDetail> GetMockData()
        {
            var cityData = new List<CityDetail>()
            {
                new CityDetail()
                {
                    city_id = 1,
                    country = "India",
                    date_established = "",
                    estimated_population = 20000,
                    name = "Bangalore",
                    state= "Karnataka",
                    tourist_rating = 5
                },
                 new CityDetail()
                {
                    city_id = 2,
                    country = "India",
                    date_established = "",
                    estimated_population = 50000,
                    name = "Chennai",
                    state= "Tamil Nadu",
                    tourist_rating = 5
                }
            };

            return cityData;
        }
    }
}
