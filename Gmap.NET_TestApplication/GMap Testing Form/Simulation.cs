using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Vaccination;

class Simulation
{
    public Population pop;

    // Constructor for Simulation; pass in a reference to the population variable
    public Simulation(ref Population population, ref WindowsFormsApp1.MainSimulation mainSim)
    {
        pop = population;
        bool done = false;
        while (true)
        {
            foreach (Individual i in pop.infected)
            {
                foreach (int o in i.Out)
                {
                    isInfected(o);
                }
            }

            mainSim.Update(); //write this function: Should reload the map updating all changed statuses.

            if (done) //change to infected list
            {
                break;
            }
        }
    }

    public void isInfected(int id)
    {
        double thresh = 0;
        foreach (Neighbor n in pop.individuals[id].In)
        {
            if (pop.individuals[n.id].isVaccinated) //test if they're vaccinated
            {
                thresh += n.w * pop.individuals[n.id].status;
            }
        }
        if (thresh > pop.individuals[id].t)
        {
            pop.individuals[id].status = 1;
        }
    }
}

