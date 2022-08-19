namespace TaskLibrary
{
    public class CoffeeMachine
    {
        public string[] CoffeeTypes = { "Capuchino" };


        public double CoinValue(double firstCoin, double secondCoin, double thirdCoin, double fourthCoin)
        {
            return firstCoin + secondCoin + thirdCoin + fourthCoin;
        }

        public string CoinInfo(double firstCoin, double secondCoin, double thirdCoin, double fourthCoin)
        {
            double result = firstCoin + secondCoin + thirdCoin + fourthCoin;
            return "The used coin values are " + firstCoin.ToString() + " " + secondCoin.ToString() + " " + thirdCoin.ToString() + " " + fourthCoin.ToString()
                + "The total is " + result;
        }

        public string GetProduct(double firstCoin, double secondCoin, double thirdCoin, double fourthCoin, string coffeeMocha, double mochaPrice, string productCapuchino,
            double capuchinoPrice, string noCash)
        {
            double result = firstCoin + secondCoin + thirdCoin + fourthCoin;
            if (result >= mochaPrice)
            {
                return coffeeMocha;
            }
            else if (result >= capuchinoPrice)
            {
                return productCapuchino;
            }
            return noCash;
        }

        public double GetChange(double firstCoin, double secondCoin, double thirdCoin, double fourthCoin, string coffeeMocha, double mochaPrice, string productCapuchino,
            double capuchinoPrice, string noCash)
        {
            double result = firstCoin + secondCoin + thirdCoin + fourthCoin;
            if (result >= mochaPrice)
            {
                return result - mochaPrice;
            }
            else if (result <= capuchinoPrice)
            {
                throw new ArgumentException();
            }
            return result - capuchinoPrice;
        }

        public string ReturnMoneyForCoffee(IClient client)
        {
            if (client.MadeCupsOfCoffee == 0) return "Ops, no coffee";
            else
            {
                if (client.LastCoffeeMade == "Capuchino")
                {
                    client.Money += new Capuchino().Price;
                }
                return "Your money are returned";
            }
        }

        public string GetCoffeeInStock()
        {

            string coffeTypes = "We have: ";
            foreach (string coffee in CoffeeTypes)
            {
                coffeTypes += coffee + ", ";
            }
            return coffeTypes.Remove(coffeTypes.Length - 2);
        }
    }
}
   