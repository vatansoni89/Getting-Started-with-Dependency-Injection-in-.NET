﻿using Newtonsoft.Json;
using PeopleViewer.Common;
using System.Collections.Generic;
using System.Net;

namespace PersonDataReader.Service
{
    public class ServiceReader : IPersonReader
    {
        private WebClient client = new WebClient();
        private string baseUri = "https://localhost:44340/api/people";

        public IEnumerable<Person> GetPeople()
        {
            string result = client.DownloadString(baseUri);
            var people = JsonConvert.DeserializeObject<IEnumerable<Person>>(result);
            return people;
        }

        public Person GetPerson(int id)
        {
            string result = client.DownloadString($"{baseUri}/{id}");
            var person = JsonConvert.DeserializeObject<Person>(result);
            return person;
        }
    }
}