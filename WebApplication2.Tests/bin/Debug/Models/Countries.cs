using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Ara
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class CapitalInfo
    {
        [JsonProperty("latlng")]
        public List<double> Latlng { get; set; }
    }

    public class Car
    {
        [JsonProperty("signs")]
        public List<string> Signs { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
    }

    public class Ces
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class CoatOfArms
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class Currencies
    {
        [JsonProperty("INR")]
        public INR INR { get; set; }

        [JsonProperty("USD")]
        public USD USD { get; set; }
    }

    public class Cym
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Demonyms
    {
        [JsonProperty("eng")]
        public Eng Eng { get; set; }

        [JsonProperty("fra")]
        public Fra Fra { get; set; }
    }

    public class Deu
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Eng
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public class Est
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Fin
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Flags
    {
        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class Fra
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("f")]
        public string F { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }
    }

    public class Gini
    {
        [JsonProperty("2011")]
        public double _2011 { get; set; }
    }

    public class Hin
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Hrv
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Hun
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Idd
    {
        [JsonProperty("root")]
        public string Root { get; set; }

        [JsonProperty("suffixes")]
        public List<string> Suffixes { get; set; }
    }

    public class INR
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class Ita
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Jpn
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Kor
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Languages
    {
        [JsonProperty("eng")]
        public string Eng { get; set; }

        [JsonProperty("hin")]
        public string Hin { get; set; }

        [JsonProperty("tam")]
        public string Tam { get; set; }
    }

    public class Maps
    {
        [JsonProperty("googleMaps")]
        public string GoogleMaps { get; set; }

        [JsonProperty("openStreetMaps")]
        public string OpenStreetMaps { get; set; }
    }

    public class Name
    {
        [JsonProperty("common")]
        public string Common { get; set; }

        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("nativeName")]
        public NativeName NativeName { get; set; }
    }

    public class NativeName
    {
        [JsonProperty("eng")]
        public Eng Eng { get; set; }

        [JsonProperty("hin")]
        public Hin Hin { get; set; }

        [JsonProperty("tam")]
        public Tam Tam { get; set; }
    }

    public class Nld
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Per
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Pol
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Por
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class PostalCode
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("regex")]
        public string Regex { get; set; }
    }

    public class Countries
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("tld")]
        public List<string> Tld { get; set; }

        [JsonProperty("cca2")]
        public string Cca2 { get; set; }

        [JsonProperty("ccn3")]
        public string Ccn3 { get; set; }

        [JsonProperty("cca3")]
        public string Cca3 { get; set; }

        [JsonProperty("cioc")]
        public string Cioc { get; set; }

        [JsonProperty("independent")]
        public bool Independent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("unMember")]
        public bool UnMember { get; set; }

        [JsonProperty("currencies")]
        public Currencies Currencies { get; set; }

        [JsonProperty("idd")]
        public Idd Idd { get; set; }

        [JsonProperty("capital")]
        public List<string> Capital { get; set; }

        [JsonProperty("altSpellings")]
        public List<string> AltSpellings { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("subregion")]
        public string Subregion { get; set; }

        [JsonProperty("languages")]
        public Languages Languages { get; set; }

        [JsonProperty("translations")]
        public Translations Translations { get; set; }

        [JsonProperty("latlng")]
        public List<double> Latlng { get; set; }

        [JsonProperty("landlocked")]
        public bool Landlocked { get; set; }

        [JsonProperty("borders")]
        public List<string> Borders { get; set; }

        [JsonProperty("area")]
        public double Area { get; set; }

        [JsonProperty("demonyms")]
        public Demonyms Demonyms { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("maps")]
        public Maps Maps { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("gini")]
        public Gini Gini { get; set; }

        [JsonProperty("fifa")]
        public string Fifa { get; set; }

        [JsonProperty("car")]
        public Car Car { get; set; }

        [JsonProperty("timezones")]
        public List<string> Timezones { get; set; }

        [JsonProperty("continents")]
        public List<string> Continents { get; set; }

        [JsonProperty("flags")]
        public Flags Flags { get; set; }

        [JsonProperty("coatOfArms")]
        public CoatOfArms CoatOfArms { get; set; }

        [JsonProperty("startOfWeek")]
        public string StartOfWeek { get; set; }

        [JsonProperty("capitalInfo")]
        public CapitalInfo CapitalInfo { get; set; }

        [JsonProperty("postalCode")]
        public PostalCode PostalCode { get; set; }
    }

    public class Rus
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Slk
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Spa
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Swe
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Tam
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class Translations
    {
        [JsonProperty("ara")]
        public Ara Ara { get; set; }

        [JsonProperty("ces")]
        public Ces Ces { get; set; }

        [JsonProperty("cym")]
        public Cym Cym { get; set; }

        [JsonProperty("deu")]
        public Deu Deu { get; set; }

        [JsonProperty("est")]
        public Est Est { get; set; }

        [JsonProperty("fin")]
        public Fin Fin { get; set; }

        [JsonProperty("fra")]
        public Fra Fra { get; set; }

        [JsonProperty("hrv")]
        public Hrv Hrv { get; set; }

        [JsonProperty("hun")]
        public Hun Hun { get; set; }

        [JsonProperty("ita")]
        public Ita Ita { get; set; }

        [JsonProperty("jpn")]
        public Jpn Jpn { get; set; }

        [JsonProperty("kor")]
        public Kor Kor { get; set; }

        [JsonProperty("nld")]
        public Nld Nld { get; set; }

        [JsonProperty("per")]
        public Per Per { get; set; }

        [JsonProperty("pol")]
        public Pol Pol { get; set; }

        [JsonProperty("por")]
        public Por Por { get; set; }

        [JsonProperty("rus")]
        public Rus Rus { get; set; }

        [JsonProperty("slk")]
        public Slk Slk { get; set; }

        [JsonProperty("spa")]
        public Spa Spa { get; set; }

        [JsonProperty("swe")]
        public Swe Swe { get; set; }

        [JsonProperty("urd")]
        public Urd Urd { get; set; }

        [JsonProperty("zho")]
        public Zho Zho { get; set; }
    }

    public class Urd
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }

    public class USD
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class Zho
    {
        [JsonProperty("official")]
        public string Official { get; set; }

        [JsonProperty("common")]
        public string Common { get; set; }
    }


}