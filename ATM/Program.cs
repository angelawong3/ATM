using System;
using System.Linq;

public class CardHolder
{
    String cardNumber;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public CardHolder(String cardNumber, int pin, String firstName, String lastName, double balance)
    {
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNumber()
    {
        return cardNumber;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNumber(String newCardNumber)
    {
        cardNumber = newCardNumber;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please Choose From One of the Following Options: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");

        }

        void deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit);
            Console.WriteLine("Thank you. Your new balance is : " + currentUser.getBalance());
        }

        void withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much money would you like to withdraw? ");
            double withdrawal = Double.Parse(Console.ReadLine());

            if (currentUser.getBalance() > withdrawal)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you. Your new balance is : " + currentUser.getBalance());
            }

        }

        void balance(CardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("12345678", 1234, "Mary", "Chan", 150.50));
        cardHolders.Add(new CardHolder("22345678", 5678, "Tom", "Lee", 388.88));
        cardHolders.Add(new CardHolder("32345678", 9012, "Betty", "Cheung", 668.68));

        // prompt the user
        Console.WriteLine("Welcome to C# ATM! ");
        Console.WriteLine("Please insert your debit card. ");
        String debitCardNumber = "";
        CardHolder currentUser;

        while (true)
        {
            try
            {
                debitCardNumber = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(x => x.cardNumber == debitCardNumber);
                if (currentUser != null) {
                    break;
                } else {
                    Console.WriteLine("Invalid card. Please try again. ");
                }
            }
            catch
            {
                Console.WriteLine("Invalid card. Please try again. ");
            }
        }

        Console.WriteLine("Please enter you pin: ");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid pin. Please try again. ");
                }
            }
            catch
            {
                Console.WriteLine("Invalid pin. Please try again. ");
            }
        }



    }

}