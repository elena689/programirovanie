// Дан текст. В тексте нужно все пробелы заменить на черточки. Все строчные "к" заменить на заглавные. Все заглавные "С", заменить на строчные.

string text = "С утра падал снег."
            + "Медвежонок сидел на пеньке." 
            + "Он поднял голову. "
            + "Малыш считал упавшие на носу снежинки." 
            + "Снежинки падали пушистые и белые.";

// string s = "qwerty"
//             012
// s[3]//r

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i<length; i++)
    {
        if (text[i]==oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '_');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
