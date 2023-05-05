namespace Baker.Models
{
  public class Bread
  {
    private static int _loafPrice = 5;
    private int _orderAmount;
    public int OrderAmount
    {
      get { return _orderAmount; }
      set { _orderAmount = value; }
    }
    public int Total = 0;
    public Bread()
    {

    }
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
      // int total = 0;
      for(int i = 0; i <=_orderAmount; i++)
      {
        if(i % 3 != 0)
        {
          Total += 5;
        }
        else
        {
          Total += 0;
        }
      }
      return Total;
    }
  }
}