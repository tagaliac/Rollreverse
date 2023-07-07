public class Health
{
    private int maxHealth;
    private int currentHealth;
    private bool isAlive;

    public Health(int max_health){
        maxHealth=max_health;
        currentHealth=max_health;
        isAlive=true;
    }

    public void removeHealth(int amouth){
        if(currentHealth-amouth<0){
            currentHealth=0;
            isAlive=false;
        }else{
            currentHealth-=amouth;
        }
    }

    public void heal(int amouth){
        if(currentHealth+amouth>maxHealth){
            currentHealth=maxHealth;
        }else{
            currentHealth+=amouth;
        }
    }

    public void revive(){
        isAlive=true;
        currentHealth=maxHealth;
    }
}
