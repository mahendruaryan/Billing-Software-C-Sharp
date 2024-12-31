using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;



namespace WinFormsApp4
{
    public partial class Loginpage : Form
    {
        public static int logineduserindex;//using logined user index in next forms 
        //users list is created in Userclass used with User.Users
        int userchecking = 0;  //for checking if the user exist or not
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Loginpage_Load(object sender  , EventArgs e)
        {//loading all json files if present
            try
            {
                string jsonString = File.ReadAllText("Members.json");// json to read files
                Membership.people = JsonSerializer.Deserialize<List<Membership>>(jsonString);// reading files
            }
            catch { }//if members file is not present than it will not give error

            try
            {
                string productsjsonString = File.ReadAllText("Products.json");// json to read files
                Product.items = JsonSerializer.Deserialize<List<Product>>(productsjsonString);// reading files
            }
            catch { }//if products file is not present than it will not give error

            try
            {
                string userjsonString = File.ReadAllText("User.json");// json to read files
                User.Users = JsonSerializer.Deserialize<List<User>>(userjsonString);// reading files

            }
            catch //if user file is not present than it will not give error
            {
                // if no user afile is present it will automatically add a new user admin so that user is able to login 
                User.Users.Add(new User("admin", "password", true));
            }

            Membership.StatusCheck(Membership.people);//will check that if the validty of membership and if the membership is expired it will change status


            this.MaximizeBox= false;//user will not able to maximize this box
            hidepasslbl.Hide();
        }

       

        private void showpasslbl_Click(object sender, EventArgs e)
        {
            passwordtxtbox.PasswordChar = '\0';//user will able to see the password
            showpasslbl.Hide();
            hidepasslbl.Show();//this label will hide and other label will show to hide the pasword
        }

        private void hidepasslbl_Click(object sender, EventArgs e)
        {
            passwordtxtbox.PasswordChar = '*';
            hidepasslbl.Hide();
            showpasslbl.Show();
        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            for(int a=0;a<User.Users.Count;a++)
            {// if user enters correct username and password
                if (User.Users[a].UserName == usernametxtbox.Text && User.Users[a].Password == passwordtxtbox.Text)
                {
                    MessageBox.Show("Login Successfully");
                    userchecking = 1;//setting user checking to 1
                    this.Hide();
                    new Dashboard().Show();
                    logineduserindex = a;

                }
            }

            if (userchecking == 0)//if password and username not matches
            {
                MessageBox.Show("User and Password does not match");
                passwordtxtbox.Text = "";
                usernametxtbox.Text = "";

            }

            userchecking= 0;//setting again to zero for next time use

        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void loginpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}