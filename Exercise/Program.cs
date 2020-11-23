using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Program
    {
        public Dictionary<string,double> RetrieveCalValues(Dictionary<string,double> data)
        {
            // remove from the dictionary all pairs where the values are negative
            // add a new pair to the dictionary with key="sum" as key the summation of all remaining values
            // add a new pair to the dictionary with key="mult" as key the product of all remaining values
            // add a new pair to the dictionary with key="div" as key the division of all remaining values
            // round the appropriate values to 10 decimal places
            // return the updated dictionary
           
            return null;
        }

        public void RetrieveCalValues(Dictionary<string, double> data, string clear)
        {
            // remove from the dictionary all pairs where the key contains the substring <clear>
            // add a new pair to the dictionary with key="sum" as key the summation of all remaining values
            // add a new pair to the dictionary with key="mult" as key the product of all remaining values
            // round the appropriate values to 10 decimal places
        }

        public void RetrieveCalValuesRigour(Dictionary<string, double> data, string clear)
        {
            // remove from the dictionary all pairs where the key contains the a lexicographically version of <clear>
            // example: clear = "corrupt" is contained in "cor rupt","corrupt", "corrupt1", "12c or ru pt45", "cor12rupt"
            // add a new pair to the dictionary with key="sum" as key the summation of all remaining values
            // add a new pair to the dictionary with key="mult" as key the product of all remaining values
            // round the appropriate values to 10 decimal places
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Exercise6!");

            
        }
    }
}
