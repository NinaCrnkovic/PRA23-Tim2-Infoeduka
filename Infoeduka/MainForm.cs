using Infoeduka.Model;
using Infoeduka.UserControls;
using Utilities;

namespace Infoeduka
{
    public partial class MainForm : Form
    {
        private DataManager _dataManager = new DataManager();
        public Person AuthenticatedPerson
        {
            get { return _authenticatedPerson; }
            set
            {
                _authenticatedPerson = value;
                SetViewForUser();
            }
        }


        private Person _authenticatedPerson;
        public MainForm()
        {
            // Stvori novu instancu LoginPanel-a
            LoginForm loginForm = new LoginForm(_dataManager);
            // Dodaj LoginPanel u Panel kontrolu na MainForm-u
            this.Controls.Add(loginForm);
            loginForm.BringToFront();
            InitializeComponent();
            SetPanelForDropDownVisibilityToFalse();
        }
        //ponašanje tijekom pokretanja frome
        private void MainForm_Load(object sender, EventArgs e)
        {
            _dataManager.LoadPersonsToDictionary();
            _dataManager.LoadCoursesToDictionary();
            _dataManager.LoadNotificationsToDictionary();
            //poziv panela za prikaz aktualnih obavijesti
            CallCurrentNotifications();
        }

        private void CallCurrentNotifications()
        {
            ListOfNotifications listOfNotifications = new(_dataManager, "");
            pnlHolderForOtherPanels.Controls.Clear();
            pnlHolderForOtherPanels.Controls.Add(listOfNotifications);
        }

        //ponašanje tijekom zatvaranja forme
        private void SaveAllOnClosing(object sender, FormClosingEventArgs e)
        {
            _dataManager.SaveAllDataInFile();
        }

        //glavni gumbi - koji otvaraju padajuæi izbornik
        private void MainButtonsForDropDownMenu_Click(object sender, EventArgs e)
        {
            Button mainButton = sender as Button;
            if (mainButton is null)
            {
                return;
            }
            switch (mainButton.Name)
            {
                case "btnMainNotifications":
                    ShowDropDownPanel(pnlNotificationsDropDown);
                    break;
                case "btnMainCourse":
                    ShowDropDownPanel(pnlCourseDropDown);
                    break;
                case "btnMainLecturer":
                    ShowDropDownPanel(pnlLecturerDropDown);
                    break;

            }
        }

