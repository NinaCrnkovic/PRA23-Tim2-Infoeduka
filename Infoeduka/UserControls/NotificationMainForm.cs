using Infoeduka.CustomDesign;
using Infoeduka.Model;
using Utilities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infoeduka.UserControls
{
    public partial class NotificationMainForm : UserControl
    {
        //u pozivu kreiranja ove komponente će se poslati data manager i postaviti ćemo ga ovdje u konstruktoru kako bi mogli pristupiti metodama
        private readonly DataManager _dataManager;
        private readonly string _callingButton;
        private readonly Notification _notificationEdit;
        private readonly Person _authenticatedPerson;
        public NotificationMainForm(DataManager dataManager, string callingButton, Person authenticatedPerson)
        {
            _dataManager = dataManager;
            _callingButton = callingButton;
            _authenticatedPerson = authenticatedPerson;
            InitializeComponent();
        }

        public NotificationMainForm(DataManager dataManager, string callingButton, Person authenticatedPerson, Notification notificationEdit) : this(dataManager, callingButton, authenticatedPerson)
        {
            _notificationEdit = notificationEdit;

        }

        

        //provjera koji gumb ga zove (za add ili edit)
       

        private void NotificationMainForm_Load(object sender, EventArgs e)
        {
            if (_callingButton == "btnAddNewNotification")
            {
                LoadComboBox();
                ClearForm();

            }
            else if (_callingButton == "btnEditNotification")
            {
                LoadComboBox();
                if (_notificationEdit != null)
                {
                    tbName.Text = _notificationEdit.Name;
                    tbDescription.Text = _notificationEdit.Description;
                    //ccbCourses.SelectedValue = _notificationEdit.Course;
                    dtDate.Value = _notificationEdit.ExpirationDate;
                        
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            var name = tbName.Text;
            var description = tbDescription.Text;
            var course = ccbCourses.SelectedValue.ToString();
            if (!Utility.IsTextValid(name))
            {
                CustomMessageBox.Show("Nije unesen ispravan naziv obavijesti.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }
            if (!Utility.IsTextValid(description))
            {
                CustomMessageBox.Show("Nije unesen ispravan opis obavijesti.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            // Provjera je li neki element odabran

            Person creator = _authenticatedPerson;
            var expirationDate = dtDate.Value;


        


            if (_callingButton == "btnAddNewNotification")
            {
                Notification newNotification = new Notification(name, description, course, creator, expirationDate);
                try
                {
                    // dodajte novog Person objekta u dictionary u DataManager klasi
                    _dataManager.AddNewNotificationToDictionary(newNotification);

                    // obavijestite korisnika da su podaci spremljeni
                    CustomMessageBox.Show("Uspješno spremljeno", "", MessageBoxButtons.OK);
                    ClearForm();
                }
                catch (Exception ex)
                {

                    CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message, "Greška", MessageBoxButtons.OK);
                }
            }
            else if (_callingButton == "btnEditNotification")
            {
                _notificationEdit.Name = name;
                _notificationEdit.Description = description;
                _notificationEdit.Course = course;
                _notificationEdit.Creator = creator;
                _notificationEdit.ExpirationDate = expirationDate;
                try
                {
                    _dataManager.UpdateNotificationToDictionary(_notificationEdit);
                    CustomMessageBox.Show("Uspješno spremljeno", "", MessageBoxButtons.OK);
                    Dispose();
                }
                catch (Exception ex)
                {

                    CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message, "Greška", MessageBoxButtons.OK);
                }
            }

        }
        public List<Course> GetCourseListFromDictionary(IDictionary<int, Course> dictionary)
        {
            List<Course> courses = new List<Course>();

            foreach (var course in dictionary.Values)
            {
                courses.Add(course);
            }

            return courses;
        }

        private void LoadComboBox()
        {
            IDictionary<int, Course> courseDictionary = _dataManager.GetCoursesDictionary();
            List<string> courseNames = new List<string>();
            ccbCourses.MaxDropDownItems = 4;

            if (_authenticatedPerson.IsAdmin)
            {
                courseNames = courseDictionary.Select(c => c.Value.Name).ToList();
            }
            else
            {
                foreach (var course in courseDictionary.Values)
                {
                    if (course.Lecturers.Any(l => l.Id == _authenticatedPerson.Id))
                    {
                        courseNames.Add(course.Name);
                    }
                }
            }

            if (courseNames.Count == 0)
            {
                Dispose();
                CustomMessageBox.Show("Ne možete dodavati obavijesti jer niste predavač niti na jednom kolegiju", "Upozorenje", MessageBoxButtons.OK);
                
            }
            else
            {
                ccbCourses.DataSource = courseNames;
                if (_callingButton == "btnEditNotification")
                {
                    foreach(var item in ccbCourses.Items)
                {
                        var code = item.ToString();
                        if (code == _notificationEdit.Course)
                        {
                            int index = ccbCourses.Items.IndexOf(item);
                            ccbCourses.SelectedIndex = index;
                            break;
                        }
                    }
                }
                

            }
        }


        private void ClearForm()
        {
            // Brišemo tekstualna polja unutar kontrola gbLecturers
            foreach (Control control in gbCourse.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
            dtDate.Value = DateTime.Today;
            ccbCourses.ResetText();



        }

        private void tbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && tbDescription.Multiline)
            {
                e.Handled = true;
            }
        }
    }
}
