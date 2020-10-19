using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    public class CashRegister
    {
        public CashRegister(Order order)
        {
            OrderTotal = order.Total;
        }

        public double OrderTotal { get; set; } 

        /*Beginning of properties for currency stored in drawer */
        public int Pennies => CashDrawer.Pennies;

        public int Nickels => CashDrawer.Nickels;

        public int Dimes => CashDrawer.Dimes;

        public int Quarters => CashDrawer.Quarters;

        public int HalfDollars => CashDrawer.HalfDollars;

        public int Dollars => CashDrawer.Dollars;

        public int Ones => CashDrawer.Ones;

        public int Twos => CashDrawer.Twos;

        public int Fives => CashDrawer.Fives;

        public int Tens => CashDrawer.Tens;

        public int Twenties => CashDrawer.Twenties;

        public int Fifties => CashDrawer.Fifties;

        public int Hundreds => CashDrawer.Hundreds;

        public double Total => CashDrawer.Total;
         /* Beginning of amounts of currency provided by customer*/
        public int CustomerPennies { get; set; } = 0;

        public int CustomerNickels { get; set; } = 0;

        public int CustomerDimes { get; set; } = 0;

        public int CustomerQuarters { get; set; } = 0;

        public int CustomerHalfDollars { get; set; } = 0;

        public int CustomerDollars { get; set; } = 0;

        public int CustomerOnes { get; set; } = 0;

        public int CustomerTwos { get; set; } = 0;

        public int CustomerFives{ get; set; } = 0;

        public int CustomerTens { get; set; } = 0;

        public int CustomerTwenties { get; set; } = 0;

        public int CustomerFifties { get; set; } = 0;

        public int CustomerHundreds { get; set; } = 0;

        /* Beginning of properties for amounts of change to provide */
        public int ChangePennies { get; set; } = 0;

        public int ChangeNickels { get; set; } = 0;

        public int ChangeDimes { get; set; } = 0;

        public int ChangeQuarters { get; set; } = 0;

        public int ChangeHalfDollars { get; set; } = 0;

        public int ChangeDollars { get; set; } = 0;

        public int ChangeOnes { get; set; } = 0;

        public int ChangeTwos { get; set; } = 0;

        public int ChangeFives { get; set; } = 0;

        public int ChangeTens { get; set; } = 0;

        public int ChangeTwenties { get; set; } = 0;

        public int ChangeFifties { get; set; } = 0;

        public int ChangeHundreds { get; set; } = 0;
    }
}
