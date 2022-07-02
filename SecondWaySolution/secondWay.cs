string[] arr = new string[]{"this", "is", "some", "text", "string", "and", "a", "ssh"}; 
string str = ""; 
foreach (var word in arr) 
{ 
    if (word.Length <= 3) 
    { 
        str += word + " "; 
    } 
} 
 
var answer = str.Trim().Split(' ').ToArray(); 
 
Console.WriteLine(answer); 
 
Console.WriteLine("[{0}]", string.Join(", ", answer));