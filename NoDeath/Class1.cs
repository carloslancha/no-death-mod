using Modding;

namespace NoDeath
{
    public class NoDeath : Mod
    {
        private const string version = "1.0.0";
        
        public override void Initialize()
        {
            ModHooks.Instance.TakeHealthHook += TakeHealth;
        }
        
        public int TakeHealth(int damageAmount)
        {
            int currentHealth = PlayerData.instance.health;

            if (currentHealth - damageAmount < 1)
            {
                return 0;
            }
            
            return damageAmount;
        }
        
        public override string GetVersion()
        {
            return version;
        }
    }
}