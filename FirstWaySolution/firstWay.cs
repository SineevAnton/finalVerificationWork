string[] arr = new string[] { "this", "is", "some", "text", "string", "and", "a", "ssh" };

int CheckElementsLength(string[] array)
{
    int count = 0;
    foreach (var word in array)
    {
        if (word.Length <= 3)
        {
            count += 1;
        }
    }
    return count;
}

int answerArrLength = CheckElementsLength(arr);

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