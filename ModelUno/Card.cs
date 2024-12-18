using System;

namespace ModelUno
{
    /// <summary>
    /// Карта
    /// </summary>
    [Serializable]
    public class Card
    {
        public Card(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public string Name { get; private set; }

        /// <summary>
        /// Особенность карты, определяющее её свойства
        /// </summary>
        public Feature Feature { get; set; }

        public int ID { get; }

        /// <summary>
        /// Стоимость карты
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// Цвет карты
        /// </summary>
        public CardColor Color { get; set; }

        public void ChangeWildColor(CardColor color)
        {
            Color = color;
            Name = color.ToString() + Name.Substring(Name.IndexOf('('));
        }

        public override string ToString()
        {
            return $"{Color}({Feature})";
        }
    }
}
