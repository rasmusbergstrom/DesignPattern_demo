namespace Bank_demo
{
    interface IBankMethods
    {
        void Withdraw(int sum);
        void Transfer(Account to, int money);
        void Despoit(int sum);

        void changeName(Account acc, string name);
    }
}