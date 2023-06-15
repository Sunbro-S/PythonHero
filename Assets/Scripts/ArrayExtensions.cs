using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExtensions : MonoBehaviour
{
    // Start is called before the first frame update
    public static T[] Shuffle<T>(T[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = Random.Range(0, i + 1);
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        return array;
    }
}
