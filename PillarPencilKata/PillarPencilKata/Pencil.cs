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
            pencilDurability = 1000;
            initialPencilPoints = pencilDurability;
            eraserDurability = 100;
            pencilLength = 5;
            sb = new StringBuilder("", 1000);
        }
        public Pencil(int pencilDurability, int eraserDurability, int pencilLength)
        {
            this.pencilDurability = pencilDurability;
            initialPencilPoints = pencilDurability;
            this.eraserDurability = eraserDurability;
            this.pencilLength = pencilLength;

            sb = new StringBuilder("", 1000);
        }

        public string TextWriter(string str)
        {
            char[] chars = new char[str.Length];
            chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (pencilDurability > 0)
                {
                    if (char.IsUpper(chars[i]))
                    {
                        if (pencilDurability >= 0)
                        {
                            sb.Append(chars[i]);
                            pencilDurability = pencilDurability - 2;// 2 points for upper case letter
                        }
                        else
                        {
                            sb.Append(' ');
                        }
                    }
                    else if (char.IsWhiteSpace(chars[i]))
                    {
                        sb.Append(chars[i]);
                    }
                    else
                    {
                        sb.Append(chars[i]);
                        pencilDurability = pencilDurability - 1;
                    }
                }
                else
                {
                    sb.Append(' ');
                }
            }
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

        public string EraseWords(string str)
        {
            string newWords = "";
            string word = "";
            string blankSpaces = ReturnWhiteSpaces(str.Length);

            string words = sb.ToString();
            string[] strArray = new string[sb.Length];
            strArray = words.Split(' ');

            int indexOf = IndexOfString(strArray, str);
            if (indexOf > 0)
            {
                word = strArray[indexOf];
            } 

            char[] charArr = word.ToCharArray();
            StringBuilder sb2 = new StringBuilder(word);

            if ((eraserDurability >= str.Length) && (word.Length > str.Length))
            {
                sb2.Replace(str, "");
                strArray[indexOf] = sb2.ToString() + blankSpaces;
                eraserDurability = eraserDurability - str.Length;

                sb.Clear();
                newWords = string.Join(" ", strArray);
                sb.Append(newWords);
                return sb.ToString();
            } 
            else
            {
                for (int i = charArr.Length; i > 0; i--)
                {
                    if (eraserDurability > 0)
                    {
                        charArr[i] = ' ';
                        eraserDurability = eraserDurability - 1;
                    }
                }
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

        public override string ToString()
        {
            return "/" + sb + "/";
        }


    }





}
