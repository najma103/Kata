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

    }
}
