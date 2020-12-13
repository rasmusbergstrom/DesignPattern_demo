namespace Bank_demo
{
    public interface IAccount
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public string Type { get; set; }
     

        public string ReadMoney();
        public string ReadName();

        
    }
}