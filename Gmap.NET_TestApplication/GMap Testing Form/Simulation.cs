using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Firebase.Vaccination;

class Simulation
{
    public Population pop;
    public UiUpdate main;

    // Constructor for Simulation; pass in a reference to the population variable
    public Simulation(ref Population population, UiUpdate update)
    {
        pop = population;
        main = update;
        pop.individuals[12].status = 1;
        pop.infected.Add(pop.individuals[12]);
    }

    public List<Individual> tempList = new List<Individual>();

    public void Run()
    {
        tempList = new List<Individual>(pop.infected);
        //tempList = pop.infected;
        int a = 0;
        //bool done = false;
        //while (true)
        //{
        if (pop.infected.Count != 0)
        {
            foreach (Individual i in pop.infected)
            {
                i.recovery--;
                if (i.recovery == 0)
                {
                    i.isRecovered = true;
                    tempList.Remove(i);
                } else 
                foreach (int o in i.Out)
                {
                    isInfected(o);
                }
                a++;
            }
        }

            main.Update(); //write this function: Should reload the map updating all changed statuses.
            pop.infected = tempList;
        //    a++;
        //    if (a > 25) done = true;
        //    if (done) //change to infected list
        //    {
        //        break;
        //    }
        //    Thread.Sleep(100);
        //}
    }

    public void isInfected(int id)
    {
        double thresh = 0;
        if (pop.individuals[id].status == 1) return;
        foreach (Neighbor n in pop.individuals[id].In)
        {
            if (!pop.individuals[n.id].isVaccinated || !pop.individuals[n.id].isRecovered) //test if they're vaccinated OR recovered
            {
                thresh += n.w * pop.individuals[n.id].status;
            }
        }
        if (thresh > pop.individuals[id].t)
        {
            pop.individuals[id].status = 1;
            tempList.Add(pop.individuals[id]);
        }
    }
}

