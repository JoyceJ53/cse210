using System;
using System.Net.Quic;
using System.Runtime.CompilerServices;

// this class keeps track of the reference and the text of the scripture. It can hide words and get the rendered display of the text.
public class Scripture
{
    // variables
    private string _verse = "This is a scripture verse";
    private Random _random = new Random();
    private string[] _words;

    // scripture string
    public Scripture()
        {
            // _words = _verse.Split(' ');
        }

    public Scripture (List<string> verse){
        _words = verse.ToArray();
    }

    public void SetWords(List<string> verse){
        _words = verse.ToArray();
    }
    // method to return all words
    public string[] GetWords()
        {
            return _words;
        }
    public string RenderedScripture()
    {
        string verse = string.Join(" ", _words);
        return verse;
    }

    // method to get random index for words
    public int GetRandomIndex()
        {
            int index = _random.Next(0, _words.Length);
            return index;
        }

    // method to end program if scripture is completely hidden
    public bool ScriptureIsHidden(string[] verse)
    {
        // quit = !(_words.All(word => word == "_"));
        foreach (string word in verse){
            if(!word.StartsWith("_")){
                return false;
            }
        }
        return true;
    }
    public void ReplaceWords(Word word)
    {
        _verse = word.ReplaceWords(_verse);
    }
}