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
    public Bread() {}
    public Bread(int orderAmount)
    {
      _orderAmount = orderAmount;
    }
    public int CalculateTotal() 
    {
      for(int i = 0; i <=_orderAmount; i++)
      {
        if(i % 3 != 0)
        {
          Total += _loafPrice;
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