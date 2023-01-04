using System;

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

}