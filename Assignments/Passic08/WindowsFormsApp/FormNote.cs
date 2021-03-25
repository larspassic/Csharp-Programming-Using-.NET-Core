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
            
            //Not sure how to do this.
            //I need to be able to bring date in to this form note by using this property
            set
            {
                textBoxFormNote.Text = NoteContents;
            }
        }


    }
}
