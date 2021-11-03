public class BaseWarrior : BaseClassScript {
    private bool cheesecake;
    public bool Cheesecake {
        get {return cheesecake;}
        set {cheesecake = value;}
    }
    public bool hasCheese;
    public bool HasCheese{
        get {if (hasCheese==true){hasCheese=false; cheesecake=true; return "F. Supplier: gimme 3 $!";}else{return false;}}
        set {hasCheese=value;}    
    }
    public BaseWarrior() {

        ClassName="Warrior";
        Damage=69;
        Health=120;
        Agility=8;
        Inteligence=1;
        Strength=1;
        Cheesecake=true;
    }
}