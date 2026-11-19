using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnect
{
    internal class HobbyValidation
    {
        public static bool ValidateHobbyInput(
           string rawDescription,
           string rawPlayerNum,
           string rawPrice,
           out string errorMessage,
           out int parsedPlayerNum,
           out decimal parsedPrice)
        {
            // Set default values for out parameters
            errorMessage = string.Empty;
            parsedPlayerNum = 0;
            parsedPrice = 0;

            // Validate Description
            string description = rawDescription?.Trim();

            return // 1. Validate Description is not empty
                Validate(
                    !string.IsNullOrEmpty(description),
                    "Description must be entered.",
                    out errorMessage
                )
                && // 2. Validate Description
                Validate(
                    !description.All(char.IsDigit),
                    "Description must not be completely numeric.",
                    out errorMessage
                )
                &&      //3. Validate Number of Players
                Validate(
                    int.TryParse(rawPlayerNum, out parsedPlayerNum) &&
                    parsedPlayerNum > 0,
                    "Number of players must be a valid whole number greater than zero.",
                    out errorMessage
                )
                &&      //4. Validate Price
                Validate(
                    decimal.TryParse(rawPrice, out parsedPrice) &&
                    parsedPrice > 0,
                    "Price must be a numeric value greater than zero.",
                    out errorMessage
                );
        }
        //Error message Formulation
        private static bool Validate(
            bool condition,
            string message,
            out string errorMessage)
        {
            errorMessage = condition ? string.Empty : message;
            return condition;
        }
    }
}
