using System;

//Assignment 06
//Author: Passic, Lars, 2011958

namespace Assignment_06_WinForms
{
    public class VENDBADFLAVORException : Exception
    {
        public VENDBADFLAVORException()
            : base("Bad Conversion to a Flavor enumeral attempted")
        {
        }

        public VENDBADFLAVORException(string Message)
            : base(Message)
        {
        }

        public VENDBADFLAVORException(string Message, Exception Inner)
            : base(Message, Inner)
        {
        }

        public VENDBADFLAVORException(string Message, string BadFlavorString)
            : base(string.Format("{0}:{1}", Message, BadFlavorString))
        {
        }
    }
}
