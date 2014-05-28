﻿using System;
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
		//public bool isEmpty { get { return (content == string.Empty); } }
		//=======================

		public bool contains(IEnumerable<string> words)
		{
			IEnumerable<string> wordsToSearch = words.Skip(1); //first word poins to Paket
			Func<string, bool> wordIsHere = (w) => { return content.ToLower().Contains(w.ToLower()); };
			int countMatched = wordsToSearch.Count(w => wordIsHere(w));
			bool isAllWordsHere = (wordsToSearch.Count() == countMatched);
			return isAllWordsHere;
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

			Ret.load(lines);

			return Ret;
		}//function

		private void load(IEnumerable<string> lines)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = lineFirst; i <= lineLast; i++)
			{
				sb.AppendLine(lines.ElementAt(i));
			}
			content = sb.ToString();
		}//function
	}//class
}//ns
