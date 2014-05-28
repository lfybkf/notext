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
		public static readonly string fileFake = "FAKE";
		static readonly IEnumerable<Abzac> empty = new Abzac[0];
		static readonly Encoding encoding = Encoding.GetEncoding(1251);
		//====================
		string fileName;
		string wordMain = string.Empty;
		DateTime dtIndexed;
		ICollection<Abzac> content;
		//================
		public int size { get { return content != null ? content.Count() : 0; } }
		//================


		public IEnumerable<Abzac> findAll(IEnumerable<string> words)
		{
			if (words.Count() < 2)
				return empty;

			string wordFirst = words.ElementAt(0);
			//is it for me exactly or for all?
			if (wordMain.StartsWith(wordFirst) == false && wordFirst != wordAny) 
				return empty;

			if (isActual == false)
				load();

			return content.Where(a => a.contains(words));

		}//function

		public bool isActual
		{
			get 
			{
				if (fileName == fileFake)
					return true;

				DateTime dt = File.GetLastAccessTime(fileName);
				return (dt == dtIndexed);
			}
		}//function

		public Paket(string fileName)
		{
			this.fileName = fileName;
			if (fileName == fileFake)
				return;

			this.wordMain = Path.GetFileNameWithoutExtension(fileName).ToLower();
			this.dtIndexed = File.GetLastAccessTime(fileName);
		}//function

		public void load()
		{
			if (fileName == fileFake)
				return;

			string[] lines = File.ReadAllLines(fileName, encoding);
			load(lines);			
		}//function

		public void load(IEnumerable<string> lines)
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
