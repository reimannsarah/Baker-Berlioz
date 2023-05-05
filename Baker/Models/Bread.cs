namespace Baker.Models
{
  public class Bread
  {
    private int _loafPrice = 5;
    private int _orderAmount;
    public Bread(int orderAmount)
    {
      _orderAmount = orderAmount;
    }
    public int GetOrderAmount()
    {
      return _orderAmount;
    }
    public int GetLoafPrice()
    {
      return _loafPrice;
    }
    public int CalculateTotal() 
    {
      int total = 0;
      for(int i = 0; i <=_orderAmount; i++)
      {
        if(i % 3 != 0)
        {
          total += 5;
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