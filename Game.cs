using System;
using System.Linq;

namespace knightmoves;

class Game{
    // Make your changes in this file
	private string phrase;
	
    public Game(string phrase)
    {
		this.phrase = phrase;
	}

    public string DisplayBlanks()
{
    string result = "";

    foreach (char c in phrase)
    {
        if (c == ' ')
    {
        result += "  ";
    }
    else
    {
        result += "_ ";
    }
    }

    return result.TrimEnd();
}
    
public string Play(char[] guessedLetters)
{
    string result = "";
    
    string guess = new string(guessedLetters).ToUpper();

   foreach (char c in phrase)
{
    if (c == ' ')
        result += "  ";
    else if (guess.Contains(char.ToUpper(c)))
        result += c + " ";
    else
        result += "_ ";
}

    return result.TrimEnd();
}
        
    public bool IsValid(string guessedLetters){
		if(guessedLetters.Length != 10){
			return false;
		} else if (guessedLetters.Contains(" ")) {
			return false;
			
		} else if (guessedLetters.Distinct().Count() != 10)
		{
   			 return false;
		}
		else 
		{
        return true;
    }
}
