public class BaseSummoner : BaseClassScript {

    private string summonAbility;

    public string summonSummoned(){
        return "neydd 5 mana for zumun";
    }
    public string summonAbility
    {
        get {return summonAbility;}
        set {summonAbility=value;}
    }
    public BaseSummoner() {
        ClassName = "Summoner";
        Damage = 5;
        Health = 5;
        Agility = 3;
        Strenght = 4;
        Inteligence = 3;
        SummonAbility = "ghost";
    }
}