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

namespace Infoeduka.UserControls
{
    public partial class ListOfNotificationForEditOrDelete : UserControl
    {
        private readonly DataManager _dataManager;
        private string _callingButton;
        private Panel _pnlHolderForOtherPanels;
        private readonly Person _authenticatedPerson;
        
        public ListOfNotificationForEditOrDelete(DataManager dataManager, string callingButton, Person authenticatedPerson, Panel holderPanel)
        {
            _dataManager = dataManager;
            _callingButton = callingButton;
            _authenticatedPerson = authenticatedPerson;
            _pnlHolderForOtherPanels = holderPanel;
            InitializeComponent();
        }

       
        private void ListOfNotificationForEditOrDelete_Load(object sender, EventArgs e)
        {
            DefineLabelText();
            DefineListViewColumnHeaders();
            SetListViewProperties();
            ShowData();
            lvNotifications.MouseClick += lvLecturers_MouseClick;
        }


        private void DefineLabelText()
        {
            if (_callingButton == "btnEditNotification")
            {
                lblTitleForCollegeView.Text = "Uređivanje obavijesti";
            }
            else if (_callingButton == "btnDeleteNotification")
            {
                lblTitleForCollegeView.Text = "Brisanje obavijesti";
            }
            
        }

        private void lvLecturers_MouseClick(object sender, MouseEventArgs e)
        {
            var item = lvNotifications.GetItemAt(e.X, e.Y);
            if (item != null && e.Button == MouseButtons.Left)
            {
                var subItem = item.GetSubItemAt(e.X, e.Y);
                if (subItem != null && subItem.Text == "Izbriši obavijest")
                {
                    var notification = item.Tag as Notification;
                    if (notification != null)
                    {

                        var result = CustomMessageBox.Show($"Jeste li sigurni da želite izbrisati obavijest: {notification.Name}\nopis: {notification.Description}\npredavača: {notification.Creator.FirstName} {notification.Creator.LastName}, za kolegij:{notification.Course},\nod: {notification.DateOfCreation}\npromjena od: {notification.DateOfChange}\ndatumisteka: {notification.ExpirationDate}?", "Upozorenje", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.Yes)
                        {
                            _dataManager.DeleteNotificationFromDictionary(notification.Id);
                            lvNotifications.Items.Remove(item);
                        }
                    }
                }
                else if (subItem != null && subItem.Text == "Uredi obavijest")
                {

                    var notificationEdit = item.Tag as Notification;
                    if (notificationEdit != null)
                    {
                        NotificationMainForm formEditNotification = new(_dataManager, "btnEditNotification", _authenticatedPerson, notificationEdit);

                        this.SendToBack();
                        _pnlHolderForOtherPanels.Controls.Add(formEditNotification);
                    }
                }
            }
        }

        //metoda za prikaz podataka o osobama
        private void ShowData()
        {
            List<Notification> list = LoadData();
            foreach (var item in list)
            {
                AddListViewRow(item);
            }

        }
        //metoda za punjenje liste iz dictionarya osoba
        private List<Notification> LoadData()
        {
            IDictionary<int, Notification> notifications = _dataManager.GetNotificationDictionary();
            List<Notification> list = new List<Notification>();

            //provjeravamo da li je osoba admin ili je autor obavijesti

            int creatorID = _authenticatedPerson.Id;

            foreach (var notification in notifications.Values)
            {
                if (_authenticatedPerson.IsAdmin || notification.Creator.Id ==creatorID )
                {
                    list.Add(notification);
                }
            }
            return list;
        }

        private void AddListViewRow(Notification notification)
        {
            string deleteText = "Izbriši obavijest";
            string editText = "Uredi obavijest";
            string[] rowData = { };

            switch (_callingButton)
            {
                case "btnDeleteNotification":
                    rowData = new string[]
                    {
                notification.Name,
                $"{notification.Creator.FirstName} {notification.Creator.LastName}",
                notification.Course,
                notification.DateOfCreation.ToString(),
                deleteText
                    };
                    break;

                case "btnEditNotification":
                    rowData = new string[]
                    {
                notification.Name,
                $"{notification.Creator.FirstName} {notification.Creator.LastName}",
                notification.Course,
                notification.DateOfCreation.ToString(),
                editText
                    };
                    break;
            }

            ListViewItem row = new ListViewItem(rowData);
            row.Tag = notification;

            // Set text color for delete/edit column
            if (rowData.Contains(deleteText) || rowData.Contains(editText))
            {
                row.UseItemStyleForSubItems = false;
                row.SubItems[rowData.Length - 1].ForeColor = Color.Red;
            }

            lvNotifications.Items.Add(row);
        }


        //postavljanje view propertisa na listi
        private void SetListViewProperties()
        {
            lvNotifications.GridLines = false;
            lvNotifications.FullRowSelect = true;
            lvNotifications.MultiSelect = false;
        }
        //definiramo kako će nam izgledati hederi da stupcima
        private void DefineListViewColumnHeaders()
        {
            switch (_callingButton)
            {
                case "btnDeleteNotification":
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Naziv", Width = 200 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Kreirao", Width = 150 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Kolegij", Width = 190 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Datum kreiranja:", Width = 140 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Brisanje obavijesti", Width = 150 });
                    break;
                case "btnEditNotification":
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Naziv", Width = 200 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Kreirao", Width = 150 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Kolegij", Width = 190 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Datum kreiranja:", Width = 140 });
                    lvNotifications.Columns.Add(new ColumnHeader { Text = "Uređivanje obavijesti", Width = 160 });
                    break;
            
            }

        }


    }
}
