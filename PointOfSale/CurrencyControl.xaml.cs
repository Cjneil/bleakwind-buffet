
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        
        /// <summary>
        /// Dependency Property for Currency
        /// </summary>
        public static DependencyProperty CurrencyProperty = DependencyProperty.Register("Type", typeof(string), typeof(CurrencyControl), new FrameworkPropertyMetadata(" ",
            FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// Dependency Property for Step
        /// </summary>
        public static DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(int), typeof(CurrencyControl), new PropertyMetadata(1));

        /// <summary>
        /// Dependency Propertry for Count
        /// </summary>
        public static DependencyProperty CustomerAmountProperty = DependencyProperty.Register("CustomerAmount", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, 
            FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Dependency Propertry for Count
        /// </summary>
        public static DependencyProperty ChangeAmountProperty = DependencyProperty.Register("ChangeAmount", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0,
            FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        

        /// <summary>
        /// Creates a currency control
        /// </summary>
        public CurrencyControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// How much buttons will increment Count by
        /// </summary>
        public int Step
        {
            get { return (int)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        /// <summary>
        /// Count of the middle textbox
        /// </summary>
        public int CustomerAmount
        {
            get { return (int)GetValue(CustomerAmountProperty); }
            set { SetValue(CustomerAmountProperty, value); }
        }

        /// <summary>
        /// Count of the middle textbox
        /// </summary>
        public int ChangeAmount
        {
            get { return (int)GetValue(ChangeAmountProperty); }
            set { SetValue(ChangeAmountProperty, value); }
        }

        /// <summary>
        /// type of money that this control references
        /// </summary>
        public string Currency
        {
            get { return (string)GetValue(CurrencyProperty); }
            set { SetValue(CurrencyProperty, value); }
        }

        /// <summary>
        /// Handles the increment or decrement buttons being clicked
        /// </summary>
        /// <param name="sender">The button clicked by the user</param>
        /// <param name="e">The event arguments</param>
        void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        CustomerAmount += Step;
                        break;
                    case "Decrement":
                        CustomerAmount -= Step;
                        break;
                }
            }
            e.Handled = true;
        }       
    }
}
