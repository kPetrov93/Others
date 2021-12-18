using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }

        public int Capacity { get; set; }

        public void Add(Pet pet)
        {
            if (data.Count < Capacity )
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            var currentAnimal = data.FirstOrDefault(x => x.Name == name);

            if (currentAnimal == null)
            {
                return false;
            }

            data.Remove(currentAnimal);
            return true;
        }

        public Pet GetPet(string name, string owner)
        {
            var currentAnimal = data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            return currentAnimal;
        }

        public Pet GetOldestPet()
        {
            var currentAnimal = data.OrderByDescending(x => x.Age).FirstOrDefault();
            return currentAnimal;
        }

        public int Count { get { return data.Count; } }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");
            foreach (var animal in data)
            {
                sb.AppendLine($"Pet {animal.Name} with owner: {animal.Owner}");
            }


            return sb.ToString().TrimEnd();
        }
    }
}
