using System;

using System.Globalization;

namespace ChineseZodiac


{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string appName = "Chinese Zodiac";
                string appVersion = "1.0.0";
                string appAuthor = "Patrick Towey";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
                Console.ResetColor();

                Console.WriteLine("Which year were you born in?");
                string input = Console.ReadLine();

                string yearFormat = "yyyy";
                    DateTime date;
                    if (!DateTime.TryParseExact(input, yearFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                    Console.WriteLine("Invalid format. Year must be yyyy (e.g. 2000).");
                    return;
                    }
                    int yearBorn = date.Year;
                    if (yearBorn < 1960 || yearBorn > 2019)
                    {
                        Console.WriteLine("Year must be between 1960-2019.");
                        return;
                    } 

                int Rat = 1996;
                int Rat1 = 2008;
                int Rat2 = 1984;
                int Rat3 = 1972;
                int Rat4 = 1960;
                int Ox = 2009;
                int Ox1 = 1997;
                int Ox2 = 1985;
                int Ox3 = 1973;
                int Ox4 = 1961;
                int Tiger = 2010;
                int Tiger1 = 1998;
                int Tiger2 = 1986;
                int Tiger3 = 1974;
                int Tiger4 = 1962;
                int Rabbit = 2011;
                int Rabbit1 = 1999;
                int Rabbit2 = 1987;
                int Rabbit3 = 1975;
                int Rabbit4 = 1963;
                int Dragon = 2012;
                int Dragon1 = 2000;
                int Dragon2 = 1988;
                int Dragon3 = 1976;
                int Dragon4 = 1964;
                int Snake = 2013;
                int Snake1 = 2001;
                int Snake2 = 1989;
                int Snake3 = 1977;
                int Snake4 = 1965;
                int Horse = 2014;
                int Horse1 = 2002;
                int Horse2 = 1990;
                int Horse3 = 1978;
                int Horse4 = 1966;
                int Goat = 2015;
                int Goat1 = 2003;
                int Goat2 = 1991;
                int Goat3 = 1979;
                int Goat4 = 1967;
                int Monkey = 2016;
                int Monkey1 = 2004;
                int Monkey2 = 1992;
                int Monkey3 = 1980;
                int Monkey4 = 1968;
                int Rooster = 2017;
                int Rooster1 = 2005;
                int Rooster2 = 1993;
                int Rooster3 = 1981;
                int Rooster4 = 1969;
                int Dog = 2018;
                int Dog1 = 2006;
                int Dog2 = 1994;
                int Dog3 = 1982;
                int Dog4 = 1970;
                int Pig = 2019;
                int Pig1 = 2007;
                int Pig2 = 1995;
                int Pig3 = 1983;
                int Pig4 = 1971;
                yearBorn = Int32.Parse(input);

                if (yearBorn == Rat)
                {
                    Console.WriteLine("You are a rat!");
                }
                if (yearBorn == Rat1)
                {
                    Console.WriteLine("You are a rat!");
                }
                if (yearBorn == Rat2)
                {
                    Console.WriteLine("You are a rat!");
                }
                if (yearBorn == Rat3)
                {
                    Console.WriteLine("You are a rat!");
                }
                if (yearBorn == Rat4)
                {
                    Console.WriteLine("You are a rat!");
                }
                if (yearBorn == Ox)
                {
                    Console.WriteLine("You are an Ox!");
                }
                if (yearBorn == Ox1)
                {
                    Console.WriteLine("You are an Ox!");
                }
                if (yearBorn == Ox2)
                {
                    Console.WriteLine("You are an Ox!");
                }
                if (yearBorn == Ox3)
                {
                    Console.WriteLine("You are an Ox!");
                }
                if (yearBorn == Ox4)
                {
                    Console.WriteLine("You are an Ox!");
                }
                if (yearBorn == Tiger)
                {
                    Console.WriteLine("You are a Tiger!");
                }
                if (yearBorn == Tiger1)
                {
                    Console.WriteLine("You are a Tiger!");
                }
                if (yearBorn == Tiger2)
                {
                    Console.WriteLine("You are a Tiger!");
                }
                if (yearBorn == Tiger3)
                {
                    Console.WriteLine("You are a Tiger!");
                }
                if (yearBorn == Tiger4)
                {
                    Console.WriteLine("You are a Tiger!");
                }
                if (yearBorn == Rabbit)
                {
                    Console.WriteLine("You are a Rabbit!");
                }
                if (yearBorn == Rabbit1)
                {
                    Console.WriteLine("You are a Rabbit!");
                }
                if (yearBorn == Rabbit2)
                {
                    Console.WriteLine("You are a Rabbit!");
                }
                if (yearBorn == Rabbit3)
                {
                    Console.WriteLine("You are a Rabbit!");
                }
                if (yearBorn == Rabbit4)
                {
                    Console.WriteLine("You are a Rabbit!");
                }
                if (yearBorn == Dragon)
                {
                    Console.WriteLine("You are a Dragon!");
                }
                if (yearBorn == Dragon1)
                {
                    Console.WriteLine("You are a Dragon!");
                }
                if (yearBorn == Dragon2)
                {
                    Console.WriteLine("You are a Dragon!");
                }
                if (yearBorn == Dragon3)
                {
                    Console.WriteLine("You are a Dragon!");
                }
                if (yearBorn == Dragon4)
                {
                    Console.WriteLine("You are a Dragon!");
                }
                if (yearBorn == Snake)
                {
                    Console.WriteLine("You are a Snake!");
                }
                if (yearBorn == Snake1)
                {
                    Console.WriteLine("You are a Snake!");
                }
                if (yearBorn == Snake2)
                {
                    Console.WriteLine("You are a Snake!");
                }
                if (yearBorn == Snake3)
                {
                    Console.WriteLine("You are a Snake!");
                }
                if (yearBorn == Snake4)
                {
                    Console.WriteLine("You are a Snake!");
                }
                if (yearBorn == Horse)
                {
                    Console.WriteLine("You are a Horse!");
                }
                if (yearBorn == Horse1)
                {
                    Console.WriteLine("You are a Horse!");
                }
                if (yearBorn == Horse2)
                {
                    Console.WriteLine("You are a Horse!");
                }
                if (yearBorn == Horse3)
                {
                    Console.WriteLine("You are a Horse!");
                }
                if (yearBorn == Horse4)
                {
                    Console.WriteLine("You are a Horse!");
                }
                if (yearBorn == Goat)
                {
                    Console.WriteLine("You are a Goat!");
                }
                if (yearBorn == Goat1)
                {
                    Console.WriteLine("You are a Goat!");
                }
                if (yearBorn == Goat2)
                {
                    Console.WriteLine("You are a Goat!");
                }
                if (yearBorn == Goat3)
                {
                    Console.WriteLine("You are a Goat!");
                }
                if (yearBorn == Goat4)
                {
                    Console.WriteLine("You are a Goat!");
                }
                if (yearBorn == Monkey)
                {
                    Console.WriteLine("You are a Monkey!");
                }
                if (yearBorn == Monkey1)
                {
                    Console.WriteLine("You are a Monkey!");
                }
                if (yearBorn == Monkey2)
                {
                    Console.WriteLine("You are a Monkey!");
                }
                if (yearBorn == Monkey3)
                {
                    Console.WriteLine("You are a Monkey!");
                }
                if (yearBorn == Monkey4)
                {
                    Console.WriteLine("You are a Monkey!");
                }
                if (yearBorn == Rooster)
                {
                    Console.WriteLine("You are a Rooster!");
                }
                if (yearBorn == Rooster1)
                {
                    Console.WriteLine("You are a Rooster!");
                }
                if (yearBorn == Rooster2)
                {
                    Console.WriteLine("You are a Rooster!");
                }
                if (yearBorn == Rooster3)
                {
                    Console.WriteLine("You are a Rooster!");
                }
                if (yearBorn == Rooster4)
                {
                    Console.WriteLine("You are a Rooster!");
                }
                if (yearBorn == Dog)
                {
                    Console.WriteLine("You are a Dog!");
                }
                if (yearBorn == Dog1)
                {
                    Console.WriteLine("You are a Dog!");
                }
                if (yearBorn == Dog2)
                {
                    Console.WriteLine("You are a Dog!");
                }
                if (yearBorn == Dog3)
                {
                    Console.WriteLine("You are a Dog!");
                }
                if (yearBorn == Dog4)
                {
                    Console.WriteLine("You are a Dog!");
                }
                if (yearBorn == Pig)
                {
                    Console.WriteLine("You are a Pig!");
                }
                if (yearBorn == Pig1)
                {
                    Console.WriteLine("You are a Pig!");
                }
                if (yearBorn == Pig2)
                {
                    Console.WriteLine("You are a Pig!");
                }
                if (yearBorn == Pig3)
                {
                    Console.WriteLine("You are a Pig!");
                }
                if (yearBorn == Pig4)
                {
                    Console.WriteLine("You are a Pig!");
                }

                Console.WriteLine("Find another year? Yes | No");
            } while (Console.ReadLine() != "No");
            Console.WriteLine("Thank you for taking the time to learn your Chinese Zodiac Animal");
            Environment.Exit(0);
        } 
    } 
}
