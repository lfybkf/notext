using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdb
{
	class Paket
	{
		public static const string wordAny = "*";
		static const IEnumerable<Abzac> empty = new Abzac[0];
		//====================
		string fileName;
		string wordMain;
		DateTime dtIndexed;
		IEnumerable<Abzac> content = new List<Abzac>();


		//================
		public IEnumerable<Abzac> findAll(IList<string> words)
		{
			if (words.Count < 2)
				return empty;

			if (words[0] != wordMain || words[0] != wordAny)
				return empty;

			return content.Where(a => a.contains(words));

		}//function

	}//class
}//ns
