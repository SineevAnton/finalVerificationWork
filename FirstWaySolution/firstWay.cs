string[] arr = new string[]{"this", "is", "some", "text", "string", "and", "a", "ssh"}; 
int answerArrLength = 0;

foreach (var word in arr)
{
    if (word.Length <= 3)
    {
        answerArrLength += 1;
    }
}

string[] answerArr = new string[answerArrLength];
int answerIndex = 0;

foreach (var word in arr)
{
    if (word.Length <= 3)
    {
        answerArr[answerIndex] = word;
        answerIndex += 1;
    }
}

Console.WriteLine("[{0}]", string.Join(", ", answerArr));