
static bool isPalidrome(string word)
{

    string processed_word = removeUnecessaryChar(word);

    int i = 0; 
    int j = processed_word.Length - 1;

    while (j > i)
    {
        if (processed_word[i] != processed_word[j])
        {
            return false;
        }
        i++;
        j--;
    }

    return true;


}

static string removeUnecessaryChar(string word)
{
    string result = "";

    foreach(char c in word)
    {
        if (char.IsLetter(c))
        {
            result += c;
        }

    }
    return result;
}


Console.WriteLine("enter a word to check if it is a palindrome");
string userInput = Console.ReadLine();
bool res = isPalidrome(userInput);

Console.WriteLine($"the provided word is a {(res ? "palindrom": "not a palindrome")}");