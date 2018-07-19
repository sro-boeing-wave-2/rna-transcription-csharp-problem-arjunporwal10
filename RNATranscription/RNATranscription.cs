using System;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //throw new NotImplementedException("You need to implement this function.");
            //StringBuilder myStringBuilder = new StringBuilder(nucleotide);
            //myStringBuilder.Replace('G', 'C', 0, myStringBuilder.Length);
            //myStringBuilder.Replace('C', 'G', 0, myStringBuilder.Length);
            //myStringBuilder.Replace('T', 'A', 0, myStringBuilder.Length);
            //myStringBuilder.Replace('A', 'U', 0, myStringBuilder.Length);

            //return myStringBuilder.ToString();
            string msg = "";
            foreach (char c in nucleotide)
            {
                if (c == 'G') msg += 'C';
                else if (c == 'C') msg += 'G';
                else if (c == 'T') msg += 'A';
                else msg += 'U';

            }
            return msg;
        }
    }
}
