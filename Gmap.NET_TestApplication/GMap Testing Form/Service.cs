namespace Firebase.Vaccination
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
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
        public int status = 0;

    }
    public class Neighbor
    {
        public int id;
        public double w;
        public bool infectTrigger; // turn this bool to true when one neighbor infects another, is used by the UI to visualize the transmission of the infection
    }

    public class Appointment
    {
        public Patient prospect { get; set; }
        public Destination destination { get; set; }
        public Point[] pointList { get; set; }
        public string InitialTime { get; set; }
        public bool acepted { get; set; }
        public string vaccinated { get; set; }
        public bool active { get; set; }
        public string fid { get; set; } //key


    }

    public class Patient
    {
        public string userName;
        public string FirstName;
        public string LastName;
        public string SS;
        public string Age;
        public int uid;
        public string image;
        public string userCellphone;
    }
    public class Driver
    {
        public int companyColor;

    }

    public class Van
    {
        public string Make;
        public string Model;
        public string Vials { get; set; }
        public string CarPlate;
        public string VanId { get; set; }

    }



    public class Point
    {
        public double lat;
        public double lng;
        public double time;
    }
    public class Destination
    {
        public double lat;
        public double lng;
        public string destinationName;
    }
    public class Company
    {
        public string companyName { get; set; }
        public string status { get; set; }
    }
    public class Status
    {
        public int code { get; set; }       
    }
    public class Response
    {
        public bool success;
        public string message;
        public string companyId;
        public string received;
        public string color;
        public int[] infected { get; set; }
    }

}
