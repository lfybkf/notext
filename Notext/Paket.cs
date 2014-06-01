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
		public static readonly string delimS = " ";
		public static readonly char[] delim = delimS.ToArray();
		public static readonly string wordAny = "*";
		public static readonly string fileFake = "FAKE";
		public static readonly string mask = "*.txt";
		static readonly IEnumerable<Abzac> empty = new Abzac[0];
		static readonly Encoding encoding = Encoding.GetEncoding(1251);
		static readonly string BasePath = Environment.CurrentDirectory;
		//====================
		string fileName;
		public string name {get; private set;}
		DateTime dtIndexed;
		ICollection<Abzac> content;
		//================
		public int size { get { return content != null ? content.Count() : 0; } }
		//================

		public bool isWordMine(string word)
		{
			return name.StartsWith(word) || word == wordAny;
		}//function

		public static IEnumerable<Paket> createItems()
		{
			return Directory.EnumerateFiles(BasePath, mask)
				.Select(s => new Paket(s));
		}//function

		public IEnumerable<Abzac> findAll(IEnumerable<string> words)
		{
			if (words.Count() < 2)
				return empty;

			string wordFirst = words.ElementAt(0);
			//is it for me exactly or for all?
			if (isWordMine(wordFirst) == false) 
				return empty;

			if (isActual == false)
				load();

			return content.Where(a => a.contains(words));

		}//function

		public override string ToString()
		{
			return name;
		}//function

		public bool isActual
		{
			get 
			{
				if (fileName == fileFake)
					return true;

				DateTime dt = File.GetLastAccessTime(fileName);
				return (dt == dtIndexed && content != null);
			}
		}//function

		public Paket(string fileName)
		{
			this.fileName = fileName;
			if (fileName == fileFake)
				return;

			this.name = Path.GetFileNameWithoutExtension(fileName).ToLower();
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
