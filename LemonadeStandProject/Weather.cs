using System;
namespace LemonadeStand
{
	public class Weather
	{
		string condition;
		string predictedForecast;
		int tempature;
		List<string> weatherConditions;

		public Weather()
		{
			weatherConditions = new List<string>
			{
				"sunny",
				"cloudy",
				"rainy",
				"sunny"
			};
			tempature = FindTempature();
			condition = FindCondition();
			predictedForecast = $"It is {condition} and {tempature} degrees today.";
		}

		public string FindCondition()
		{
			Random rnd = new Random();
			int randomNumber;

            randomNumber = rnd.Next(0, 3);

			condition = weatherConditions[randomNumber];

            return condition;
		}
		public int FindTempature()
		{
			Random rand = new Random();
			int randomTemp;

			randomTemp = rand.Next(72,89);
			return randomTemp;
		}

	}
}

