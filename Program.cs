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
