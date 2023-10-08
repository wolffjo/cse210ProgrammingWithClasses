public class PromptGenerator
{
    Random rnd = new Random();
    public List<string> _PromptList = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    //public string _Prompt;

    public string GetPrompt()
    {
        int num = rnd.Next(0, 5);
        string prompt = _PromptList[num];
        //_Prompt = prompt;

        return prompt;
    }
}