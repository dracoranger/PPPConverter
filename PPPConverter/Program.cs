using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPConverter
{
    static class Program
    {

        // Something might be weird

        static double Alert_User()
        {

            return 0;
        }

        // Attempts to take in data about the quality and price of an item, and converts them to be equivelant to USD
        // Computer runs twice as fast, costs four times as much (?) - tries to equalize across time as 400% more
        // Probably needs fairly specific choices and assumptions, may want to expose to user
        // Attempts to fix issue with literally all the money in the world won't make a reasonable equivelancy.  
        static double[] Calculate_Quality_Equivelance(double[] USD_cost, double[] comp_cost, double[] comp_quality, double lower_limit = .5, double upper_limit = 1.5)
        {

            double[] comp_val = [];

            for (int i = 0; i < comp_cost.Length; i++)
            {

                comp_val[i] = comp_cost[i] * comp_quality[i];

                if (USD_cost[i] / comp_val[i] < lower_limit || USD_cost[i] / comp_val[i] > upper_limit)
                {
                    Alert_User();
                }

            }

            return comp_val;
        }

        // Attempts to complete the percentage allocation calculation
        // Given yearly income, and relative time period/wealth, attempts to break out how the individual will likely spend their money, for the average (median?) person
        //Arbitrary basis makes it either percentage (if 1) or off a wealth pool (so like 500 gp or something)
        static double[] Calculate_Percentage_Wealth_Allocation(double[] period, double[] nudge, double[] socioecon_class, double arbitrary_basis = 0)
        {
            double[] wealth_allocation_avg = [];

            for (int i = 0; i < period.Length; i++)
            {

                wealth_allocation_avg[i] = arbitrary_basis * period[i] * nudge[i] * socioecon_class[i];

            }
            return wealth_allocation_avg;
        }

        // Attempts to extrapolate the yearly wage of an average worker
        //Arbitrary basis makes it either percentage (if 1) or off a wealth pool (so like 500 gp or something)
        static double Calculate_Average_Yearly_Wage((double[] Calculate_Percentage_Wealth_Allocation, double[,] prices, double arbitrary_basis = 0, int year_length)
        {
            double yearly_wage = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                double temp_price = 0;
                for (int j = 0; j < prices[i].Length; j++)
                {
                    temp_price = temp_price + prices[i, j];
                }

                //May need to correct, idea is that yearly wage is the amount in prices times the allocation times the year, so the general amount one would likely spend in a day multiplied by the year
                //would need to normalize prices to be the amount purchased in a day.  Price of 1 lb beef would be calculated the same as an egg, even if you probably eat more than one egg a day.  
                yearly_wage = yearly_wage + Calculate_Percentage_Wealth_Allocation[i] * temp_price * year_length;
            }
            return yearly_wage;
        }
        // Attempts to complete the PPP calculation, last item
        //All items should be normalized, so should just be adding up each side and returning the result
        static double Calculate_Final_PPP(double[] USD_cost, double[] comp_cost)
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
