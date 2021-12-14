using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// public static class StringExtension: using UnityEngine;

public static class Rash
{
    public static int CharCount(this string str, char k)  //Первый параметр - это тип данных в который мы добавили свой метод 
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == k)
            {
                counter++;
            }
        }
        return counter;
    }

    public static Dictionary<int, int> NumberOfDuplicateListItems(this List<int> list)
    {
        return list.GroupBy(i => i).Where(i => i.Count() >= 1).ToDictionary(i => i.Key, j => j.Count());
    }
}