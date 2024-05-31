using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordBank : MonoBehaviour
{
    public List<string> originalWords = new List<string>()
    {
        "Junk", "Jesus", "Puns", "Chance", "Weenis", "Smash", "Goner", "Covert", "Floopin", "Truck", "Mega", "Supercalifragilisticexpialidocious", "Loud", "Enough", "Mommy", "Connor",
        "Heehee", "Daniel", "Exponent", "Partner", "Internet", "Pazzazz", "Legolas", "Existentialism", "Dachshund", "Sovereignty"
    };

    public List<string> workingWords = new List<string>();

    void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        ConvertToLower(workingWords);
    }
    void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }
    void ConvertToLower(List<string> list)
    {
        for (int i = 0; i < list.Count;i++)
        {
            list[i] = list[i].ToLower();
        }
    }
    public string GetWord()
    {
        string newWord = string.Empty;

        if (workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }

        return newWord;
    }
}
