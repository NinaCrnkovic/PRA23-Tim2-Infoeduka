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
    public partial class ListOfCourses : UserControl
    {
        private readonly DataManager _dataManager;
        private string _callingButton;
        private Panel _pnlHolderForOtherPanels;
        public ListOfCourses(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            _callingButton = callingButton;
            InitializeComponent();
        }

        public ListOfCourses(DataManager dataManager, string callingButton, Panel holderPanel) : this(dataManager, callingButton)
        {
            _pnlHolderForOtherPanels = holderPanel;

        }

        private void ListOfCourses_Load(object sender, EventArgs e)
        {
            DefineLabelText();
            DefineListViewColumnHeaders();
            SetListViewProperties();
            ShowData();
            lvCourses.MouseClick += lvCourses_MouseClick;

        }
        // brisanje ili uređivanje kolegija na klik
        private void lvCourses_MouseClick(object sender, MouseEventArgs e)
        {
            var item = lvCourses.GetItemAt(e.X, e.Y);
            if (item != null && e.Button == MouseButtons.Left)
            {
                var subItem = item.GetSubItemAt(e.X, e.Y);
                if (subItem != null && subItem.Text == "Izbriši kolegij")
                {
                    var course = item.Tag as Course;
                    if (course != null)
                    {
                        var lecturerNames = string.Join(", ", course.Lecturers.Select(l => $"{l.FirstName} {l.LastName}"));
                        var result = CustomMessageBox.Show($"Jeste li sigurni da želite izbrisati kolegij Šifra: {course.Code}, {course.Name}, {course.Ects}, Predavači: {lecturerNames}?", "Upozorenje", MessageBoxButtons.OKCancel);


                        if (result == DialogResult.Yes)
                        {
                            _dataManager.DeleteCourseFromDictionary(course.Id);
                            lvCourses.Items.Remove(item);
                        }
                    }
                }
                else if (subItem != null && subItem.Text == "Uredi kolegij")
                {
                    var course = item.Tag as Course;
                    if (course != null)
                    {
                        var courseEdit = item.Tag as Course;
                        CoursesMainForm formEditCourse = new(_dataManager, "btnEditCourse", courseEdit);

                        this.SendToBack();
                        
                        _pnlHolderForOtherPanels.Controls.Add(formEditCourse);
                    }
                }
            }
        }

        private void DefineLabelText()
        {
            if (_callingButton == "btnViewAllCourses")
            {
                lblTitleForCollegeView.Text = "Pregled svih kolegija";

            }
            else if (_callingButton == "btnDeleteCourse")
            {
                lblTitleForCollegeView.Text = "Brisanje kolegija";
            }
            else if (_callingButton == "btnEditCourse")
            {
                lblTitleForCollegeView.Text = "Uređivanje kolegija";
            }
        }

        //metoda za prikaz podataka o osobama
        private void ShowData()
        {
            List<Course> list = LoadData();
            foreach (var item in list)
            {
                AddListViewRow(item);
            }

        }
        //metoda za punjenje liste iz dictionarya osoba
        private List<Course> LoadData()
        {
            IDictionary<int, Course> courses = _dataManager.GetCoursesDictionary();
            List<Course> list = new List<Course>();
            foreach (var course in courses.Values)
            {
                list.Add(course);
            }

            return list;
        }



        private void AddListViewRow(Course course)
        {
            string[] lecturers = course.Lecturers.Select(l => $"{l.FirstName} {l.LastName}").ToArray();
            string[] rowData = { };
            string deleteText = "Izbriši kolegij";
            string editText = "Uredi kolegij";

            if (_callingButton == "btnViewAllCourses")
            {
                rowData = new string[]
                {
                course.Code,
                course.Name,
                course.Ects.ToString(),
                string.Join(", ", lecturers)
                };

            }
            else if (_callingButton == "btnDeleteCourse")
            {
                rowData = new string[]
                {
                course.Code,
                course.Name,
                course.Ects.ToString(),
                deleteText
                };
            }
            else if (_callingButton == "btnEditCourse")
            {
                rowData = new string[]
                {
                course.Code,
                course.Name,
                course.Ects.ToString(),
                editText
                };
            }

            ListViewItem row = new ListViewItem(rowData);
            row.Tag = course;
            // Postavljanje boje teksta za ćeliju sa natpisom Izbriši ili Uredi
            if (rowData.Contains("Izbriši kolegij") || rowData.Contains("Uredi kolegij"))
            {
                row.UseItemStyleForSubItems = false;
                row.SubItems[rowData.Length - 1].ForeColor = Color.Red;
            }

           
            lvCourses.Items.Add(row);
        }
        //postavljanje view propertisa na listi
        private void SetListViewProperties()
        {
            lvCourses.GridLines = false;
            lvCourses.FullRowSelect = true;
            lvCourses.MultiSelect = false;
        }
        //definiramo kako će nam izgledati hederi da stupcima

        private void DefineListViewColumnHeaders()
        {
            var columns = new List<ColumnHeader>()
            {
                 new ColumnHeader { Text = "Šifra", Width = 80 },
                 new ColumnHeader { Text = "Naziv", Width = 500 },
                 new ColumnHeader { Text = "ECTS", Width = 50 }
            };

            if (_callingButton == "btnViewAllCourses")
            {
                columns.Add(new ColumnHeader { Text = "Predavači", Width = 650 });
            }
            else if (_callingButton == "btnDeleteCourse")
            {
                columns.Add(new ColumnHeader { Text = "Brisanje kolegija", Width = 228 });
            }
            else if (_callingButton == "btnEditCourse")
            {
                columns.Add(new ColumnHeader { Text = "Uređivanje kolegija", Width = 228 });
            }

            lvCourses.Columns.AddRange(columns.ToArray());
        }

    }


}

