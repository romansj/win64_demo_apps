using System;

namespace ClassLibraryNETSt{
    public class RandomGenerator{
        private string allowedChars;
        
        public RandomGenerator(string allowedChars) {
            this.allowedChars = allowedChars;
        }

        public string getRandomString(int min, int max) {
            var random = new Random();
            int randomLength = random.Next(min, max);
            
            var stringChars = new char[randomLength];

            for (int i = 0; i < stringChars.Length; i++) {
                stringChars[i] = allowedChars[random.Next(allowedChars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
    }
}