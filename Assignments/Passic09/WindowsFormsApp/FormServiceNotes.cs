using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

//Assignment 09
//Author: Passic, Lars, 2011958

namespace WindowsFormsApp
{
    public partial class FormServiceNotes : Form
    {
        public FormServiceNotes()
        {
            InitializeComponent();
        }


        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            //Create a new note - need to add as a child to the FormServiceNotes form
            Form note = new FormNote();

            //Make the parent the service notes form
            note.MdiParent = this;

            //Actually show the individual note
            note.Show();


        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            //Create a new instance of the note child object
            FormNote note = new FormNote();

            //Make this a child form
            note.MdiParent = this;

            
            //Use the OpenFileDialog and a new instance of Note to display a file specified by the user
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //If the result of the OpbenFileDialog experience was "OK"
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                //stream reader?
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);

                //Bring the contents in from the streamReader and change the title of the small note window
                note.NoteContents = streamReader.ReadToEnd();
                note.Text = openFileDialog.FileName.ToString();
                note.Show();
            }



        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            //Use SaveFileDialog to save the contents of a Note to a file.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            //Propose a file name - my team mates showed me this idea!!
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.FileName = "Note_" + DateTime.Now.ToString("MMMM_dd_yyyy_HHmmss");

            //If the result of the save file dialog experience was "OK"
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Check ActiveMdiChild first to determine what to read in
                if (this.ActiveMdiChild != null)
                {

                    //Write the contents of the note to the place that was chosen by the user
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                    {
                        //use the Active MDI child note object to call the NoteContents property
                        streamWriter.WriteLine((this.ActiveMdiChild as FormNote).NoteContents);
                    }

                }
            }

        }

        private void toolStripMenuItemFile_Click(object sender, EventArgs e)
        {
            //Check ActiveMDIChild to activate or deactivate Save button
            //Confirmed that this works
            if (this.ActiveMdiChild == null)
            {
                
                toolStripMenuItemSave.Enabled = false;
            }
            else
            {
                toolStripMenuItemSave.Enabled = true;
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            //Close the service notes form
            this.Close();
        }
    }
}
