using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercize2 : MonoBehaviour
{

    [SerializeField] private string STRINGA;
     

    // REGOLA PER LA STRINGA :
    // (aragon;left;angry) Che siate attento, non è unu gingillo quello che portate!
    // (gandalf;right) Uno stregone non è mai in ritardo, arriva precisamente quando intende farlo.

    // Start is called before the first frame update
    void Start()
    {
        // Stampare singolarmente i contenuti della stringa

        int indiceapertatonda = STRINGA.IndexOf("(");

        int indicechiusatonda = STRINGA.IndexOf(")");

        //string testotratonde = STRINGA.Substring(indiceapertatonda,)




    }

}
