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
    public partial class Form2 : Form
    {
        
        public Form2()
        {

            InitializeComponent();

        }
        BindingList<Account> _items;


        private void initializeListOfAccounts()
        {
            _items = new BindingList<Account>();


            // Allow new parts to be added, but not removed once committed.        
            _items.AllowNew = true;
            _items.AllowRemove = true;

            // Raise ListChanged events when new parts are added.
            _items.RaiseListChangedEvents = true;

            // Allow parts to be edited.
            _items.AllowEdit = true;

            //Add objects to the list
            _items.Add(new Account("saving", 123455));
            _items.Add(new Account("private", 5000000));
            _items.Add(new Account("he", 15000));


        }
        BindingList<Account> _items2;
        private void initializeListOfAccounts2()
        {
            _items2 = new BindingList<Account>();

            // Allow new parts to be added, but not removed once committed.        
            _items2.AllowNew = true;
            _items2.AllowRemove = true;

            // Raise ListChanged events when new parts are added.
            _items2.RaiseListChangedEvents = true;

            // Allow parts to be edited.
            _items2.AllowEdit = true;

            foreach (var item in _items)
            {
                _items2.Add(item);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedAccount = listBox1.SelectedIndex;
            var thisObj = _items.ElementAt(selectedAccount);

            label3.Text =  " Money left: " + thisObj.Money;
            
        
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
            initializeListOfAccounts();
            initializeListOfAccounts2();
            listBox1.DataSource = _items;
            listBox1.DisplayMember = "AccountName";
            listBox2.DataSource = _items2;
            listBox2.DisplayMember = "AccountName";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            
            //Get first index
            int selectedAccount = listBox1.SelectedIndex;

            //Get second index
            int selectedAccount_second = listBox2.SelectedIndex;

            //get the selected Account-object.
            var thisObj = _items.ElementAt(selectedAccount);

            var thisObj_transfer = _items2.ElementAt(selectedAccount_second);

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter amount ", "Create new account ", "Default", 500, 300);
            int i = Convert.ToInt32(input);

            thisObj.Transfer(thisObj_transfer, i);

            textBox1.Text = "Money after transfer: " + thisObj.Money;
            textBox2.Text = "Money after transfer: " + thisObj_transfer.Money;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                int selectedAccount = listBox2.SelectedIndex;
                var thisObj = _items2.ElementAt(selectedAccount);

                label5.Text = " Money left: " + thisObj.Money;


            
        }
    }
}
