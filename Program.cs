string[] words = { "Hello", "World", "-20", "and", "world", "many" };
Random random = new Random();
int randomIndex = random.Next(0, words.Length);
string randomWord = words[randomIndex];
Console.WriteLine(randomWord);
if (randomWord.Length >= 3)
{
    Console.WriteLine(  randomWord);
}
else
{
    Console.WriteLine("Сдесь больше трех символов");
}
return 0;