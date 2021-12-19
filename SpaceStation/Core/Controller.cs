using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private IRepository<IPlanet> planetRepository;
        private IRepository<IAstronaut> astronautRepository;
        private IMission mission;
        private int exploredPlanets = 0;

        public Controller()
        {
            planetRepository = new PlanetRepository();
            astronautRepository = new AstronautRepository();
            mission = new Mission();
        }

        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut;

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }
            else
            {
                throw new InvalidOperationException("Astronaut type doesn't exists!");
            }

            astronautRepository.Add(astronaut);
            return $"Successfully added {astronaut.GetType().Name}: {astronautName}!";
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);

            foreach (var item in items)
            {
                planet.Items.Add(item);
            }

            planetRepository.Add(planet);
            
            return $"Successfully added Planet: {planetName}!";
        }

        public string ExplorePlanet(string planetName)
        {
            var astronauts = astronautRepository.Models.Where(x => x.Oxygen > 60).ToList();

            if (!astronauts.Any())
            {
                throw new InvalidOperationException("You need at least one astronaut to explore the planet");
            }

            var planet = planetRepository.FindByName(planetName);

            mission.Explore(planet, astronauts);
            exploredPlanets++;

            int deadAstro = astronauts.Count(x => !x.CanBreath);

            return $"Planet: {planetName} was explored! Exploration finished with {deadAstro} dead astronauts!";
        }

        public string Report()
        {
            var astronauts = astronautRepository.Models;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{exploredPlanets} planets were explored!");
            sb.AppendLine("Astronauts info:");
            
            foreach (var astro in astronauts)
            {
                sb.AppendLine($"Name: {astro.Name}");
                sb.AppendLine($"Oxygen: {astro.Oxygen}");
                string itemsInfo = astro.Bag.Items.Any() ?
                   string.Join(", ", astro.Bag.Items) :
                   "none";

                sb.AppendLine($"Bag items: {itemsInfo}");
            }
            
            string result = sb.ToString().TrimEnd();
            return result;
        }

        public string RetireAstronaut(string astronautName)
        {
            var astronaut = astronautRepository.FindByName(astronautName);

            if (astronaut == null)
            {
                throw new InvalidOperationException($"Astronaut {astronautName} doesn't exists!");
            }
            else
            {
                astronautRepository.Remove(astronaut);
                return $"Astronaut {astronautName} was retired!";
            }

        }
    }
}
