using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CityController : ApiController
    {
       public  CitiesEntities ce = new CitiesEntities();
        HttpClient client1, client2;

        public CityController()
        {
            client1 = new HttpClient();
            client2 = new HttpClient();
            client1.BaseAddress = new Uri(ConfigurationManager.AppSettings["countryBaseAddress"]);
            client2.BaseAddress = new Uri(ConfigurationManager.AppSettings["weatherBaseAddress"]);
        }
        public CityController(Uri countryURI, Uri weatherURI)
        {
            client1 = new HttpClient();
            client2 = new HttpClient();
            CitiesEntities ce = new CitiesEntities();
            client1.BaseAddress = countryURI;
            client2.BaseAddress = weatherURI;

        }

        //GET: api/City
        public IEnumerable<CityDetail> Get()
        {
            return ce.CityDetails.ToList();
        }

        //Search by cityName
        [Route("api/City/{cityName}")]
        public string Get(string cityName)
        {
            CityDetail cityDetail = ce.CityDetails.FirstOrDefault(x => x.name == cityName);
            if (cityDetail == null)
            {
                return "City details not in database";
            }

            HttpResponseMessage weatherDetailsResponse = GetCityWeatherDetail(cityName);
            Root details = JsonConvert.DeserializeObject<Root>(weatherDetailsResponse.Content.
                                                ReadAsStringAsync().Result);

            if (weatherDetailsResponse.IsSuccessStatusCode)
            {
                var country = details.Sys.Country;
                HttpResponseMessage CountryDetailsResponse = GetCountryDetails("IN");
                if (CountryDetailsResponse.IsSuccessStatusCode)
                {
                    var t = CountryDetailsResponse.Content.ReadAsStringAsync().Result;
                    List<Countries> myCountryDetails = JsonConvert.DeserializeObject<List<Countries>>(CountryDetailsResponse.Content.ReadAsStringAsync().Result);


                    string output = cityDetail.name +" "+ cityDetail.tourist_rating + " " + cityDetail.city_id + " " + cityDetail.country + " " + 
                        cityDetail.date_established + " " + cityDetail.estimated_population
                        + " " + myCountryDetails[0].Cca2 + " " + myCountryDetails[0].Cca3  + " " + details.Id+ " " + details.Main.Temp+ " " + details.Visibility;

                    return output;
                }
            }

            return "country details not available";
        }

        // GET: api/City/5
        public CityDetail Get(int id)
        {
           return  ce.CityDetails.FirstOrDefault(x => x.city_id == id);
        }

        // POST: api/City
        public string Post(CityDetail cityDetail)
        {
            ce.CityDetails.Add(cityDetail);
            ce.SaveChanges();

            return "city added";
        }

        // PUT: api/City/5
        public string Put(int id, CityDetail cityDetail)
        {
            CityDetail cd = ce.CityDetails.Find(id);
            if(cd!= null)
            {
                cd.country = cityDetail.country;
                cd.date_established = cityDetail.date_established;
                cd.estimated_population = cityDetail.estimated_population;
                cd.name = cityDetail.name;
                cd.state = cityDetail.state;
                cd.tourist_rating = cityDetail.tourist_rating;

                ce.Entry(cd).State = System.Data.Entity.EntityState.Modified;
                ce.SaveChanges();
            }

            return "city updated";
        }

        // DELETE: api/City/5
        public string Delete(int id)
        {
            CityDetail cd = ce.CityDetails.Find(id);
            if (cd != null)
                ce.CityDetails.Remove(cd);
            ce.SaveChanges();

            return "city deleted";
        }
        private HttpResponseMessage GetCityWeatherDetail(string cityName)
        {
            string requestUri = client2.BaseAddress + "q=" + cityName + "&appid=" + ConfigurationManager.AppSettings["weatherApiKey"];

            HttpResponseMessage response = client2.GetAsync(requestUri).Result;
            return response;
        }

        private HttpResponseMessage GetCountryDetails(string countryCode)
        {
            string requestUri = client1.BaseAddress + "alpha/" + countryCode;
            client1.DefaultRequestHeaders.Accept.Clear();
            client1.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client1.GetAsync(requestUri).Result;
            return response;
        }
    }
}
