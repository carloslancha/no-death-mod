using Modding;

namespace NoDeath {
    public class NoDeath : Mod {
        private const string version = "1.5.78-1";
        
        public override void Initialize() {
            ModHooks.TakeHealthHook += TakeHealth;
        }
        
        public int TakeHealth(int damageAmount) {
            int currentHealth = PlayerData.instance.health;

            LogDebug("Health" + currentHealth);
            LogDebug("Damage" + damageAmount);

            if (currentHealth - damageAmount < 1)
                return 0;
            
            return damageAmount;
        }
        public override string GetVersion() => version;
    }
}