using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        void Start();
        void Stop();
    }

    public interface ILand
    {
        double MaxLandSpeed { get; set; }
        void Drive();
    }

    public interface ISea
    {
        double MaxWaterSpeed { get; set; }
        void Drive();
    }

    public interface IAir
    {
        double MaxAirSpeed { get; set; }
        bool Winged { get; set; }
        void Fly();
    }

    public class Motorcycle : IVehicle, ILand
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxLandSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class JetSki : IVehicle, ISea
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Cessna : IVehicle, IAir
    {
        public bool Winged { get; set; }
        public double MaxAirSpeed { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }

        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection of all vehicles that fly
            Cessna c17 = new Cessna();
            Cessna c21 = new Cessna();

            List<IAir> flyingCessnas = new List<IAir>()
            {
                c17, c21
            };

            // With a single `foreach`, have each vehicle Fly()
            foreach(IAir plane in flyingCessnas)
            {
                plane.Fly();
            }

            // Build a collection of all vehicles that operate on roads
            Motorcycle Fatboy = new Motorcycle();
            Motorcycle Sportster = new Motorcycle();

            List<ILand> harleys = new List<ILand>()
            {
                Fatboy, Sportster
            };

            // With a single `foreach`, have each road vehicle Drive()
            foreach(ILand hog in harleys)
            {
                hog.Drive();
            }


            // Build a collection of all vehicles that operate on water
            JetSki Yamaha = new JetSki();
            JetSki Honda = new JetSki();

            List<ISea> waveRunners = new List<ISea>()
            {
                Yamaha, Honda
            };

            // With a single `foreach`, have each water vehicle Drive()
            foreach(ISea runner in waveRunners)
            {
                runner.Drive();
            }
        }
    }
}
