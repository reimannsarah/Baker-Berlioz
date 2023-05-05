namespace Baker
{
  public class Pastry
  {
    private int _pastryPrice = 2;
    private int _orderAmount;
    public Pastry(int orderAmount)
    {
      _orderAmount = orderAmount;
    }
    public int GetPastryPrice()
    {
      return _pastryPrice;
    }
    public int GetOrderAmount()
    {
      return _orderAmount;
    }
  }
}