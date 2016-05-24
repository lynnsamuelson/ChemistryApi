using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeriodicTableApi.Models
{
    public class Element
    {
        public int ElementId {get; set;}
        public string AtomicName { get; set; }
        public string AtomicSymbol { get; set; }
        public decimal AtomicMass { get; set; }
        public string Series { get; set; }
        public int NumberOfProtons { get; set; }
        public int NumberOfNeutrons { get; set; }
        public int NumberOfElectrons { get; set; }
        public string StateAt295k { get; set; }
        public decimal MeltingPoint { get; set; }
        public decimal BoinlingPoint { get; set; }
        public int Electronegativity { get; set; }
        public int ElectronAffinity { get; set; }
        public decimal Valence { get; set; }
        public decimal Ionization { get; set; }
        public decimal Radius { get; set; }
        public decimal Hardness { get; set; }
        public decimal Modulus { get; set; }
        public decimal Density { get; set; }
        public decimal Conductivity { get; set; }
        public decimal Heat { get; set; }
        public decimal Abundance { get; set; }
        public int YearDiscovered { get; set; }
        public string Orbitals { get; set; }
        public string Family { get; set; }
        public string Period { get; set; }
        public string Classification { get; set; }

    }

}
