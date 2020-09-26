using System;

namespace AbstartFactory
{
    public class MasalaCooker
    {
        private ICooker cooker;

        public MasalaCooker(ICooker cooker)
        {
            this.cooker = cooker;
        }

        public void CookMasala(DateTime currentDate, Country country)
        {
            if (IsSummerDate(currentDate))
            {
                if (country == Country.India)
                {
                    cooker.FryRice(100, Level.Low);
                    cooker.FryChicken(100, Level.Low);
                    cooker.PepperRice(Level.Medium);
                    cooker.PepperChicken(Level.Medium);
                }

                if (country == Country.Ukraine)
                {
                    cooker.FryRice(150, Level.Medium);
                    cooker.FryChicken(200, Level.Medium);
                    cooker.SaltRice(Level.Low);
                    cooker.SaltChicken(Level.Low);
                }

                if (country == Country.England)
                {
                    cooker.FryRice(50, Level.Low);
                    cooker.FryChicken(50, Level.Low);
                }

                return;
            }

            if (country == Country.India)
            {
                cooker.FryRice(200, Level.Strong);
                cooker.FryChicken(100, Level.Strong);
                cooker.SaltRice(Level.Strong);
                cooker.PepperRice(Level.Strong);
                cooker.SaltChicken(Level.Strong);
                cooker.PepperChicken(Level.Strong);
            }

            if (country == Country.Ukraine)
            {
                cooker.FryRice(500, Level.Strong);
                cooker.FryChicken(300, Level.Medium);
                cooker.SaltRice(Level.Strong);
                cooker.PepperRice(Level.Low);
                cooker.SaltChicken(Level.Medium);
                cooker.PepperChicken(Level.Low);
            }

            if (country == Country.England)
            {
                cooker.FryRice(100, Level.Low);
                cooker.FryChicken(100, Level.Low);
            }
        }

        private bool IsSummerDate(DateTime currentDate)
        {
            return currentDate.Month >= 6 && currentDate.Month <= 8;
        }
    }
}
