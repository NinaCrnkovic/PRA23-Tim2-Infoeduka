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
    public partial class LecturerMainForm : UserControl
    {
        //u pozivu kreiranja ove komponente će se poslati data manager i postaviti ćemo ga ovdje u konstruktoru kako bi mogli pristupiti metodama
        private readonly DataManager _dataManager;
        private readonly string _callingButton;
        private readonly Person _personEdit;
        public LecturerMainForm(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            _callingButton = callingButton;
            InitializeComponent();
        }

        // Konstruktor s dodatnim parametrom 
        public LecturerMainForm(DataManager dataManager, string callingButton, Person personEdit) : this(dataManager, callingButton)
        {
            _personEdit = personEdit;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            
            var firstName = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var email = tbEmail.Text;
            var password = tbPassword.Text;
            var isAdmin = GetChecked();

            if (!Utility.IsTextValid(firstName))
            {
                CustomMessageBox.Show("Nije uneseno ime osobe.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            if (!Utility.IsTextValid(lastName))
            {
                CustomMessageBox.Show("Nije uneseno prezime osobe.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            if (!Utility.IsUsernameValid(email))
            {
                CustomMessageBox.Show("Nije unesen ispravan e-mail.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            if (!Utility.IsTextValid(password))
            {
                CustomMessageBox.Show("Nije unesen ispravna lozinka.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }



            // kreirajte novog Person objekta


            if (_callingButton == "btnAddNewLecturer")
                {
                    Person newPerson = new Person(firstName, lastName, email, password, isAdmin);
                    try
                    {
                    // dodajte novog Person objekta u dictionary u DataManager klasi
                    _dataManager.AddNewPersonToDictionary(newPerson);

                    // obavijestite korisnika da su podaci spremljeni
                    CustomMessageBox.Show("Uspješno spremljeno", "", MessageBoxButtons.OK);
                    ClearForm();
                    }
                    catch (Exception ex)
                    {

                     CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message, "Greška", MessageBoxButtons.OK);
                    }   
                }
                else if (_callingButton == "btnEditLecturer")
                {
                    _personEdit.FirstName = firstName;
                    _personEdit.LastName = lastName;
                    _personEdit.Email = email;
                    _personEdit.Password = password;
                    _personEdit.IsAdmin = isAdmin;
                    try
                    {
                    _dataManager.UpdatePersonToDictionary(_personEdit);
                    CustomMessageBox.Show("Uspješno spremljeno", "", MessageBoxButtons.OK);
                    Dispose();
                    }
                    catch (Exception ex)
                    {

                    CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message, "Greška", MessageBoxButtons.OK);
                    }
                }
           
        }

        private bool GetChecked()
        {
            if (rbtnAdmin.Checked)
            {
                return true;
            }
            
            return false;

        }
        //provjera koji gumb ga zove (za add ili edit)
        private void LecturerMainForm_Load(object sender, EventArgs e)
        {
            if (_callingButton == "btnAddNewLecturer")
            {
                ClearForm();

            }
            else if (_callingButton == "btnEditLecturer")
            {
                if (_personEdit != null)
                {
                    tbFirstName.Text = _personEdit.FirstName;
                    tbLastName.Text = _personEdit.LastName;
                    tbEmail.Text = _personEdit.Email;
                    tbPassword.Text = _personEdit.Password;

                    if (_personEdit.IsAdmin)
                    {
                        rbtnAdmin.Checked = true;
                    }
                    else
                    {
                        rbtnLecturer.Checked = true;
                    }
                }
            }
        }

        private void ClearForm()
        {
            // Brišemo tekstualna polja unutar kontrola gbLecturers
            foreach (Control control in gbLecturer.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
                  
            rbtnAdmin.Checked = false;
            rbtnLecturer.Checked = false;
               
        }
    }
}
