using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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



        //When File -> New is clicked
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


        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            //Use SaveFileDialog to save the contents of a Note to a file.
            //Use ActiveMDIChild to determine which Note to save to disk.
            
        }

        private void FormServiceNotes_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemFile_Click(object sender, EventArgs e)
        {
            //Check ActiveMDIChild to activate or deactivate Save button
            if (this.ActiveMdiChild == null)
            {
                toolStripMenuItemSave.Enabled = false;
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            //Close the service notes form
            this.Close();
        }
    }
}
