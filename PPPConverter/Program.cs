using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPConverter
{
    static class Program
    {

        // Attempts to take in data about the quality and price of an item, and converts them to be equivelant to USD
        // Computer runs twice as fast, costs four times as much (?) 
        // Probably needs fairly specific choices and assumptions, may want to expose to user
        // Attempts to fix issue with literally all the money in the world won't make a reasonable equivelancy.  
        static double calculate_quality_equivelance(double[] USD_cost, double[] comp_cost)
        {

            return 0;
        }

        // Attempts to complete the percentage allocation calculation
        // Given yearly income, and relative time period/wealth, attempts to break out how the individual will likely spend their money
        static double calculate_percentage_wealth_allocation(double[] USD_cost, double[] comp_cost)
        {

            return 0;
        }

        // Attempts to extrapolate the yearly wage of an average worker
        static double calculate_average_yearly_wage(double[] USD_cost, double[] comp_cost)
        {

            return 0;
        }
        // Attempts to complete the PPP calculation, last item
        //All items should be normalized, so should just be adding up each side and returning the result
        static double calculate_final_PPP(double[] USD_cost, double[] comp_cost)
        {
            double USD_val = 0;
            double comp_val = 0;
            for (int i = 0; i < comp_cost.Length; i++)
            {
                USD_val = USD_val + USD_cost[i];
                comp_val = comp_val + USD_cost[i];
            }

            return comp_val/USD_val;
        }

        // Need to take in any source of data and attempt to convert it to USD PPP
        static double[] calculate_overall_PPP()
        {
            //Load last input

            //Take in inputs
                //Intent
                    //Find PPP
                    //Find potential implications
                //Scale (individual, town, society)
                    //Period (Stone age, Iron age, Roman, Medieval, Industrial Age, Space Age, Information Age, Future)
                    //Relative wealth (for individual and town) (Starving, Impoverished, Stunted, Comfortable, Wealthy, set Gini coefficient(?))
                    //Global modifiers (General danger level, (more spending on weapons) finetune adjustment of wealth allocation)
                    //Wealth (Absolute or relative - gives user automatically updating remaining amount, relative helps with deciding prices based on rest of input)
                //Resources - Each one is quantity, price, quality (% compared to US) (Utility function compared to US?  10x as much food doesn't produce 10x as much wealth?)
                    //Food
                    //Energy
                    //Weapons
                    //Clothes
                    //Consumer goods
                    //Housing
                    //Water
                    //Services
                    //Savings/Investment
                //

            //Temp save

            //Establish path

                //PPP

                    //Quality conversion

                //Likely time period/situation

                    //Rest of society


            //Page database
            
            //Normalize and convert



            //Return to user

            //Prompt for saving for later work

                //Overwrite temp save

            return [0];
        }



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Get data

            //offer data analysis
                // Analysis is designed to assist user with establishing the world they're trying to desgin.  
                // Compare wealth allocation percentages to historical periods
                // Give historical context, give closest neighbors and what adjustments would likely be necessary

            //Run calculations

            //Return value, with examples
        }
    }
}
