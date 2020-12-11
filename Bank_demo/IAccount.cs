namespace Bank_demo
{
    public interface IAccount
    {
       public void Withdraw(int sum);
       public  void Transfer(IAccount transferTo, int money);
       public  void Despoit(int sum);

        
    }
}