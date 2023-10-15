string[] words = { "Hello", "World", "-20", "and", "world", "many" };
Random random = new Random();
int randomIndex = random.Next(0, words.Length);
string randomWord = words[randomIndex];
Console.WriteLine(randomWord);
if (randomWord.Length >= 3)
{
    Console.WriteLine("Here is a word that has 3 or more characters: " + randomWord);
}
else
{
    Console.WriteLine("There is no word that has 3 or more characters.");
}
return 0;