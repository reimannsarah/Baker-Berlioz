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
    public int CalculateTotal()
    {
      int total = 0;
      for(int i = 1; i <= _orderAmount; i++)
      {
        if(i % 4 != 0)
        {
          total += 2;
        }
        else
        {
          total += 0;
        }
      }
      return total;
    }
  }
}