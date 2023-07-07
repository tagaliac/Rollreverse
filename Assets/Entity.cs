public class Entity
{
    private Health selfHealth;

    public Entity(Health health){
        selfHealth=health;
    }

    public Health getHealth(){
        return selfHealth;
    }
}
