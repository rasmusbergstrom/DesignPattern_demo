using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_demo
{
    
    public partial class Form1 : Form
    {
        public BindingList<IAccount> _items = new BindingList<IAccount>();
        public BindingList<IAccount> _items2 = new BindingList<IAccount>();
        IAccount acc;
        AccountFactory factory = new AccountFactory();


        public Form1()
        {         
            InitializeComponent();          
        }

        #region Form1_Load
        private void Form1_Load_1(object sender, EventArgs e)
        {
            initializeListOfAccounts();
           

            listBox1.DataSource = _items;
            
            listBox1.DisplayMember = "FullAccountInfo";

            listBox2.DataSource = _items2;

            listBox2.DisplayMember = "AccountName";
        }
        #endregion


        #region Initialize List of Accounts
        public void initializeListOfAccounts()
        {
            _items = new BindingList<IAccount>();
            _items2 = new BindingList<IAccount>(_items);

            // Allow new parts to be added, but not removed once committed.        
            _items.AllowNew = true;
            _items.AllowRemove = true;

            _items2.AllowNew = true;
            _items2.AllowRemove = true;

            // Raise ListChanged events when new parts are added.
            _items.RaiseListChangedEvents = true;
            _items2.RaiseListChangedEvents = true;

            // Allow parts to be edited.
            _items.AllowEdit = true;
            _items2.AllowEdit = true;

            //Add objects to the list
            _items.Add(factory.GetAccount("saving"));
            _items.Add(factory.GetAccount("budget"));
            _items.Add(factory.GetAccount("private"));
        }

        #endregion


        #region SELECT-Button
        private void button1_Click(object sender, EventArgs e)
        {
      
                //Find the index from the list
                int selectedAccount = listBox1.SelectedIndex;
                
                //get the selected Account-object.
                var thisObj = _items.ElementAt(selectedAccount);

            //string money = thisObj.Money.ToString();
            //Update label with text
            
           
        }

        #endregion


        #region NEW ACCOUNT-Button
        private void newAccButton_Click(object sender, EventArgs e)
        {
            //Ask user for AccountName
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter new accountname ", "Create new account ", "Default", 500, 300);
            //Create a new Account obj with Name = input, Money = 0;  
            //Account accNew = new Account(input, 0); 
            //Add the new obj to list. 
            //_items.Add(accNew);
            _items.ResetBindings();
            _items2.ResetBindings(); 


        }

        #endregion


        #region REMOVE-Button
        private void RemoveButtom_Click(object sender, EventArgs e)
        {
            int selectedAccount = listBox1.SelectedIndex;
            try
            {
                _items.RemoveAt(selectedAccount);
                _items.ResetBindings();
                _items2.ResetBindings();        
            }
            catch
            { 
            }

       
        }
        #endregion





        #region RENAME
        private void button2_Click(object sender, EventArgs e)
        {
            int selectedAccount = listBox1.SelectedIndex;
            var thisObj = _items.ElementAt(selectedAccount);
            string name = Microsoft.VisualBasic.Interaction.InputBox("Enter new name ", "Create new account ", "Default", 500, 300);


           // thisObj.changeName(thisObj, name);
            _items.ResetBindings();
            _items2.ResetBindings();
          
        }
        #endregion


        #region DEPOSIT
        private void button3_Click(object sender, EventArgs e)
        {
            int value = Converter();
            int selectedAccount = listBox1.SelectedIndex;
            var thisObj = _items.ElementAt(selectedAccount);

            thisObj.Despoit(value);
            _items.ResetBindings();
            _items2.ResetBindings();


        }
        #endregion


        #region WITHDRAW 
        private void button4_Click(object sender, EventArgs e)
        {

            int value = Converter();
            int selectedAccount = listBox1.SelectedIndex;
            var thisObj = _items.ElementAt(selectedAccount);

            thisObj.Withdraw(value);
            _items.ResetBindings();
            _items2.ResetBindings();

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        #endregion




        #region HELP-Methods

        public int Converter()
        {
            int value;
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter amount ", "Enter amount ", "Default", 500, 300);
            if(input == "")
            {
                value = 0; 
            }
            else
            {
                value = int.Parse(input);
            }

            return value;
        }
  
        #endregion

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Set transfer-list visible
        private void transfer_2_Click(object sender, EventArgs e)
        {
         
            if (listBox2.Visible == false)
            {
                listBox2.Visible = true;
                button6.Visible = true;
            }
            else
            {
                listBox2.Visible = false;
                button6.Visible = false;
            }
        }
        //Transfer money to this account 
        private void button6_Click(object sender, EventArgs e)
        {
            int selectedAccount1 = listBox1.SelectedIndex;
            int selectedAccount2 = listBox2.SelectedIndex;
    

            //Gets the obj from index 
            var fromObj = _items.ElementAt(selectedAccount1);
            var toObj = _items.ElementAt(selectedAccount2);

            int money = Converter();

            //if (fromObj.Money >= money)
            //{
            //    fromObj.Transfer(toObj, money);

            //    TransferLabel.Text = "Money sent!";
                
            //    _items.ResetBindings();
            //    _items2.ResetBindings();


            //}
            //else
            //{
            //    TransferLabel.Text = "ERROR! Not enough money!";            
            //}


        }
    }

}

        
    