        //Gumbi u padajuæem izborniku
        private void ButtonsInDropDownMenu_Click(object sender, EventArgs e)
        {
            Button dropdownButton = sender as Button;
            if (dropdownButton is null)
            {
                return;
            }
            switch (dropdownButton.Name)
            {   //Notifications
                case "btnViewAllNotifications":
                    ListOfNotifications listOfNotifications = new(_dataManager, "btnViewAllNotifications");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(listOfNotifications);
                    break;
                case "btnAddNewNotification":
                    NotificationMainForm formAddNotification = new(_dataManager, "btnAddNewNotification", _authenticatedPerson);
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formAddNotification);
                    break;
                case "btnEditNotification":
                    ListOfNotificationForEditOrDelete formEditNotification = new(_dataManager, "btnEditNotification", _authenticatedPerson, pnlHolderForOtherPanels);
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formEditNotification);
                    break;
                case "btnDeleteNotification":
                    ListOfNotificationForEditOrDelete formDeleteNotification = new(_dataManager, "btnDeleteNotification", _authenticatedPerson, pnlHolderForOtherPanels);
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formDeleteNotification); ;
                    break;
                //Courses
                case "btnViewAllCourses":
                    ListOfCourses listOfCourses = new(_dataManager, "btnViewAllCourses");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(listOfCourses);
                    break;
                case "btnAddNewCourse":
                    CoursesMainForm formAddCourse = new(_dataManager, "btnAddNewCourse");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formAddCourse);
                    break;
                case "btnEditCourse":
                    ListOfCourses formEditCourse = new(_dataManager, "btnEditCourse", pnlHolderForOtherPanels);
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formEditCourse);
                    break;
                case "btnDeleteCourse":
                    ListOfCourses formDeleteCourse = new(_dataManager, "btnDeleteCourse");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formDeleteCourse);
                    break;
                //Lecturers
                case "btnViewAllLecturers":
                    ListOfLecturers listOfLecturers = new (_dataManager, "btnViewAllLecturers");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(listOfLecturers);
                    break;
                case "btnAddNewLecturer":
                    LecturerMainForm formAddLecturer = new LecturerMainForm(_dataManager, "btnAddNewLecturer");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formAddLecturer);
                    break;
                case "btnEditLecturer":
                    ListOfLecturers formEditLecturer = new(_dataManager, "btnEditLecturer", pnlHolderForOtherPanels);
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(formEditLecturer);
                    break;
                case "btnDeleteLecturer":
                    ListOfLecturers fromDeleteLecturer = new(_dataManager, "btnDeleteLecturer");
                    pnlHolderForOtherPanels.Controls.Clear();
                    pnlHolderForOtherPanels.Controls.Add(fromDeleteLecturer);
                    break;

            }
        }


        //Gumbi footer
        //akcije na gumbima u footeru - linkovi na stranice

        private void LbAlgebraLink_LinkClicked(object sender, EventArgs e)
        {
            try
            {
                Utility.VisitLink("https://www.algebra.hr/");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void LinkItems_Click(object sender, EventArgs e)
        {
            PictureBox linkItem = sender as PictureBox;
            if (linkItem is null)
            {
                return;
            }
            switch (linkItem.Name)
            {
                case "pbTikTok":
                    Utility.VisitLink("https://www.tiktok.com/@algebrauniversity");
                    break;
                case "pbLinkedin":
                    Utility.VisitLink("https://www.linkedin.com/company/28381/admin/");
                    break;
                case "pbFacebook":
                    Utility.VisitLink("https://web.facebook.com/racunarstvo?_rdc=1&_rdr");
                    break;
                case "pbInstagram":
                    Utility.VisitLink("https://www.instagram.com/algebra_university_college/");
                    break;
                case "pbYouTube":
                    Utility.VisitLink("https://www.youtube.com/channel/UCWIWCcDw_k2-BP9JnbryIyg");
                    break;
            }
        }
        
        //postavljamo visibility na panelima koji glume drop down i ukojima su ostali gumbi na false 
        private void SetPanelForDropDownVisibilityToFalse()
        {

            pnlCourseDropDown.Visible = false;
            pnlNotificationsDropDown.Visible = false;
            pnlLecturerDropDown.Visible = false;
        }



        //metoda za skrivanje panela koji glume drop down
        private void HideDropDownPanel()
        {
            if (pnlCourseDropDown.Visible)
            {
                pnlCourseDropDown.Visible = false;
            }
            if (pnlNotificationsDropDown.Visible)
            {
                pnlNotificationsDropDown.Visible = false;
            }
            if (pnlLecturerDropDown.Visible)
            {
                pnlLecturerDropDown.Visible = false;
            }

        }

        //metoda za pokazivanje panela koji glume drop down
        private void ShowDropDownPanel(Panel panel)
        {
            if (panel.Visible == false)
            {
                //hide metoda zatvara prijašnji otvoreni drop down kada klikenemo na slijedeæi
                HideDropDownPanel();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
                CallCurrentNotifications();
            }
        }

        private void SetViewForUser()
        {
            if (_authenticatedPerson != null)
            {
                this.btnUserLoggedIn.Text = $"{_authenticatedPerson.FirstName} {_authenticatedPerson.LastName}";

                if (!_authenticatedPerson.IsAdmin)
                {
                    this.btnMainLecturer.Visible = false;
                    this.btnAddNewCourse.Visible = false;
                    this.btnEditCourse.Visible = false;
                    this.btnDeleteCourse.Visible = false;
                }
            }
            else
            {
                this.btnUserLoggedIn.Text = "";
                this.btnMainLecturer.Visible = true;
                this.btnAddNewCourse.Visible = true;
                this.btnEditCourse.Visible = true;
                this.btnDeleteCourse.Visible = true;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Kreiranje nove instance glavne forme
         

            // Zatvaranje trenutne instance glavne forme
      

            // Pokretanje nove instance glavne forme
      
            // postavite authenticated person na null kako biste oznaèili da nitko nije prijavljen
            AuthenticatedPerson = null;
            // Ponovo prikažite LoginForm
           
            LoginForm loginForm = new LoginForm(_dataManager);
            this.Controls.Add(loginForm);
            loginForm.BringToFront();
            pnlHolderForOtherPanels.Controls.Clear();
            SetPanelForDropDownVisibilityToFalse();
            CallCurrentNotifications();
            
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            CallCurrentNotifications();
        }
    }
}