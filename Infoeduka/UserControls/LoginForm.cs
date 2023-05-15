using Infoeduka.CustomDesign;
using Infoeduka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Infoeduka.UserControls
{
 
    public partial class LoginForm : UserControl
    {
        private readonly DataManager _dataManager;
        //definiranje master admina
        private readonly Person masterAdmin = new Person()
        {
            Email = "master@admin.com",
            FirstName = "Master",
            LastName = "Admin",
            Password = "123",
            IsAdmin = true
        };

        public LoginForm(DataManager dataManager)
        {
            _dataManager = dataManager;
            InitializeComponent();
        }

        //definiranje tekstualnih polja
        string username = "";
        string password = "";
      
    
        private void TbEmail_TextChanged(object sender, EventArgs e)
        {
            username = tbEmail.Text;
        
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            password = tbPassword.Text;
            tbPassword.PasswordChar = '*';


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           

            // dohvaćanje svih osoba iz baze podataka
            var persons = _dataManager.GetPersonsDictionary().Values;

            // pronalazak osobe s zadanim korisničkim imenom i lozinkom
            var authenticatedPerson =  persons.FirstOrDefault(person => person.Email == username && person.Password == password);
            if (authenticatedPerson is null &&  (password == masterAdmin.Password && username == masterAdmin.Email))
                {
                    authenticatedPerson = masterAdmin;
                } 

            // provjera da li postoji autenticirana osoba
            if (authenticatedPerson is not null)
            {
                this.SendToBack();
                this.Visible = false;
                // postavljanje vrijednosti AuthenticatedPerson propertyja na autentificiranu osobu
                ((MainForm)this.ParentForm).AuthenticatedPerson = authenticatedPerson;
            }
            else
            {
                // ako ne postoji, prikaži poruku o neuspješnoj autentifikaciji
                CustomMessageBox.Show("Pogrešno uneseno korisničko ime ili lozinka!", "Upozorenje!", MessageBoxButtons.OK);
            }
        }
    }
}
