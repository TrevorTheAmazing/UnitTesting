using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.ClassFiles.Game.Day
{
    public class Weather
    {
        //memb vars
        public string condition;
        public int temperature;
        public int happinessIndex;
        public string predictedForecast;
        Random random;
        private List<string> weatherConditions = new List<string>() { "It's a scorcher wow such heat", "Sunny and hot", "Exceptionally nice and borderline perfect", "Cloudy but warm", "No rain but pretty chill", "Cold and rainy" };

        //constru
        public Weather(Random randomIn)
        {
            random = randomIn;
            int tempRando = random.Next(0, weatherConditions.Count);
            this.condition = weatherConditions[tempRando];

            //put logic here to set the random range based on the conditions
            switch (tempRando)
            //switch (random)
            {
                case (0):
                    this.temperature = random.Next(98, 106);
                    this.happinessIndex = random.Next(80, 101);
                    break;
                case (1):
                    this.temperature = random.Next(81, 99);
                    this.happinessIndex = random.Next(65, 101);
                    break;
                case (2):
                    this.temperature = random.Next(72, 82);
                    this.happinessIndex = random.Next(50, 101);
                    break;
                case (3):
                    this.temperature = random.Next(63, 73);
                    this.happinessIndex = random.Next(39, 101);
                    break;
                case (4):
                    this.temperature = random.Next(54, 65);
                    this.happinessIndex = random.Next(30, 101);
                    break;
                case (5):
                    this.temperature = random.Next(48, 55);
                    this.happinessIndex = random.Next(20, 101);
                    break;
                default:
                    this.temperature = 68;
                    this.happinessIndex = random.Next(50, 80);
                    break;
            }                       

            try
            {
                this.predictedForecast = weatherConditions[tempRando + 1];
            }            
            catch(ArgumentOutOfRangeException)
            {
                this.predictedForecast = weatherConditions[0];
            }
        }

        //memb meths
        public string WeatherReport()
        {
            return ("Today's weather: " + condition + ", " + (temperature.ToString() + " degrees."));
        }    
        
        public string WeatherPrediction()
        {
            return predictedForecast;
        }
    }
}
