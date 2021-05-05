using System;
using System.Collections.Generic;
using System.Text;

namespace Measurement_Convertor_APP
{
    class Convertor
        {
        public static double MetersToFeet(double meters)
        {
            return meters * 3.281;
        }
        public static double KilometersToMiles(double km)
        {
            return km / 1.609;
        }
        public static double CentimetersToInches(double cm)
        {
            return cm / 2.54;
        }
        public static double FeetToMeters(double feet)
        {
            return feet / 3.281;
        }
        public static double MilesToKilometers(double miles)
        {
            return miles * 1.609;
        }
        public static double InchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }
    }
}
