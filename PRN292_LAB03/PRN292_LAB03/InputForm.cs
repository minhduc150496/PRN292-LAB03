using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN292_LAB03
{
    public partial class InputForm : Form
    {
        private bool adding = false;
        private CD oldCD = null;
        public InputForm(DetailForm owner)
        {
            InitializeComponent();
            this.Owner = owner;
            this.cbGenre.DataSource = Enum.GetValues(typeof(CDGenre));
        }

        public void prepareAdding()
        {
            adding = true;
            btnAdd.Text = "Add";
            txtID.Enabled = true;
        }

        public void prepareEditing(CD cd)
        {
            adding = false;
            btnAdd.Text = "Update";
            txtID.Enabled = false;
            oldCD = cd;

            if (cd == null) return;
            txtID.Text = cd.ID;
            txtAlbum.Text = cd.Album;
            txtSinger.Text = cd.Singer;
            txtDuration.Text = cd.Duration.ToString();
            txtSongs.Text = string.Join(System.Environment.NewLine, cd.Songs);
            cbGenre.SelectedIndex = (int)cd.Genre;
        }

        private bool validate()
        {
            // 1- ID: empty, duplicated
            if (adding)
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Please enter the ID", "Invalid");
                    return false;
                }
                var mainForm = (DetailForm)this.Owner;
                if (mainForm.cdList.FirstOrDefault
                    (a => a.ID == txtID.Text) != null)
                {
                    MessageBox.Show("Duplicated ID", "Invalid");
                    return false;
                }
            }
            // 2- Album: empty
            if (txtAlbum.Text == "")
            {
                MessageBox.Show("Please enter the Album", "Invalid");
                return false;
            }
            // 3- Singer: empty
            if (txtSinger.Text == "")
            {
                MessageBox.Show("Please enter the Singer", "Invalid");
                return false;
            }
            // 4- Duration: cannot parse, empty
            if (txtDuration.Text == "")
            {
                MessageBox.Show("Please enter the Duration", "Invalid");
                return false;
            }
            long duration = 0;
            if (long.TryParse(txtDuration.Text, out duration) == false)
            {
                MessageBox.Show("Please enter a integer in Duration", "Invalid");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool valid = validate();
            if (valid)
            {
                if (adding)
                {
                    // 1. Create a new Emp
                    CD cd = new CD();
                    cd.ID = txtID.Text;
                    cd.Album = txtAlbum.Text;
                    cd.Singer = txtSinger.Text;
                    cd.Duration = long.Parse(txtDuration.Text);
                    cd.Songs = txtSongs.Lines.OfType<string>().ToList<string>();
                    cd.Genre = (CDGenre)cbGenre.SelectedIndex;
                    // 2. Add the new Emp to list
                    var mainForm = (DetailForm)this.Owner;
                    var list = (BindingList<CD>)mainForm.dgCD.DataSource;
                    list.Add(cd);
                    mainForm.cdList.Add(cd);
                } else
                {
                    // 1. Update fields
                    oldCD.Album = txtAlbum.Text;
                    oldCD.Singer = txtSinger.Text;
                    oldCD.Duration = long.Parse(txtDuration.Text);
                    oldCD.Songs = txtSongs.Text.Split('\n').ToList<string>();
                    oldCD.Genre = (CDGenre)cbGenre.SelectedIndex;

                    var mainForm = (DetailForm)this.Owner;
                    mainForm.dgCD.Refresh();

                    // 2. Close Dialog
                    this.Close();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtAlbum.Text = "";
            txtSinger.Text = "";
            txtDuration.Text = "";
            txtSongs.Text = "";
            cbGenre.SelectedIndex = 0;
        }
    }
}
