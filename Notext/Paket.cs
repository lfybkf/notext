using System;
using System.IO;
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
		IEnumerable<Abzac> content;

		//================
		public IEnumerable<Abzac> findAll(IEnumerable<string> words)
		{
			if (words.Count() < 2)
				return empty;

			if (words.ElementAt(0) != wordMain || words.ElementAt(0) != wordAny)
				return empty;

			return content.Where(a => a.contains(words));

		}//function

		public void init(string fileName)
		{
			this.fileName = fileName;
			this.dtIndexed = File.GetLastAccessTime(fileName);
			this.wordMain = Path.GetFileNameWithoutExtension(fileName).ToLower();
			string[] lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));
			content = new List<Abzac>();
			
			if (lines.Count() < 1)
				return;

			;
		}//function
	}//class
}//ns
