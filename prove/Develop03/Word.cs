using System;

class Word
{

    //Attributes
    private string _word;
    private List<string> _items;

    //Constructors
    public Word(List<string> wordList)
    {
        SetWordList(wordList);

        //Display the Starting product
        Display();
    }

    //Methods
    private void SetWordList(List<string> wordList)
    {
        _items = wordList;
    }

    public void ReplaceWord()
    {
        //Create a new random variable
        Random numGen = new Random();
        
        //Create a variable to hold the list length
        int listLength = _items.Count();

        //Create a random number between
        // 1 and the listLength, while in a while loop

        int doIt = 0;
        while (doIt != 3)
        {
            //Make a little section the tests to see if that
            // word has already been underlined out

            bool exacute = false;
            int removeWord = 0;

            while (exacute != true)
            {
                //Get the index of what will be replaced
                removeWord = numGen.Next(0, listLength);

                string testWord = _items[removeWord];

                if (testWord[0] == '_')
                {
                    exacute = false;
                }

                else if (testWord[0] != '_')
                {
                    exacute = true;
                }
            }

            string listWord = _items[removeWord];

            //Take word and change value
            setWord(listWord);

            //Now remove the word in the list
            _items.Remove(_items[removeWord]);

            //Replace with word
            _items.Insert(removeWord, _word);

            doIt += 1;
        }

    }

    private void setWord(string word)
    {
        //Loop through and replace all the words
        for (int i = 0; i < word.Length; i ++)
        {
            foreach (char letter in word){
                word = word.Replace(letter, '_');
            }
        }
        _word = word;
    }

    public List<string> GetList()
    {
        List<string> list = _items;

        return(list);
    }

    public void Display()
    //Display the words in the list
    {
        string display = String.Join(" ", _items.ToArray());
        Console.WriteLine(display);
    }

}