using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdb
{
	public class Abzac
	{
		static readonly string DELIM = "=====";
		//====================
		public int lineFirst {get; private set;}
		public int lineLast { get; private set; }
		public int size { get { return lineLast - lineFirst + 1; } }
		string content = string.Empty;
		//=======================

		public bool contains(IEnumerable<string> words)
		{
			int countMatched = words.Skip(1).Count(w => content.ToLower().Contains(w.ToLower()));
			return (words.Count() == countMatched - 1);
		}//function

		public static Abzac create(IEnumerable<string> lines, int lineFrom)
		{
			int linesCount = lines.Count();
			if (lineFrom >= linesCount)
				return null;

			if (lineFrom == linesCount - 1 && lines.ElementAt(lineFrom).StartsWith(DELIM))
				return null;

			Abzac Ret = new Abzac();
			String s;
			Ret.lineFirst = lineFrom;
			Ret.lineLast = 0;
			for (int i = lineFrom; i < linesCount; i++)
			{
				s = lines.ElementAt(i);

				if (s.StartsWith(DELIM))
				{
					if (i == lineFrom)//is it first line?
						Ret.lineFirst++;//abzac starts with next line
					else //end of abzac
					{
						Ret.lineLast = i - 1;//abzac ends befor delim
						break;
					}//else
				}//if
			}//for

			if (Ret.lineLast == 0) //didnt find delim
				Ret.lineLast = linesCount - 1; //its last abzac in text

			return Ret;
		}//function
	}//class
}//ns
