﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform.Model
{
    public class Match
    {
        private String id;
        private Equipe domicile, exterieur;
        private double localistionX, localisationY;
        private DateTime date;
        private string description;
        private Boolean etat;

        public double LocalistionX { get => localistionX; set => localistionX = value; }
        public double LocalisationY { get => localisationY; set => localisationY = value; }
        public string Description { get => description; set => description = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Id { get => id; set => id = value; }
        public bool Etat { get => etat; set => etat = value; }
        internal Equipe Domicile { get => domicile; set => domicile = value; }
        internal Equipe Exterieur { get => exterieur; set => exterieur = value; }
    }
}
