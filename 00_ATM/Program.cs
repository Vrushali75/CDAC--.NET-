using System;


namespace _00_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int main_bal = 1000000;
            int pin = 9632;
            int[] arr =new int[3];//arr[3]
            Console.WriteLine("Enter your pin: ");
            int pin1 = Convert.ToInt32(Console.ReadLine());
            if(pin==pin1)
            {
               do
               {
                    Console.WriteLine("1)Credit Amount\n2)Withdraw Amount\n3)Check Balance\n");
                
                    int ch = Convert.ToInt32(Console.ReadLine());
                
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("----------Credit Amount----------");
                            Console.WriteLine("Enter amount to be credited: ");
                            int cred_amt = Convert.ToInt32(Console.ReadLine());
                            main_bal = main_bal + cred_amt;
                            Console.WriteLine("Total balance after credited amount is: " + main_bal);
                            break;

                        case 2:
                            Console.WriteLine("-----------Withdraw Amount----------");
                            Console.WriteLine("Enter the withdrawl amount: ");
                            int withdraw_amt = Convert.ToInt32(Console.ReadLine());
                            main_bal = main_bal - withdraw_amt;
                            Console.WriteLine("Total Balance after withdrwal amount is: " + main_bal);
                            break;

                        case 3:
                            Console.WriteLine("----------Remaining Balance----------");
                            Console.WriteLine("Remaining Balance is :" + main_bal);
                            break;

                        default:
                            Console.WriteLine("Enter valid choice !");
                            break;

                    }
                    Console.WriteLine("If you want to continue, press Y");
                    char ch1 = Convert.ToChar(Console.ReadLine());
                    if (ch1 == 'Y' || ch1=='y') 
                        continue;
                    else
                    {
                        Console.WriteLine("Thank You, Visit again !");
                        break;
                    }
                        
                } while (true);



            }
            else
            {
                Console.WriteLine("Please enter valid pin!");
            }
            Console.ReadLine();
        }
    }
}
