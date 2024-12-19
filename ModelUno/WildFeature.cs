using System;

namespace ModelUno
{
    // "дикая" карта
    [Serializable]
    public class WildFeature : Feature
    {
        readonly AllowedOperations allowedOperations;

        public override AllowedOperations AllowedOperations { get { return allowedOperations; } }

        public AllowedOperations Allowed { get; }

        internal WildFeature(AllowedOperations allowed)
        {
            Allowed = allowed;
            Name = $"Wild{allowed}";
            // запоминаем ограничения для операций в локальном поле
            allowedOperations = AllowedOperations.Drop | AllowedOperations.Wild | allowed;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
