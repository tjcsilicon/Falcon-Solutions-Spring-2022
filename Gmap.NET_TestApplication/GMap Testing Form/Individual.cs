using System;
using System.Collections;
using System.Collections.Generic;


namespace Firebase.Vaccination
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using Firebase.Database;
    using System;
    using System.Net.Http;
    using System.Reactive.Linq;
    using System.Threading.Tasks;

    public class Population
    {
        public int K;
        public Individual[] individuals { get; set; }
        public List<int> selected = new List<int>();
    }
    public class Individual
    {
        public double lat;
        public double lng;
        public string name;
        public double t;//threshold
        public Neighbor[] In { get; set; }
        public int[] Out { get; set; }
        public int status;
    }
    public class Neighbor
    {
        public int id;
        public double w;

    }

    public class getData
    {
        public static Population pop;
        public static async Task Run()
        {
            //******************** Initialization ***************************//
            var client = new FirebaseClient("https://heymotocarro-1a1d4.firebaseio.com/");
            HttpClient httpclient = new HttpClient();

            string selectedkey = null, responseString, companyId;
            FormUrlEncodedContent content;
            HttpResponseMessage response;

            pop = await client
               .Child("population")//Prospect list
               .OnceSingleAsync<Population>();

            //******************** Get value K ***********************//
            Console.WriteLine($"K: { pop.K}");

            //******************** Get initial list of Prospect ***********************//
            foreach (var person in pop.individuals)
            {
                Console.WriteLine($"name:{ person.name}, { person.t} ");
                foreach (var ne in person.In)
                {
                    Console.WriteLine($"  neig: {ne.id}, {ne.w} ");
                }
            }
        }
    }
}
    //public void SetConnections(List<Individual> population, int[] connection_ids, float[] _weights)
    //{
    //    int population_size = population.Count;
    //    for (int a = 0; a < connection_ids.Length; a++)
    //    {
    //        for (int i = 0; i < population_size; i++)
    //        {
    //            if (population[i].id == a)
    //            {
    //                connections.Add(population[i]);
    //                weights.Add(_weights[a]);
    //                break;
    //            }
    //        }
    //    }
    //}

//[Serializable]
//public class SerializedIndividual
//{
//    public int id;
//    public string firstName, lastName;
//    public int status;
//    public float pos_x, pos_y;
//    public int[] connections;
//    public float[] weights;
//}

//[Serializable]
//public class PopulationHolder
//{
//    public SerializedIndividual[] population;
//}
