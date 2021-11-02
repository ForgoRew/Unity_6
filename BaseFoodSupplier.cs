public class BaseFoodSupplier : BaseClassScript {
    private string specialAbility;
    private bool hasCheese;
    public string RiceCooked(){
        return "plz 5 $ for rice...";
    }

    public string SpecialAbility{
        get {return specialAbility;}
        set {specialAbility=value;}
    }
    public bool HasCheese{
        get {if (hasCheese == true){return "Here is ur cheesecake...";}else{return "NO CHEESECAKE FOR U!";}}
        set {hasCheese=value;}
    }
    public BaseFoodSupplier(){
        ClassName="Food Supplier";
        Damage=0;
        Health=1000;
        Strength=1;
        Inteligence=5;
        Agility=4;
        SpecialAbility="Can cook 60 second rice in 59 seconds!";
    }
}