﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class korclass
    {
        //Rendszerváltozók
        private double sugar,
            kerulet,
            terulet;

        //Konstruktor
        public korclass(double r) { this.sugar = r; }

        public void setKerulet(double r) {

            this.kerulet = 2 * r * Math.PI;
        
        }

        public void setTerulet()
        {

            this.terulet = Math.Pow(this.sugar, 2) * Math.PI;

        }

        public double getKerulet()
        {

            return this.kerulet;

        }

        public double getTerulet()
        {

            return this.terulet;

        }

        public double getSugar() { return this.sugar; }

    }
}
