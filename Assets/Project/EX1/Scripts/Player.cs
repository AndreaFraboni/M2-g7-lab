

using System.Threading.Tasks.Sources;
using UnityEditor.UI;

public class Player
{
    public string nome;
    private int punteggio;

    // getter
    public void SetPunteggio(int score)
    {
        if (score >= 0)
        {
            punteggio = score;
        }
        else if (score < 0)
        {
            score = 0;
            punteggio = score;
        }
    }

    //setter
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
        punteggio += danno; // aumento punteggio del player ad ogni danno inflitto.
    }

    public void IncrementaPunteggio(int score)
    {
        punteggio += score;
    }

}
