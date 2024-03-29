﻿namespace Firebase.Vaccination
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    public class Population
    {
        public int K;
        public Individual[] individuals { get; set; }
        public List<int> selected = new List<int>();
        public List<Individual> infected = new List<Individual>();
    }
    public class Individual
    {
        public double lat;
        public double lng;
        public string name;
        public double t;//threshold
        public Neighbor[] In { get; set; }
        public int[] Out { get; set; }
        public int status = 0;
        public bool isVaccinated;
        public bool isRecovered;
        public int recovery = 4;
        public int id;
    }
    public class Neighbor
    {
        public int id;
        public double w;
        public bool infectTrigger; // turn this bool to true when one neighbor infects another, is used by the UI to visualize the transmission of the infection
        public bool wasInfect = false;
    }

}
