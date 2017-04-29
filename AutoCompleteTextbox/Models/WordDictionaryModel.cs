using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteTextbox.Models
{
    public class WordDictionaryModel
    {
        private Dictionary<string, List<string>> wordDictionary;

        private readonly int wordSuggestionCount;
        private const int DEFAULT_SUGGESTIONCOUNT = 10;

        public WordDictionaryModel()
        {
            wordDictionary = (Dictionary<string, List<string>>)HttpContext.Current.Application["WordDictionary"];
            string str = System.Configuration.ConfigurationManager.AppSettings["wordSuggestionCount"];
            int number;
            if (int.TryParse(str, out number))
            {
                wordSuggestionCount = number;
            }
            else
            {
                wordSuggestionCount = DEFAULT_SUGGESTIONCOUNT;
            }
        }

        public List<string> GetTopSuggestionWords(string searchWord)
        {
            List<string> result = new List<string>();

            string firstChar = searchWord.Substring(0, 1);
            List<string> strs;
            if (wordDictionary.ContainsKey(firstChar))
            {
                strs = (List<string>)wordDictionary[firstChar];
            }
            else
            {
                strs = (List<string>)wordDictionary["Other"];
            }
            

            int index = 0;
            foreach (string w in strs)
            {
                if (w.StartsWith(searchWord))
                {
                    index++;
                    result.Add(w);
                    Console.WriteLine(w);
                    if (index == wordSuggestionCount) { break; }
                }
            }

            return result;

        }

    }
}