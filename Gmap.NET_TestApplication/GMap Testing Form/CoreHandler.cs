using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Firebase.Vaccination;

namespace Core
{
    public enum IndividualStatus { susceptable, infected, recovered}

    public class PopulationHandler
    {

        public Dictionary<int, Individual> population_set = new Dictionary<int, Individual>();

        public SerializedIndividual CompressIndividual(Individual m_individual)
        {
            SerializedIndividual newIndividual = new SerializedIndividual();
            newIndividual.firstName = m_individual.firstName;
            newIndividual.lastName = m_individual.lastName;
            newIndividual.pos_x = m_individual.pos_x;
            newIndividual.pos_y = m_individual.pos_y;
            newIndividual.id = m_individual.id;
            switch (m_individual.status)
            {
                case IndividualStatus.susceptable:
                    newIndividual.status = 0;
                    break;
                case IndividualStatus.infected:
                    newIndividual.status = 1;
                    break;
                case IndividualStatus.recovered:
                    newIndividual.status = 2;
                    break;
            }

            return newIndividual;
        }

        public Individual DecompressIndividual(SerializedIndividual m_individual)
        {
            Individual newIndividual = new Individual();
            newIndividual.firstName = m_individual.firstName;
            newIndividual.lastName = m_individual.lastName;
            newIndividual.pos_x = m_individual.pos_x;
            newIndividual.pos_y = m_individual.pos_y;
            newIndividual.id = m_individual.id;
            switch (m_individual.status)
            {
                case 0:
                    newIndividual.status = IndividualStatus.susceptable;
                    break;
                case 1:
                    newIndividual.status = IndividualStatus.infected;
                    break;
                case 2:
                    newIndividual.status = IndividualStatus.recovered;
                    break;
            }
            return newIndividual;
        }

        public Dictionary<int, Individual> GetPopulationFromJSON(string jsonText)
        {
            PopulationHolder convertedData = JsonConvert.DeserializeObject<PopulationHolder>(jsonText);
            List <Individual> population = new List<Individual>();
            foreach(SerializedIndividual individual in convertedData.population)
            {
                var _ind = DecompressIndividual(individual);
                int _id = _ind.id;
                population.Add(_ind);
            }

            Dictionary<int, Individual> finalizedPopulation = new Dictionary<int, Individual>();
            for(int i = 0; i < population.Count; i++)
            {
                Individual _ind = population[i];
                _ind.SetConnections(population, convertedData.population[i].connections, convertedData.population[i].weights);
                finalizedPopulation.Add(_ind.id, _ind);
            }

            return finalizedPopulation;
        }

        public string GetJSONFromPopulation(PopulationHolder _population)
        {
            string json = JsonConvert.SerializeObject(_population);
            return json;
        }

        public void GetDataset()
        {
            string s = System.IO.File.ReadAllText("../../testingPopulationSet.json");
            Console.WriteLine(s);
            population_set = GetPopulationFromJSON(s);
        }

    }

}