using System;

namespace ModelUno
{
    [Serializable]
    public class Card
    {
        public Card(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public string Name { get; private set; }

        // особенность карты с ее свойством
        public Feature Feature { get; set; }

        public int ID { get; }

        // стоимость карты
        public int Cost { get; set; }

        // Цвет карты
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
