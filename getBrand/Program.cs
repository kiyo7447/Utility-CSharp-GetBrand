using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace getBrand
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetCreditCardType(args[0]));
		}


		public static string GetCreditCardType(string CreditCardNumber)
		{
			//American Express
			//34～、37～	15桁
			Regex regExpress = new Regex("^3[47][0-9]{13}$");

			//Diner Club
			//300～305、36、38で始まる14桁の数字
			Regex regDiners = new Regex("^3(?:0[0-5]|[68][0-9])[0-9]{11}$");
	
			//Discover Card
			//6011、65で始まる16桁の数字
			Regex regDiscover = new Regex("^6(?:011|5[0-9]{2})[0-9]{12}$");

			//JCB
			//2131、1800で始まる15桁
			//35から始まる16桁の数字
			Regex regJSB = new Regex("^(?:2131|1800|35\\d{3})\\d{11}$");

			//Master Card
			//51～55で始まる16桁の数字
			Regex regVisa = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");
			
			//VISA
			//4で始まる16桁または13桁の数字
			Regex regMaster = new Regex("^5[1-5][0-9]{14}$");
			


			if (regVisa.IsMatch(CreditCardNumber))
				return "VISA";
			if (regMaster.IsMatch(CreditCardNumber))
				return "MASTER";
			if (regExpress.IsMatch(CreditCardNumber))
				return "AEXPRESS";
			if (regDiners.IsMatch(CreditCardNumber))
				return "DINERS";
			if (regDiscover.IsMatch(CreditCardNumber))
				return "DISCOVERS";
			if (regJSB.IsMatch(CreditCardNumber))
				return "JSB";
			return "invalid";
		}

	}
}
