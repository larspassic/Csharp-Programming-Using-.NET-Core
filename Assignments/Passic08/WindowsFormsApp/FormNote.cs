using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormNote : Form
    {
        
        
        public FormNote()
        {
            InitializeComponent();
        }

        
        
        //Internal property?
        //"Internal" aka "Project Public" (not available outside the project)
        internal string NoteContents
        {
            get
            {
                return textBoxFormNote.Text;
            }
            set
            {
                textBoxFormNote.Text = NoteContents;
            }
        }


    }
}
