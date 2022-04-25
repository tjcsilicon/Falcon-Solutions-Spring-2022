﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MColor = System.Windows.Media.Color;
using DColor = System.Drawing.Color;
using LiveCharts.Wpf;

namespace Firebase.Vaccination
{
    public class UiUpdate
    {
        public UiUpdate (GMapControl control, Population p)
        {
            gMap = control;
            pop = p;
        }

        // The overlay used to display lines on the gMap control
        GMapOverlay polyOverlay = new GMapOverlay("polygons");

        GMapControl gMap;
        Population pop;

        // Size in pixel the icons will display in the map
        int imgSize = 32;



        // The main Update function of the program. It is called every time the simulation ends a cycle
        public void Update()
        {
            HandleMapPopulation();
            HandleMapConnections();
            HandleGraph();
        }

        // Called on Update(), updates the nodes in the gMap control
        private void HandleMapPopulation()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            foreach (Individual individual in pop.individuals)
            {

                Bitmap img = new Bitmap(64, 64);
                switch (individual.status)
                {
                    case 0:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Susceptable_large, new Size(imgSize, imgSize));
                        break;
                    case 1:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Infected_large, new Size(imgSize, imgSize));
                        break;
                    case -1:
                        img = new Bitmap(WindowsFormsApp1.Properties.Resources.IndividualIcon_Recovered_large, new Size(imgSize, imgSize));
                        break;
                }
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(individual.lat, individual.lng),
                    img);
                markersOverlay.Markers.Add(marker);
            }
            gMap.Overlays.Add(markersOverlay);
        }

        // Called on Update(), updates the lines connecting nodes in the gMap control
        private void HandleMapConnections()
        {
            gMap.Overlays.Remove(polyOverlay);
            polyOverlay.Clear();
            int indv = 0;
            foreach (Individual m_individual in pop.individuals)
            {
                int id = 0;
                foreach (var connection in m_individual.In)
                {
                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(new PointLatLng(m_individual.lat, m_individual.lng));
                    points.Add(new PointLatLng(pop.individuals[connection.id].lat, pop.individuals[connection.id].lng));
                    GMapPolygon polygon = new GMapPolygon(points, "mypolygon");

                    DColor color = GetColorOfLine(indv, id);

                    polygon.Stroke = new System.Drawing.Pen(color, 0.5f);
                    polyOverlay.Polygons.Add(polygon);
                    id++;

                }
                indv++;
            }
            gMap.Overlays.Add(polyOverlay);
        }

        public void HandleGraph()
        {
            int sus = 0, inf = 0, rec = 0, vac = 0;
            foreach (Individual m in pop.individuals)
            {
                if (m.isVaccinated) { vac++; continue; }
                if (m.isRecovered) { rec++; continue; }
                switch (m.status)
                {
                    case 0:
                        sus++;
                        break;
                    case 1:
                        inf++;
                        break;
                }
            }
            UpdateGraph(infected_series, inf);
            UpdateGraph(susceptable_series, sus);
            UpdateGraph(recovered_series, rec);
            UpdateGraph(vaccinated_series, vac);
        }

        // The different StackedAreaSeries for the different types of status afflictions for the population
        StackedAreaSeries susceptable_series, infected_series, recovered_series, vaccinated_series = new StackedAreaSeries();

        private System.Drawing.Color GetColorOfLine(int person_a, int id)
        {
            if (pop.individuals[person_a].In[id].infectTrigger)
            {
                return System.Drawing.Color.Red;
            }
            else
            {
                return DColor.FromArgb(100, 37, 70, 74);

            }
        }

        private void UpdateGraph(StackedAreaSeries m_series, int value)
        {
            //int value = rnd.Next(0, 10);
            m_series.Values.Add(value);
        }
    }


}