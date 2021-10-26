public class BaseWarrior : BaseClassScript {
    private bool cheesecake;
    public bool Cheesecake {
        get {return cheesecake;}
        set {cheesecake = value;}
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