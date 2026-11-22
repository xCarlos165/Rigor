using System;

namespace Rigor.Core
{
    public static class GameEvents
    {
        public static event Action<float, int> OnPlayerDamaged;
        public static event Action OnPlayerPermadeath;

        public static void RaisePlayerDamaged(float amount, int bodyPartId)
            => OnPlayerDamaged?.Invoke(amount, bodyPartId);

        public static void RaisePlayerPermadeath()
            => OnPlayerPermadeath?.Invoke();
    }
}
