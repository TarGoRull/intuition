//Аесть код выполнять действие раз в 5 секунд например?
//Вариант 1. InvokeRepeating:
using UnityEngine;
 
public class Timer : MonoBehaviour
{
    void Start ()
    {
        InvokeRepeating("Message", 0, 5);
    }
    
    void Message()
    {
        Debug.Log("Hello");
    }
}


//Вариант 2. Coroutines:
//Кликните здесь для просмотра всего текста

using System.Collections;
using UnityEngine;
 
public class Timer : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("DoMessage");
    }
 
    IEnumerator DoMessage()
    {
        for (; ; )
        {
            Message();
            yield return new WaitForSeconds(5f);
        }
    }
 
    void Message()
    {
        Debug.Log("Hello");
    }
}
