namespace Baker.Models
{
  public class Bread
  {
    private int _loafPrice = 2;
    private int _orderAmount;
    public Bread(int orderAmount)
    {
      _orderAmount = orderAmount;
    }
    public int GetOrderAmount()
    {
      return _orderAmount;
    }
  }
}