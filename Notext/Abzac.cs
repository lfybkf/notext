using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bdb
{
	class Abzac
	{
		static const string BEGIN = "=======";
		//====================
		int firstLine;
		string content;
		//=======================

		public bool contains(IEnumerable<string> words)
		{
			int countMatched = words.Skip(1).Count(w => content.ToLower().Contains(w.ToLower()));
			return (words.Count() == countMatched - 1);
		}//function

		public static Abzac create(IEnumerable<string> lines, int fromLine)
		{
			Abzac Ret = null;
			return Ret;
		}//function
	}//class
}//ns
