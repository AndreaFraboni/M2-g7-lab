public class Enemy
{
    public string nome;
    public int salute;
    public int livello;

    //Setter
    public void SetSalute(int health)
    {
        if (health <= 0) health = 10; // salute non può essere < o = 0 settiamo almeno 10 di salute !!!
        salute = health;              // settiamo la salute dell'enemy
    }

    //Getter
    public int GetSalute()
    {
        return salute;
    }

    public void SubisciDanno(int danno)
    {
        salute = salute - danno;
        if (salute < 0) salute = 0;
    }

    public bool IsAlive()
    {
        if (salute > 0)
        {
            return true;
        }
        else
            return false;
    }

}
