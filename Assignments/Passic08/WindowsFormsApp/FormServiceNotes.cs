using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

//Assignment 08
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
            Form Note = new FormNote();

            //Make the parent the service notes form
            Note.MdiParent = this;

            //Actually show the individual note
            Note.Show();


        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            //Use the OpenFileDialog and a new instance of Note to display a file specified by the user
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                //stream reader?
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                ActiveMdiChild. streamReader.ReadToEnd


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
                //Write the contents of the note to the place that was chosen by the user
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    //Use ActiveMDIChild to determine which Note to save to disk
                    //This is NOT working
                    //How am I supposed to pull the next out of the currently active child note??
                    streamWriter.WriteLine(ActiveMdiChild.Text);
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
