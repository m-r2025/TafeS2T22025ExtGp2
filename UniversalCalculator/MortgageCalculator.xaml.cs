using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

        }

		private void btn_morExit_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainMenu));
		}

		private void btn_morCalculate_Click(object sender, RoutedEventArgs e)
		{			
			try
			{
				double p = double.Parse(txtbox_morPrincipal.Text);
				double AIR = double.Parse(txtbox_morAIR.Text);
				double MIR = AIR/100/12;
				double n = int.Parse(txtbox_morMonths.Text) + int.Parse(txtbox_morYears.Text) * 12 ;
				double monthlyPayment = (p * (MIR * Math.Pow((1 + MIR), n))) / (Math.Pow((1 + MIR), (n-1)));				
				txtbox_morMIR.Text=MIR.ToString();
				txtbox_morMP.Text= monthlyPayment.ToString();
			}
			catch (FormatException ex)
			{
				
			}
		}
	}
}
