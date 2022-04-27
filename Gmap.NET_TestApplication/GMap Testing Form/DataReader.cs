namespace Firebase.Vaccination
{

    using Firebase.Database;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Reactive.Linq;
    using System.Threading.Tasks;


    public class DataReader
    {
        public Population population_dataset;
        public bool isReady = false;
        public async Task Run()
        {
            //******************** Initialization ***************************//
            var client = new FirebaseClient("https://heymotocarro-1a1d4.firebaseio.com/");
            HttpClient httpclient = new HttpClient();

            string selectedkey = null, responseString, companyId;
            FormUrlEncodedContent content;
            HttpResponseMessage response;

            var PopulationData = await client
               .Child("population")//Prospect list
               .OnceSingleAsync<Population>();

            //******************** Get value K ***********************//
            Console.WriteLine($"K: { PopulationData.K}");

            //******************** Get initial list of Prospect ***********************//
            foreach (var person in PopulationData.individuals)
            {
                Console.WriteLine($"name:{ person.name}, { person.t} ");
                Console.WriteLine($"pos: {person.lng}, {person.lat}");
                foreach (var ne in person.In)
                {
                    Console.WriteLine($"  neig: {ne.id}, {ne.w} ");
                }

            }

            foreach(var person in PopulationData.individuals)
            {
                if (person.status == 1)
                {
                    PopulationData.infected.Add(person);
                }
            }
           
            population_dataset = PopulationData;
            isReady = true;
        }
    }


}
