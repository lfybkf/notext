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
		public static readonly string mask = "*.txt";
		static readonly IEnumerable<Abzac> empty = new Abzac[0];
		static readonly Encoding encoding = Encoding.GetEncoding(1251);
		static readonly string BasePath = Environment.CurrentDirectory;
		static readonly string cmdEdit = ".edit";
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

			#region cmd
			if (wordFirst != wordAny) //cmd only for one - me
			{ 
				if (words.ElementAt(1) == cmdEdit)
				{
					System.Diagnostics.Process.Start(fileName);
					return empty;
				}//if
			}//if
			#endregion

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
				DateTime dt = File.GetLastWriteTime(fileName);
				return (dt == dtIndexed && content != null);
			}
		}//function

		public Paket(string fileName)
		{
			this.fileName = fileName;
			this.name = Path.GetFileNameWithoutExtension(fileName).ToLower();
			this.dtIndexed = File.GetLastWriteTime(fileName);
		}//function

		public void load()
		{
			string[] lines = File.ReadAllLines(fileName, encoding);
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
