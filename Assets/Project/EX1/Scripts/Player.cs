
using System.Threading.Tasks.Sources;
using UnityEditor.UI;
using static UnityEditor.Experimental.GraphView.GraphView;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string nome;

    private int punteggio;

    //setter
    public void SetPunteggio(int score)
    {
        if (score<0)
        {
            punteggio = 0;
        }
        else
            punteggio = score;
    }

    //getter
    public int GetPunteggio()
    {
        return punteggio;
    }

    public bool IsVincitore()
    {
        if (punteggio >= 100)
        {
            return true;
        }
        else return false;
    }

    public void AttaccaNemico(Enemy nemico, int danno)
    {
        nemico.SubisciDanno(danno);
        Debug.Log($"Player di nome : {nome} ha attaccato il nemico di nome {nemico.nome} con danno {danno} e il nemico ha una salute residua di {nemico.GetSalute()} punti");
        punteggio += danno; // aumento punteggio del player ad ogni danno inflitto.
    }

    public void IncrementaPunteggio(int score)
    {
        punteggio += score;
    }

}
