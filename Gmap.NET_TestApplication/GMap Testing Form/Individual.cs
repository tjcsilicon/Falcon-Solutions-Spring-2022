using System;
using System.Collections;
using System.Collections.Generic;
using Core;

public class Individual
{
    public int id;

    public string firstName;
    public string lastName;

    public IndividualStatus status;

    public float pos_x;
    public float pos_y;

    public List<Individual> connections = new List<Individual>();
    public List<float> weights = new List<float>();

    public void SetConnections(List<Individual> population, int[] connection_ids, float[] _weights)
    {
        int population_size = population.Count;
        for (int a = 0; a < connection_ids.Length; a++)
        {
            for (int i = 0; i < population_size; i++)
            {
                if (population[i].id == a)
                {
                    connections.Add(population[i]);
                    weights.Add(_weights[a]);
                    break;
                }
            }
        }
    }
}

[Serializable]
public class SerializedIndividual
{
    public int id;
    public string firstName, lastName;
    public int status;
    public float pos_x, pos_y;
    public int[] connections;
    public float[] weights;
}

[Serializable]
public class PopulationHolder
{
    public SerializedIndividual[] population;
}