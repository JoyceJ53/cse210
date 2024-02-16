using System;
using System.Text;

public class Word
{
    private Scripture _scripture = new Scripture();
    // private StringBuilder _modifiedSentence = new StringBuilder();
    private string _modifiedSentence = "";

    public Word(Scripture scripture)
    {
        _scripture = scripture;
        string _modifiedSentence = "";
    }
    public string ReplaceWords(string scripture)
    // this method will replace the words in the scripture
    {
        _modifiedSentence = "";
        // getting the words from Scripture.cs
        
        // string[] words = _scripture.GetWords();
        string[] words = scripture.Split(' ');
        // getting random index for words
        int index1 = _scripture.GetRandomIndex();
        int index2 = _scripture.GetRandomIndex();
        int index3 = _scripture.GetRandomIndex();

        // replacing the words
        foreach (string word in words)
            {
                // if the word indexes are the same replace the word with underscores
                if (word == words[index1] || word == words[index2] || word == words[index3])
                {
                    _modifiedSentence += new string('_', word.Length);
                }
                // else append the word unchanged
                else{
                    _modifiedSentence += word;
                }
                // add a space after each word
                _modifiedSentence += " ";
            } 
        // change the list to a string and remove the last space
        string verse = _modifiedSentence.ToString().Trim();
        // return the string
        return verse;
        }
}