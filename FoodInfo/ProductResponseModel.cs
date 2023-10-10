using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodInfo
{
    internal class ProductResponseModel
    {
		private int barcode;

		public int Barcode
		{
			get { return barcode; }
			set { barcode = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string imageUrl;

		public string ImageUrl
		{
			get { return imageUrl; }
			set { imageUrl = value; }
		}

	}
}
