public class BaseSummoner : BaseClassScript {

    private string summonAbility;

    public string summonAbility
    {
        get {return summonAbility;}
        set {summonAbility=xd;}
    }
    public BaseSummoner() {
        ClassName = "Summoner";
        Damage = 5;
        Health = 5;
        Agility = 3;
        Strenght = 4;
        Inteligence = 3;
    }
}