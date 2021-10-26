public class BaseSummoner : BaseClassScript {
    public GameObject summonObject;
    public BaseSummoner() {
        ClassName = "Summoner";
        Damage = 5;
        Health = 5;
        Agility = 3;
        Strenght = 4;
        Inteligence = 3;
    }

    void private void Update() {
        if (Input.GetKey("r"))
        {
            Summon();
        }
    }

    public void Summon()
    {
        Instantiate(summonObject);
    }
}