# AutoCompleteTextbox
This projects contain implementation of AutoComplete textbox in ASP.NET MVC


Configurations:
To correctly load the dictionary word file in the memory please configure the Web.Config section:
 
Configure filepath value to where you have put the word dictionary file. (it is assumed that delimiter in the file between words is ‘\n’) 
User can also configure how many suggestion words should be shown to the user by configuring ‘wordSuggestionCount’ value. Default is set to 10.

Solution details:
Solution is prepared with VisualStudio2013 and on ASP.NET MVC type project.  Framework 4.5 of .net is used. 

Dictionary will be loaded from text file into the memory at Application_Start event.  This is global event and will trigger once when application starts on receiving the first request.  Later requests will not have delay due to loading of dictionary. (See Global.asax.cs)

Dictionary is stored as a global Application level variable that is shared by all the users. All users will use same dictionary object in the memory. Users are only reading from the dictionary and no writing is involved, so there is no need for synchronization. (See Global.asax.cs)

DataStructure used to store word dictionary is C# Dictionary<key,value>. Here key is a string containing a English alphabet letter and value is C# List<string> containing the words that starts with that key letter. We are storing 27 key value pair in the Dictionary. For example first key is ‘a’ and value is the List of all the words starting with ‘a’. This structure drastically reduces the search/filtering time. Instead of searching a word in few thousands of words containing in the word file, search will happen in few hundred of words.  (See Global.asax.cs and WordDictionaryModel.cs)

Files included or modified:  
AutoCompleteTextbox.js
HomeController.cs
WordDictionaryModel.cs
Global.asax.cs
_AutoCompleteTextBox.cshtml
Index.cshtml


