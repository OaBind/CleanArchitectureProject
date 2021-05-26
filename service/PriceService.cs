class PriceService : IPrice
{
    public double getProductPriceById(uint id)
    {
        return new PriceDB().getPriceByProductId(id);
    }
}