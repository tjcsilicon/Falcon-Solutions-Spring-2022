using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Firebase.Vaccination;
using Newtonsoft.Json;
using WindowsFormsApp1;

public class VaccinationAssessment
{
    public VaccinationAssessment(MainSimulation s)
    {
        _s = s;
    }

    MainSimulation _s;
    Population p;

    int compareOut(Individual i, Individual j)
    {
        if (i.Out.Length > j.Out.Length)
        {
            return 1;
        }
        else if (i.Out.Length == j.Out.Length)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    int compareIn(Individual i, Individual j)
    {
        if (i.In.Length > j.In.Length )
        {
            return 1;
        }
        else if (i.In.Length == j.In.Length)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public void ApplyVaccinations(Population pop)
    {
        p = pop;
        List<Individual> l = new List<Individual>(pop.individuals);
        List<Individual> c = new List<Individual>(pop.individuals);
        Individual[] arr = pop.individuals.ToArray<Individual>();
        int k = pop.K;
        l.Sort(compareOut); //sorts by outgoing
        List<Individual> b = new List<Individual>();
        for (int i = 0; i < l.Count; i++) //adds k of the most outgoing individuals to new list
        {
            b.Add(l[i]);

        }
        b.Sort(compareIn); //sorts newList by most In

        int[] a = new int[k];
        for (int i = 0; i < k; i++) // changes vaccination status of best fits
        {
            _s.Log("Applied Vaccine to " + b[i].name);
            b[i].isVaccinated = true;
            a[i] = c.IndexOf(b[i]);
        }
        Task.Run(() =>sendK(a).Wait());

    }

    async Task sendK(int[] a)
    {
        /*
                var dictionary = new Dictionary<string, string>
                {
                    { "K", }
                }*/

        string values = JsonConvert.SerializeObject(a, Formatting.Indented);

        var dictionary = new Dictionary<string, string>
            {
                { "key",values },// https://www.newtonsoft.com/json/help/html/SerializeObject.htm
                { "companyId", "FalconSolutions"}
            };
        var content = new FormUrlEncodedContent(dictionary);
        HttpClient c = new HttpClient();
        var response = await c.PostAsync("https://us-central1-heymotocarro-1a1d4.cloudfunctions.net/sendk", content);
        var responseString = await response.Content.ReadAsStringAsync();
        var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Response>(responseString);
        Console.WriteLine(data.received);
        int i = 0;
        _s.Log(data.received);
        foreach (var infec in data.infected)
        {
            Console.WriteLine($"infec: {i}->{infec} ");
            
            i++;
            _s.Log($"infec: {i}->{infec} ");
            p.individuals[infec].status = 1;
            p.infected.Add(p.individuals[infec]);

        }

    }

}

public class Response
{
    public string received { get; set; }
    public int[] infected { get; set; }
    public bool status { get; set; }
    public string companyID { get; set; }
    public int color { get; set; }
    public string message { get; set; }

}