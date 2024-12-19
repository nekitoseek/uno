namespace ModelUno
{
    public static class CardBuilder
    {
        // стоимость карт от 0..9 составляют 0..9 соответственно
        public static void BuildNumericCard(Card card, int number)
        {
            card.Feature = new PrimitiveFeature(number);
            card.Cost = number;
        }

        // карта пропуска хода
        public static void BuildSkipCard(Card card)
        {
            card.Feature = new ActiveFeature(AllowedOperations.Skip);
            card.Cost = 20;
        }

        // карта смены направления
        public static void BuildRotateCard(Card card)
        {
            card.Feature = new ActiveFeature(AllowedOperations.Rotate);
            card.Cost = 20;
        }

        // карта +2
        public static void BuildTakeTwoCard(Card card)
        {
            card.Feature = new ActiveFeature(AllowedOperations.TakeTwo);
            card.Cost = 20;
        }

        // карта выбор цвета
        public static void BuildWildColorCard(Card card)
        {
            card.Feature = new WildFeature(AllowedOperations.Color);
            card.Cost = 50;
        }

        // карта выбор цвета +4
        public static void BuildWildColorTakeFourCard(Card card)
        {
            card.Feature = new WildFeature(AllowedOperations.Color | AllowedOperations.TakeFour);
            card.Cost = 50;
        }
    }
}
