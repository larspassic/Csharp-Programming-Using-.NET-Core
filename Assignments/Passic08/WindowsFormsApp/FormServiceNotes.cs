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
    }
}
