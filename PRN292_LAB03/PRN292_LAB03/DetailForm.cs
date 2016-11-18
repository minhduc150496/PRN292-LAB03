using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace PRN292_LAB03
{
    public partial class DetailForm : Form
    {
        public BindingList<CD> cdList = new BindingList<CD>();
        private InputForm inputForm = null;

        public DetailForm()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";

            cdList.AllowRemove = true;
            cdList.AllowEdit = true;
            cdList.AllowNew = true;
            cdList.Add(new CD
            {
                Album = "DucKUTE",
                Singer = "TP HCM",
                Songs = new List<string>
                {
                    "aaaaa", "bbbbb"
                }
            });
            cdList.Add(new CD
            {
                Album = "Trump",
                Singer = "New York"
            });
            cdList.Add(new CD
            {
                Album = "Cliton",
                Singer = "New York"
            });
            dgCD.AutoGenerateColumns = true;
            dgCD.DataSource = cdList;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (inputForm = new InputForm(this))
            {
                inputForm.prepareAdding();
                inputForm.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCD.SelectedRows.Count > 0)
            {
                var index = dgCD.SelectedRows[0].Index;
                var list = (BindingList<CD>)dgCD.DataSource;
                var cd = list.ElementAtOrDefault(index);
                using (inputForm = new InputForm(this))
                {
                    inputForm.prepareEditing(cd);
                    inputForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No rows selected");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCD.SelectedRows.Count > 0)
            {
                var r = dgCD.SelectedRows[0];
                int index = r.Index;
                var list = (BindingList<CD>)dgCD.DataSource;
                if (index < list.Count())
                {
                    var item = list.ElementAtOrDefault(index);
                    if (item != null)
                    {
                        list.Remove(item);
                        cdList.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("No rows selected");
            }
        }

        private void btnLoadFrom_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            //var stream = 
            //if (stream != null)
            //{
            //    using (stream)
            //    {
            //        var sr = new StreamWriter(stream);
            //        sr.Write(json);
            //        sr.Close();
            //    }
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchResults = cdList.Where
                (a => a.Album.Contains(txtAlbum.Text)
                && a.Singer.Contains(txtSinger.Text)
                && (txtSong.Text=="" || a.Songs.FirstOrDefault
                (s => s.Contains(txtSong.Text))!=null))
                .ToList<CD>();
            dgCD.DataSource = new BindingList<CD>(searchResults);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAlbum.Text = "";
            txtSinger.Text = "";
            txtSong.Text = "";
            dgCD.DataSource = cdList;
        }

        private void dgCD_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 1. Get header text
            int index = e.ColumnIndex;
            string headerText = dgCD.Columns[index].HeaderText;
            // 2. Sort
            var bl = (BindingList<CD>)dgCD.DataSource;
            List<CD> list = null;
            if (headerText == "ID")
            {
                list = bl.OrderBy(a => a.ID).ToList<CD>();
            }
            else if (headerText == "Album")
            {
                list = bl.OrderBy(a => a.Album).ToList<CD>();
            }
            else if (headerText == "Singer")
            {
                list = bl.OrderBy(a => a.Singer).ToList<CD>();
            }
            else if (headerText == "Duration")
            {
                list = bl.OrderBy(a => a.Duration).ToList<CD>();
            }
            else if (headerText == "Songs")
            {
                list = bl.OrderBy(a => a.Songs.ToString()).ToList<CD>();
            }
            else if (headerText == "Genre")
            {
                list = bl.OrderBy(a => a.ToString()).ToList<CD>();
            }
            // 3.Set value to cdList
            if (list != null)
            {
                dgCD.DataSource = new BindingList<CD>(list);
            }
        }

        private void dgCD_MouseClick(object sender, MouseEventArgs e)
        {
            //if (dgCD.SelectedRows.Count > 0)
            //{
            //    var index = dgCD.SelectedRows[0].Index;
            //    var list = (BindingList<CD>)dgCD.DataSource;
            //    var cd = list.ElementAtOrDefault(index);
            //    if (cd != null)
            //    {
            //        var songs = cd.Songs;
            //        dgSongs.Rows.Clear();
            //        int count = 0;
            //        foreach (var song in songs)
            //        {
            //            dgSongs.Rows.Add(1);
            //            dgSongs.Rows[count].Cells[0].Value = songs[count];
            //            count++;
            //        }
            //    }
            //}
        }

        private void dgCD_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCD.SelectedRows.Count > 0)
            {
                var index = dgCD.SelectedRows[0].Index;
                var list = (BindingList<CD>)dgCD.DataSource;
                var cd = list.ElementAtOrDefault(index);
                if (cd != null)
                {
                    var songs = cd.Songs;
                    dgSongs.Rows.Clear();
                    int count = 0;
                    foreach (var song in songs)
                    {
                        dgSongs.Rows.Add(1);
                        dgSongs.Rows[count].Cells[0].Value = songs[count];
                        count++;
                    }
                }
            }
        }

        private void dgCD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var list = cdList.ToList<CD>();
            var json = JsonConvert.SerializeObject(list);
            var fileName = saveFileDialog1.FileName;
            var sw = new StreamWriter(fileName);
            if (sw != null)
            {
                using (sw)
                {
                    sw.Write(json);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fileName = openFileDialog1.FileName;
            var sr = new StreamReader(fileName);
            if (sr!=null)
            {
                using (sr)
                {
                    var json = sr.ReadToEnd();
                    var list = JsonConvert.DeserializeObject<List<CD>>(json);
                    cdList = new BindingList<CD>(list);
                    dgCD.DataSource = cdList;
                }
            }
        }
    }
}
