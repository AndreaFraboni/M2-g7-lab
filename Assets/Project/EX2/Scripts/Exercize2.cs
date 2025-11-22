using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

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
        int indiceapertatonda = STRINGA.IndexOf("("); // trovo indice a cui si trova la parentisi tonda aperta che contiene i testi che mi servono
        int indicechiusatonda = STRINGA.IndexOf(")"); // trovo indice a cui si trova la parentesi tonda chiuda che racchiude i testi che mi servono

        if (indiceapertatonda == -1 || indicechiusatonda == -1)
        {
            Debug.Log("ATTENZIONE !!! MANCANO LA PARENTESI TONDE (   ) e qundi il testo è stato composto male ! Usare questo stile : (aragon;left;angry) Che siate attento, non è unu gingillo quello che portate!");
        }
        else
        {
            string testotratonde = STRINGA.Substring(indiceapertatonda + 1, indicechiusatonda - 1); // estrapolo il testo chiuso tra le tonde
            string[] testo = testotratonde.Split(";"); // splitto il contenuto del testo estratto prima sulla base del carattere ;

            Debug.Log(testo[0]);
            Debug.Log(testo[1]);
            Debug.Log(testo[2]);

            string[] testofrase = STRINGA.Split(")");
            Debug.Log(testofrase[1]);

        }

    }

}
