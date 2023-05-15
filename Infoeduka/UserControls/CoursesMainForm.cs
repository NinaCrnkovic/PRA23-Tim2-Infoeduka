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
    public partial class CoursesMainForm : UserControl
    {
        private readonly DataManager _dataManager;
        private readonly string _callingButton;
        private readonly Course _editCourse;
        public CoursesMainForm(DataManager dataManager, string callingButton)
        {
            _dataManager = dataManager;
            _callingButton = callingButton;
       
            InitializeComponent();
            flpAllLecturers.WrapContents = false;
            flpLecturersOnCourse.WrapContents = false;
      
        }

        public CoursesMainForm(DataManager dataManager, string callingButton, Course editCourse) : this(dataManager, callingButton)
        {
            _editCourse = editCourse;

        }

        private void CoursesMainForm_Load(object sender, EventArgs e)
        {
            if (_callingButton == "btnAddNewCourse")
            {
            
                ShowDataOnLoad();
            }
            else if (_callingButton == "btnEditCourse")
            {
                if (_editCourse != null)
                {
                    tbCourseName.Text = _editCourse.Name;
                    tbCode.Text = _editCourse.Code;
                    tbEcts.Text = _editCourse.Ects.ToString();
                    List<Person> lecturersOnCourse = _editCourse.Lecturers.ToList();
                    foreach (var item in lecturersOnCourse)
                    {
                        Label lbl = GetPersonLabel(item, new Size(flpLecturersOnCourse.Width - 8, 40));
                        //lbl.MouseMove += Lbl_MouseMove;
                        flpLecturersOnCourse.Controls.Add(lbl);
                        lbl.MouseDown += NewLabel_MouseDown;

                    }
                  
                    List<Person> allLecturers = LoadData();
                    foreach (var item in allLecturers)
                    {
                        // Provjera je li item prisutan u listi lecturersOnCourse
                        if (!lecturersOnCourse.Contains(item))
                        {
                            Label lbl = GetPersonLabel(item, new Size(flpLecturersOnCourse.Width - 8, 40));
                            //lbl.MouseDown += NewLabel_MouseDown;
                            lbl.MouseMove += Lbl_MouseMove;
                            flpAllLecturers.Controls.Add(lbl);
                        }
                    }

                }
            }
            
          
        }

       

        //metoda za prikaz podataka o osobama
        private void ShowDataOnLoad()
        {
            List<Person> list = LoadData();
            foreach (var item in list)
            {
                Label lbl = GetPersonLabel(item, new Size(flpAllLecturers.Width-8, 40));
                lbl.MouseMove += Lbl_MouseMove;
                flpAllLecturers.Controls.Add(lbl);
               
            }
            

        }
        
        //-----------------------------------Eventi za drag and drop i metode

        // Metoda koja se poziva kada se prođe mišem preko labele - za drag and drop
          private void Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            // Konverzija sender-a u Label tip.
            Label lbl = sender as Label;
            // Provjera da li je lbl null, u slučaju da sender nije tipa Label.
            // Ako je lbl null, DoDragDrop() se neće pozvati.
            lbl?.DoDragDrop(lbl, DragDropEffects.Move);
        }

        private void FlpLecturersOnCourse_DragDrop(object sender, DragEventArgs e)
        {
     
            var addedlabel = e.Data.GetData(typeof(Label)) as Label;
            // Provjerite postoji li labela s istim imenom
            string labelTag = addedlabel.Tag.ToString();
            bool labelFound = false;
            foreach (Control control in flpLecturersOnCourse.Controls)
            {
                if (control is Label && control.Tag.ToString() == labelTag)
                {
                    labelFound = true;
                    break;
                }
            }
            if (labelFound) return;

            Label draggedLabel = e.Data?.GetData(typeof(Label)) as Label;
            Label newLabel = AddNewLabelToList(draggedLabel);

            Point mouseLocation = MousePosition;
            mouseLocation = flpLecturersOnCourse.PointToClient(mouseLocation);
            newLabel.Location = mouseLocation;
            flpLecturersOnCourse.Controls.Add(newLabel);

            // Omogućite brisanje labela
            newLabel.MouseDown += NewLabel_MouseDown;

            flpAllLecturers.Controls.Remove(draggedLabel);

        }        

        private void FlpLecturersOnCourse_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void NewLabel_MouseDown(object sender, MouseEventArgs e)
        {
          
            if (e.Button == MouseButtons.Right)
            {
                Label selectedLabel = sender as Label;
                ContextMenuStrip menu = new ContextMenuStrip();
                ToolStripMenuItem deleteItem = new ToolStripMenuItem("Obriši");
                deleteItem.Click += (s, args) => {
                    flpLecturersOnCourse.Controls.Remove(selectedLabel);
                    selectedLabel.MouseDown -= NewLabel_MouseDown;
                    selectedLabel.MouseDown += Lbl_MouseMove;
                    flpAllLecturers.Controls.Add(selectedLabel);
                };
                menu.Items.Add(deleteItem);
                menu.Show(selectedLabel, new Point(e.X, e.Y));
         
            }
            
        }


        //-----------------------------Metode za liste i labele

        //Metoda za dodavanje nove labele na listu
        private static Label AddNewLabelToList(Label draggedLabel)
        {
            Label newLabel = new Label();
            newLabel.Text = draggedLabel.Text;
            newLabel.Font = draggedLabel.Font;
            newLabel.BackColor = draggedLabel.BackColor;
            newLabel.ForeColor = draggedLabel.ForeColor;
            newLabel.Size = draggedLabel.Size;
            newLabel.TextAlign = draggedLabel.TextAlign;
            newLabel.Tag = draggedLabel.Tag;
            newLabel.Margin = draggedLabel.Margin;
            return newLabel;
        }

        //metoda za punjenje liste iz dictionarya osoba
        private List<Person> LoadData()
        {
            IDictionary<int, Person> persons = _dataManager.GetPersonsDictionary();
            List<Person> list = new List<Person>();
            foreach (var person in persons.Values)
            {
                list.Add(person);
            }

            return list;
        }

        //metoda za stvaranje nove labele u koje će se dodavati osobe
        public Label GetPersonLabel(Person o, Size size)
        {
            var label = new Label
            {
                Text = $"{o.FirstName} {o.LastName}",
                AutoSize = false,
                Size = size,
                BackColor = Color.FromArgb(11, 7, 17),
                ForeColor = Color.WhiteSmoke,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(3),
                Anchor = AnchorStyles.None,
                Tag = o.Id
            };

            
            return label;
        }

        //Metoda koja iz flow layout pnaela vraća listu predavača 
        private List<Person> GetLecturersFromLecturersOnCourse()
        {
            List<Person> lecturers = new();

            IDictionary<int, Person> persons = _dataManager.GetPersonsDictionary();

            // prolazak kroz sve kontrole u FlowLayoutPanelu
            foreach (Control control in flpLecturersOnCourse.Controls)
            {
                // provjera da li je kontrola tipa Label
                if (control is Label label)
                {
                    // dohvaćanje podataka o Person objektu iz teksta labele

                    int personId = Convert.ToInt32(label.Tag);

                    foreach (var key in persons.Keys)
                    {
                        if (key == personId)
                        {
                            lecturers.Add(persons[personId]);
                        }
                    }

                }
            }

            return lecturers;
        }


        //----------------------------Brisanje
        //metoda za brisanje unesenog iz forme
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
            flpLecturersOnCourse.Controls.Clear();
            flpAllLecturers.Controls.Clear();
            ShowDataOnLoad();
        }
     
        //-----------------------------Spremanje
        //Metoda za gumb spremi
        private void BtnSave_Click(object sender, EventArgs e)
        {

            string name = tbCourseName.Text;
            string code = tbCode.Text;
            int ects;
            List<Person> lecturers = GetLecturersFromLecturersOnCourse();

            if (!Utility.IsTextValid(name))
            {
                CustomMessageBox.Show("Nije unesen ispravan naziv kolegija.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (!Utility.IsTextValid(code))
            {
                CustomMessageBox.Show("Nije unesena ispravna šifra kolegija (min 3 znaka).", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(tbEcts.Text, out ects) || !Utility.IsEctsValid(tbEcts.Text))
            {
                CustomMessageBox.Show("Nije unesen ispravan broj ects bodova (1-10).", "Upozorenje", MessageBoxButtons.OK);
                return;
            }

            if (lecturers is null || lecturers.Count == 0)
            {
                CustomMessageBox.Show("Nije dodan predavač na kolegij. Kolegij mora imati barem jednog predavača.", "Upozorenje", MessageBoxButtons.OK);
                return;
            }



            if (_callingButton == "btnAddNewCourse")
            {
               

                // kreirajte novog Person objekta
                Course newCourse = new Course(name, code, ects, lecturers);
                try
                {
                    // dodajte novog Person objekta u dictionary u DataManager klasi
                    _dataManager.AddNewCourseToDictionary(newCourse);

                    // obavijestite korisnika da su podaci spremljeni
                    ClearForm();
                    
                    CustomMessageBox.Show("Uspješno spremljeno.", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni" + ex.Message, "Greška!", MessageBoxButtons.OK);
                }
            }
            else if (_callingButton == "btnEditCourse")
            {
                _editCourse.Name = name;
                _editCourse.Code = code;
                _editCourse.Ects = ects;
                _editCourse.Lecturers = lecturers;
                try
                {
                    _dataManager.UpdateCourseToDictionary(_editCourse);
                    CustomMessageBox.Show("Uspješno spremljeno", "", MessageBoxButtons.OK);
                  
                    Dispose();
                }
                catch (Exception ex)
                {

                    CustomMessageBox.Show("Došlo je do greške, podaci nisu spremljeni! - " + ex.Message, "Greška", MessageBoxButtons.OK);
                }
            }

        }


        //-------------promjena boje labelama u panelima za predavače
        private void FlpAllLecturers_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is Label label)
            {
                label.MouseEnter += Label_MouseEnter;
                label.MouseLeave += Label_MouseLeave;
            }
        }

        private void FlpLecturersOnCourse_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is Label label)
            {
                label.MouseEnter += Label_MouseEnter;
                label.MouseLeave += Label_MouseLeave;
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.BackColor = Color.Red;
            }
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                label.BackColor = Color.White;
            }
        }


    }
}
