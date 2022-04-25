using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebase.Vaccination
{
    public class UiUpdate
    {
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
            gMapControl.Overlays.Add(markersOverlay);
        }

        // Called on Update(), updates the lines connecting nodes in the gMap control
        private void HandleMapConnections()
        {
            gMapControl.Overlays.Remove(polyOverlay);
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
            gMapControl.Overlays.Add(polyOverlay);
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
    }
}
