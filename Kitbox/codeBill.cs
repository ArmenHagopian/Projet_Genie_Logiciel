using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kitbox
{
    public class codeBill
    {
		public string GetBill()
		{
			//reference et code pour la liste des composants
			// faire la somme des articles identiques

            Dictionary<string, object> bill = new Dictionary<string, object>();
			Dictionary<string, object> boxes = new Dictionary<string, object>();
			List<Box> Boxes = new List<Box>();

            string header = "Kitbox Fabric" + "\n" + "Avenue du Chocolat 50" + "\n" + "1400 Nivelles" + "\n" + "Tél: 02 99 99 99 99" + "  " + "TVA: BE08XXXXXXXX" + "\n" + "www.kitboxfabric.com";
            string footer = "Merci à bientôt - Dank u tot ziens" + "\n" + "    Ouvert de 10 à 20h" + "\n" + "   Open van 10u tot 20u";
			string components = Components();


            bill.Add("header", header);
            bill.Add("components", components);
            bill.Add("footer", footer); // Add Total

			/*  Code permettant d'afficher le contenu du Bill
             
     
            Console.WriteLine(bill["header"]);

            / Console.WriteLine(bill["components"]);   Add Number - Description - Price of components

            Console.WriteLine("\n" + bill["footer"]);
            Console.ReadLine();

            */
		}

		private string Components()
		{

			string str = "";	
			Boxes = Wardrobe.Boxes;

			foreach( KeyValuePair<string, string> kvp1 in dictionnaire_wardrobe )
	        {
				foreach (KeyValuePair<string, string> kvp2 in kvp1.Value)
				{
					if (typeof(Box).isinstanceoftype(kvp2.Value))
					{
						foreach (KeyValuePair<string, string> kvp3 in kvp2.Value.pieces)
						{
							str += kvp3.Value + "\t";//Add the reference of the Part
							foreach (KeyValuePair<string, string> kvp4 in kvp3.Value)
							{
								foreach (Part part in kvp3.Value)
								{
									str += part.Code + "\t";//Add the price of the Part
									str += Convert.ToString(part.Dimensions.X) + "(largeur)x" + "\t";//width
									str += Convert.ToString(part.Dimensions.Z) + "(profondeur)x" + "\t";//depth
									str += Convert.ToString(part.Dimensions.Y) + "(hauteur)" + "\t";//height
									str += Convert.ToString(part.Color);
									str += Convert.ToString(part.Selling_price) + "€" + "\n";//Add the price of the Part
								}
							}
						}
					}
					else if (typeof(Part).isinstanceoftype(kvp1.Value))
					{
						str += kvp1.Value.reference + kvp1.Value.selling_price;
						str += part.Code + "\t";//Add the price of the Part
						str += Convert.ToString(part.Dimensions.X) + "(largeur)x" + "\t";//width
						str += Convert.ToString(part.Dimensions.Z) + "(profondeur)x" + "\t";//depth
						str += Convert.ToString(part.Dimensions.Y) + "(hauteur)" + "\t";//height
						str += Convert.ToString(part.Color);
						str += Convert.ToString(part.Selling_price) + "€" + "\n";//Add the price of the Part
					}
				}
	        }

			//foreach (object item in dictionnaire_wardrobe)
			//{
			//	if (typeof(Box).isinstanceoftype(selection))
			//	{
			//		foreach (Part part in box)
			//		{
						
			//		}

			//	}
			//	else if (typeof(Part).isinstanceoftype())
			//	{
			//		str += .reference + .selling_price;
			//	}
			//}

		 }
     }
}

