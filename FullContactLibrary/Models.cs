using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FullContactLibrary
{
    public class Models
    {
    }
    [DataContract]
    public class Twitter
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string typeName { get; set; }
        [DataMember]
        public bool isPrimary { get; set; }
    }
    [DataContract]
    public class Quora
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string typeName { get; set; }
    }
    [DataContract]
    public class Foursquare
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string typeName { get; set; }
        [DataMember]
        public bool isPrimary { get; set; }
    }
    [DataContract]
    public class Googleplu
    {
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string typeName { get; set; }
        [DataMember]
        public bool isPrimary { get; set; }
    }
    [DataContract]
    public class Photos
    {
        [DataMember]
        public List<Twitter> twitter { get; set; }
        [DataMember]
        public List<Quora> quora { get; set; }
        [DataMember]
        public List<Foursquare> foursquare { get; set; }
        [DataMember]
        public List<Googleplu> googleplus { get; set; }
    }
    [DataContract]
    public class Website
    {
        [DataMember]
        public string url { get; set; }
    }
    [DataContract]
    public class Gtalk
    {
        [DataMember]
        public string handle { get; set; }
    }
    [DataContract]
    public class Skype
    {
        [DataMember]
        public string handle { get; set; }
    }
    [DataContract]
    public class Chats
    {
        [DataMember]
        public List<Gtalk> gtalk { get; set; }
        [DataMember]
        public List<Skype> skype { get; set; }
    }
    [DataContract]
    public class ContactInfo
    {
        [DataMember]
        public string familyName { get; set; }
        [DataMember]
        public string givenName { get; set; }
        [DataMember]
        public string fullName { get; set; }
        [DataMember]
        public List<Website> websites { get; set; }
        [DataMember]
        public Chats chats { get; set; }
    }
    [DataContract]

    public class Organization
    {
        [DataMember]
        public bool isPrimary { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string startDate { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public bool current { get; set; }
        [DataMember]
        public string endDate { get; set; }
    }
    [DataContract]
    public class City
    {
        [DataMember]
        public bool deduced { get; set; }
        [DataMember]
        public string name { get; set; }
    }
    [DataContract]
    public class State
    {
        [DataMember]
        public bool deduced { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string code { get; set; }
    }
    [DataContract]
    public class Country
    {
        [DataMember]
        public bool deduced { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string code { get; set; }
    }
    [DataContract]
    public class Continent
    {
        [DataMember]
        public bool deduced { get; set; }
        [DataMember]
        public string name { get; set; }
    }
    [DataContract]
    public class County
    {
        [DataMember]
        public bool deduced { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string code { get; set; }
    }
    [DataContract]
    public class LocationDeduced
    {
        [DataMember]
        public string normalizedLocation { get; set; }
        [DataMember]
        public string deducedLocation { get; set; }
        [DataMember]
        public City city { get; set; }
        [DataMember]
        public State state { get; set; }
        [DataMember]
        public Country country { get; set; }
        [DataMember]
        public Continent continent { get; set; }
        [DataMember]
        public County county { get; set; }
        [DataMember]
        public double likelihood { get; set; }
    }

    [DataContract]
    public class Demographics
    {
        [DataMember]
        public string locationGeneral { get; set; }
        [DataMember]
        public LocationDeduced locationDeduced { get; set; }
        [DataMember]
        public string age { get; set; }
        [DataMember]
        public string gender { get; set; }
        [DataMember]
        public string ageRange { get; set; }
    }

    [DataContract]
    public class Aboutme
    {
        [DataMember]
        public string typeName { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string url { get; set; }
    }

     [DataContract]
    public class SocialProfiles
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string typeId { get; set; }
        [DataMember]
        public string typeName { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public int? followers { get; set; }
        [DataMember]
        public int? following { get; set; }
    }
    [DataContract]
    public class FullContactPerson
    {
        public FullContactPerson()
        {
            new HashSet<SocialProfiles>();
        }
        [DataMember]
        public int status { get; set; }
        [DataMember]
        public double likelihood { get; set; }
        [DataMember]
        public string requestId { get; set; }
        [DataMember]
        public Photos photos { get; set; }
        [DataMember]
        public ContactInfo contactInfo { get; set; }
        [DataMember]
        public List<Organization> organizations { get; set; }
        [DataMember]
        public Demographics demographics { get; set; }
        [DataMember]
        public List<SocialProfiles> socialProfiles { get; set; }
    }
}
