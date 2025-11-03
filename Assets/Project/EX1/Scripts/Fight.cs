using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("<<<<<<<<<<<<<<<<<<<<<< Esercizio 1 - parte 1 >>>>>>>>>>>>>>>>>>>>>>>>>>");

        Player player1 = new Player();
        Player player2 = new Player();
        player1.nome = "Mario";
        player1.SetPunteggio(1);
        player2.nome = "Peppino";
        player2.SetPunteggio(1);

        Debug.Log($"Player 1 ha come nome : {player1.nome} e come punteggio : {player1.GetPunteggio()}");
        Debug.Log($"$Player 2 ha come nome : {player2.nome} e come punteggio : {player2.GetPunteggio()}");

        Debug.Log("<<<<<<<<<<<<<<<<<<<<<< Esercizio 1 - parte 2 >>>>>>>>>>>>>>>>>>>>>>>>>>");

        Player player3 = new Player();
        player3.nome = "Giovanni";
        player3.SetPunteggio(1);

        Debug.Log($"Il Player 3 PRIMA DI USARE la funzione IncrementaPunteggio ha come nome : {player3.nome} e come punteggio : {player3.GetPunteggio()}");
        player3.IncrementaPunteggio(110);
        Debug.Log($"Il Player 3 DOPO AVER USATO la funzione IncrementaPunteggio ha come nome : {player3.nome} e come punteggio : {player3.GetPunteggio()}");

        if (player3.IsVincitore())
        {
            Debug.Log($"Il player di nome : {player3.nome} ha vinto con punteggio >= 100 !!!");
        }
        else
        {
            Debug.Log($"Il player di nome : {player3.nome} NON ha vinto !!!!! ");
        }

        Debug.Log("<<<<<<<<<<<<<<<<<<<<<< Esercizio 1 - parte 3 >>>>>>>>>>>>>>>>>>>>>>>>>>");

        player3.SetPunteggio(-10);

        Debug.Log($"Il Player 3 che ha nome : {player3.nome} e usando SetPunteggio(-10) NON potendo avere punteggio <0 il suo punteggio ora è : {player3.GetPunteggio()}");

        if (player3.IsVincitore())
        {
            Debug.Log($"Il player di nome : {player3.nome} ha vinto con punteggio >= 100 !!!");
        }
        else
        {
            Debug.Log($"Il player di nome : {player3.nome} NON ha vinto !!!!! ");
        }

        Debug.Log("<<<<<<<<<<<<<<<<<<<<<< Esercizio 1 - parte 4 >>>>>>>>>>>>>>>>>>>>>>>>>>");

        Enemy enemy = new Enemy();
        enemy.nome = "Nemico";
        enemy.SetSalute(100);

        int dannodainfliggere = 10; // setto danno di valore fisso che il player può infliggere

        // SIMULZIONE BATTAGLIA

        Debug.Log("<<<<<<<<<<<<<<<<<<<<<< SIMULAZIONE BATTAGLIA >>>>>>>>>>>>>>>>>>>>>>>>>>");

        while (enemy.IsAlive())
        {
            player1.AttaccaNemico(enemy, dannodainfliggere);

            Debug.Log($"Player1 di nome : {player1.nome} ha attaccato il nemico di nome {enemy.nome} con danno {dannodainfliggere} e il nemico ha una salute residua di {enemy.GetSalute()} punti");

            if (player1.IsVincitore())
            {
                Debug.Log("PLAYER 1 ha VINTO");
            }
            else
            {
                Debug.Log("PLAYER 1 NON HA VINTO");
            }
        }
    }


}
