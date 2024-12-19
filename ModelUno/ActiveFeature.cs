using System;

namespace ModelUno
{
    // Содержит особенности активной карты
    [Serializable]
    public class ActiveFeature : Feature
    {
        readonly AllowedOperations allowedOperations;
        public override AllowedOperations AllowedOperations { get { return allowedOperations; } }
        public AllowedOperations Allowed { get; }
        internal ActiveFeature(AllowedOperations allowed)
        {
            Allowed = allowed;
            Name = $"Active{allowed}";
            allowedOperations = AllowedOperations.Drop | allowed;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
