public class Entity
{
    private Health selfHealth;

    public Entity(int maxHealth){
        selfHealth=new Health(maxHealth);
    }

    public Health getHealth(){
        return selfHealth;
    }
}
