/* 
 * Author: Connor Neil
 * Class name: Order.cs
 * Class  used to represent an order consisting of IOrderItems (Entrees, Sides, Drinks, and/or combos)
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Collection of IOrderItems representing those in the current correct
    /// </summary>
    public class Order: ObservableCollection<IOrderItem>
    {
        /// <summary>
        /// Generator for order number used in conjunction with constructor to increment value
        /// each time a new order is created
        /// </summary>
        private static int nextOrderNumber = 1;

        /// <summary>
        /// Creates a new Order while attaching 
        /// CollectionChangedListener to any changes within the collection
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// Property holding order number
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Backing variable for sales tax rate
        /// </summary>
        private double salesTaxRate = .12;

        /// <summary>
        /// Property holding sales tax rate for the order
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
            }
        }

        /// <summary>
        /// Private backing variable for subtotal of the order before tax
        /// </summary>
        private double subtotal;

        /// <summary>
        /// Property holding subtotal of order prior to tax
        /// </summary>
        public double Subtotal
        {
            get
            {
                subtotal = 0;
                foreach(IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Private backing variable for tax on the order
        /// </summary>
        private double tax;
        /// <summary>
        /// Property holding value of tax as a function of subtotal and sales tax rate
        /// </summary>
        public double Tax
        {
            get
            {
                tax = 0;
                tax = Subtotal * SalesTaxRate;
                return tax;
            }
        }

        /// <summary>
        /// Property holding total cots of order subtotal + tax
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        /// <summary>
        /// Backing variable for calories of the order
        /// </summary>
        private uint calories = 0;

        /// <summary>
        /// Property for total Calories of all items in the order
        /// </summary>
        public uint Calories
        {
            get
            {
                calories = 0;
                foreach (IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        /// <summary>
        /// Listener for whether any properties have changed within the collection
        /// </summary>
        /// <param name="sender">Collection that has changed</param>
        /// <param name="e">Arguments providing info about what has changed in the collection</param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Reset:
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
            }
        }

        /// <summary>
        /// Listener for whether any properties have changed within individual items in the collection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }

        public void ClearOrder()
        {
            foreach (IOrderItem item in this)
            {
                item.PropertyChanged -= CollectionItemChangedListener;
            }
            this.Clear();
        }
    }
}
