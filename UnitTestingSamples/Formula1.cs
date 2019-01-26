﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace UnitTestingSamples
{
    public class Formula1
    {
        private IChampionsLoader _loader;
        public Formula1(IChampionsLoader loader) => _loader = loader;

        public XElement ChampionsByCountry(string country)
        {
            var q = from r in _loader.LoadChampions().Elements("Racer")
                    where r.Element("Country").Value == country
                    orderby int.Parse(r.Element("Wins").Value) descending
                    select new XElement("Racer",
                        new XAttribute("Name", r.Element("Firstname").Value + " " + r.Element("Lastname").Value),
                        new XAttribute("Country", r.Element("Country").Value),
                        new XAttribute("Wins", r.Element("Wins").Value));
            return new XElement("Racers", q.ToArray());
        }
    }
}
