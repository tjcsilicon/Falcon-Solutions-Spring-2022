using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Vaccination;

public class VaccinationAssessment
{
    public Population pop;

    // Constructor
    public VaccinationAssessment(Population population)
    {
        pop = population;
    }


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
        if (i.In.Length > j.In.Length)
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

    public void ApplyVaccinations(int k)
    {
        List<Individual> l = new List<Individual>(pop.individuals);
        l.Sort(compareOut); //sorts by outgoing
        List<Individual> b = new List<Individual>();
        for (int i = 0; i < l.Count; i++) //adds k of the most outgoing individuals to new list
        {
            b.Add(l[i]);

        }
        b.Sort(compareIn); //sorts newList by most In


        for (int i = 0; i < k; i++) // changes vaccination status of best fits
        {
            b[i].isVaccinated = true;
        }
    }
}