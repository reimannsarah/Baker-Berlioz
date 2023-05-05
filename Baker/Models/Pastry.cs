namespace Baker
{
  public class Pastry
  {
    private int _pastryPrice = 2;
    private int _orderAmount;
    public int OrderAmount 
    {
      get { return _orderAmount; }
      set { _orderAmount = value; }
    }
    public int Total = 0;
    public Pastry() {}
    public Pastry(int orderAmount)
    {
      _orderAmount = orderAmount;
    }
    public int CalculateTotal()
    {
      // int total = 0;
      for(int i = 1; i <= _orderAmount; i++)
      {
        if(i % 4 != 0)
        {
          Total += _pastryPrice;
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