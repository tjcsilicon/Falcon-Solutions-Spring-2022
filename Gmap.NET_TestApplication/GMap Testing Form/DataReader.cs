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


            //******************* Cloud Function subcribe a Company ****************/
            var company = new Company
            {
                companyName = "WSU VANS",
                status = "active"
            };

            var dictionary = new Dictionary<string, string>
            {
                { "companyName",company.companyName  },
                { "status",company.status}
            };

            content = new FormUrlEncodedContent(dictionary);
            response = await httpclient.PostAsync("https://us-central1-heymotocarro-1a1d4.cloudfunctions.net/reportCompany", content);
            responseString = await response.Content.ReadAsStringAsync();
            Response data = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseString);
            //Response message
            Console.WriteLine(data.message);
            Console.WriteLine(data.companyId);
            companyId = data.companyId;

            //******************* Report selectted indivuals Call Cloud Function select a Appointment By Id ****************/
            //PopulationData.selected[0] = 3;
            //PopulationData.selected[1] = 7;



            dictionary = new Dictionary<string, string>
            {
                { "key","selectedkey"  },// https://www.newtonsoft.com/json/help/html/SerializeObject.htm
                { "companyId",companyId}
            };
            content = new FormUrlEncodedContent(dictionary);
            response = await httpclient.PostAsync("https://us-central1-heymotocarro-1a1d4.cloudfunctions.net/sendk", content);
            responseString = await response.Content.ReadAsStringAsync();
            data = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseString);
            Console.WriteLine(data.received);
            int i = 0;
            foreach (var infec in data.infected)
            {
                Console.WriteLine($"infec: {i}->{infec} ");
                i++;
            }


            //subscriptionFree.Dispose();
            //subscriptionSelected.Dispose();*/

            var stop = Console.ReadLine();
            population_dataset = PopulationData;
        }
    }


}
