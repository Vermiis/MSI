using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorytmEwolucyjny
{
    public class Chromosome
    {
        public List<bool> Genes { get; set; }
        public double Fenotype
        {

            get
            {
                return CalculateFenotype();
            }
        }
        public Chromosome(int chromosomeLenght, Random random)
        {
                     
            for (int i = 0; i < chromosomeLenght; i++)
            {

                Genes.Insert(i, random.Next(2) == 0);
            }
        }
        public double CalculateFenotype()
        {
            double suma = 0;
            int i = Genes.Count() - 1;

            foreach (var item in Genes)
            {
                if (item == true)
                {
                    suma += Math.Pow(2, i);
                }
                i--;
            }

            return suma;
        }
    }

    public class Individual
    {
        public double Fitness { get; set; }
        public Chromosome Chromosome { get; set; }
        public Individual(int chromosomeLenght, Random random)
        {
            Chromosome = new Chromosome(chromosomeLenght, random);  
        }

    }

    public class Population
    {
        private Func<double, double> _fitnessFunction;
        public Population(int numberOfIndividuals, int chromosomeLengh, Func<double,double> fitness, Random random)
        {
            numberOfIndividuals = Enumerable.Range(0, numberOfIndividuals)
            .Select(x => new Individual(chromosomeLengh, random).ToList();

                                                                         
                                                                         
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
      

        }
    }
}
