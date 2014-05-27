using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdb
{
	public class Paket
	{
		public static readonly string wordAny = "*";
		static readonly IEnumerable<Abzac> empty = new Abzac[0];
		//====================
		string fileName;
		string wordMain;
		DateTime dtIndexed;
		ICollection<Abzac> content;

		public int size { get { return content != null ? content.Count() : 0; } }
		//================
		public IEnumerable<Abzac> findAll(IEnumerable<string> words)
		{
			if (words.Count() < 2)
				return empty;

			string wordFirst = words.ElementAt(0);
			if (wordMain.StartsWith(wordFirst) == false)
				return empty;

			if ( wordFirst != wordAny)
				return empty;

			return content.Where(a => a.contains(words));

		}//function

		public void init(string fileName)
		{
			this.fileName = fileName;
			this.dtIndexed = File.GetLastAccessTime(fileName);
			this.wordMain = Path.GetFileNameWithoutExtension(fileName).ToLower();
			string[] lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));
			init(lines);			
		}//function

		public void init(IEnumerable<string> lines)
		{
			if (lines.Count() < 1)
				return;

			content = new List<Abzac>();
			Abzac a = null;
			int lineFrom = 0;
			do
			{
				a = Abzac.create(lines, lineFrom);
				if (a != null)
				{
					lineFrom = a.lineLast + 1;
					content.Add(a);
				}//if
				
			} while (a != null);
		}//function
	}//class
}//ns
