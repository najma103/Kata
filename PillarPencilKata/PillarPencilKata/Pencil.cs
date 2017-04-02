using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarPencilKata
{
    public class Pencil
    {

        private int pencilDurability;
        private int eraserDurability;
        private int pencilLength; 
        
        private int shortPencil = 50;
        private int longPencil = 100;
        private StringBuilder sb;

        //initial values the object was created with
        private int initialPencilPoints;

        // properties
        public int PencilLength
        {
            get { return pencilLength; }
            set { pencilLength = value; }
        }
        public int PencilDurability
        {
            get { return pencilDurability; }
            set { PencilDurability = value; }
        }
        public int EraserDurability
        {
            get { return eraserDurability; }
            set { eraserDurability = value; }
        }

        // constructiors
        public Pencil()
        {
            pencilDurability = 40000;
            initialPencilPoints = pencilDurability;
            eraserDurability = 10000;
            pencilLength = 10;
            sb = new StringBuilder("", 10000);
        }
        public Pencil(int pencilDurability, int eraserDurability, int pencilLength)
        {
            this.pencilDurability = pencilDurability;
            initialPencilPoints = pencilDurability;
            this.eraserDurability = eraserDurability;
            this.pencilLength = pencilLength;

            sb = new StringBuilder("", 10000);
        }

        public string TextWriter(string str)
        {
            sb.Append(str);
            return sb.ToString(); 
        }

        public bool SharpenPencil()
        {
            if (pencilLength > 0)
            {
                pencilDurability = initialPencilPoints;
                pencilLength--;
                return true;
            }
            
            return false;
        }

        public string EraseWordFromPaper(string str)
        {
            string newWords = "";
            string blankSpaces = ReturnWhiteSpaces(str.Length);
            string words = sb.ToString();
            string[] strArray = new string[sb.Length];
            strArray = words.Split(' ');

            // index of the word
            int indexOf = IndexOfString(strArray, str);
            string word = strArray[indexOf];
            if(word.Length > str.Length)
            {
                char[] charArr = word.ToCharArray();
                StringBuilder sb2 = new StringBuilder(word);
                sb2.Replace(str, "");
                strArray[indexOf] = sb2.ToString() + blankSpaces;

                sb.Clear();
                newWords = string.Join(" ", strArray);
                sb.Append(newWords);
                return sb.ToString();


            }
            else
            {
                strArray[Array.LastIndexOf(strArray, str)] = blankSpaces;
                sb.Clear();

                newWords = string.Join(" ", strArray);
                sb.Append(newWords);
                return sb.ToString();
            }


        }

        private int IndexOfString(string[] strArr, string str)
        {
            int lastIndex = strArr.Length - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (strArr[i].Contains(str))
                {
                    return i;
                }
            }
            return -1;
        }

        private string ReturnWhiteSpaces(int spaceLength)
        {
            string newSpaces = "";
            for (int i = 0; i < spaceLength; i++)
            {
                newSpaces += " ";
            }

            return newSpaces;
        }

    }
}
