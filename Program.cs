/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: October 30, 2022
* Assignment CIS214 Performance Assessment - Account Balance Calculations
*
* Main application (program) class.
* Print a line that states "Your Name - Week 4 PA Account Balance Calculations"
* Ask the user to enter the starting balance
* Ask the user to enter a credit or a debit for the account
* Continue asking the user to enter credits or debits until the user enters a 0
* (zero) to quit
* If the debit would cause the account balance to be negative
*   do not deduct the value from the account
*   throw a user-defined exception stating the value would cause the account to
*   go negative
*   print the exception information
* If the value is not a number
*   handle the FormatException
*   print the exception information
*   print an error message
* If the credit or debit is valid, update the account balance and print the
* updated balance value
\******************************************************************************/
public class Program
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "\nJason D'Oyley - Week 4 PA Account Balance Calculations\n"
        );

        // Ask the user to enter the starting balance
        Console.Write("Please enter the starting balance: ");
        string? val = Console.ReadLine();
        double startBalance = Convert.ToDouble(val);
        double bal = startBalance;

        // Continue asking the user to enter credits or debits until the user
        // enters a 0 (zero) to quit
        while (true)
        {
            try
            {
                // Ask the user to enter a credit or a debit for the account
                Console.Write(
                "Please enter a credit or debit amount (0 to quit): "
            );
                val = Console.ReadLine();
                double userVal = Convert.ToDouble(val);

                // Quit the program if the user enter 0
                if (userVal == 0)
                {
                    Console.WriteLine($"The updated balance is: {bal:F2}");
                    break;
                }

                // Hold the temp value
                double temp = bal + userVal;

                // If the credit or debit is valid, update the account balance
                if (temp < 0)
                {
                    throw new Exception("Amount entered will cause account to be negative");
                }
                else
                {
                    bal = temp;
                }

                Console.WriteLine($"The updated balance is: {bal:F2}\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e}\nPlease enter a numeric value.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e}\n");
            }
        }
    }
}