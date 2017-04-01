using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarPencilKata
{
    public class Pencil
    {
        private int eraserDurability;
        private int pencilDurability;
        private int shortPencil = 50;
        private int longPencil = 100;
        private StringBuilder sb;

        public Pencil()
        {
            pencilDurability = 40000;
            eraserDurability = 10000;
            sb = new StringBuilder("", 10000);
        }
        public Pencil(int pencilDurability, int eraserDurability)
        {
            this.pencilDurability = pencilDurability;
            this.eraserDurability = eraserDurability;

            sb = new StringBuilder("", 10000);
        }

        public string TextWriter(string str)
        {
            sb.Append(str);
            return sb.ToString(); 
        }

    }
}
