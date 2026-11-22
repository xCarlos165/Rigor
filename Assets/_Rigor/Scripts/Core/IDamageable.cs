namespace Rigor.Core
{
    public interface IDamageable
    {
        void ApplyDamage(float amount, int bodyPartId);
    }
}
