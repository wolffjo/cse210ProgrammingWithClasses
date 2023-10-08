using System.Runtime.CompilerServices;
using System.IO;

public class EntryXXX
{   
    // Suggestion.
    /*
        public string _user;
        public string _prompt;
        public string _date;
    */
    int count = 0;
    bool i = false;
    int indexSize = 0;
    int index = 0;
    PromptGenerator generator = new PromptGenerator();
    public string _file;
    public List<string> _response = new List<string>(); 
    public List<string> _date = new List<string>();
    public List<string> _prompt = new List<string>();


    public void SaveAsEntry(string date, string prompt, string response)
    {
        _date.Add(date);
        _prompt.Add(prompt);
        _response.Add(response);
        
    }
    public void SaveEntries(string fileName)
    {
        
        {
            foreach(string item in _date)
            {
                indexSize += 1;
            }
            while(i != true)
            {
                if(count != indexSize)
                {
                    using (StreamWriter outputFile = new StreamWriter(fileName, append:true))
                    {
                        outputFile.WriteLine($"{_date[index]} ~|~ {_prompt[index]} ~|~ {_response[index]}");
                    }
                    count += 1;
                    index += 1;
                }
                else
                {
                    i = true;
                }
            }            
        }
    }

    public void LoadEntries()
    {
        
    }
}