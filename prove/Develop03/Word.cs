class Word
{
    private string _word;
    private bool _isHidden;

    Random random = new Random();

    //"And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Display()
    {
        // If it is false, display the word
        // if it is true, display the lines (____)
        if(_isHidden == true)
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write($"{_word} ");
        }

        

        // Strings are iterable. Meaning, i can loop through them.
        // For example: 
        /*
        string name = "Joseph";
        char letter = name[0]
        
        Since I can access by index, I can loop through each letter to get the length
        and print a _ for every letter

        
        
        */
    }
}