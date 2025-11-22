using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EX3 : MonoBehaviour
{
    [SerializeField] private int numeroMax;

    // devo ottenere questa sequenza di aggiunta di dati alla lista
    // 0 -> [0]            all'inizio
    // 1 -> [0,1]          in fondo
    // 2 -> [0,2,1]        in mezzo
    // 3 -> [3,0,2,1]      all'inizio
    // 4 -> [3,0,2,1,4]    in fondo
    // 5 -> [3,0,5,2,1,4]  i nmezzo

    // Start is called before the first frame update
    void Start()
    {
        List<int> listanumeri = new List<int>();      

        for (int i = 0; i < numeroMax+1; i++)
        {

            if (i % 3 == 0)
            {
                listanumeri.Insert(0, i);
            }
            else if (i % 3 == 1)
            {
                listanumeri.Add(i);
            }
            else if (i % 3 ==2)
            {
                listanumeri.Insert(listanumeri.Count / 2, i);
            }

            string listatesto = StampaLista(ref listanumeri);
            Debug.Log("Contenuto Lista : " + listatesto);

        }
    }

    string StampaLista(ref List<int> lista)
    {
        string testolista = "";

        foreach (int i in lista)
        {
            Debug.Log(i);
            testolista += i + " ";    
        }

        return testolista;
    }

}
