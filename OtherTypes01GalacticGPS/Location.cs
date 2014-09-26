using System;

namespace OtherTypes01GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet currentPlanet;

        public Location(double latitude, double longitude, Planet p) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.CurrentPlanet = p;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set { this.latitude = value; }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set { this.longitude = value; }
        }

        public Planet CurrentPlanet
        {
            get { return this.currentPlanet; }
            set { this.currentPlanet = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.CurrentPlanet);
        }

    }
}
